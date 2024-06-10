namespace EmployeeApp
{
    partial class UpdateEmployeeForm
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
            update = new Button();
            isActiveLabel = new Label();
            status = new CheckBox();
            hireDatePicker = new DateTimePicker();
            jobTitleText = new TextBox();
            jobTitleLabel = new Label();
            salaryText = new TextBox();
            salaryLabel = new Label();
            hireDateLabel = new Label();
            phoneNumberText = new TextBox();
            phoneNumberLabel = new Label();
            lastNameText = new TextBox();
            lastNameLabel = new Label();
            firstNameText = new TextBox();
            firstNameLabel = new Label();
            updateLabel = new Label();
            SuspendLayout();
            // 
            // update
            // 
            update.Location = new Point(201, 545);
            update.Name = "update";
            update.Size = new Size(107, 42);
            update.TabIndex = 23;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += Update_Click;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new Point(27, 469);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new Size(99, 31);
            isActiveLabel.TabIndex = 18;
            isActiveLabel.Text = "Is Active";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Checked = true;
            status.CheckState = CheckState.Checked;
            status.Location = new Point(203, 477);
            status.Name = "status";
            status.Size = new Size(18, 17);
            status.TabIndex = 22;
            status.UseVisualStyleBackColor = true;
            // 
            // hireDatePicker
            // 
            hireDatePicker.Location = new Point(201, 277);
            hireDatePicker.Name = "hireDatePicker";
            hireDatePicker.Size = new Size(274, 38);
            hireDatePicker.TabIndex = 19;
            // 
            // jobTitleText
            // 
            jobTitleText.Location = new Point(201, 407);
            jobTitleText.Name = "jobTitleText";
            jobTitleText.Size = new Size(274, 38);
            jobTitleText.TabIndex = 21;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new Point(27, 406);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new Size(99, 31);
            jobTitleLabel.TabIndex = 9;
            jobTitleLabel.Text = "Job Title";
            // 
            // salaryText
            // 
            salaryText.Location = new Point(201, 340);
            salaryText.Name = "salaryText";
            salaryText.Size = new Size(274, 38);
            salaryText.TabIndex = 20;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(27, 339);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(75, 31);
            salaryLabel.TabIndex = 10;
            salaryLabel.Text = "Salary";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new Point(27, 277);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new Size(110, 31);
            hireDateLabel.TabIndex = 11;
            hireDateLabel.Text = "Hire Date";
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(201, 214);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(274, 38);
            phoneNumberText.TabIndex = 17;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(27, 217);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(168, 31);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(201, 154);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(274, 38);
            lastNameText.TabIndex = 16;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(27, 153);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(122, 31);
            lastNameLabel.TabIndex = 13;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(201, 94);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(274, 38);
            firstNameText.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(27, 93);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(124, 31);
            firstNameLabel.TabIndex = 14;
            firstNameLabel.Text = "First Name";
            // 
            // updateLabel
            // 
            updateLabel.AutoSize = true;
            updateLabel.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateLabel.Location = new Point(163, 26);
            updateLabel.Name = "updateLabel";
            updateLabel.Size = new Size(158, 43);
            updateLabel.TabIndex = 24;
            updateLabel.Text = "Update";
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 626);
            Controls.Add(updateLabel);
            Controls.Add(update);
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
            Name = "UpdateEmployeeForm";
            Text = "Employee Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update;
        private Label isActiveLabel;
        private CheckBox status;
        private DateTimePicker hireDatePicker;
        private TextBox jobTitleText;
        private Label jobTitleLabel;
        private TextBox salaryText;
        private Label salaryLabel;
        private Label hireDateLabel;
        private TextBox phoneNumberText;
        private Label phoneNumberLabel;
        private TextBox lastNameText;
        private Label lastNameLabel;
        private TextBox firstNameText;
        private Label firstNameLabel;
        private Label updateLabel;
    }
}