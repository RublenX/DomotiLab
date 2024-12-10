using Dispositivos.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Dispositivos.Infraestructura.Persistencia
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<Conectividad> Conectividades { get; set; }
        public DbSet<ConectividadEthernet> ConectividadesEthernet { get; set; }
        public DbSet<ConectividadWifi> ConectividadesWifi { get; set; }
        public DbSet<ConectividadBluetooth> ConectividadesBluetooth { get; set; }
        public DbSet<ConectividadRfid> ConectividadesRfid { get; set; }
        public DbSet<ConectividadNfc> ConectividadesNfc { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dispositivo>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Dispositivo>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Dispositivo>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Dispositivo>()
                .OwnsOne(d => d.Compra, compra =>
                {
                    compra.Property(c => c.Tienda).HasColumnName("CompraTienda");
                    compra.Property(c => c.Fecha).HasColumnName("CompraFecha");
                    compra.Property(c => c.Precio).HasColumnName("CompraPrecio");
                });

            modelBuilder.Entity<Conectividad>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Conectividad>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Conectividad>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadEthernet>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ConectividadEthernet>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadEthernet>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadWifi>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ConectividadWifi>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadWifi>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadBluetooth>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ConectividadBluetooth>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadBluetooth>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadRfid>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ConectividadRfid>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadRfid>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadNfc>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ConectividadNfc>()
                .Property(d => d.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<ConectividadNfc>()
                .Property(d => d.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
