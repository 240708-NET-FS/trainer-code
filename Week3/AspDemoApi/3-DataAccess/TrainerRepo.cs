using AspDemoApi.DTO;

namespace AspDemoApi.Data;

public class TrainerRepo : ITrainerRepo {

    private readonly PokemonDBContext _context;

    public TrainerRepo(PokemonDBContext context) {
        this._context = context;
    }

    //Create pokemon on our database
    public Trainer CreateNewTrainer(Trainer newTrainer) {
        _context.Trainers.Add(newTrainer);
        _context.SaveChanges();

        return newTrainer;
    }

}