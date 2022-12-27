using Microsoft.AspNetCore.Mvc;
using Cataloger.Model;
using Cataloger.DataAccess.Postgres;
using Cataloger.API.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Cataloger.API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly CatalogerDbContext _context;

        public AuthController(CatalogerDbContext context)
        {
            _context = context;
        }

        [HttpPost("sing-in")]
        public async Task<ActionResult<User>> SingIn(User user)
        {
            
            try
            {
                var dbUser = await _context.Users
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(x => x.Login == user.Login);
                    
                if (dbUser == null)
                    return NotFound();

                if (Utils.Verify(user.Password, dbUser.Password))
                {
                    return Ok(dbUser);
                }
                return BadRequest();
            } 
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("sing-up")]
        public async Task<ActionResult<User>> SingUp(User user)
        {
            var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                //Check if user already exist in the database
                var dbUser = await _context.Users
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(x => x.Login == user.Login);

                if (dbUser != null)
                    //HTTP:409
                    return Conflict();
                
                //Check the password is not null or empty
                if (!user.Password.IsNullOrEmpty())
                    user.Password = Utils.Encrypt(user.Password);

                await _context.AddAsync(user);
                await _context.SaveChangesAsync();

                //Commit transaction if every is right.
                await transaction.CommitAsync();

                return Created("", user);
            }
            catch (Exception ex)
            {
                //Rollback transaction if something went wrong
                //That avoid storing user into database
                await transaction.RollbackAsync();
                return BadRequest(ex);
            }
        }
    }
}