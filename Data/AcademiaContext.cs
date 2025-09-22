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
        public DbSet<Curso> Cursos { get; set; }

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

                entity.HasMany(m => m.Cursos).WithOne(c => c.Materia).HasForeignKey(c => c.IdMateria);

                entity.HasData(
                    new { Id = 1, Descripcion = "desc1", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 2, Descripcion = "desc2", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 3, Descripcion = "desc3", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 4, Descripcion = "desc4", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 5, Descripcion = "deesc4", HsSemanales = 1, HsTotales = 2, IdPlan = 1 }
                );
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Cupo)
                    .IsRequired();

                entity.Property(e => e.AnioCalendario).IsRequired();

                entity.Property(e => e.IdComision).IsRequired();

                entity.HasOne(c => c.Materia)
                    .WithMany(m => m.Cursos)
                    .HasForeignKey(c => c.IdMateria)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasData(
                    new { Id = 1, Cupo = 1, AnioCalendario = DateTime.Now, IdComision = 2, IdMateria = 1 },
                    new { Id = 2, Cupo = 432, AnioCalendario = new DateTime(2025,10,09), IdComision = 2, IdMateria = 1 },
                    new { Id = 3, Cupo = 2332, AnioCalendario = new DateTime(2025,09, 09), IdComision = 2, IdMateria = 2 },
                    new { Id = 4, Cupo = 233, AnioCalendario = new DateTime(2025, 07, 09), IdComision = 2, IdMateria = 2 },
                    new { Id = 5, Cupo = 1234, AnioCalendario = new DateTime(2025, 10, 10), IdComision = 2, IdMateria = 4 }
                );
            });

        }
    }
}
