using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Station
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyShiftController : ControllerBase
    {
        private readonly IDailyShiftRepository _dailyShift;
        private object response = new response("success");

        public DailyShiftController(IDailyShiftRepository dailyShift)
        {
            this._dailyShift = dailyShift;
        }
        [HttpGet("{date}")]
        public async Task<ActionResult<IEnumerable<DailyShift>>> Get(string date)
        {
            try
            {
                var data = await this._dailyShift.GetShift(date);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddFuelBalances([FromBody] List<DailyShift> data)
        {
            await this._dailyShift.AddShift(data);
            return Ok(response);
        }
    }
}
