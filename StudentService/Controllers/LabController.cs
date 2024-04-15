using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Entites;
using StudentService.Interfaces;
using StudentService.Services;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabController : ControllerBase
    {
        private readonly ILabService _labService;

        public LabController(ILabService labService)
        {
            _labService = labService;

        }

        [HttpGet]
        public ActionResult<List<Lab>> GetAllLab()
        {
            var labs = _labService.GetAllLab();

            return Ok(labs);
        }

        [HttpGet("{Id}")]
        public ActionResult<List<Lab>> GetById(int Id)
        {
            var labs = _labService.GetById(Id);
            return Ok(labs);
        }

        [HttpGet("filter")]
        public ActionResult<Lab> Filter(string? name, string? subject)
        {
            if (name == null && subject != null)
            {
                return _labService.GetBySubject(subject);

            }
            else if (subject == null && name != null)
            {
                return _labService.GetBySubject(subject);
            }
            else if (name != null && subject != null)
            {
                var labByName = _labService.GetByName(name);
                var labBySubject = _labService.GetBySubject(subject);
                return _labService.CompareLabBySubject(labByName, labBySubject);

            }
            else
            {
                return new Lab();
            }
        }


        [HttpPost]

        public ActionResult<List<Lab>> CreateLab()
        {
            throw new NotImplementedException();
        }

        [HttpPut]

        public ActionResult<List<Lab>> UpdateLab()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<List<Lab>> DeleteLab()
        {
            throw new NotImplementedException();
        }


    }
}
