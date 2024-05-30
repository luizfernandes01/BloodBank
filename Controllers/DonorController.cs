using BloodBank.API.Models;
using BloodBank.Application.InputModel;
using BloodBank.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donors")]
    public class DonorController : ControllerBase

    {
        private readonly IDonorService _donorService;
        public DonorController(IDonorService donorService)
        {
            _donorService = donorService;
        } 
        

        [HttpGet]

        public IActionResult Get(string query)
        {
            var donors = _donorService.GetAll( query);
            return Ok(donors);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var donor = _donorService.GetById( id);

            if (donor == null)
            {
                return NotFound();
            }

            return Ok(donor);
        }

        [HttpPost]

        public IActionResult Post([FromBody] NewDonorInputModel inpuModel)
        {
            var id = _donorService.Create(inpuModel);

            return CreatedAtAction(nameof(GetById),new { id = id }, inpuModel);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody]UpdateDonorInputModel inputModel) 
        {
            _donorService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _donorService.Delete(id);

            return NoContent();
        }
    }
}
