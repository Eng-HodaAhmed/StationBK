using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models.Station;
using System.Globalization;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    
    public class FuelRepository : IFuelRepository
    {
        private readonly AppDbContext _context;

        public FuelRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task Addfuel(List<Fuel> fuelData)
        {
            this._context.Fules.AddRange(fuelData);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Fuel>> GetFuel(string date)
        {
            var fuels=await this._context.Fules.Where(rec => rec.Date == date).ToListAsync();
            return fuels;
        }

        public async Task<IEnumerable<Fuel>> GetTotalFuel(TotalDataRequestModel request)
        {
            var fuels = await this._context.Fules
            .ToListAsync(); // Fetching all records from the database

            var filteredFules = fuels
                .Where(rec =>
                {
                    int recMonth = int.Parse(rec.Date.Substring(3, 2)); // Parsing the month
                    int recYear = int.Parse(rec.Date.Substring(6)); // Parsing the year

                    return recMonth == request.month && recYear == request.year && rec.FuelName == request.name;
                })
                .ToList(); // Filtering in memory

            return filteredFules;
        }
    }
}
