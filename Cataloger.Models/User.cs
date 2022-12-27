namespace Cataloger.Model;

public class User 
{
    public Guid Id { get; set; }
    public string? UserName {get; set;}
    public string? Login {get; set;}
    public string? Password {get; set;}
    public DateTime CreateAt {get; set;}
    public DateTime UpdateAt {get; set;}
    public int RoleId {get; set;}
    public Role? Role {get; set;}
    public Movie? Movie {get; set;}
}