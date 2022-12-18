using Cataloger.DataAccess.Postgres.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cataloger.DataAccess.Postgres;

public class CatalogerDbContext : DbContext
{
    public CatalogerDbContext(DbContextOptions<CatalogerDbContext> options) : base(options)
    {
    }

    public DbSet<Movie>? Movies {get; set;}
    public DbSet<User>? Users {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogerDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
