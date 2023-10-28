using Microsoft.AspNetCore.Mvc;
using ShoppingAPI23.DAL.Entities;
using ShoppingAPI23.Domain.Interfaces;

namespace ShoppingAPI23.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// Estya es la primera parte de la URL de esta API
    public class CountriesController : Controller
    {
        private readonly ICountryService _countryService;
        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // En un controlador los metodos cambian de nombre, y realmente se llama Actions,
        // su es una API se denomina ENDPOINT
        //Todo Endpoint returna ActionResult, retorna resultado de una accion

        [HttpGet, ActionName("Get")]
        [Route("Get")] // Concateno la URL inicial : api/countries/get
        
        public async Task<ActionResult<IEnumerable<Country>>> GetCountriesAsync()
        {
            var countries = await _countryService.GetCountriesAsync(); // lendo a capa de Domain para traer tabla countries
        
            if(countries == null || !countries.Any())
            {
                return NotFound();  
            }

            return Ok(countries);
        }
    }
}
