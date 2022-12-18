using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cataloger.DataAccess.Postgres.Entities;

public sealed class Movie
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? NameDirector { get; set; }
    public DateTimeOffset ReleaseDate { get; set; }
    public string? Country { get; set; }
    public string? Description {get; set;}

    public Guid UserId {get; set;}
    public List<User>? Users {get; set;}
}

public sealed class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
    //    builder.HasKey(x => x.Id);
    //    builder.Property(x => x.Title).HasMaxLength(250);
    //    builder.Property(x => x.NameDirector).HasMaxLength(250);
    //    builder.Property(x => x.Country).HasMaxLength(250);
    //    builder.Property(x => x.Description).HasMaxLength(50);
    }
}