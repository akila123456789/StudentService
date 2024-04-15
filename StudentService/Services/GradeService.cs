using StudentService.Entites;
using StudentService.Interfaces;

namespace StudentService.Services
{
    public class GradeServise : IGradeService
    {
        private readonly IStaticDataStore _staticDataStore;

        public GradeServise(IStaticDataStore staticDataStore)
        {

            _staticDataStore = staticDataStore;
        }

        public Grade CompareGradeByCount(Grade gradeByname, Grade gradeBycount)
        {
            if (gradeByname?.GradeId == gradeBycount?.GradeId)
            {
                return gradeBycount;
            }
            else
            {
                return new Grade();
            }
        }

        public List<Grade> GetAllGrade()
        {
            return _staticDataStore.Grades;
        }

        public Grade GetByCount(int? count)
        {
            return _staticDataStore.Grades.Where(x => x.StudentCount == count ).FirstOrDefault();
        }

        public Grade GetByGId(int id)
        {
            return _staticDataStore.Grades.Where(x => x.GradeId == id).FirstOrDefault();
        }

        public Grade GetByName(string name)
        {
            return _staticDataStore.Grades.Where(x => x.GradeName == name).FirstOrDefault();
        }
    }
}
