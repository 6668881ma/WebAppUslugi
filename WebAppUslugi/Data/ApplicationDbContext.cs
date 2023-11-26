using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppUslugi.Data.identity;

namespace WebAppUslugi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Service>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<Service>() .Property(z => z.Name).HasMaxLength(100);

            builder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    Name = "Test",
                    Price = 4m, 
                }
                );



            base.OnModelCreating(builder);
        }
        public DbSet<Service> services { get; set; }

    }
}
