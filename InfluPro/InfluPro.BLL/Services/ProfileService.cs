
using InfluPro.BLL.Data;
using InfluPro.DAL.Entities;
using InfluPro.DAL.Interfaces;

namespace InfluPro.BLL.Services
{
    public class ProfileService : IProfile
    {
        // Database inject
        private readonly AppDbContext _context; 

        public ProfileService(AppDbContext context)
        {
            _context = context;
        }

        // Add a new profile
        public void Add(Profile profile)
        {
            _context.Profiles.Add(profile);
            _context.SaveChanges();
        }

        // Delete
        public void Delete(int id)
        {
            var existingProfile = _context.Profiles.FirstOrDefault(p => p.Id == id);
            if (existingProfile != null)
            {
                _context.Profiles.Remove(existingProfile);
                _context.SaveChanges();
            }
        }

        // Get a profile by ID
        public Profile GetById(int id)
        {
            //var profile = _context.Profiles.FirstOrDefault(p => p.Id == id);
            return _context.Profiles.FirstOrDefault(p => p.Id == id);
        }

        // Read (List)
        public List<Profile> Getlist()
        {
            //var profiles = _context.Profiles.ToList();
            return _context.Profiles.ToList();
        }

        // Update
        public void Update(int id, Profile profile)
        {
            var existingProfile = _context.Profiles.FirstOrDefault(p => p.Id == id);
            if (existingProfile != null)
            {
            _context.Entry(existingProfile).CurrentValues.SetValues(profile);  
                _context.SaveChanges();
            }
        }
    }

}
