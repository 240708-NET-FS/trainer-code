using AspDemoApi.DTO;
using AspDemoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspDemoApi.Controllers;

//Above my class declaration, I will use a data annotation to designate this as an ASP.NET controller
[ApiController]
[Route("api/[controller]")]
public class PokemonController : ControllerBase
{
    //This controller uses non-async methods to excute CRUD operations
    //It also DOES NOT use try catch and exceptions
    
    //Eventually, I will add my service layer object here, using dependency injection
    private readonly IPokemonService _pokeService;
    private readonly ITrainerService _trainerService;


    //Im going to create a constructor for my controller, ASP.NET will handle actually instantiating this
    //controller object during the runtime of my app. For now, it will remain empty. 
    public PokemonController(IPokemonService pokeService, ITrainerService trainerService) { 
        _pokeService = pokeService;
        _trainerService = trainerService;
    }

    //My first method will be an HttpPost, so that I can persist something to my database
    [HttpPost]
    public IActionResult CreatePokemon(PokemonDTO pokemonToStore)
    {      
        var newPokemon = _pokeService.CreateNewPokemon(pokemonToStore);
        return Ok(newPokemon);                 
    }

    [HttpPost("{id}")]
    public IActionResult CreatePokemonForTrainer(int id, PokemonDTO pokemonToStore)
    {      
        var newPokemon = _pokeService.CreateNewPokemon(pokemonToStore);
        return Ok(newPokemon);                 
    }

    [HttpGet]
    public IActionResult GetAllPokemon()
    {      
        return Ok(_pokeService.GetAllPokemon());                
    }

    [HttpGet("{id}")]
    public IActionResult GetPokemonById(int id)
    {      
        throw new NotImplementedException();                
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePokemon(int id)
    {      
        throw new NotImplementedException();               
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePokemon(PokemonDTO pokemonToStore)
    {      
        throw new NotImplementedException();                 
    }

}





