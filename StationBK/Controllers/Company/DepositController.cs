using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Entities.company;
using StationBK.Core.Interfaces.Company;
using StationBK.Core.Models;
using System.Drawing.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly IDepositRepository _depositRepository;
        private readonly IMapper _mapper;

        public DepositController(IDepositRepository depositRepository, IMapper mapper)
        {
            _depositRepository = depositRepository;
            _mapper = mapper;
        }
        // GET: api/<DepositController>
        [HttpGet]
        public async Task<IEnumerable<Deposit>> Get()
        {
            var deposits = await _depositRepository.GetDeposit();

            return deposits;
        }

        // POST api/<DepositController>
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddDeposits([FromBody] DepositModel depositModel)
        {
            var deposit = _mapper.Map<Deposit>(depositModel);
            await _depositRepository.AddDeposit(deposit);
            return Ok();
        }


    }
}
