using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.company;
using StationBK.Core.Interfaces.Company;

namespace StationBK.Infrastructure.Data.Repository.company
{
    public class BalanceRepository : IBalanceRepository
    {
        private readonly AppDbContext _context;

        public BalanceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddBalance(Balance balance)
        {
            await _context.Balances.AddAsync(balance);
            await _context.SaveChangesAsync();
        }

        public async Task<float> GetBalance(int month)
        {
            var balanceRecord = await _context.Balances.FirstOrDefaultAsync(ele => ele.month == month);
            if (balanceRecord == null)
                return 0;
            return balanceRecord!.balance;
        }
    }
}
