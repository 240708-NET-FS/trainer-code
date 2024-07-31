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
    //This controller uses async methods to excute CRUD operations
    //It also uses try catch and exceptions
    
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
        try
        {
            var trainer = await _trainerService.GetTrainerById(id);
            if(trainer is null) return NotFound("Trainer does not exist!");
            return Ok(trainer);
        }catch(Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTrainer(int id, [FromBody] TrainerDTO updateTrainer)
    {
        try
        {
            var trainer = await _trainerService.UpdateTrainer(id, updateTrainer);
            if(trainer is null) return NotFound("Trainer does not exist!");
            return Ok(trainer);
        }catch(Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTrainer(int id)
    {
        try
        {
            var trainer = await _trainerService.DeleteTrainer(id);
            if(trainer is null) return NotFound("Trainer does not exist!");
            return Ok(trainer);
        }catch(Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}