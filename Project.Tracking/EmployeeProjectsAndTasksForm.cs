//Christine Jordan 12.7.2020 CIS266:Term Project
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
    public partial class EmployeeProjectsAndTasksForm : Form
    {
        private bool isLoaded = false;
        private double totalHours = 0.0;
        public EmployeeProjectsAndTasksForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;
            this.employeeBindingSource.DataSource = this.projectTrackingDataSet.Employee;
            isLoaded = true;
            SetupProjectDetailsListView();

        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        private void SetupProjectDetailsListView()
        {
            int width = projectDetailsListView.Width / 4; //Four total columns

            //adding headers to columns of listview
            projectDetailsListView.Columns.Add("Project", width);
            projectDetailsListView.Columns.Add("Task", width);
            projectDetailsListView.Columns.Add("Date", width);
            projectDetailsListView.Columns.Add("Hours", width);

            //allow row to be selected, but not multiple rows
            projectDetailsListView.View = View.Details;
            projectDetailsListView.MultiSelect = false;
            projectDetailsListView.FullRowSelect = true;
        }
        
        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //resetting the total hours
            totalHours = 0.0;
            //resetting the employee details
            projectDetailsListView.Items.Clear();

            //if form is loaded and we have a employee selected, go into scope
            if (isLoaded && employeeListBox.SelectedIndex != -1)
            {
                //get employee id
                int employeeId = (int)employeeListBox.Tag;
                //Get employee row based on employee id
                EmployeeRow employee = this.projectTrackingDataSet.Employee.FindById(employeeId);
                EmployeeTasksRow[] employeeTasks = (EmployeeTasksRow[])employee.GetChildRows("fk_EmployeeTaskToEmployee");

                //Look through each EmployeeTask joining relationship
                foreach (EmployeeTasksRow row in employeeTasks)
                {
                    //Get current task row for based on task it
                    TaskRow task = projectTrackingDataSet.Task.FindById(row.TaskId);

                    //Get Project associated with task. All tasks have a project get first of array
                    ProjectRow project = this.projectTrackingDataSet.Project.FindById(task.ProjectId);

                    string date;
                    try
                    {
                        //start date is not nullable, but my database column is
                        //if db null happens, exception is thrown
                        date = row.DateWorked.ToShortDateString();
                    }
                    catch
                    {
                        //use not available, if start date is db null
                        date = "N/A";
                    }

                    //create a list view item adding project name, task name, task date, & task hours worked.
                    ListViewItem item = new ListViewItem(project.Name);
                    item.SubItems.Add(task.Name);
                    item.SubItems.Add(date);
                    item.SubItems.Add(row.HoursWorked.ToString());

                    //add item to list view
                    projectDetailsListView.Items.Add(item);

                    //accumulating total hours
                    totalHours += row.HoursWorked;

                }
                totalHourTextBox.Text = totalHours.ToString();
                MainForm.SetReadyLabel($"Total Tasks: [{employeeTasks.Length}]");
            }
        }

        //Event-handler for formating values for listbox. 
        private void employeeListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = "ID: " + ((DataRowView)e.ListItem).Row["Id"] + ", "
                + "Title: " + ((DataRowView)e.ListItem).Row["Title"] + ", "
                + "Name: " + ((DataRowView)e.ListItem).Row["FirstName"] + " "  + ((DataRowView)e.ListItem).Row["LastName"];
            
        }
    }
}
