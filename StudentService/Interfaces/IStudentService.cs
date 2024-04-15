using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface IStudentService
    {
        public List<Students> GetAllStudets();

        public Students GetById(int id);
        public Students GetByName(string name);
        public Students GetByCity(string city);
        public Students CompareStudentsByCity(Students studentsByName, Students studentsByCity);

    }
}
