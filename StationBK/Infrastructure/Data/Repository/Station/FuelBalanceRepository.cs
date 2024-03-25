using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models.Station;
using System.Globalization;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    public class FuelBalanceRepository : IFuelBalanceRepository
    {
        private readonly AppDbContext _context;

        public FuelBalanceRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task AddFuelBalance(List<FuelBalance> fuelData)
        {
            this._context.FuelBalances.AddRange(fuelData);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FuelBalance>> GetFuelBalance(string date)
        {
            var fuelsBalance = await this._context.FuelBalances.Where(rec => rec.Date == date).ToListAsync();
            return fuelsBalance;
        }

        public async Task<IEnumerable<FuelBalance>> GetTotalFuel(int month,int year, string name)
        {
                 var fuels = await this._context.FuelBalances
                .ToListAsync(); // Fetching all records from the database

                var filteredFules = fuels
                    .Where(rec =>
                    {
                        int recMonth = int.Parse(rec.Date.Substring(3, 2)); // Parsing the month
                        int recYear = int.Parse(rec.Date.Substring(6)); // Parsing the year

                        return recMonth == month && recYear == year && rec.FuelName == name;
                    })
                    .ToList(); // Filtering in memory

                return filteredFules;
            }
        }

       
    }

