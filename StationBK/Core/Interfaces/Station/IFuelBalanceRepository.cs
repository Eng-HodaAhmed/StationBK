using StationBK.Core.Entities.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IFuelBalanceRepository
    {
        public Task<IEnumerable<FuelBalance>> GetFuelBalance(string date);
        public Task AddFuelBalance(List<FuelBalance> fuelData);
        public Task<IEnumerable<FuelBalance>> GetTotalFuel(int month,int year, string name);
    }
}
