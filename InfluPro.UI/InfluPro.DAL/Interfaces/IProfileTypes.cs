
using InfluPro.DAL.Entities;

namespace InfluPro.DAL.Interfaces
{
    public interface IProfileTypes
    {
        List<ProfileTypes> GetList();
        ProfileTypes GetById(int id);
        void Add(ProfileTypes profileTypes);
        void Delete(int id, ProfileTypes profileTypes);
        void Update(int id, ProfileTypes profileTypes);
    }
}
