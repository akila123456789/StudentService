using StudentService.Entites;
using StudentService.Interfaces;

namespace StudentService.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IStaticDataStore _staticDataStore;

        public BuildingService(IStaticDataStore staticDataStore)
        {

            _staticDataStore = staticDataStore;
        }

        public List<Building> GetAllBuilding()
        {
            return _staticDataStore.Buildings;
        }

        public Building CompareBuildingByFloor(Building buildingByname, Building buildingByfloor)
        {
            if (buildingByname?.BuildingId == buildingByfloor?.BuildingId)
            {
                return buildingByfloor;
            }
            else
            {
                return new Building();
            }
        }

        public Building GetById(int id)
        {
            return _staticDataStore.Buildings.Where(x => x.BuildingId == id).FirstOrDefault();
        }


        public Building GetByName(string name)
        {
            return _staticDataStore.Buildings.Where(x => x.BuildingName == name).FirstOrDefault();
        }

        public Building GetByFloor(int? floor)
        {
            return _staticDataStore.Buildings.Where(x => x.BuildingFloorNumber == floor).FirstOrDefault();
        }



        //public List<Building> buildings;

        //public BuildingService()
        //{
        //    buildings = new List<Building>();
        //    buildings.AddRange(GetAllBuilding());

        //}

        //public List<Building> GetAllBuilding()
        //{
        //    List<Building> buildings = new List<Building>();
        //    Building building = new Building();
        //    building.BuildingId = 1;
        //    building.BuildingName = "A";

        //    buildings.Add(building);

        //    Building buildingB = new Building()
        //    {
        //        BuildingId = 2,
        //        BuildingName = "B"
        //    };
        //    buildings.Add(buildingB);


        //    Building buildingC = new Building()
        //    {
        //        BuildingId = 3,
        //        BuildingName = "C"
        //    };

        //    buildings.Add(buildingC);

        //    return buildings;


        //}


    }
}
