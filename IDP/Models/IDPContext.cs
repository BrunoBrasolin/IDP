using Microsoft.EntityFrameworkCore;
namespace IDP.Models
{
    public class IDPContext : DbContext
    {
        public IDPContext(DbContextOptions<IDPContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>();
            modelBuilder.Entity<Sistema>();
            modelBuilder.Entity<Acesso>();
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Sistema> Sistema { get; set; }
        public DbSet<Acesso> Acesso { get; set; }
    }
}
