using Microsoft.AspNetCore.Mvc;
using Cataloger.DataAccess.Postgres.Entities;
using Cataloger.DataAccess.Postgres;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult> GetMovies()
        {
          return Ok();
        }

        // GET
        [HttpGet("{id}")]
        public async Task<ActionResult> GetMovie()
        {
            return Ok();
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieModel()
        {
            return Ok();
        }

        // Create new 
        [HttpPost]
        public async Task<ActionResult> PostMovieModel()
        {
            var movie = new Movie
            {
                Id = Guid.NewGuid(),
                //Title = 
            };
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return Ok(movie.Id);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(Guid id)
        {
            return Ok();
        }
    }
}
