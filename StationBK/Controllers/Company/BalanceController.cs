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
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceRepository _balanceRepository;
        private readonly IMapper _mappe;

        public BalanceController(IBalanceRepository balanceRepository, IMapper mappe)
        {
            _balanceRepository = balanceRepository;
            _mappe = mappe;
        }
        // GET: api/<BalanceController>

        [HttpGet("{month}")]
        public async Task<float> Get(int month)
        {
            return await _balanceRepository.GetBalance(month);
        }



        // POST api/<BalanceController>
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddBalance(Balance balance)
        {
            //var balance = this._mappe.Map<Balance>(balanceModel);
            await _balanceRepository.AddBalance(balance);
            return Ok();
        }



    }
}
