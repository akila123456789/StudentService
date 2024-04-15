using Microsoft.AspNetCore.Mvc;
using StudentService.Entites;
using StudentService.Interfaces;
using StudentService.Services;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;

        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;

        }

        [HttpGet]
        public ActionResult<List<Grade>> GetAllGrade()
        {
            var grades = _gradeService.GetAllGrade();

            return Ok(grades);
        }

        [HttpGet("{Id}")]
        public ActionResult<List<Grade>> GetByGId(int Id)
        {
            var grades = _gradeService.GetByGId(Id);
            return Ok(grades);
        }

        [HttpGet("filter")]
        public ActionResult<Grade> Filter(string? name, int? count)
        {
            if (name == null && count != null)
            {
                return _gradeService.GetByCount(count);

            }
            else if (count == null && name != null)
            {
                return _gradeService.GetByCount(count);
            }
            else if (name != null && count != null)
            {
                var gradeByname = _gradeService.GetByName(name);
                var gradeBycount = _gradeService.GetByCount(count);
                return _gradeService.CompareGradeByCount(gradeByname, gradeBycount);

            }
            else
            {
                return new Grade();
            }
        }


        [HttpPost]

        public ActionResult<List<Grade>> CreateGrade()
        {
            throw new NotImplementedException();
        }

        [HttpPut]

        public ActionResult<List<Grade>> UpdateGrade()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<List<Grade>> DeleteGrade()
        {
            throw new NotImplementedException();
        }


    }
}
