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
            this.projectListBox = new System.Windows.Forms.ListBox();
            this.projectListBoxLabel = new System.Windows.Forms.Label();
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
            // projectListBox
            // 
            this.projectListBox.DataSource = this.projectBindingSource;
            this.projectListBox.DisplayMember = "Name";
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.Location = new System.Drawing.Point(12, 55);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.Size = new System.Drawing.Size(300, 212);
            this.projectListBox.TabIndex = 1;
            this.projectListBox.ValueMember = "Id";
            this.projectListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.projectListBox_Format);
            // 
            // projectListBoxLabel
            // 
            this.projectListBoxLabel.AutoSize = true;
            this.projectListBoxLabel.Location = new System.Drawing.Point(13, 36);
            this.projectListBoxLabel.Name = "projectListBoxLabel";
            this.projectListBoxLabel.Size = new System.Drawing.Size(43, 13);
            this.projectListBoxLabel.TabIndex = 2;
            this.projectListBoxLabel.Text = "Project:";
            // 
            // ProjectEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectListBoxLabel);
            this.Controls.Add(this.projectListBox);
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
        private System.Windows.Forms.ListBox projectListBox;
        private System.Windows.Forms.Label projectListBoxLabel;
    }
}