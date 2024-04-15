//using StudentService.Entites;
//using StudentService.Interfaces;

//namespace StudentService.Services
//{
//    public class StudentServices : IStudentService
//    {
//        private readonly IStaticDataStore _staticDataStore;

//        public StudentServices(IStaticDataStore staticDataStore)
//        {
      
//            _staticDataStore = staticDataStore;
//        }
//        public List<Student> GetAllStudets()
//        {
//            return _staticDataStore.Students;
//        }

//        public Student CompareStudentsByCity(Student studentsByname, Student studentsByCity)
//        {
//            if (studentsByname?.StudentId == studentsByCity?.StudentId)
//            {
//                return studentsByCity;
//            }
//            else
//            {
//                return new Student();
//            }
//        }



//        public Student GetById(int id)
//        {
//            return _staticDataStore.Students.Where(x => x.StudentId == id).FirstOrDefault();

//        }

//        public Student GetByName(string name)
//        {
//            return _staticDataStore.Students.Where(x => x.StudentName == name).FirstOrDefault();
//        }

//        public Student GetByCity(string city)
//        {
//            return _staticDataStore.Students.Where(x => x.StudentCity == city).FirstOrDefault();
//        }
//    }
//}
