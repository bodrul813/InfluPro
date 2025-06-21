
using InfluPro.DAL.Enumarations;
using System.ComponentModel.DataAnnotations;

namespace InfluPro.DAL.Entities
{
    public class Profile : BaseEntity
    {

        public string G_Id { get; set; }

        public int? ProfileTypeId { get; set; }

        public string UserId { get; set; }

        public string ProfileUrl { get; set; }

        public string Name { get; set; }

        public string Profile_Picture { get; set; }

        public int FollowerCount { get; set; }

        public int FollowingCount { get; set; }

    }
}
