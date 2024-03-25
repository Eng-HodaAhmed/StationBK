using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Interfaces.Station;
using static System.Runtime.InteropServices.JavaScript.JSType;
using StationBK.Infrastructure.Data.Repository.Station;
using StationBK.Core.Entities.Station;
using StationBK.Core.Models;
using StationBK.Core.Models.Station;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Station
{
    [Route("api/[controller]")]
    [ApiController]
    public class OilController : ControllerBase
    {
        private readonly IOilRepository _oilRepository;
        private object response = new response("success");

        public OilController(IOilRepository oilRepository)
        {
            this._oilRepository = oilRepository;
        }
        // GET: api/<OilController>
        [HttpGet("{date}")]
        public async Task<ActionResult<IEnumerable<Oil>>> Get(string date)
        {
            try
            {
                var oils = await _oilRepository.GetOil(date);
                return Ok(oils);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        

        // POST api/<OilController>
        [HttpPost]
        public async Task<ActionResult> AddOils([FromBody] List<Oil> OilData)
        {
            await _oilRepository.AddOil(OilData);
            return Ok(response);
        }

        [HttpPost]
        [Route("getTotal")]
        public async Task<ActionResult<IEnumerable<Oil>>> GetTotalData([FromBody] TotalDataRequestModel request)
        {
            try
            {
                var fuels = await _oilRepository.GetTotalOil(request);
                return Ok(fuels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


    }
}
