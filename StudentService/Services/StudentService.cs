using StudentService.Entites;
using StudentService.Interfaces;

namespace StudentService.Services
{
    public class StudentServices : IStudentService
    {
        private readonly IStaticDataStore _staticDataStore;

        public StudentServices(IStaticDataStore staticDataStore)
        {
      
            _staticDataStore = staticDataStore;
        }
        public List<Students> GetAllStudets()
        {
            return _staticDataStore.Students;
        }

        public Students CompareStudentsByCity(Students studentsByname, Students studentsByCity)
        {
            if (studentsByname?.StudentId == studentsByCity?.StudentId)
            {
                return studentsByCity;
            }
            else
            {
                return new Students();
            }
        }



        public Students GetById(int id)
        {
            return _staticDataStore.Students.Where(x => x.StudentId == id).FirstOrDefault();

        }

        public Students GetByName(string name)
        {
            return _staticDataStore.Students.Where(x => x.StudentName == name).FirstOrDefault();
        }

        public Students GetByCity(string city)
        {
            return _staticDataStore.Students.Where(x => x.StudentCity == city).FirstOrDefault();
        }
    }
}
