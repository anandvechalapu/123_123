using Api.DTO;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailersController : ControllerBase
    {
        private readonly RetailersService _retailersService;

        public RetailersController(RetailersService retailersService)
        {
            _retailersService = retailersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRetailersAsync()
        {
            var result = await _retailersService.GetAllRetailersAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRetailerByIdAsync(int id)
        {
            var result = await _retailersService.GetRetailerByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRetailerAsync([FromBody]RetailerModel model)
        {
            var result = await _retailersService.CreateRetailerAsync(model);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRetailerAsync([FromBody]RetailerModel model)
        {
            var result = await _retailersService.UpdateRetailerAsync(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRetailerAsync(int id)
        {
            var result = await _retailersService.DeleteRetailerAsync(id);
            return Ok(result);
        }
    }
}