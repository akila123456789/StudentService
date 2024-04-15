using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetAllStudets();

        public Student GetById(int id);
        public Student GetByName(string name);
        public Student GetByCity(string city);
        public Student CompareStudentsByCity(Student studentsByName, Student studentsByCity);

    }
}
