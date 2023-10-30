using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Dbcontextoption is used to override configuration --connection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<EmployeeEF> EmployeeEFs { get; set; }
 

        public static implicit operator ApplicationBuilder(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }

    }
}
