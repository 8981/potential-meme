using Cataloger.Model.Movie;
using Microsoft.EntityFrameworkCore;
namespace Cataloger.Model;

public class CatalogerContext : DbContext
{
    public CatalogerContext(DbContextOptions<CatalogerContext> options) : base(options)
    {

    }

    public DbSet<MovieModel> Movies {get; set;} = null;
}