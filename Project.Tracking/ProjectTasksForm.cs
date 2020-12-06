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
    public partial class ProjectTasksForm : Form
    {
        //Receiving dataset from mainform and updating controls to use dataset.
        public ProjectTasksForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;
            this.projectBindingSource.DataSource = this.projectTrackingDataSet;
            this.statusBindingSource.DataSource = this.projectTrackingDataSet;

            statusIdComboBox.DataSource = this.projectTrackingDataSet.Status;
            managerIdComboBox.DataSource = this.projectTrackingDataSet.Employee;

        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }
    }
}
