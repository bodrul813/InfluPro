
using InfluPro.DAL.Entities;

namespace InfluPro.DAL.Interfaces
{

    //abstract type
    public interface IProfileTypes
    {
        List<ProfileTypes> Getlist();
        ProfileTypes GetById(int id);
        void Add(ProfileTypes profileType);
        void Update(int id, ProfileTypes profileType);
        void Delete(int id, ProfileTypes profileType);

    }
}
