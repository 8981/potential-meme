using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cataloger.DataAccess.Postgres.Entities;

public class Role
{
    public Guid Id {get; set;}
    public string? Title {get; set;}
    public DateTime CreateAt {get; set;}
    public DateTime UpdateAt {get; set;}
}

public sealed class RoleEntityConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(250);
    }
}