using InfluPro.API.Models;
using InfluPro.DAL.Entities;
using InfluPro.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace InfluPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationControler : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfile _profile;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthenticationControler(UserManager<ApplicationUser> userManager, IProfile profile, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _profile = profile;
            _roleManager = roleManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model, ApplicationUser user) // Fixed parameter type and name
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.EmailAddress,
                    Email = model.EmailAddress
                };

                var result = await _userManager.CreateAsync(user, model.Password); // Fixed missing await and corrected type usage
                if (result.Succeeded)
                {
                    var profile = new Profile
                    {
                        UserId = user.Id,
                        G_Id = Guid.NewGuid().ToString(),
                        Name = model.Name,
                        ProfileUrl = model.ProfileUrl,
                        ProfileTypeId = 1, // Assuming a default profile type ID
                    };

                    _profile.Add(profile);

                    var roleResult = await _roleManager.AddClaimAsync(User, new Claim("role", "User"));
                    if (!roleResult.Succeeded)
                    {
                        _profile.Delete(profile.Id);
                        await _userManager.DeleteAsync(user);
                        return BadRequest(roleResult.Errors);
                    }
                    var response = new RegisterResponeModel
                    {
                        Name = profile.Name,
                        UserId = user.Id,
                        ProfileId = profile.G_Id,
                        ProfileUrl = profile.ProfileUrl,
                        EmailAddress = user.Email,
                        PhoneNumber = model.PhoneNumber,
                        Status = profile.Status,
                    };
                    return Ok(response);
                }
                else
                {
                    return BadRequest(result.Errors);
                }
            }

            return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
