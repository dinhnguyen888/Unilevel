using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorController : ControllerBase
    {
        private readonly DistributorService _distributorService;

        public DistributorController(DistributorService distributorService)
        {
            _distributorService = distributorService;
        }

        [HttpPost]
        public async Task<IActionResult> AddDistributor(DistributorDTO distributorDto)
        {
            try
            {
                await _distributorService.AddDistributorAsync(distributorDto);
                return Ok("Distributor added successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDistributor(string id, DistributorDTO distributorDto)
        {
            try
            {
                await _distributorService.UpdateDistributorAsync(id, distributorDto);
                return Ok("Distributor updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistributor(string id)
        {
            try
            {
                await _distributorService.DeleteDistributorAsync(id);
                return Ok("Distributor deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
