using EmployeeLibrary.Models;

namespace EmployeeLibrary.DataAccess
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess _db;

        public EmployeeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<EmployeeModel>> GetAllEmployee()
        {
            return await _db.LoadData<EmployeeModel, dynamic>("spEmployees_ViewAll", new { });
        }

        public async Task<List<EmployeeModel>> GetAllOrSearchEmployee(string searchText)
        {
            return await _db.LoadData<EmployeeModel, dynamic>("spEmployees_GetAllOrSearch", new { SearchText = searchText });
        }

        public async Task<EmployeeModel?> GetEmployeeById(int id)
        {
            var rows = await _db.LoadData<EmployeeModel, dynamic>("spEmployees_GetEmployeeById", new { Id = id });
            return rows.FirstOrDefault();
        }

        public async Task CreateEmployee(string firstName,
                                   string lastName,
                                   string phoneNumber,
                                   DateTime hireDate,
                                   decimal salary,
                                   string jobTitle,
                                   bool status)
        {
            await _db.SaveData("spEmployees_Insert",
                new
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    HireDate = hireDate,
                    Salary = salary,
                    JobTitle = jobTitle,
                    Status = status
                });
        }
        public async Task UpdateEmployee(int id,
                                   string firstName,
                                   string lastName,
                                   string phoneNumber,
                                   DateTime hireDate,
                                   decimal salary,
                                   string jobTitle,
                                   bool status)
        {
            await _db.SaveData("spEmployees_Update",
                new
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    HireDate = hireDate,
                    Salary = salary,
                    JobTitle = jobTitle,
                    Status = status
                });
        }

        public async Task DeleteEmployee(int id)
        {
            await _db.SaveData("spEmployees_Delete", new { Id = id });
        }
    }
}
