using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService service;

        public StudentController(IStudentService service)
        {
            this.service = service;
        }


   
        
        //get:api/book
        [HttpGet]
        [Route("GetStudents")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetStudents();
                return new ObjectResult(model);
            }
            catch
            {
                return StatusCode(StatusCodes.Status204NoContent);

            }
        }

        // GET api/book/getbookbyid/5
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetStudentById(id);
                if (model != null)
                    return new ObjectResult(model);
                else
                    return StatusCode(StatusCodes.Status500InternalServerError);

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        // POST api/<Book/Addbook
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                int result = service.AddStudent(student);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }





        // PUT api/<BookController>/update boook
        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult Put([FromBody] Student student)
        {
            try
            {
                int result = service.UpdateStudent(student);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // DELETE api/<BookController>/5
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteStudent(id);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }



    }
}
