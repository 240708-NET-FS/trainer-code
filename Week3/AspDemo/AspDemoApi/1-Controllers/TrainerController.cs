using AspDemoApi.DTO;
using AspDemoApi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AspDemoApi.Controllers;
//Above my class declaration, I will use a data annotation to designate this as an ASP.NET controller
[ApiController]
[Route("api/[controller]")]
public class TrainerController : ControllerBase
{
    private readonly ITrainerService _trainerService;

    public TrainerController(ITrainerService trainerService)
    {
        _trainerService = trainerService;
    }

    //CRUD
    [HttpPost]
    public async Task<IActionResult> CreateTrainer(TrainerDTO newTrainer)
    {
        return Ok(await _trainerService.CreateTrainer(newTrainer));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTrainers()
    {
        return Ok(await _trainerService.GetAllTrainers());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTrainersById(int id)
    {
        var trainer = await _trainerService.GetTrainerById(id);

        if(trainer is null) return BadRequest("Trainer does not exist!");
        
        return Ok(trainer);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTrainer()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteTrainer()
    {
        throw new NotImplementedException();
    }
}