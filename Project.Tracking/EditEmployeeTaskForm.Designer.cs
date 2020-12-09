namespace Project.Tracking
{
    partial class EditEmployeeTaskForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label taskIdLabel;
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label hoursWorkedLabel;
            System.Windows.Forms.Label dateWorkedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeTaskForm));
            this.employeeTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTasksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeTasksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.taskIdComboBox = new System.Windows.Forms.ComboBox();
            this.employeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.dateWorkedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectTrackingDataSet = new Project.Tracking.ProjectTrackingDataSet();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            taskIdLabel = new System.Windows.Forms.Label();
            employeeIdLabel = new System.Windows.Forms.Label();
            hoursWorkedLabel = new System.Windows.Forms.Label();
            dateWorkedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingNavigator)).BeginInit();
            this.employeeTasksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // taskIdLabel
            // 
            taskIdLabel.AutoSize = true;
            taskIdLabel.Location = new System.Drawing.Point(9, 57);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new System.Drawing.Size(34, 13);
            taskIdLabel.TabIndex = 3;
            taskIdLabel.Text = "Task:";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(9, 84);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(68, 13);
            employeeIdLabel.TabIndex = 5;
            employeeIdLabel.Text = "Employee Id:";
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new System.Drawing.Point(9, 111);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            hoursWorkedLabel.TabIndex = 7;
            hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // dateWorkedLabel
            // 
            dateWorkedLabel.AutoSize = true;
            dateWorkedLabel.Location = new System.Drawing.Point(9, 138);
            dateWorkedLabel.Name = "dateWorkedLabel";
            dateWorkedLabel.Size = new System.Drawing.Size(74, 13);
            dateWorkedLabel.TabIndex = 9;
            dateWorkedLabel.Text = "Date Worked:";
            // 
            // employeeTasksBindingNavigator
            // 
            this.employeeTasksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeTasksBindingNavigator.BindingSource = this.employeeTasksBindingSource;
            this.employeeTasksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeTasksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeTasksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeeTasksBindingNavigatorSaveItem});
            this.employeeTasksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeTasksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeTasksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeTasksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeTasksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeTasksBindingNavigator.Name = "employeeTasksBindingNavigator";
            this.employeeTasksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeTasksBindingNavigator.Size = new System.Drawing.Size(365, 25);
            this.employeeTasksBindingNavigator.TabIndex = 0;
            this.employeeTasksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employeeTasksBindingNavigatorSaveItem
            // 
            this.employeeTasksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeTasksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeTasksBindingNavigatorSaveItem.Image")));
            this.employeeTasksBindingNavigatorSaveItem.Name = "employeeTasksBindingNavigatorSaveItem";
            this.employeeTasksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeTasksBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeTasksBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(94, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(36, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // taskIdComboBox
            // 
            this.taskIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taskBindingSource, "Name", true));
            this.taskIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Name", true));
            this.taskIdComboBox.DataSource = this.taskBindingSource;
            this.taskIdComboBox.DisplayMember = "Name";
            this.taskIdComboBox.FormattingEnabled = true;
            this.taskIdComboBox.Location = new System.Drawing.Point(94, 54);
            this.taskIdComboBox.Name = "taskIdComboBox";
            this.taskIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.taskIdComboBox.TabIndex = 4;
            this.taskIdComboBox.ValueMember = "Id";
            // 
            // employeeIdComboBox
            // 
            this.employeeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.employeeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "Id", true));
            this.employeeIdComboBox.DataSource = this.employeeBindingSource;
            this.employeeIdComboBox.DisplayMember = "FirstName";
            this.employeeIdComboBox.FormattingEnabled = true;
            this.employeeIdComboBox.Location = new System.Drawing.Point(94, 81);
            this.employeeIdComboBox.Name = "employeeIdComboBox";
            this.employeeIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeeIdComboBox.TabIndex = 6;
            this.employeeIdComboBox.ValueMember = "Id";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeTasksBindingSource, "HoursWorked", true));
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(94, 108);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(49, 20);
            this.hoursWorkedTextBox.TabIndex = 8;
            // 
            // dateWorkedDateTimePicker
            // 
            this.dateWorkedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeTasksBindingSource, "DateWorked", true));
            this.dateWorkedDateTimePicker.Location = new System.Drawing.Point(94, 134);
            this.dateWorkedDateTimePicker.Name = "dateWorkedDateTimePicker";
            this.dateWorkedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateWorkedDateTimePicker.TabIndex = 10;
            // 
            // projectTrackingDataSet
            // 
            this.projectTrackingDataSet.DataSetName = "ProjectTrackingDataSet";
            this.projectTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.projectTrackingDataSet;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.projectTrackingDataSet;
            // 
            // EditEmployeeTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 268);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(taskIdLabel);
            this.Controls.Add(this.taskIdComboBox);
            this.Controls.Add(employeeIdLabel);
            this.Controls.Add(this.employeeIdComboBox);
            this.Controls.Add(hoursWorkedLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(dateWorkedLabel);
            this.Controls.Add(this.dateWorkedDateTimePicker);
            this.Controls.Add(this.employeeTasksBindingNavigator);
            this.Name = "EditEmployeeTaskForm";
            this.Text = "Edit Employee Task";
            this.Load += new System.EventHandler(this.EditEmployeeTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingNavigator)).EndInit();
            this.employeeTasksBindingNavigator.ResumeLayout(false);
            this.employeeTasksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeTasksBindingSource;
        private System.Windows.Forms.BindingNavigator employeeTasksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeeTasksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox taskIdComboBox;
        private System.Windows.Forms.ComboBox employeeIdComboBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.DateTimePicker dateWorkedDateTimePicker;
        private ProjectTrackingDataSet projectTrackingDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}