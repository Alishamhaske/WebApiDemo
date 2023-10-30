using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class EmployeeEFRepository : IEmployeeEFRepository
    {

        private readonly ApplicationDbContext db;

        public EmployeeEFRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployeeEF(EmployeeEF employeeEF)
        {
            db.EmployeeEFs.Add(employeeEF);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployeeEF(int id)
        {
            int res = 0;
            var result = db.EmployeeEFs.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.EmployeeEFs.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public EmployeeEF GetEmployeeEFById(int id)
        {
            var result = db.EmployeeEFs.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<EmployeeEF> GetEmployeeEFs()
        {
            var result = from b in db.EmployeeEFs
                         select b;
            return result;
        }

        public int UpdateEmployeeEF(EmployeeEF employeeEF)
        {
            int res = 0;
            var result = db.EmployeeEFs.Where(x => x.Id == employeeEF.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = employeeEF.Name; // book contains new data, result contains old data
                result.Dept = employeeEF.Dept;
                result.Salary = employeeEF.Salary;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
