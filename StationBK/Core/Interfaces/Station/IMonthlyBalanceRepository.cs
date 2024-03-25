using StationBK.Core.Entities.Station;
using StationBK.Core.Models.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IMonthlyBalanceRepository

    {
        public Task<IEnumerable<MonthlyBalance>> GetMonthlyBalance(int year);
        public Task AddMonthlyBalance(List<MonthlyBalance> data);


    }
}
