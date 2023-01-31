using Microsoft.EntityFrameworkCore;

namespace HotListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country 
                { 
                    Id = 1,
                    Name="India",
                    ShortName="IN"
                },
                 new Country 
                { 
                    Id = 2,
                    Name="Russia",
                    ShortName="RSA"
                },
                  new Country
                  {
                      Id = 3,
                      Name = "America",
                      ShortName = "USA"
                  }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name="Sandales Resort and Spa",
                    Address="Negril",
                    CountryId=1,
                    Rating=4.3
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 2,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 3,
                    Rating = 3.8
                }
                );
        }
    }
}
