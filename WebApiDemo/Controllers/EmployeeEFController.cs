using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEFController : ControllerBase
    {

        private readonly IEmployeeEFService service;

        public EmployeeEFController(IEmployeeEFService service)
        {
            this.service = service;
        }

        // GET: api/<BookController/getbooks
        [HttpGet]
        [Route("GetEmployeeEFs")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetEmployeeEFs();
                return new ObjectResult(model);
            }
            catch
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }


        /// delete

        // GET api/book/getbookbyid
        [HttpGet]
        [Route("Get EmployeeEFById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetEmployeeEFById(id);
                if (model != null)
                    return new ObjectResult(model);
                else
                    return new ObjectResult(model);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



        // POST api/<Book/Addbook
        [HttpPost]
        [Route("AddEmployeeEF")]
        public IActionResult Post([FromBody] EmployeeEF employeeEF)
        {
            try
            {
                int result = service.AddEmployeeEF(employeeEF);
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




        //update
        [HttpPut]
        [Route("UpdateEmployeeEF")]
        public IActionResult Put([FromBody] EmployeeEF employeeEF)
        {
            try
            {
                int result = service.UpdateEmployeeEF(employeeEF);
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





        // DELETE api/<EmployeeEFController>/5
        [HttpDelete]
        [Route("DeleteEmployeeEF/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteEmployeeEF(id);
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
