namespace EmployeeApp
{
    partial class AddEmployeeForm
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
            firstNameLabel = new Label();
            firstNameText = new TextBox();
            lastNameLabel = new Label();
            lastNameText = new TextBox();
            phoneNumberLabel = new Label();
            phoneNumberText = new TextBox();
            hireDateLabel = new Label();
            salaryLabel = new Label();
            salaryText = new TextBox();
            jobTitleLabel = new Label();
            jobTitleText = new TextBox();
            hireDatePicker = new DateTimePicker();
            status = new CheckBox();
            isActiveLabel = new Label();
            save = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(65, 72);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(124, 31);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(239, 73);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(274, 38);
            firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(65, 132);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(122, 31);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(239, 133);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(274, 38);
            lastNameText.TabIndex = 2;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(65, 196);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(168, 31);
            phoneNumberLabel.TabIndex = 0;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(239, 193);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(274, 38);
            phoneNumberText.TabIndex = 3;
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new Point(65, 256);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new Size(110, 31);
            hireDateLabel.TabIndex = 0;
            hireDateLabel.Text = "Hire Date";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(65, 318);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(75, 31);
            salaryLabel.TabIndex = 0;
            salaryLabel.Text = "Salary";
            // 
            // salaryText
            // 
            salaryText.Location = new Point(239, 319);
            salaryText.Name = "salaryText";
            salaryText.Size = new Size(274, 38);
            salaryText.TabIndex = 5;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new Point(65, 385);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new Size(99, 31);
            jobTitleLabel.TabIndex = 0;
            jobTitleLabel.Text = "Job Title";
            // 
            // jobTitleText
            // 
            jobTitleText.Location = new Point(239, 386);
            jobTitleText.Name = "jobTitleText";
            jobTitleText.Size = new Size(274, 38);
            jobTitleText.TabIndex = 6;
            // 
            // hireDatePicker
            // 
            hireDatePicker.Location = new Point(239, 256);
            hireDatePicker.Name = "hireDatePicker";
            hireDatePicker.Size = new Size(274, 38);
            hireDatePicker.TabIndex = 4;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Checked = true;
            status.CheckState = CheckState.Checked;
            status.Location = new Point(241, 456);
            status.Name = "status";
            status.Size = new Size(18, 17);
            status.TabIndex = 7;
            status.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new Point(65, 448);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new Size(99, 31);
            isActiveLabel.TabIndex = 4;
            isActiveLabel.Text = "Is Active";
            // 
            // save
            // 
            save.Location = new Point(218, 520);
            save.Name = "save";
            save.Size = new Size(107, 42);
            save.TabIndex = 8;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += Save_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 594);
            Controls.Add(save);
            Controls.Add(isActiveLabel);
            Controls.Add(status);
            Controls.Add(hireDatePicker);
            Controls.Add(jobTitleText);
            Controls.Add(jobTitleLabel);
            Controls.Add(salaryText);
            Controls.Add(salaryLabel);
            Controls.Add(hireDateLabel);
            Controls.Add(phoneNumberText);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lastNameText);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameText);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "AddEmployeeForm";
            Text = "Employee Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private Label phoneNumberLabel;
        private TextBox phoneNumberText;
        private Label hireDateLabel;
        private Label salaryLabel;
        private TextBox salaryText;
        private Label jobTitleLabel;
        private TextBox jobTitleText;
        private DateTimePicker hireDatePicker;
        private CheckBox status;
        private Label isActiveLabel;
        private Button save;
    }
}