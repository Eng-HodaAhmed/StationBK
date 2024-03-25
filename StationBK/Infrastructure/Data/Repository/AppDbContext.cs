using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.company;
using StationBK.Core.Entities.Station;


namespace StationBK.Infrastructure.Data.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<Purchace> Purchaces { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Balance> Balances { get; set; }

        public DbSet<DailyShift> DailyShifts { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Fuel> Fules { get; set; }
        public DbSet<FuelBalance> FuelBalances { get; set; }
        public DbSet<Oil> Oils { get; set; }
        public DbSet<OilPrice> OilPrices { get; set; }
        public DbSet<MonthlyBalance> MonthlyBalances { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
