using Microsoft.EntityFrameworkCore;
using StationBK.Core.Entities.Station;
using StationBK.Core.Interfaces.Station;
using StationBK.Core.Models.Station;
using System.Globalization;

namespace StationBK.Infrastructure.Data.Repository.Station
{
    public class OilRepository : IOilRepository
    {
        private readonly AppDbContext _context;

        public OilRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task AddOil(List<Oil> data)
        {
            this._context.Oils.AddRange(data);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Oil>> GetOil(string date)
        {
            var fuels = await this._context.Oils.Where(rec => rec.Date == date).ToListAsync();
            return fuels;
        }
        public async Task<IEnumerable<Oil>> GetTotalOil(TotalDataRequestModel request)
        {

            var oils = await this._context.Oils
            .ToListAsync(); // Fetching all records from the database

            var filteredOils = oils
                .Where(rec =>
                {
                    //int recMonth = int.Parse(rec.Date.Substring(3, 2)); // Parsing the month
                    //int recYear = int.Parse(rec.Date.Substring(6,4)); // Parsing the year

                    return  rec.OilName == request.name;
                })
                .ToList(); // Filtering in memory

            return filteredOils;
        }

     
    }
}
