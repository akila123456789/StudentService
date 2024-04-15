using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface IBuildingService
    {
        public List<Building> GetAllBuilding();

        public Building GetById(int id);

        public Building GetByName(string name);
        public Building GetByFloor(int? floor);
        public Building CompareBuildingByFloor(Building buildingByName, Building buildingByfloor);


    }
}
