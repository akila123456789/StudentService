using StudentService.Entites;
using StudentService.Interfaces;

namespace StudentService.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IStaticDataStore _staticDataStore;

        public TeacherService(IStaticDataStore staticDataStore)
        {

            _staticDataStore = staticDataStore;
        }

        public Teacher CompareTeacherBySalary(Teacher teacherByName, Teacher teacherBySalary)
        {
            if (teacherByName?.TeacherId == teacherBySalary?.TeacherId)
            {
                return teacherBySalary;
            }
            else
            {
                return new Teacher();
            }
        }

        public List<Teacher> GetAllTeacher()
        {
            return _staticDataStore.Teachers;
        }

        public Teacher GetById(int id)
        {
            return _staticDataStore.Teachers.Where(x => x.TeacherId == id).FirstOrDefault();
        }

        public Teacher GetByName(string name)
        {
            return _staticDataStore.Teachers.Where(x => x.TeacherName == name).FirstOrDefault();
        }


        public Teacher GetBysalary(decimal? salary)
        {
            return _staticDataStore.Teachers.Where(x => x.TeacherSalary == salary).FirstOrDefault();
        }
    }

    
}