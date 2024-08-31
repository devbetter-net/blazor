using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Datal;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}