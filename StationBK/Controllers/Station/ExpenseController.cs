using Microsoft.AspNetCore.Mvc;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StationBK.Controllers.Station
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepository _expenseRepository;
        private object response = new response("success");

        public ExpenseController(IExpenseRepository expenseRepository)
        {
            this._expenseRepository = expenseRepository;
        }
        [HttpPost]
        public async Task<ActionResult> AddExpense([FromBody] List<Expense> data)
        {
            await this._expenseRepository.AddExpense(data);
            return Ok(response);
        }
    }
}
