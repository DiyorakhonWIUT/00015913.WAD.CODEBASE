// 00015913
using _00015913_back_end.Models;
using Microsoft.EntityFrameworkCore;
namespace _00015913_back_end.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the foreign key relationship
            modelBuilder.Entity<JobPost>()
                .HasOne(j => j.Company)
                .WithMany(c => c.JobPosts)
                .HasForeignKey(j => j.CompanyId);

            base.OnModelCreating(modelBuilder);
        }
    }

}
