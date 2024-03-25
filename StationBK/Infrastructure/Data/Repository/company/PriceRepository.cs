using StationBK.Core.Entities.company;
using StationBK.Core.Interfaces.Company;


namespace StationBK.Infrastructure.Data.Repository.company
{
    public class PriceRepository : IPriceRepository
    {
        private readonly AppDbContext _context;

        public PriceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddPrice(Price price)
        {
            await _context.Prices.AddAsync(price);
            await _context.SaveChangesAsync();
        }

        public async Task<Price> GetLastPrice()
        {
            var lastPrice = _context.Prices.OrderByDescending(p => p.date).FirstOrDefault();
            return lastPrice;
        }
    }
}
