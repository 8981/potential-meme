using Microsoft.AspNetCore.Mvc;
using Cataloger.Model;
using Cataloger.DataAccess.Postgres;

namespace Cataloger.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogerController : ControllerBase
    {
        private readonly CatalogerDbContext _context;

        public CatalogerController(CatalogerDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<Movie>> GetMovies()
        {
          return Ok();
        }

        // GET
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            return Ok();
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieModel(Guid id, Movie movie)
        {
            return Ok();
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovieModel(Movie movie)
        {
          return Ok();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(Guid id)
        {
            return Ok();
        }
    }
}
