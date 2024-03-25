using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Entities.company;
using StationBK.Core.Interfaces.Company;
using StationBK.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPriceRepository _priceRepo;
        private readonly IMapper _mapper;

        public PriceController(IPriceRepository priceRepo, IMapper mapper)
        {
            _priceRepo = priceRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<PriceModel> Get()
        {
            var Price = await _priceRepo.GetLastPrice();
            var priceModel = _mapper.Map<PriceModel>(Price);
            return priceModel;

        }



        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddPrice([FromBody] PriceModel priceModel)
        {
            try
            {
                var price = _mapper.Map<Price>(priceModel);
                await _priceRepo.AddPrice(price);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error,{ex}");
            }
        }



    }
}
