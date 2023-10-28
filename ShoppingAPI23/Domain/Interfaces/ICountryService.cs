using ShoppingAPI23.DAL.Entities;

namespace ShoppingAPI23.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync();//firma de metodo

        Task<Country> CreateCountryAsync(Country country);
  

    }
}
