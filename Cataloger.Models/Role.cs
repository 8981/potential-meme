using Microsoft.EntityFrameworkCore.Metadata;

namespace Cataloger.Model;

public class Role
{
    public Guid Id {get; set;}
    public string? Title {get; set;}
    public DateTime CreateAt {get; set;}
    public DateTime UpdateAt {get; set;}
}