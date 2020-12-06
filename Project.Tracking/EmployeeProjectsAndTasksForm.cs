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
    public partial class EmployeeProjectsAndTasksForm : Form
    {
        private bool isLoaded = false;
        public EmployeeProjectsAndTasksForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;
            this.employeeBindingSource.DataSource = this.projectTrackingDataSet.Employee;
            isLoaded = true;

        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded && employeeListBox.SelectedIndex != -1)
            {

            }
        }

        //Event-handler for formating values for listbox. 
        private void employeeListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((DataRowView)e.ListItem).Row["FirstName"] + " " + ((DataRowView)e.ListItem).Row["LastName"];
        }
    }
}
