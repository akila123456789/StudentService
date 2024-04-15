using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface IStaticDataStore
    {
        public List<Student> Students { get;}

        public List<Grade> Grades { get;}

        public List<Building> Buildings { get;}
        public List<Teacher> Teachers { get;}

        public List<Lab> Labs { get;}
    }
}
