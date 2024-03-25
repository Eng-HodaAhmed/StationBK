using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.company;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    public class OilPriceRepository:IOilPriceRepository
    {
        private readonly AppDbContext _context;

        public OilPriceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddPrice(OilPrice price)
        {
            await _context.OilPrices.AddAsync(price);
            await _context.SaveChangesAsync();
        }

        public async Task<OilPrice> GetLastPrice()
        {
            var lastPrice = _context.OilPrices.OrderByDescending(p => p.date).FirstOrDefault();
            return lastPrice;
        }
    }
}
