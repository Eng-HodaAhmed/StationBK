using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models;
using StationBK.Core.Models.Station;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Station
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelRepository _fuelRepository;
        private object response = new response("success");

        public FuelController(IFuelRepository fuelRepository)
        {
            _fuelRepository = fuelRepository;
        }
        // GET: api/<FuelController>
        [HttpGet("{date}")]
        public async Task<ActionResult<IEnumerable<Fuel>>> Get(string date)
        {
            try
            {
                var fuels = await _fuelRepository.GetFuel(date);
                return Ok(fuels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost]
        [Route("getTotal")]
        public async Task<ActionResult<IEnumerable<Fuel>>> GetTotalData( [FromBody] TotalDataRequestModel request)
        {
            try
            {
                var fuels = await _fuelRepository.GetTotalFuel(request);
                return Ok(fuels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }



        // POST api/<FuelController>
        [HttpPost]
        public async Task<ActionResult> AddFuels([FromBody] List<Fuel> fuelData)
        {
            await _fuelRepository.Addfuel(fuelData);
            
            return Ok(response);
        }


    }
}
