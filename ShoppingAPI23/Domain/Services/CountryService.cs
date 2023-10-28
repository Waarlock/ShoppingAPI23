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
    }
}
