using StationBK.Core.Entities.Station;
using StationBK.Core.Models.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IDailyShiftRepository
    {
        public Task<DailyShift> GetShift(string date);
        public Task AddShift(List<DailyShift> data);
        public Task<TotalDailyShiftModel> GetTotal(int month,int year);
    }
}
