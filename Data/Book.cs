using Microsoft.EntityFrameworkCore;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;  // Varchar(255) olacak
    public string Author { get; set; } = string.Empty; // Varchar(255) olacak
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty; // Varchar(255) veya Text
    public int Stock { get; set; }
}
