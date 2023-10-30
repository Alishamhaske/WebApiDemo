using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        int IStudentRepository.AddStudent(Student student)
        {
            // added the student object in the DBSet
            db.Students.Add(student);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        int IStudentRepository.DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Students.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        Student IStudentRepository.GetStudentById(int id)
        {
            var result = db.Students.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        IEnumerable<Student> IStudentRepository.GetStudents()
        {
            var result = from b in db.Students
                         select b;
            return result;
        }

        int IStudentRepository.UpdateStudent(Student student)
        {
            int res = 0;
            // find the record from Dbset that we need to modify
            //var result = (from b in db.Books
            //             where b.Id == book.Id
            //             select b).FirstOrDefault();

            var result = db.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = student.Name; // book contains new data, result contains old data
                result.Percentage = student.Percentage;
                result.City = student.City; ;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }



    }
}
