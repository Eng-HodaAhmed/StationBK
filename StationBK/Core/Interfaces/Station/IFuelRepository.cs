using StationBK.Core.Entities.Station;
using StationBK.Core.Models.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IFuelRepository
    {
        public Task<IEnumerable<Fuel>> GetFuel(string date);
        public Task<IEnumerable<Fuel>> GetTotalFuel(TotalDataRequestModel request);
        public Task Addfuel(List<Fuel> fuelData);
    }
}
