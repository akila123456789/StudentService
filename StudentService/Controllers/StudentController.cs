using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Entites;
using StudentService.Interfaces;
using StudentService.Services;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult <List<Students>> GetAllStudetss()
        {
            var students = _studentService.GetAllStudets();
            return Ok(students);
        }

        [HttpGet("Id")]
        public ActionResult<Students> GetById (int id)
        {
            var student = _studentService.GetById(id);
            return Ok(student);
        }

        [HttpGet("filter")]
        public ActionResult<Students> Filter(string? name, string? city)
        {
            if (name == null && city != null)
            {
                return _studentService.GetByCity(city);

            }
            else if (city == null && name != null)
            {
                return _studentService.GetByCity(city);
            }
            else if (name != null && city != null)
            {
                var studentsByName = _studentService.GetByName(name);
                var studentsByCity = _studentService.GetByCity(city);
                return _studentService.CompareStudentsByCity(studentsByName, studentsByCity);

            }
            else
            {
                return new Students();
            }
        }


        [HttpPost]

        public ActionResult<List<Students>> CreateStudent()
        {
            throw new NotImplementedException();
        }

        [HttpPut]

        public ActionResult<List<Students>> UpdateStudent()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<List<Students>> DeleteStudent()
        {
            throw new NotImplementedException();
        }






    }
}
