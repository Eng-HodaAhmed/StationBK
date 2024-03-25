using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    public class MonthlyBalanceRepository:IMonthlyBalanceRepository
    {
        private readonly AppDbContext _context;

        public MonthlyBalanceRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task AddMonthlyBalance(List<MonthlyBalance> data)
        {
            this._context.MonthlyBalances.AddRange(data);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MonthlyBalance>> GetMonthlyBalance(int year)
        {
            var data = await this._context.MonthlyBalances.Where(rec=> DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year).ToListAsync();
            return data;
        }
    }
}
