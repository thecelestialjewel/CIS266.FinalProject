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
        public EmployeeProjectsAndTasksForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }
    }
}
