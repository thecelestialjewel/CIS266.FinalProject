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

namespace Project.Tracking
{
    public partial class EditTaskForm : Form
    {
        public EditTaskForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;

            this.taskBindingSource.DataSource = null;
            this.taskBindingSource.DataSource = this.projectTrackingDataSet.Task;

            this.projectBindingSource.DataSource = null;
            this.projectBindingSource.DataSource = this.projectTrackingDataSet.Project;

            this.statusBindingSource.DataSource = null;
            this.statusBindingSource.DataSource = this.projectTrackingDataSet.Status;
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        //Event handler created for task data.
        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                taskBindingSource.EndEdit();
                //Save the data
                MainForm.SaveData();
            }
            catch (Exception ex)
            {

                //If not valid, display message.
                MessageBox.Show(ex.Message);
                MainForm.SetReadyLabel("Error saving tasks!");
            }
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
