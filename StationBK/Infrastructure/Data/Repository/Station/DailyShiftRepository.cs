using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models.Station;
using System.Globalization;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    public class DailyShiftRepository : IDailyShiftRepository
    {
        private readonly AppDbContext _context;

        public DailyShiftRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task AddShift(List<DailyShift> data)
        {
            this._context.DailyShifts.AddRange(data);
            await this._context.SaveChangesAsync();
        }

        public async Task<DailyShift> GetShift(string date)
        {
            var shift = await this._context.DailyShifts.FirstOrDefaultAsync(rec => rec.Date == date);
            return shift;
        }

        public async Task<TotalDailyShiftModel> GetTotal(int month,int year)
        {
            float depositeMoney = await _context.DailyShifts
            .Where(rec => DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Month == month
            && DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year)
            .SumAsync(d => d.deposit);



            float cashMoney = await _context.DailyShifts
            .Where(rec => DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Month == month
            && DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year)
            .SumAsync(d => d.CashMoney);


            float creditMoney = await _context.DailyShifts
            .Where(rec => DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Month == month
            && DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year)
            .SumAsync(d => d.CrediteMoney);

            float expenses = await _context.DailyShifts
            .Where(rec => DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Month == month
            && DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year)
            .SumAsync(d => d.ExpensesMony);

            float washingMoney = await _context.DailyShifts
            .Where(rec => DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Month == month
            && DateTime.ParseExact(rec.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year == year)
            .SumAsync(d => d.Washing);

           var total = new TotalDailyShiftModel(cashMoney, creditMoney, expenses, washingMoney, depositeMoney);

            return total;
        }
    }
}
