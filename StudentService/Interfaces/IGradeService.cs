using StudentService.Entites;

namespace StudentService.Interfaces
{
    public interface IGradeService
    {
        public List<Grade> GetAllGrade();

        public Grade GetByGId(int id);
        public Grade GetByName(string name);
        public Grade GetByCount(int? count);
        public Grade CompareGradeByCount(Grade gradeByname, Grade gradeBycount);


    }
}
