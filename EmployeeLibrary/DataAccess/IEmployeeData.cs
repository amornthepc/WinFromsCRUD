using EmployeeLibrary.Models;

namespace EmployeeLibrary.DataAccess
{
    public interface IEmployeeData
    {
        Task CreateEmployee(string firstName, string lastName, string phoneNumber, DateTime hireDate, decimal salary, string jobTitle, bool status);
        Task DeleteEmployee(int id);
        Task<List<EmployeeModel>> GetAllEmployee();
        Task<List<EmployeeModel>> GetAllOrSearchEmployee(string searchText);
        Task UpdateEmployee(int id, string firstName, string lastName, string phoneNumber, DateTime hireDate, decimal salary, string jobTitle, bool status);
        Task<EmployeeModel?> GetEmployeeById(int id);
    }
}