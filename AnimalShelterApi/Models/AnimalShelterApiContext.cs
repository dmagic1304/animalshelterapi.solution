using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Rex", Breed = "German Shepard", Age = 3 },
          new Dog { DogId = 2, Name = "Wolfie", Breed = "Husky", Age = 7 },
          new Dog { DogId = 3, Name = "Craig", Breed = "Pit Bull", Age = 5 }
        );
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Fluffy", Breed = "Persian", Age = 4 },
          new Cat { CatId = 2, Name = "Missy", Breed = "Siamese", Age = 2 },
          new Cat { CatId = 3, Name = "Nala", Breed = "Ragdoll", Age = 9 }
        );
    }
    
  }
}