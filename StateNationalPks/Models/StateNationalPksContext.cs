using Microsoft.EntityFrameworkCore;

namespace StateNationalPks.Models
{
  public class StateNationalPksContext : DbContext
  {
    public StateNationalPksContext(DbContextOptions<StateNationalPksContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Type = "National", Name = "RockyMountain National Park", Description = "excellent place to visit", Rating = 4, ImageUrl = "https://www.themediterraneantraveller.com/wp-content/uploads/2018/11/greece-heraklion-00032.jpg"},
          new Park { ParkId = 2, Type = "State", Name = "cooks", Description = "A good weekend kayaking outlet in Tigard", Rating = 8, ImageUrl = "https://cdn.travelpulse.com/images/65aaedf4-a957-df11-b491-006073e71405/c8f899f1-a4af-4ea3-b5dd-447ebbaeb40e/630x355.jpg"},
          new Park { ParkId = 3, Type = "National", Name = "Utah arches park", Description = " All red rocks", Rating = 3, ImageUrl = "https://www.toursbylocals.com/images/guides/46/46460/202027064423775.jpg"}
        );

        builder.Entity<User>()
      .HasData(
        new User { Id = 1,  Username = "Leilani", Password = "test" },
        new User { Id = 2,  Username = "Travis", Password = "test" }
      );
    }
  }
}