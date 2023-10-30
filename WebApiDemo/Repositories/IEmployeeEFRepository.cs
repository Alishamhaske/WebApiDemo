using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public interface IEmployeeEFRepository
    {


        IEnumerable<EmployeeEF> GetEmployeeEFs();

        EmployeeEF GetEmployeeEFById(int id);
        int UpdateEmployeeEF(EmployeeEF employeeEF);
        int DeleteEmployeeEF(int id);
        int AddEmployeeEF(EmployeeEF employeeEF);



    }
}
