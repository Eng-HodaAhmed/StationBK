using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using System.Globalization;
using System.Xml.Linq;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context;

        public ExpenseRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task AddExpense(List<Expense> expenseData)
        {
            this._context.Expenses.AddRange(expenseData);
            await this._context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Expense>> GetExpenses(int month,int year)
        {
            var expenses = await this._context.Expenses.Where(rec =>
            DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Month == month
            && DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year
            )
            .ToListAsync();
            return expenses;
        }
    }
}
