namespace Cataloger.Model;

public class User 
{
    public Guid Id { get; set; }
    public string? UserName {get; set;}
    public string? Login {get; set;}
    public string? Password {get; set;}
}