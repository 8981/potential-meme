using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cataloger.DataAccess.Postgres.Entities;

public sealed class User
{
    public Guid Id {get; set;}
    public string? UserName {get; set;}
    public string? Login {get; set;}
    public string? Password {get; set;}

    public List<Movie>? Movies {get; set;}

}

public sealed class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.Movies);
        builder.Property(x => x.UserName).HasMaxLength(250);
        builder.Property(x => x.Login).HasMaxLength(250);
        builder.Property(x => x.Password).HasMaxLength(250);
    }

} 
