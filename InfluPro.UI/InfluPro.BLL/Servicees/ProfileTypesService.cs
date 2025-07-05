
using InfluPro.BLL.Data;
using InfluPro.DAL.Entities;
using InfluPro.DAL.Interfaces;

namespace InfluPro.BLL.Servicees
{
    public class ProfileTypesService : IProfileTypes
    {
        private readonly AppDbContext _context;

        public ProfileTypesService(AppDbContext context)
        {
            _context = context;
        }

        // Add
        public void Add(ProfileTypes profiles)
        {
            _context.ProfilesTypes.Add(profiles);
            _context.SaveChanges();
        }

        // Delete by ID and ProfileTypes
        public void Delete(int id, ProfileTypes profiles)
        {
            var existingProfile = _context.ProfilesTypes.FirstOrDefault(p => p.Id == id);
            if (existingProfile != null)
            {
                _context.ProfilesTypes.Remove(existingProfile);
                _context.SaveChanges();
            }
        }

        // GetById
        public ProfileTypes GetById(int id)
        {
            return _context.ProfilesTypes.FirstOrDefault(p => p.Id == id);
        }

        // List
        public List<ProfileTypes> GetList()
        {
            return _context.ProfilesTypes.ToList(); // Corrected property name to 'ProfilesTypes'
        }

        // Update
        public void Update(int id, ProfileTypes profiles)
        {
            var existingProfile = _context.ProfilesTypes.FirstOrDefault(p => p.Id == id);
            if (existingProfile != null)
            {
                _context.Entry(existingProfile).CurrentValues.SetValues(profiles);
                _context.SaveChanges();
            }
        }
    }
}
