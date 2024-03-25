using StationBK.Core.Entities.Station;
using StationBK.Core.Models.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IOilRepository
    {
        public Task<IEnumerable<Oil>> GetOil(string date);
        public Task<IEnumerable<Oil>> GetTotalOil(TotalDataRequestModel request);
        public Task AddOil(List<Oil> data);
    }
}
