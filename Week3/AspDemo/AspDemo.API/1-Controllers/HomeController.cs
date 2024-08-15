using Microsoft.AspNetCore.Mvc;

namespace AspDemoApi.Controllers;

//Above my class declaration, I will use a data annotation to designate this as an ASP.NET controller
[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult HomePage()
    {      
        var html = "<h1>Hello!</h1>";
        
        return Content(html, "text/html");
    }
}