using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        }
        // Usando Fluent API para criar/ajustar as tabelas
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Produto>(p =>
        //     {
        //         p.ToTable("produtos");
        //         p.HasKey(p => p.Id);
        //         p.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
        //         p.Property(p => p.Descricao).HasColumnType("VARCHAR(60)");
        //         p.Property(p => p.Valor).IsRequired();
        //         p.Property(p => p.TipoProduto).HasConversion<string>();
        //     });
        // }
    }
}