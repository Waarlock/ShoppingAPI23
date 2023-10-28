using Microsoft.EntityFrameworkCore;
using ShoppingAPI23.DAL;
using ShoppingAPI23.DAL.Entities;
using ShoppingAPI23.Domain.Interfaces;

namespace ShoppingAPI23.Domain.Services
{
    public class CountryService : ICountryService
    {
        private readonly DataBaseContext _context;

        public CountryService(DataBaseContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
           return await _context.Countries.ToListAsync();
        }

        public async Task<Country> CreateCountryAsync(Country country)
        {
            try
            {
                country.Id = Guid.NewGuid();
                country.CreatedDate = DateTime.Now;

                _context.Countries.Add(country);
                await _context.SaveChangesAsync();

                return country;

            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
