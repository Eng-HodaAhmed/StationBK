using StationBK.Core.Entities.company;


namespace StationBK.Core.Interfaces.Company
{
    public interface IPriceRepository
    {
        public Task AddPrice(Price price);
        public Task<Price> GetLastPrice();
    }
}
