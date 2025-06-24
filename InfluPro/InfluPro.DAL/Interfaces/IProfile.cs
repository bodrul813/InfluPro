
using InfluPro.DAL.Entities;

namespace InfluPro.DAL.Interfaces
{
    public interface IProfile
    {
        List<Profile> Getlist();
        Profile GetById(int id);
        void Add(Profile profile);
        void Update(int id, Profile profile);
        void Delete(int id);
    }
}
