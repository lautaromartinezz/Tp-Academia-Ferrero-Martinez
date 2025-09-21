using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data
{
    internal class AcademiaContext: DbContext
    {
        public DbSet<Materia> Materias { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }

        internal AcademiaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string? connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.HsSemanales)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.HsTotales)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdPlan)
                    .IsRequired();

                entity.HasData(
                    new { Id = 1, Descripcion = "desc1", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 2, Descripcion = "desc2", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 3, Descripcion = "desc3", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 4, Descripcion = "desc4", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 5, Descripcion = "deesc4", HsSemanales = 1, HsTotales = 2, IdPlan = 1 }
                );
            });
        }
    }
}
