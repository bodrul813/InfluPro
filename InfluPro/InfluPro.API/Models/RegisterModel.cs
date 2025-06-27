using InfluPro.DAL.Enumarations;

namespace InfluPro.API.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileUrl { get; set; }

    }


    public class RegisterResponeModel
    {
        public string UserId { get; set; }
        public string ProfileId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileUrl { get; set; }
        public string RoleName { get; set; }
        public Status Status { get; set; }

    }
}
