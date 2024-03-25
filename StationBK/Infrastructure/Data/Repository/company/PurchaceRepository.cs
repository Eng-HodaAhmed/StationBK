using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.company;
using StationBK.Core.Interfaces.Company;

namespace StationBK.Infrastructure.Data.Repository.company
{
    public class PurchaceRepository : IPurchaceRepository
    {
        private readonly AppDbContext _context;

        public PurchaceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddPurchace(Purchace purchace)
        {
            await _context.Purchaces.AddAsync(purchace);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Purchace>> GetPurchace()
        {
            return await _context.Purchaces.ToListAsync();
        }
    }
}
