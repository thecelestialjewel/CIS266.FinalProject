namespace Project.Tracking
{
    partial class ProjectEmployeesForm
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
            this.projectTrackingDataSet = new Project.Tracking.ProjectTrackingDataSet();
            this.projectListBoxLabel = new System.Windows.Forms.Label();
            this.taskDetailsListView = new System.Windows.Forms.ListView();
            this.projectListView = new System.Windows.Forms.ListView();
            this.taskDetailsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalHoursTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // projectTrackingDataSet
            // 
            this.projectTrackingDataSet.DataSetName = "ProjectTrackingDataSet";
            this.projectTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectListBoxLabel
            // 
            this.projectListBoxLabel.AutoSize = true;
            this.projectListBoxLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectListBoxLabel.Location = new System.Drawing.Point(145, 39);
            this.projectListBoxLabel.Name = "projectListBoxLabel";
            this.projectListBoxLabel.Size = new System.Drawing.Size(58, 18);
            this.projectListBoxLabel.TabIndex = 2;
            this.projectListBoxLabel.Text = "Project:";
            // 
            // taskDetailsListView
            // 
            this.taskDetailsListView.HideSelection = false;
            this.taskDetailsListView.Location = new System.Drawing.Point(432, 68);
            this.taskDetailsListView.Name = "taskDetailsListView";
            this.taskDetailsListView.Size = new System.Drawing.Size(342, 290);
            this.taskDetailsListView.TabIndex = 3;
            this.taskDetailsListView.UseCompatibleStateImageBehavior = false;
            // 
            // projectListView
            // 
            this.projectListView.HideSelection = false;
            this.projectListView.Location = new System.Drawing.Point(28, 68);
            this.projectListView.Name = "projectListView";
            this.projectListView.Size = new System.Drawing.Size(352, 290);
            this.projectListView.TabIndex = 4;
            this.projectListView.UseCompatibleStateImageBehavior = false;
            this.projectListView.SelectedIndexChanged += new System.EventHandler(this.projectListView_SelectedIndexChanged);
            // 
            // taskDetailsLabel
            // 
            this.taskDetailsLabel.AutoSize = true;
            this.taskDetailsLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDetailsLabel.Location = new System.Drawing.Point(530, 39);
            this.taskDetailsLabel.Name = "taskDetailsLabel";
            this.taskDetailsLabel.Size = new System.Drawing.Size(85, 18);
            this.taskDetailsLabel.TabIndex = 5;
            this.taskDetailsLabel.Text = "Task Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Hours:";
            // 
            // totalHoursTextBox
            // 
            this.totalHoursTextBox.Enabled = false;
            this.totalHoursTextBox.Location = new System.Drawing.Point(136, 389);
            this.totalHoursTextBox.Name = "totalHoursTextBox";
            this.totalHoursTextBox.Size = new System.Drawing.Size(67, 20);
            this.totalHoursTextBox.TabIndex = 7;
            // 
            // ProjectEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalHoursTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDetailsLabel);
            this.Controls.Add(this.projectListView);
            this.Controls.Add(this.taskDetailsListView);
            this.Controls.Add(this.projectListBoxLabel);
            this.Name = "ProjectEmployeesForm";
            this.Text = "Project and Employees";
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectTrackingDataSet projectTrackingDataSet;
        private System.Windows.Forms.Label projectListBoxLabel;
        private System.Windows.Forms.ListView taskDetailsListView;
        private System.Windows.Forms.ListView projectListView;
        private System.Windows.Forms.Label taskDetailsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalHoursTextBox;
    }
}