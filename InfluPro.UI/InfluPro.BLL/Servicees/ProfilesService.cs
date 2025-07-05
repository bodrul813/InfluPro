

using InfluPro.BLL.Data;
using InfluPro.DAL.Entities;
using InfluPro.DAL.Interfaces;

namespace InfluPro.BLL.Servicees
{
    public class ProfilesService : IProfiles
    {
        private readonly AppDbContext _context;

        public ProfilesService(AppDbContext context)
        {
            _context = context;
        }

        // Add
        public void Add(Profiles profiles)
        {
            _context.Profiles.Add(profiles);
            _context.SaveChanges();
        }

        // Delete by ID and Profiles
        public void Delete(int id, Profiles profiles)
        {
            var existingProfile = _context.Profiles.FirstOrDefault(p => p.Id == id);
            if (existingProfile != null)
            {
                _context.Profiles.Remove(existingProfile);
                _context.SaveChanges();
            }
        }

        //GetById
        public Profiles GetById(int id)
        {
            return _context.Profiles.FirstOrDefault(p => p.Id == id);
        }

        // List
        public List<Profiles> GetList()
        {
            return _context.Profiles.ToList();
        }

        // Update
        public void Update(int id, Profiles profiles)
        {
            var existingProfile = _context.Profiles.FirstOrDefault(p => p.Id == id);
            if (existingProfile != null)
            {
                _context.Entry(existingProfile).CurrentValues.SetValues(profiles);
                _context.SaveChanges();
            }
        }
    }
}
