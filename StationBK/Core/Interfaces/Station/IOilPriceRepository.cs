using StationBK.Core.Entities.company;
using StationBK.Core.Entities.Station;

namespace StationBK.Core.Interfaces.Station
{
    public interface IOilPriceRepository
    {
        public Task AddPrice(OilPrice price);
        public Task<OilPrice> GetLastPrice();
    }
}
