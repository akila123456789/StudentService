using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Entites;
using StudentService.Interfaces;
using StudentService.Services;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public ActionResult<List<Teacher>> GetAllTeacher()
        {
            var teachers = _teacherService.GetAllTeacher();
            return Ok(teachers);
        }

        [HttpGet("Id")]
        public ActionResult<Teacher> GetById(int id)
        {
            var teacher = _teacherService.GetById(id);
            return Ok(teacher);
        }

        [HttpGet("Filter")]
        public ActionResult<Teacher> Filter(string? name , decimal? salary)
        {
            if (name == null && salary != null)
            {
                return _teacherService.GetBysalary(salary);

            }
            else if(salary == null && name != null)
            {
                return _teacherService.GetByName(name);
            }
            else if (name != null  && salary!= null)
            {
                var teacherByName = _teacherService.GetByName(name);
                var teacherBySalary = _teacherService.GetBysalary(salary);
                return _teacherService.CompareTeacherBySalary(teacherByName, teacherBySalary);
                
            }
            else
            {
                return new Teacher();
            }
        }

        [HttpPost]

        public ActionResult<List<Teacher>> CreateTeacher()
        {
            throw new NotImplementedException();
        }

        [HttpPut]

        public ActionResult<List<Teacher>> UpdateTeacher()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<List<Teacher>> DeleteTeacher()
        {
            throw new NotImplementedException();
        }



    }
}
