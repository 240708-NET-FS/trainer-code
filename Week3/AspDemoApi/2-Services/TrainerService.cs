using AspDemoApi.Data;
using AspDemoApi.DTO;
using AspDemoApi.Services;
using tUtil = AspDemoApi.Utilities.TrainerUtility;

namespace AspDemoApi.Services;

public class TrainerService : ITrainerService
{
    private readonly ITrainerRepo _trainerRepo;

    public TrainerService(ITrainerRepo trainerRepo)
    {
        _trainerRepo = trainerRepo;
    }
    
    public async Task<Trainer> CreateTrainer(TrainerDTO newTrainer)
    {
        Trainer trainer = tUtil.DTOToTrainer(newTrainer);        
        return await _trainerRepo.CreateNewTrainer(trainer);
    }

    public async Task<List<Trainer>> GetAllTrainers()
    {        
        return await _trainerRepo.GetAllTrainers();
    }
}