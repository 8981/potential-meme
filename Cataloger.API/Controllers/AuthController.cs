using Microsoft.AspNetCore.Mvc;
using Cataloger.Model;
using Cataloger.DataAccess.Postgres;

[Route("api/controller")]
[ApiController]
public class AuthController : Controller
{
    private readonly CatalogerDbContext _context;

    public AuthController(CatalogerDbContext context)
    {
        _context = context;
    }
}