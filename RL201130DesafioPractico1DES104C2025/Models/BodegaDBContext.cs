using Microsoft.EntityFrameworkCore;

namespace RL201130DesafioPractico1DES104C2025.Models
{
    public class BodegaDBContext : DbContext
    {
        public BodegaDBContext(DbContextOptions<BodegaDBContext> options) : base(options)
        {
        
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }

        
    }
}