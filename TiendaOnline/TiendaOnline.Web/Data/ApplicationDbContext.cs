using Microsoft.EntityFrameworkCore;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        { }
        public DbSet<Country> countries { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>()
                .HasIndex (t => t.Name)
                .IsUnique ();  
        }

        

    }
}
