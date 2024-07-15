using Microsoft.EntityFrameworkCore;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty; // Varchar(255)
    public string Password { get; set; } = string.Empty; // Varchar(255)
    public string Email { get; set; } = string.Empty; // Varchar(255)
    public string Role { get; set; } = string.Empty; // Varchar(50) (Admin, Seller, Customer)
}
