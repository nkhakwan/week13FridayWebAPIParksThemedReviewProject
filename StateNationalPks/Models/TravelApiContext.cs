using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
        : base(options)
    {
    }

    public DbSet<Place> Places { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
        .HasData(
          new Place { PlaceId = 1, City = "Heraklion", Country = "Greece", Description = "A beautiful scenic place with delicious food surrounded by warm Aegean waters.", Rating = 4, ImageUrl = "https://www.themediterraneantraveller.com/wp-content/uploads/2018/11/greece-heraklion-00032.jpg"},
          new Place { PlaceId = 2, City = "Istanbul", Country = "Turkey", Description = " Go to Istanbul if you just have to choose one City in the entire World. All famous tourist attraction in 2 miles diameter. Don't need even transport to go to different attractions. Just walk", Rating = 8, ImageUrl = "https://cdn.travelpulse.com/images/65aaedf4-a957-df11-b491-006073e71405/c8f899f1-a4af-4ea3-b5dd-447ebbaeb40e/630x355.jpg"},
          new Place { PlaceId = 3, City = "Fes", Country = "Morocco", Description = " Good place to visit if you are already visiting Tangier in Morocco. But do visit Karaveen university that is the oldest university still operational in the World. It started functuning around late 700's. And Yep still going after 1300 years", Rating = 3, ImageUrl = "https://www.toursbylocals.com/images/guides/46/46460/202027064423775.jpg"}
        );

        builder.Entity<User>()
      .HasData(
        new User { Id = 1,  Username = "TylerTest", Password = "test" },
        new User { Id = 2,  Username = "KhanTest", Password = "test" }
      );
    }
  }
}