using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Tracking
{
    public partial class ProjectTrackingMainForm : Form
    {
        private readonly ProjectTrackingDataSet projectTrackingDataSet;

        public ProjectTrackingMainForm()
        {
            //Turning on all components on page.
            InitializeComponent();
            IsMdiContainer = true;
            projectTrackingDataSet = new ProjectTrackingDataSet();
            FillData();
        }

        //Using data adapters to fill dataset.
        private void FillData()
        {
            //instantiating adapters
            ProjectTrackingTableAdapters.EmployeeTableAdapter employeeTableAdapter = new ProjectTrackingTableAdapters.EmployeeTableAdapter();
            ProjectTrackingTableAdapters.EmployeeTasksTableAdapter employeeTasksTableAdapter = new ProjectTrackingTableAdapters.EmployeeTasksTableAdapter();
            ProjectTrackingTableAdapters.ProjectTableAdapter projectTableAdapter = new ProjectTrackingTableAdapters.ProjectTableAdapter();
            ProjectTrackingTableAdapters.StatusTableAdapter statusTableAdapter = new ProjectTrackingTableAdapters.StatusTableAdapter();
            ProjectTrackingTableAdapters.TaskTableAdapter taskTableAdapter = new ProjectTrackingTableAdapters.TaskTableAdapter();

            //Getting data and putting in dataset. 
            try
            {
                employeeTableAdapter.Fill(projectTrackingDataSet.Employee);
                employeeTasksTableAdapter.Fill(projectTrackingDataSet.EmployeeTasks);
                projectTableAdapter.Fill(projectTrackingDataSet.Project);
                statusTableAdapter.Fill(projectTrackingDataSet.Status);
                taskTableAdapter.Fill(projectTrackingDataSet.Task);

            }
            //if an error, display a message to user.
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SaveData()
        {
            //instantiating adapters
            ProjectTrackingTableAdapters.EmployeeTableAdapter employeeTableAdapter = new ProjectTrackingTableAdapters.EmployeeTableAdapter();
            ProjectTrackingTableAdapters.EmployeeTasksTableAdapter employeeTasksTableAdapter = new ProjectTrackingTableAdapters.EmployeeTasksTableAdapter();
            ProjectTrackingTableAdapters.ProjectTableAdapter projectTableAdapter = new ProjectTrackingTableAdapters.ProjectTableAdapter();
            ProjectTrackingTableAdapters.StatusTableAdapter statusTableAdapter = new ProjectTrackingTableAdapters.StatusTableAdapter();
            ProjectTrackingTableAdapters.TaskTableAdapter taskTableAdapter = new ProjectTrackingTableAdapters.TaskTableAdapter();
            
            //assigning table adapter to table adapter manager properities
            ProjectTrackingTableAdapters.TableAdapterManager tableAdapterManager = new ProjectTrackingTableAdapters.TableAdapterManager();
            tableAdapterManager.EmployeeTableAdapter = employeeTableAdapter;
            tableAdapterManager.EmployeeTasksTableAdapter = employeeTasksTableAdapter;
            tableAdapterManager.ProjectTableAdapter = projectTableAdapter;
            tableAdapterManager.StatusTableAdapter = statusTableAdapter;
            tableAdapterManager.TaskTableAdapter = taskTableAdapter;

            //updating database based on dataset
            try
            {
                int rowsUpdated = tableAdapterManager.UpdateAll(projectTrackingDataSet);
                SetReadyLabel($"Database updated. Totals rows updated [{rowsUpdated}]");

            }
            //if an error, display a message to user.
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        //menu strip for exiting
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }


        //arranges window in cascade style
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        
        //arrange window in horizontal tile
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        //arrange window in verticle tile
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        //Taking form, setting main form as parent, update status label, and showing form.
        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            SetReadyLabel($"{form.Text} is open.");
            form.Show();
        }
        //Updates status label.
        public void SetReadyLabel(string message)
        {
            toolStripStatusLabel.Text = message;
        }


        //Save click event. Save data to database.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        //Click event for project tasks menu option. 
        private void projectTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectTasksForm(projectTrackingDataSet));
        }

        //Click event for employees menu option.
        private void projectEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectEmployeesForm(projectTrackingDataSet));
        }

        //Click event for employee projects and tasks menu option.
        private void employeeProjectTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new EmployeeProjectsAndTasksForm(projectTrackingDataSet));
        }
    }
}
