using Microsoft.EntityFrameworkCore;
namespace Cataloger.Model;

public class CatalogerContext : DbContext
{
    public CatalogerContext(DbContextOptions<CatalogerContext> options) : base(options)
    {

    }

    public DbSet<Movie> Movies {get; set;} = null!;
}