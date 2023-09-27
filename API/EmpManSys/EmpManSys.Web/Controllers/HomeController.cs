using Microsoft.AspNetCore.Mvc;

namespace EmpManSys.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("Index")]
    public string Index()
    {
        return "Hello World!";
    }
}
