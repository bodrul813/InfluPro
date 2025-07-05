

namespace InfluPro.DAL.Entities
{
    public class Profiles : BaseEntity
    {

        public string G_Id { get; set; }

        public int? ProfileTypeId { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string ProfileUrl { get; set; }  // UNIQUE

        public string Email { get; set; }       // UNIQUE

        public string? Profile_Picture { get; set; }

        public int FollowerCount { get; set; } = 0;

        public int FollowingCount { get; set; } = 0;


    }
}
