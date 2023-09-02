using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Implementations;
using BusInt.TestApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusInt.TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly IPaisRepository _paisRepository;
        public PaisController()
        {
            var context = new AppDbContext();
            _paisRepository = new PaisRepository(context);
        }

        [HttpGet("Paises")]
        public async Task<IActionResult> GetPaises()
        {
            try
            {
                var result = await _paisRepository.GetAll();
                return Ok(result);
            }
            catch (ApplicationException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPaises([FromQuery] string cod)
        {
            try
            {
                var result = await _paisRepository.GetByCodeAsync(cod);
                return Ok(result);
            }
            catch (ApplicationException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] Pais pais)
        {
            try
            {
                var result = await _paisRepository.Save(pais);
                return Ok(result);
            }
            catch (ApplicationException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
