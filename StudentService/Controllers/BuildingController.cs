using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Entites;
using StudentService.Interfaces;
using StudentService.Services;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _buildingService;

        public BuildingController(IBuildingService buildingService)
        {
            _buildingService = buildingService;

        }

        [HttpGet]
        public ActionResult<List<Building>> GetAllBuilding()
        {
            var buildings = _buildingService.GetAllBuilding();

            return Ok(buildings);
        }

        [HttpGet("{Id}")]
        public ActionResult<List<Building>> GetById(int Id)
        {
            var buildings = _buildingService.GetById(Id);
            return Ok(buildings);
        }

        [HttpGet("filter")]
        public ActionResult<Building> Filter(string? name, int? floor)
        {
            if (name == null && floor != null)
            {
                return _buildingService.GetByFloor(floor);

            }
            else if (floor == null && name != null)
            {
                return _buildingService.GetByFloor(floor);
            }
            else if (name != null && floor != null)
            {
                var buildingByName = _buildingService.GetByName(name);
                var buildingByFloor = _buildingService.GetByFloor(floor);
                return _buildingService.CompareBuildingByFloor(buildingByName, buildingByFloor);

            }
            else
            {
                return new Building();
            }
        }


        [HttpPost]

        public ActionResult<List<Building>> CreateBuilding()
        {
            throw new NotImplementedException();
        }

        [HttpPut]

        public ActionResult<List<Building>> UpdateBuilding()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<List<Building>> DeleteBuilding()
        {
            throw new NotImplementedException();
        }







    }
}
