//Christine Jordan Term Project: Form 2 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project.Tracking.ProjectTrackingDataSet;

namespace Project.Tracking
{
    public partial class ProjectEmployeesForm : Form
    {
        private bool isLoaded = false;
        private double totalHours = 0.0;
        public ProjectEmployeesForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();

            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;

            //Left side of form
            SetupColumnsForProjectListView();
            PopulateProjectsListView();
            //Right side of form
            SetUpColumnsForTaskDetailsListView();

            isLoaded = true;
        }


        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        private void SetupColumnsForProjectListView()
        {
            int width = projectListView.Width / 4; //Four total columns

            //adding headers to columns of listview
            projectListView.Columns.Add("Project Name", width);
            projectListView.Columns.Add("Description", width);
            projectListView.Columns.Add("Status", width);
            projectListView.Columns.Add("Start Date", width);
            

            //allow row to be selected, but not multiple rows
            projectListView.View = View.Details;
            projectListView.MultiSelect = false;
            projectListView.FullRowSelect = true;
            projectListView.ShowItemToolTips = true;


        }

        private void SetUpColumnsForTaskDetailsListView()
        {
            int width = taskDetailsListView.Width / 4; //Four total columns

            //adding headers to columns of listview
            taskDetailsListView.Columns.Add("Employee", width);
            taskDetailsListView.Columns.Add("Task", width);
            taskDetailsListView.Columns.Add("Date", width);
            taskDetailsListView.Columns.Add("Hours", width);


            //allow row to be selected, but not multiple rows
            taskDetailsListView.View = View.Details;
            taskDetailsListView.MultiSelect = false;
            taskDetailsListView.FullRowSelect = true;


        }
        private void PopulateProjectsListView ()
        {
            foreach (ProjectRow project in projectTrackingDataSet.Project)
            {
                //gets data for status 
                StatusRow status = projectTrackingDataSet.Status.FindById(project.StatusId);

                //adding data to dataview columns, populates data
                ListViewItem item = new ListViewItem(project.Name);
                item.SubItems.Add(project.Description);
                item.SubItems.Add(status.Status);
                item.SubItems.Add(project.StartDate.ToShortDateString());

                //When hover, will display description of project.
                item.ToolTipText = project.Description;
                item.Tag = project.Id;

                //add item to list view
                projectListView.Items.Add(item);
            }
        }

        private void projectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset the accumulation
            totalHours = 0.0;
            //clear out tasks listview
            taskDetailsListView.Items.Clear();

            //if something is selected, go into scope
            if (isLoaded && projectListView.SelectedIndices.Count > 0)
            {
                //get projectId of selection
                int projectId = (int)projectListView.SelectedItems[0].Tag;
                //getting project row for a method to get related tasks
                ProjectRow project = projectTrackingDataSet.Project.FindById(projectId);

                //employee and task they are working on
                TaskRow[] tasks = (TaskRow[])project.GetChildRows("fk_TaskToProject");
                //get employee associated with each task
                foreach (TaskRow task in tasks) //foreach tasks in our tasks list
                {
                                       
                    //using relationships to get employee information
                    EmployeeTasksRow[] eTasks = (EmployeeTasksRow[])task.GetChildRows("fk_EmployeeTaskToTask");

                    foreach (EmployeeTasksRow eTask in eTasks)
                    {
                        if (eTasks.Length > 0)
                        {
                            //accumulating the hours
                            totalHours += eTask.HoursWorked;

                            EmployeeRow employee = (EmployeeRow)eTask.GetParentRow("fk_EmployeeTaskToEmployee");


                            string date;
                            try
                            {
                                //start date is not nullable, but my database column is
                                //if db null happens, exception is thrown
                                date = eTask.DateWorked.ToShortDateString();
                            }
                            catch
                            {
                                //use not available, if start date is db null
                                date = "N/A";
                            }

                            //adding data to dataview columns, populates data
                            ListViewItem item = new ListViewItem($"{employee.FirstName} {employee.LastName}");
                            item.SubItems.Add(task.Name);
                            item.SubItems.Add(date);
                            item.SubItems.Add(eTask.HoursWorked.ToString());



                            //add item to list view
                            taskDetailsListView.Items.Add(item);
                        }
                    }
                    
                }
                //update the UI to show the total hours
                totalHoursTextBox.Text = totalHours.ToString();
            }
        }
    }
}
