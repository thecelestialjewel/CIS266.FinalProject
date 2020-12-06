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
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }
    }
}
