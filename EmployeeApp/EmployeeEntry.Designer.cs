namespace EmployeeApp
{
    partial class EmployeeEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeeDataGridView = new DataGridView();
            add = new Button();
            edit = new Button();
            delete = new Button();
            search = new Button();
            searchText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Location = new Point(52, 83);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.Size = new Size(1160, 336);
            employeeDataGridView.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(1218, 85);
            add.Name = "add";
            add.Size = new Size(97, 42);
            add.TabIndex = 1;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += Add_Click;
            // 
            // edit
            // 
            edit.Location = new Point(1218, 132);
            edit.Name = "edit";
            edit.Size = new Size(97, 42);
            edit.TabIndex = 1;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += Edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(1218, 179);
            delete.Name = "delete";
            delete.Size = new Size(97, 42);
            delete.TabIndex = 1;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += Delete_Click;
            // 
            // search
            // 
            search.Location = new Point(1117, 35);
            search.Name = "search";
            search.Size = new Size(95, 42);
            search.TabIndex = 1;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += Search_Click;
            // 
            // searchText
            // 
            searchText.Location = new Point(52, 35);
            searchText.Name = "searchText";
            searchText.Size = new Size(1059, 38);
            searchText.TabIndex = 2;
            // 
            // EmployeeEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1362, 559);
            Controls.Add(searchText);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(search);
            Controls.Add(add);
            Controls.Add(employeeDataGridView);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "EmployeeEntry";
            Text = "Employee Entry";
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeeDataGridView;
        private Button add;
        private Button edit;
        private Button delete;
        private Button search;
        private TextBox searchText;
    }
}
