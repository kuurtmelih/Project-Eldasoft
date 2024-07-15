using Microsoft.EntityFrameworkCore;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // Varchar(50) (Admin, Seller, Customer)
}
