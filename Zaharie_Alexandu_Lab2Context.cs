using Microsoft.EntityFrameworkCore;
using Zaharie_Alexandu_Lab2.Models;

public class Zaharie_Alexandu_Lab2Context : DbContext
{
    public Zaharie_Alexandu_Lab2Context(DbContextOptions<Zaharie_Alexandu_Lab2Context> options)
        : base(options)
    {
    }

    public DbSet<Book> Book { get; set; } = default!;
    public DbSet<Publisher> Publisher { get; set; } = default!;
    public DbSet<Author> Author { get; set; } = default!;
}