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
    public partial class EditEmployeeTaskForm : Form
    {
        public EditEmployeeTaskForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;
            this.employeeTasksBindingSource.DataSource = null;
            this.employeeTasksBindingSource.DataSource = this.projectTrackingDataSet.EmployeeTasks;
        }
    }
}
