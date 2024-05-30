using BloodBank.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Persistence
{
    public class DonorsDbContext : DbContext
    {
      

        public DonorsDbContext(DbContextOptions<DonorsDbContext>options) : base(options) 
        {
            
        }
        public DbSet<Donor> Donors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Donor>(o =>
            {
                o.HasKey(d => d.Id);
            });
            
          
        }
    }


}
