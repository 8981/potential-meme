using Microsoft.AspNetCore.Mvc;

namespace Cataloguer.API.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{

    private readonly ILogger<Controller> _logger;

    public Controller(ILogger<Controller> logger)
    {
        _logger = logger;
    }

    
}
