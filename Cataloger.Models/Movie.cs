namespace Cataloger.Model;

public class Movie
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
     public string? NameDirector { get; set; }
    public DateTimeOffset ReleaseDate { get; set; }
    public string? Country { get; set; }
    public string? Description {get; set;}

}
