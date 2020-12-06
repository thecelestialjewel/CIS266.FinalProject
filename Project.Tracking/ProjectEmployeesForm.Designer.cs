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
            this.components = new System.ComponentModel.Container();
            this.projectTrackingDataSet = new Project.Tracking.ProjectTrackingDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectListBoxLabel = new System.Windows.Forms.Label();
            this.employeeDetailsListView = new System.Windows.Forms.ListView();
            this.projectListView = new System.Windows.Forms.ListView();
            this.taskDetailsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectTrackingDataSet
            // 
            this.projectTrackingDataSet.DataSetName = "ProjectTrackingDataSet";
            this.projectTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.projectTrackingDataSet;
            // 
            // projectListBoxLabel
            // 
            this.projectListBoxLabel.AutoSize = true;
            this.projectListBoxLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectListBoxLabel.Location = new System.Drawing.Point(119, 39);
            this.projectListBoxLabel.Name = "projectListBoxLabel";
            this.projectListBoxLabel.Size = new System.Drawing.Size(58, 18);
            this.projectListBoxLabel.TabIndex = 2;
            this.projectListBoxLabel.Text = "Project:";
            // 
            // employeeDetailsListView
            // 
            this.employeeDetailsListView.HideSelection = false;
            this.employeeDetailsListView.Location = new System.Drawing.Point(432, 68);
            this.employeeDetailsListView.Name = "employeeDetailsListView";
            this.employeeDetailsListView.Size = new System.Drawing.Size(275, 290);
            this.employeeDetailsListView.TabIndex = 3;
            this.employeeDetailsListView.UseCompatibleStateImageBehavior = false;
            // 
            // projectListView
            // 
            this.projectListView.HideSelection = false;
            this.projectListView.Location = new System.Drawing.Point(28, 68);
            this.projectListView.Name = "projectListView";
            this.projectListView.Size = new System.Drawing.Size(269, 290);
            this.projectListView.TabIndex = 4;
            this.projectListView.UseCompatibleStateImageBehavior = false;
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(136, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ProjectEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDetailsLabel);
            this.Controls.Add(this.projectListView);
            this.Controls.Add(this.employeeDetailsListView);
            this.Controls.Add(this.projectListBoxLabel);
            this.Name = "ProjectEmployeesForm";
            this.Text = "Project and Employees";
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectTrackingDataSet projectTrackingDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Label projectListBoxLabel;
        private System.Windows.Forms.ListView employeeDetailsListView;
        private System.Windows.Forms.ListView projectListView;
        private System.Windows.Forms.Label taskDetailsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}