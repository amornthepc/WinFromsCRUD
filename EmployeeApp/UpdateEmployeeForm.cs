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
    public partial class UpdateEmployeeForm : Form
    {
        private readonly IEmployeeData _db;
        private EmployeeModel? _empData = null;
        public int Id { get; set; }

        public UpdateEmployeeForm(IEmployeeData db)
        {
            InitializeComponent();
            _db = db;
        }

        public async Task GetEmployeeInfo(int id)
        {
            _empData = await _db.GetEmployeeById(id);

            firstNameText.Text = _empData.FirstName;
            lastNameText.Text = _empData.LastName;
            phoneNumberText.Text = _empData.PhoneNumber;
            hireDatePicker.Value = _empData.HireDate;
            salaryText.Text = _empData.Salary.ToString();
            status.Checked = bool.Parse(_empData.Status);
            jobTitleText.Text = _empData.JobTitle;

        }

        private async void Update_Click(object sender, EventArgs e)
        {
            await UpdateEmployee();
            Close();
        }

        private async Task UpdateEmployee()
        {
            await _db.UpdateEmployee(_empData.Id,
                                      firstNameText.Text,
                                      lastNameText.Text,
                                      phoneNumberText.Text,
                                      hireDatePicker.Value,
                                      decimal.Parse(salaryText.Text),
                                      jobTitleText.Text,
                                      status.Checked);
        }
    }
}
