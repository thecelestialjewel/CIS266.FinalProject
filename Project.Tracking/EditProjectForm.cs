//Christine Jordan 12.7.2020 CIS266: Term Project 
//Edit Projects
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
    public partial class EditProjectForm : Form
    {
        public EditProjectForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;
            
            this.projectBindingSource.DataSource = null;
            this.projectBindingSource.DataSource = this.projectTrackingDataSet.Project;

            //this.statusBindingSource.DataSource = null;
            //this.statusBindingSource.DataSource = this.projectTrackingDataSet.Status;

            //this.employeeBindingSource.DataSource = null;
            //this.employeeBindingSource.DataSource = this.projectTrackingDataSet.Employee;

            
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        //Creating save event handler
        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Making sure data is valid and edit is turning off.
            try
            {
                Validate();
                projectBindingSource.EndEdit();
                //Save the data
                MainForm.SaveData();
            }
            catch (Exception ex)
            {
                //If not valid, display message.
                MessageBox.Show(ex.Message);
                MainForm.SetReadyLabel("Error saving project!");
            }
        }
    }
}
