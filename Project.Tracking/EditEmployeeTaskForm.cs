using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Christine Jordan Term Project 12.7.2020
namespace Project.Tracking
{
    public partial class EditEmployeeTaskForm : Form
    {
        public EditEmployeeTaskForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.employeeTasksBindingSource.DataSource = null;
            this.employeeTasksBindingSource.DataSource = projectTrackingDataSet.EmployeeTasks;
            this.taskBindingSource.DataSource = projectTrackingDataSet.Task;
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        //Create Event Handler for saving employee tasks data
        private void employeeTasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                employeeTasksBindingSource.EndEdit();
                //Save the data
                MainForm.SaveData();
            }
            catch (Exception ex)
            {

                //If not valid, display message.
                MessageBox.Show(ex.Message);
                MainForm.SetReadyLabel("Error saving employee tasks!");
            }
        }

        private void EditEmployeeTaskForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
