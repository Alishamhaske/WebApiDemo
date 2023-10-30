using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class StudentService : IStudentService
    {


        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        int IStudentService.AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        int IStudentService.DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        Student IStudentService.GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        IEnumerable<Student> IStudentService.GetStudents()
        {
            return repo.GetStudents();
        }

        int IStudentService.UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}
