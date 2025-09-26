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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Plan> Planes { get; set; }
        internal AcademiaContext()
        {
            this.Database.EnsureDeleted(); // SOLO EN DEV 
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

                entity.HasOne(e => e.Plan)
                    .WithMany(p => p.Materias)
                    .HasForeignKey(p => p.IdPlan)
                    .OnDelete(DeleteBehavior.Cascade);


                entity.HasMany(m => m.Cursos).WithOne(c => c.Materia).HasForeignKey(c => c.IdMateria).OnDelete(DeleteBehavior.Cascade);

                entity.HasData(
                    new { Id = 1, Descripcion = "desc1", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 2, Descripcion = "desc2", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 3, Descripcion = "desc3", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 4, Descripcion = "desc4", HsSemanales = 1, HsTotales = 2, IdPlan = 2 },
                    new { Id = 5, Descripcion = "deesc4", HsSemanales = 1, HsTotales = 2, IdPlan = 2 }
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
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasData(
                    new { Id = 1, Cupo = 1, AnioCalendario = DateTime.Now, IdComision = 2, IdMateria = 1 },
                    new { Id = 2, Cupo = 432, AnioCalendario = new DateTime(2025,10,09), IdComision = 2, IdMateria = 1 },
                    new { Id = 3, Cupo = 2332, AnioCalendario = new DateTime(2025,09, 09), IdComision = 2, IdMateria = 2 },
                    new { Id = 4, Cupo = 233, AnioCalendario = new DateTime(2025, 07, 09), IdComision = 2, IdMateria = 2 },
                    new { Id = 5, Cupo = 1234, AnioCalendario = new DateTime(2025, 10, 10), IdComision = 2, IdMateria = 4 }
                );
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido).IsRequired().HasMaxLength(50);

                entity.HasIndex(e => e.Email).IsUnique();

                entity.HasIndex(e => e.NombreUsuario).IsUnique();

                entity.Property(e => e.Habilitado).IsRequired().HasMaxLength(15);

                entity.HasData(
                    new { Id = 1, Nombre = "Santiago", Apellido = "Ferrero", Email = "santifnob@gmail.com", NombreUsuario = "vamoniubels", Habilitado = true },
                    new { Id = 2, Nombre = "Lautaro", Apellido = "Martinez", Email = "lautaromartinez@gmail.com", NombreUsuario = "vamoslalepra", Habilitado = true }
                );
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEspecialidad).IsRequired();

                entity.HasData(
                    new { Id = 1, Descripcion = "ISI 2023", IdEspecialidad = 1},
                    new { Id = 2, Descripcion = "IQ 2014", IdEspecialidad = 2}
                );
            });
        }
    }
}
