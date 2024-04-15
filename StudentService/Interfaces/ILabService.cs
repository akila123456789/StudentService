using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface ILabService
    {
        public List<Lab> GetAllLab();

        public Lab GetById(int id);

        public Lab GetByName(string name);

        public Lab GetBySubject(string subject);
        public Lab CompareLabBySubject(Lab labByname , Lab labBySubject);

    }
}
