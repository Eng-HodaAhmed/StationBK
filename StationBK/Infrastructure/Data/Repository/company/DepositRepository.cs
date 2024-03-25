using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.company;
using StationBK.Core.Interfaces.Company;

namespace StationBK.Infrastructure.Data.Repository.company
{

    public class DepositRepository : IDepositRepository
    {
        private readonly AppDbContext _context;
        public DepositRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddDeposit(Deposit deposit)
        {
            await _context.Deposits.AddAsync(deposit);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Deposit>> GetDeposit()
        {
            return await _context.Deposits.ToListAsync();
        }
    }
}
