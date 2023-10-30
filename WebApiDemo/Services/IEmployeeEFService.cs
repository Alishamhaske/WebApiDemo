using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public interface IEmployeeEFService
    {
        IEnumerable<EmployeeEF> GetEmployeeEFs();

        EmployeeEF GetEmployeeEFById(int id);
        int UpdateEmployeeEF(EmployeeEF employeeEF);
        int DeleteEmployeeEF(int id);
        int AddEmployeeEF(EmployeeEF employeeEF);

    }
}
