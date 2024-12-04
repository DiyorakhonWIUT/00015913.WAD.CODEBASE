// 00015913
using _00015913_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace _00015913_back_end.Data
{
    public class ApplicationDbContext : DbContext
    {
        /*    00015913    */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSet for the Company model only
        public DbSet<Company> Companies { get; set; }
        /*    00015913    */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
