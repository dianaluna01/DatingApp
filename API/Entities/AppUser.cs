using System;

namespace API.Entities;

public class AppUser //the class itself represents a table & each property represents a column
{
    //Entity Framework only works with public not private
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
