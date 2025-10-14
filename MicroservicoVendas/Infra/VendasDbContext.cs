using MicroservicoVendas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace MicroservicoVendas.Infra
{
    public class VendasDbContext : DbContext
    {
        public VendasDbContext(DbContextOptions<VendasDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
