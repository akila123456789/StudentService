using StudentService.Entites;
using StudentService.Interfaces;

namespace StudentService
{
    public class StaticDataStore : IStaticDataStore
    {
        public List<Student> Students => new List<Student>()
        {
            //new Student
            //{
            //    StudentId = 1,
            //    StudentName = "Akila"
                
            //},

            //new Student
            //{
            //    StudentId = 2,
            //    StudentName = "Akalanka"
            //},

            //new Student
            //{
            //    StudentId = 3,
            //    StudentName = "Pathum"
            //},
            //new Student
            //{
            //    StudentId = 4,
            //    StudentName = "Sandun"
            //},
        };

        public List<Grade> Grades => new List<Grade>()
        {
            new Grade
            {
                GradeId = 1,
                GradeName = "Grade1"
            },

            new Grade
            {
                GradeId = 2,
                GradeName = "Grade2"
            },
        };

        public List<Building> Buildings => new List<Building>()
        {
            new Building
            {
                BuildingId = 1,
                BuildingName = "A"
            },

            new Building
            {
                BuildingId = 2,
                BuildingName ="B"
            },

        };
        public List<Teacher> Teachers => new List<Teacher>()
        {
            new Teacher
            {
                TeacherId = 1,
                TeacherName = "Namali",
                TeacherSalary = 45000
               
            },

            new Teacher
            {
                TeacherId = 2,
                TeacherName ="Ishana",
                TeacherSalary = 50000
            },

        };
        public List<Lab> Labs => new List<Lab>()
        {
            new Lab
            {
                LabId = 1,
                LabName =  "Q"
            },
            new Lab
            {
                LabId = 2,
                LabName = "Z"
            },

        };
    }
}
