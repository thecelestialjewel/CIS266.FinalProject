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
    public partial class ProjectEmployeesForm : Form
    {
        public ProjectEmployeesForm(ProjectTrackingDataSet projectTrackingDataSet)
        {
            InitializeComponent();
        }
    }
}
