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
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // projectTrackingDataSet
            // 
            this.projectTrackingDataSet.DataSetName = "ProjectTrackingDataSet";
            this.projectTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProjectEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProjectEmployeesForm";
            this.Text = "Project and Employees";
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectTrackingDataSet projectTrackingDataSet;
    }
}