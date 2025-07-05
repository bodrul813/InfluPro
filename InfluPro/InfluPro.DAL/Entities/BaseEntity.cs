
using InfluPro.DAL.Enumerations;

namespace InfluPro.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime UpdatedAt { get; set; }= DateTime.UtcNow;
        public Status Status { get; set; }
    }
}
