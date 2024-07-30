using AspDemoApi.Services;
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
    


}