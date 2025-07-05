
using InfluPro.DAL.Entities;

namespace InfluPro.DAL.Interfaces
{
    public interface IProfiles 
    {
        List<Profiles> GetList();
        Profiles GetById(int id);
        void Add(Profiles profiles);
        void Delete(int id, Profiles profiles);
        void Update(int id, Profiles profiles); 
    }
}
