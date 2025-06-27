using InfluPro.DAL.Entities;
using InfluPro.DAL.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InfluPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileTypeControler : ControllerBase
    {
        private readonly IProfileTypes _profileTypes;
        private object _profileType;

        public ProfileTypeControler(IProfileTypes profileTypes)
        {
            _profileTypes = profileTypes;
        }

        // GET: api/<ProfileTypeControler>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_profileTypes.Getlist());
        }

        // GET api/<ProfileTypeControler>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProfileTypeControler>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfileTypeControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfileTypeControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
