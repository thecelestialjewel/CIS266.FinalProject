﻿using System;
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

            this.projectTrackingDataSet = null;
            this.projectTrackingDataSet = projectTrackingDataSet;
            this.projectBindingSource.DataSource = this.projectTrackingDataSet.Project;
           
        }

        //Getting main form to access public methods and properities.
        private ProjectTrackingMainForm MainForm
        {
            get { return (ProjectTrackingMainForm)MdiParent; }
        }

        private void projectListBox_Format(object sender, ListControlConvertEventArgs e)
        {

        }
    }
}
