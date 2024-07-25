using AspDemoApi.Models;
using AspDemoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspDemoApi.Controllers;

    //Above my class declaration, I will use a data annotation to designate this as an ASP.NET controller
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        //Eventually, I will add my service layer object here, using dependency injection
        private readonly IPokemonService _pokeService;


        //Im going to create a constructor for my controller, ASP.NET will handle actually instantiating this
        //controller object during the runtime of my app. For now, it will remain empty. 
        public PokemonController(IPokemonService pokeService) { 
            this._pokeService = pokeService;
        }

        //My first method will be an HttpPost, so that I can persist something to my database
        [HttpPost]
        public async Task<IActionResult> CreatePokemon(PokemonDTO pokemonToStore)
        { //This method runs asynchronously. It returns an IActionResult (in this case, a 200 OK for now) 
        //It returns a task, that eventually resolves
        
            try
            {
                var newPokemon = _pokeService.CreateNewPokemon(pokemonToStore);
                return Ok(newPokemon);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }            
        }

    }





