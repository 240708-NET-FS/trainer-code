using Microsoft.EntityFrameworkCore;
using AspDemoApi.DTO;

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

    public List<Pokemon> GetAllPokemon()
    {
        return _context.Pokemon.ToList();
    }

    public Pokemon? GetPokemonById(int id)
    {
        return _context.Pokemon.FirstOrDefault(p => p.PokemonId == id);
    }

}