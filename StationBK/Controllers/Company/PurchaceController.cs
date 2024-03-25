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
    public class PurchaceController : ControllerBase
    {
        private readonly IPurchaceRepository _purchaceRepo;
        private readonly IMapper _mapper;

        public PurchaceController(IPurchaceRepository purchaceRepo, IMapper mapper)
        {
            _purchaceRepo = purchaceRepo;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<Purchace>> Get()
        {
            return await _purchaceRepo.GetPurchace();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddPurchace([FromBody] PurchaceModel purchaceModel)
        {
            var purchace = _mapper.Map<Purchace>(purchaceModel);
            try
            {
                await _purchaceRepo.AddPurchace(purchace);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error,{ex}");
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
