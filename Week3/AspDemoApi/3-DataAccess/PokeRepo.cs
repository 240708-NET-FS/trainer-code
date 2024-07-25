using Microsoft.EntityFrameworkCore;
using AspDemoApi.Models;

namespace AspDemoApi.Data;

public class PokeRepo : IPokeRepo {

    private readonly PokemonDBContext _context;

    public PokeRepo(PokemonDBContext context) {
        this._context = context;
    }

    //Create pokemon on our database
    public Pokemon CreateNewPokemon(Pokemon pokemonToCreate) {
        _context.Pokemon.Add(pokemonToCreate);
        _context.SaveChanges();

        return pokemonToCreate;
    }

}