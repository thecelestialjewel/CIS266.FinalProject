namespace Project.Tracking
{
    partial class EmployeeProjectsAndTasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.projectTrackingDataSet = new Project.Tracking.ProjectTrackingDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.projectDetailsListView = new System.Windows.Forms.ListView();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.projectDetailsLabel = new System.Windows.Forms.Label();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.totalHourTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectTrackingDataSet
            // 
            this.projectTrackingDataSet.DataSetName = "ProjectTrackingDataSet";
            this.projectTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.projectTrackingDataSet;
            // 
            // employeeListBox
            // 
            this.employeeListBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeBindingSource, "Id", true));
            this.employeeListBox.DataSource = this.employeeBindingSource;
            this.employeeListBox.DisplayMember = "FirstName";
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(12, 22);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(302, 212);
            this.employeeListBox.TabIndex = 2;
            this.employeeListBox.ValueMember = "Id";
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            this.employeeListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.employeeListBox_Format);
            // 
            // projectDetailsListView
            // 
            this.projectDetailsListView.HideSelection = false;
            this.projectDetailsListView.Location = new System.Drawing.Point(336, 22);
            this.projectDetailsListView.Name = "projectDetailsListView";
            this.projectDetailsListView.Size = new System.Drawing.Size(397, 212);
            this.projectDetailsListView.TabIndex = 3;
            this.projectDetailsListView.UseCompatibleStateImageBehavior = false;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(13, 3);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(56, 13);
            this.employeeLabel.TabIndex = 4;
            this.employeeLabel.Text = "Employee:";
            // 
            // projectDetailsLabel
            // 
            this.projectDetailsLabel.AutoSize = true;
            this.projectDetailsLabel.Location = new System.Drawing.Point(336, 3);
            this.projectDetailsLabel.Name = "projectDetailsLabel";
            this.projectDetailsLabel.Size = new System.Drawing.Size(75, 13);
            this.projectDetailsLabel.TabIndex = 5;
            this.projectDetailsLabel.Text = "Project Details";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Location = new System.Drawing.Point(16, 262);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(65, 13);
            this.totalHoursLabel.TabIndex = 6;
            this.totalHoursLabel.Text = "Total Hours:";
            // 
            // totalHourTextBox
            // 
            this.totalHourTextBox.Enabled = false;
            this.totalHourTextBox.Location = new System.Drawing.Point(87, 259);
            this.totalHourTextBox.Name = "totalHourTextBox";
            this.totalHourTextBox.Size = new System.Drawing.Size(61, 20);
            this.totalHourTextBox.TabIndex = 7;
            // 
            // EmployeeProjectsAndTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 312);
            this.Controls.Add(this.totalHourTextBox);
            this.Controls.Add(this.totalHoursLabel);
            this.Controls.Add(this.projectDetailsLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.projectDetailsListView);
            this.Controls.Add(this.employeeListBox);
            this.Name = "EmployeeProjectsAndTasksForm";
            this.Text = "Employee Projects and Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjectTrackingDataSet projectTrackingDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.ListView projectDetailsListView;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label projectDetailsLabel;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.TextBox totalHourTextBox;
    }
}