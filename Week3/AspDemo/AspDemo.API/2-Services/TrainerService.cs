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

    public async Task<Trainer?> GetTrainerById(int id)
    {
        if(id < 1) throw new Exception("Trainer Id cannot be less than 1");        
        return await _trainerRepo.GetTrainerById(id);
    }

    public async Task<Trainer?> UpdateTrainer(int id, TrainerDTO updateTrainer)
    {
        try
        {
            var trainer = await GetTrainerById(id);
            if(trainer is null) return null;
            return await _trainerRepo.UpdateTrainer(id, tUtil.DTOToTrainer(updateTrainer));
        }catch(Exception)
        {
            throw;
        }
    }

    public async Task<Trainer?> DeleteTrainer(int id)
    {
        try
        {
            var trainer = await GetTrainerById(id);
            if(trainer is null) return null;
            return await _trainerRepo.DeleteTrainer(id);
        }catch(Exception)
        {
            throw;
        }
    }
}