using InfluPro.BLL.Data;
using InfluPro.DAL.Entities;
using InfluPro.DAL.Interfaces;

namespace InfluPro.BLL.Services
{
    public class ProfileTypesService : IProfileTypes
    {
        private readonly AppDbContext _context;
        public ProfileTypesService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(ProfileTypes profileType)
        {
            _context.ProfileTypes.Add(profileType);
            _context.SaveChanges();
        }

        public void Delete(int id, ProfileTypes profileType)
        {
            var existingProfileType = _context.ProfileTypes.FirstOrDefault(p => p.Id == id);
            if (existingProfileType != null)
            {
                _context.ProfileTypes.Remove(existingProfileType);
                _context.SaveChanges();
            }
        }

        public ProfileTypes GetById(int id)
        {
            //var profile = _context.ProfileTypes.FirstOrDefault(p => p.Id == id);
            return _context.ProfileTypes.FirstOrDefault(p => p.Id == id);
        }

        public List<ProfileTypes> Getlist()
        {
            //var profileTypes = _context.ProfileTypes.FirstOrDefault(p => p.Id == id);
            return _context.ProfileTypes.ToList();
        }

        public void Update( int id, ProfileTypes profileType)
        {
            var existingProfileType = _context.ProfileTypes.FirstOrDefault(p => p.Id == id);
            if (existingProfileType != null)
            {
                _context.Entry(existingProfileType).CurrentValues.SetValues(profileType);
                _context.SaveChanges();
            }
        }
    }
}
