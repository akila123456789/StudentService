using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface ITeacherService
    {
        public List<Teacher> GetAllTeacher();
        public Teacher GetById(int id);
        public Teacher GetByName(string name);
        public Teacher GetBysalary(decimal? salary);
        public Teacher CompareTeacherBySalary(Teacher teacherByName, Teacher teacherBySalary);
    }
}
