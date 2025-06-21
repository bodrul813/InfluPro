
using InfluPro.DAL.Enumarations;
using System.ComponentModel.DataAnnotations;

namespace InfluPro.DAL.Entities
{
    public class Profile : BaseEntity
    {

        [Required]
        [MaxLength(350)]
        public string G_Id { get; set; }

        public int? ProfileTypeId { get; set; }

        [Required]
        [MaxLength(450)]
        public string UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProfileUrl { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(265)]
        public string Profile_Picture { get; set; }

        [Required]
        public int FollowerCount { get; set; }

        [Required]
        public int FollowingCount { get; set; }

    }
}
