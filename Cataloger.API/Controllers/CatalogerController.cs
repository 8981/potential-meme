using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cataloger.Model;
using Cataloger.Model.Movie;

namespace Cataloger.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogerController : ControllerBase
    {
        private readonly CatalogerContext _context;

        public CatalogerController(CatalogerContext context)
        {
            _context = context;
        }

        // GET: api/Cataloger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieModel>>> GetMovies()
        {
          if (_context.Movies == null)
          {
              return NotFound();
          }
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Cataloger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieModel>> GetMovieModel(int id)
        {
          if (_context.Movies == null)
          {
              return NotFound();
          }
            var movieModel = await _context.Movies.FindAsync(id);

            if (movieModel == null)
            {
                return NotFound();
            }

            return movieModel;
        }

        // PUT: api/Cataloger/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieModel(int id, MovieModel movieModel)
        {
            if (id != movieModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(movieModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cataloger
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieModel>> PostMovieModel(MovieModel movieModel)
        {
          if (_context.Movies == null)
          {
              return Problem("Entity set 'CatalogerContext.Movies'  is null.");
          }
            _context.Movies.Add(movieModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieModel", new { id = movieModel.Id }, movieModel);
        }

        // DELETE: api/Cataloger/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieModel(int id)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            var movieModel = await _context.Movies.FindAsync(id);
            if (movieModel == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movieModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieModelExists(int id)
        {
            return (_context.Movies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
