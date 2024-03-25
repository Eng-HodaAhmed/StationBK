using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Entities.company;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Company;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models;
using StationBK.Core.Models.Station;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Station
{
    [Route("api/[controller]")]
    [ApiController]
    public class OilPriceController : ControllerBase
    {
   
        private readonly IOilPriceRepository _oilPriceRepo;
        private readonly IMapper _mapper;

        public OilPriceController(IOilPriceRepository oilPriceRepo, IMapper mapper)
        { 
            this._oilPriceRepo = oilPriceRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<OilPriceModel> Get()
        {
            var Price = await _oilPriceRepo.GetLastPrice();
            var priceModel = _mapper.Map<OilPriceModel>(Price);
            return priceModel;

        }



        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddPrice([FromBody] OilPriceModel priceModel)
        {
            try
            {
                var price = _mapper.Map<OilPrice>(priceModel);
                await _oilPriceRepo.AddPrice(price);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error,{ex}");
            }
        }
    }
}
