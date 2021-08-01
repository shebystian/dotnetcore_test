using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MyMicroservice.Models;

namespace MyMicroservice.Repository
{
    [Obsolete("This class is not used now.")]
    public class GameDbContext: DbContext
    {
        public DbSet<Game> Game {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(LAPTOP-BCM7FP7D\SQLEXPRESS01;trusted_connection=true;Database=Catalog;App=EntityFramework");
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-BCM7FP7D\SQLEXPRESS01;Database=Catalog;Trusted_Connection=True;");
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword (si quieremos conectarnos con usuario y pass a un server remoto)
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false).HasColumnName("nombre");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false).HasColumnName("categoria");
            });
        }
    }
}