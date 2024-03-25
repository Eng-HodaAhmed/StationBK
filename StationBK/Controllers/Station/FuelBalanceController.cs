using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models;
using StationBK.Core.Models.Station;
using StationBK.Infrastructure.Data.Repository.Station;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Station
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelBalanceController : ControllerBase
    {
        private readonly IFuelBalanceRepository _fuelBalanceRepository;
        private object response = new response("success");

        public FuelBalanceController(IFuelBalanceRepository fuelBalanceRepository)
        {
            this._fuelBalanceRepository = fuelBalanceRepository;
        }
        // GET: api/<FuelBalanceController>
        [HttpGet("{date}")]
        public async Task<ActionResult<IEnumerable<FuelBalance>>> Get(string date)
        {
            try
            {
                var fuels = await this._fuelBalanceRepository.GetFuelBalance(date);
                return Ok(fuels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddFuelBalances([FromBody] List<FuelBalance> fuelData)
        {
            await this._fuelBalanceRepository.AddFuelBalance(fuelData);
            return Ok(response);
        }
        [HttpPost]
        [Route("getTotal")]
        public async Task<ActionResult<IEnumerable<FuelBalance>>> GetTotalData(TotalDataRequestModel request)
        {
            try
            {
                var fuels = await _fuelBalanceRepository.GetTotalFuel(request.month, request.year, request.name);
                return Ok(fuels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
