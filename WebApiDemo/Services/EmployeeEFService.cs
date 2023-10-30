using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class EmployeeEFService : IEmployeeEFService
    {
        private readonly IEmployeeEFRepository repo;
        public EmployeeEFService(IEmployeeEFRepository repo)
        {
            this.repo = repo;
        }

        public int AddEmployeeEF(EmployeeEF employeeEF)
        {
            return repo.AddEmployeeEF(employeeEF);
        }

        public int DeleteEmployeeEF(int id)
        {
            return repo.DeleteEmployeeEF(id);
        }

        public EmployeeEF GetEmployeeEFById(int id)
        {
            return repo.GetEmployeeEFById(id);
        }

        public IEnumerable<EmployeeEF> GetEmployeeEFs()
        {
            return repo.GetEmployeeEFs();
        }

        public int UpdateEmployeeEF(EmployeeEF employeeEF)
        {
            return repo.UpdateEmployeeEF(employeeEF);
        }
    }
}
