using BloodBank.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donations")]
    public class DonationsController : ControllerBase
    {

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]

        public IActionResult Post([FromBody] CreateDonationModel createDonationModel)
        {
            return NoContent();
        }
    }
}
