using EmployeeLibrary.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Security;

namespace EmployeeApp
{
    public partial class EmployeeEntry : Form
    {
        private readonly IEmployeeData _db;

        public EmployeeEntry(IEmployeeData db)
        {
            InitializeComponent();
            _db = db;
        }

        private async Task FillDataGridView()
        {
            var employees = await _db.GetAllOrSearchEmployee(searchText.Text);

            employeeDataGridView.DataSource = employees;
        }

        private async void Search_Click(object sender, EventArgs e)
        {
            //var employees = await _db.GetAllOrSearchEmployee(searchText.Text);

            //employeeDataGridView.DataSource = employees;

            await FillDataGridView();
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            var addForm = Program.ServiceProvider.GetRequiredService<AddEmployeeForm>();
            addForm.ShowDialog();
            

            await FillDataGridView();
        }

        private async void Edit_Click(object sender, EventArgs e)
        {
            var updateForm = Program.ServiceProvider.GetRequiredService<UpdateEmployeeForm>();

            var empId = (int)employeeDataGridView.CurrentRow.Cells[0].Value;
            await updateForm.GetEmployeeInfo(empId);

            updateForm.ShowDialog();

            await FillDataGridView();
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            var id = (int)employeeDataGridView.CurrentRow.Cells[0].Value;

            await _db.DeleteEmployee(id);

            await FillDataGridView();
        }
    }
}
