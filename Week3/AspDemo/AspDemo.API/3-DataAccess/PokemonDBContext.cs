using Microsoft.EntityFrameworkCore;
using AspDemoApi.DTO;

namespace AspDemoApi.Data;

public class PokemonDBContext : DbContext {

    public PokemonDBContext() { }

    public PokemonDBContext(DbContextOptions options) : base(options ){ }

    public DbSet<Pokemon> Pokemon { get; set;}
    public DbSet<Trainer> Trainers { get; set; }

}