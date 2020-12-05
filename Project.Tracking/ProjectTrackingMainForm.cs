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

            InitializeComponent();
            projectTrackingDataSet = new ProjectTrackingDataSet();

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
        
        //menu strip for exiting
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }


        //
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        public void SetReadyLabel(string message)
        {
            statusStrip.Text = message;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
