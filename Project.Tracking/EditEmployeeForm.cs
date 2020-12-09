//Christine Jordan 12.7.2020 Term Project: editing Employee Info 
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
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.employeeBindingSource.DataSource = null;
            this.employeeBindingSource.DataSource = projectTrackingDataSet.Employee;
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        //Event handler to save employee data
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                employeeBindingSource.EndEdit();
                //Save the data
                MainForm.SaveData();
            }
            catch (Exception ex)
            {

                //If not valid, display message.
                MessageBox.Show(ex.Message);
                MainForm.SetReadyLabel("Error saving employee!");
            }
        }
    }
}
