using AspDemoApi.DTO;
using Microsoft.EntityFrameworkCore;

namespace AspDemoApi.Data;

public class TrainerRepo : ITrainerRepo {

    private readonly PokemonDBContext _context;

    public TrainerRepo(PokemonDBContext context) {
        this._context = context;
    }

    //Create pokemon on our database
    public async Task<Trainer> CreateNewTrainer(Trainer newTrainer) 
    {
        _context.Trainers.Add(newTrainer);
        await _context.SaveChangesAsync();
        return newTrainer;
    }

    public async Task<List<Trainer>> GetAllTrainers()
    {
        return await _context.Trainers.ToListAsync();
    }

}