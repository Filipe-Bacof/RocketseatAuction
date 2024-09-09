using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Os dois jeitos de inserir "\" em uma string:
        // optionsBuilder.UseSqlite("Data Source=C:\\Workspace\\RocketseatAuction\\leilaoDbNLW.db");
        // optionsBuilder.UseSqlite(@"Data Source=C:\Workspace\RocketseatAuction\leilaoDbNLW.db");

        optionsBuilder.UseSqlite(@"Data Source=C:\Workspace\RocketseatAuction\leilaoDbNLW.db");
    }
}
