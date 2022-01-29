using Microsoft.EntityFrameworkCore;

namespace IDP.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
       : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; } = null!;
    }
}
