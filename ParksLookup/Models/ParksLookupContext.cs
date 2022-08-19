using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
    public class ParksLookupContext : DbContext
    {
        public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
    }
}
//         protected override void OnModelCreating(ModelBuilder builder)
// {
//   builder.Entity<Park>()
//       .HasData(
//           new Park { ParkId = 1, Name = "Glacier", Designation = "National Park", Region = "Northwestern", State = "Montana" },
//           new Park { ParkId = 2, Name = "Cape Lookout", Designation = "State Park", Region = "Northern Coast", State = "Oregon" },
//           new Park { ParkId = 3, Name = "Olympic", Designation = "National Park", Region = "Olympic Peninsula", State = "Washington" }
// );
// }
//         public DbSet<Park> Parks { get; set; }
//     }
// }