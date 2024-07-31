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
        return await _context.Trainers
            .Include(t => t.OwnedPokemon)
            .ToListAsync();
    }

    public async Task<Trainer?> GetTrainerById(int id)
    {        
        return await _context.Trainers
            .Include(t => t.OwnedPokemon)
            .FirstOrDefaultAsync(t => t.TrainerId == id);
    }

    public async Task<Trainer?> UpdateTrainer(int id, Trainer updateTrainer)
    {        
        Trainer oldTrainer = _context.Trainers.Find(id)!;
        oldTrainer.Username = updateTrainer.Username;
        oldTrainer.Password = updateTrainer.Password;
        await _context.SaveChangesAsync();
        return oldTrainer;
    }

    public async Task<Trainer> DeleteTrainer(int id)
    {        
        Trainer deleteTrainer = _context.Trainers.Find(id)!;
        _context.Trainers.Remove(deleteTrainer);
        await _context.SaveChangesAsync();
        return deleteTrainer;
    }

}