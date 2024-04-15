using StudentService.Entites;
using StudentService.Interfaces;

namespace StudentService.Services
{
    public class LabService : ILabService
    {
        private readonly IStaticDataStore _staticDataStore;

        public LabService(IStaticDataStore staticDataStore)
        {

            _staticDataStore = staticDataStore;
        }
        public List<Lab> GetAllLab()
        {
            return _staticDataStore.Labs;

        }

        public Lab CompareLabBySubject(Lab labByname, Lab labBysubject)
        {
            if (labByname?.LabId == labBysubject?.LabId)
            {
                return labBysubject;
            }
            else
            {
                return new Lab();
            }
        }



        public Lab GetById(int id)
        {
            return _staticDataStore.Labs.Where(x => x.LabId == id).FirstOrDefault();
        }

        public Lab GetByName(string name)
        {
            return _staticDataStore.Labs.Where(x => x.LabName == name).FirstOrDefault();
        }


        public Lab GetBySubject(string subject)
        {
            return _staticDataStore.Labs.Where(x => x.LabSubject == subject).FirstOrDefault();
        }
    }
}
