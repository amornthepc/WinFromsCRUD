using EmployeeLibrary.DataAccess;
using EmployeeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class AddEmployeeForm : Form
    {
        private readonly IEmployeeData _db;

        public AddEmployeeForm(IEmployeeData db)
        {
            InitializeComponent();
            _db = db;
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            if (IsValidInfo()) 
                await SaveEmployee();

            Close();
        }

        private async Task SaveEmployee()
        {
            var FirstName = firstNameText.Text;
            var LastName = lastNameText.Text;
            var PhoneNumber = phoneNumberText.Text;
            var HireDate = hireDatePicker.Value;
            var Salary = decimal.Parse(salaryText.Text);
            var Status = status.Checked;
            var JobTitle = jobTitleText.Text;

            await _db.CreateEmployee(FirstName, LastName, PhoneNumber, HireDate, Salary, JobTitle, Status);
        }

        private bool IsBlankField()
        {
            if (string.IsNullOrEmpty(firstNameText.Text)) return true;
            if (string.IsNullOrEmpty(lastNameText.Text)) return true;
            if (string.IsNullOrEmpty(phoneNumberText.Text)) return true;
            if (string.IsNullOrEmpty(hireDatePicker.Text)) return true;
            if (string.IsNullOrEmpty(salaryText.Text)) return true;
            if (string.IsNullOrEmpty(jobTitleText.Text)) return true;

            return false;
        }

        private bool IsValidInfo()
        {
            if (IsBlankField())
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

    }
}
