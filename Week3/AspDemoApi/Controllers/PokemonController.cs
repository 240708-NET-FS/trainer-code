using Microsoft.AspNetCore.Mvc;
using AspDemoApi.Models;

namespace AspDemoApi.Controllers;

    //Above my class declaration, I will use a data annotation to designate this as an ASP.NET controller
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        //Eventually, I will add my service layer object here, using dependency injection


        //Im going to create a constructor for my controller, ASP.NET will handle actually instantiating this
        //controller object during the runtime of my app. For now, it will remain empty. 
        public PokemonController() { }

        //My first method will be an HttpPost, so that I can persist something to my database
        [HttpPost]
        public async Task<IActionResult> CreatePokemon(Pokemon pokemonToStore)
        { //This method runs asynchronously. It returns an IActionResult (in this case, a 200 OK for now) 
        //It returns a task, that eventually resolves 
            return Ok();
        }

    }





