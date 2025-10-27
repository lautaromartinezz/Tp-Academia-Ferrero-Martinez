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
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Dictado> Dictados { get; set; }
        internal AcademiaContext()
        {
            //this.Database.EnsureDeleted(); // SOLO EN DEV 

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
                //"Server=(localdb)\\MSSQLLocalDB;Database=Academia;TrustServerCertificate=True;Trusted_Connection=true;MultipleActiveResultSets=true"
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
                    new { Id = 1, Descripcion = "desc1MAT", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 2, Descripcion = "desc2MAT", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 3, Descripcion = "desc3MAT", HsSemanales = 1, HsTotales = 2, IdPlan = 1 },
                    new { Id = 4, Descripcion = "desc4MAT", HsSemanales = 1, HsTotales = 2, IdPlan = 2 },
                    new { Id = 5, Descripcion = "deesc4MAT", HsSemanales = 1, HsTotales = 2, IdPlan = 2 }
                );
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Cupo)
                    .IsRequired();

                entity.Property(e => e.AnioCalendario).IsRequired();

                entity.HasOne(e => e.Comision)
                    .WithMany(e => e.Cursos)
                    .HasForeignKey(e => e.IdComision)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Materia)
                    .WithMany(m => m.Cursos)
                    .HasForeignKey(c => c.IdMateria)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasData(
                    new { Id = 1, Cupo = 1, AnioCalendario = DateTime.Now, IdComision = 2, IdMateria = 1 },
                    new { Id = 2, Cupo = 432, AnioCalendario = new DateTime(2025, 10, 09), IdComision = 2, IdMateria = 1 },
                    new { Id = 3, Cupo = 2332, AnioCalendario = new DateTime(2025, 09, 09), IdComision = 1, IdMateria = 2 },
                    new { Id = 4, Cupo = 233, AnioCalendario = new DateTime(2025, 07, 09), IdComision = 1, IdMateria = 2 },
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

                entity.Property(e => e.Clave).IsRequired().HasMaxLength(64);

                entity.HasIndex(e => e.Email).IsUnique();

                entity.HasIndex(e => e.NombreUsuario).IsUnique();

                entity.Property(e => e.Habilitado).IsRequired().HasMaxLength(15);

                entity.Property(e => e.Salt)
                        .IsRequired()
                        .HasMaxLength(255);

                entity.HasOne((u) => u.Persona)
                    .WithMany((p) => p.Usuarios)
                    .HasForeignKey(e => e.IdPersona)
                    .OnDelete(DeleteBehavior.Cascade).IsRequired();


                var adminUser = new Domain.Model.Usuario(1, "admin", "admin", "admin", "admin@admin.com", true, "admin123", 1);

                entity.HasData(
                    new { Id = adminUser.Id, Nombre = adminUser.Nombre,Apellido=adminUser.Apellido, NombreUsuario = adminUser.NombreUsuario, Clave = adminUser.Clave, Email = adminUser.Email, Habilitado = adminUser.Habilitado, Salt = adminUser.Salt, IdPersona = adminUser.IdPersona });
                /*
                entity.HasData(
                    new { Id = 1, Nombre = "Santiago", Apellido = "Ferrero", Email = "santifnob@gmail.com", NombreUsuario = "vamoniubels", Habilitado = true, Clave = "asd", IdPersona = 1 },
                    new { Id = 2, Nombre = "Lautaro", Apellido = "Martinez", Email = "lautaromartinez@gmail.com", NombreUsuario = "vamoslalepra", Habilitado = true, Clave = "asd", IdPersona = 2 }
                );*/

                entity.HasMany(u => u.Modulos).WithMany(m => m.Usuarios);

            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(p => p.Especialidad).WithMany(e => e.Planes).HasForeignKey(p => p.IdEspecialidad);

                entity.HasData(
                    new { Id = 1, Descripcion = "ISI 2023", IdEspecialidad = 1 },
                    new { Id = 2, Descripcion = "IQ 2014", IdEspecialidad = 2 }
                );
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Ejecuta).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
                entity.HasData(
                    new { Id = 1, Descripcion = "asd", Ejecuta = "asd" },
                    new { Id = 2, Descripcion = "asd2", Ejecuta = "asd2" }
                    );
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.DescEspecialidad).HasMaxLength(50).IsRequired();
                entity.HasMany(e => e.Planes).WithOne(e => e.Especialidad).HasForeignKey(e => e.IdEspecialidad);
                entity.HasData(
                    new { Id = 1, DescEspecialidad = "Informatica" },
                    new { Id = 2, DescEspecialidad = "Quimica" }
                    );
            });

            modelBuilder.Entity<Comision>(entity =>
            {
                entity.HasKey(entity => entity.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
                entity.Property(e => e.AnioEspecialidad).IsRequired();
                entity.HasOne(c => c.Plan)
                    .WithMany(p => p.Comisiones)
                    .HasForeignKey(c => c.IdPlan)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasData(
                    new { Id = 1, Descripcion = "Com1", AnioEspecialidad = 2025, IdPlan = 1 },
                    new { Id = 2, Descripcion = "Com2", AnioEspecialidad = 2024, IdPlan = 2 }
                    );
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(p => p.Nombre)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(p => p.Apellido)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(p => p.Direccion)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(p => p.Email)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(p => p.Telefono)
                    .HasMaxLength(20)
                    .IsRequired();

                entity.Property(p => p.Legajo)
                    .IsRequired();

                entity.Property(p => p.TipoPersona)
                    .HasMaxLength(20)
                    .IsRequired();

                entity.Property(p => p.FechaNac)
                    .IsRequired();

                entity.HasOne(p => p.Plan)
                    .WithMany(plan => plan.Personas)
                    .HasForeignKey(p => p.IdPlan)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasData(
                    new { Id = 1, Nombre = "Juan", Apellido = "Pérez", Direccion = "Calle 123", Email = "juan@mail.com", Telefono = "111-222", Legajo = 1001, TipoPersona = "Alumno", FechaNac = new DateTime(2000, 1, 10), IdPlan = 1 },
                    new { Id = 2, Nombre = "Ana", Apellido = "García", Direccion = "Av. 456", Email = "ana@mail.com", Telefono = "333-444", Legajo = 1002, TipoPersona = "Docente", FechaNac = new DateTime(1990, 5, 15), IdPlan = 2 }
                );
            });

            modelBuilder.Entity<Inscripcion>(entity =>
            {
                entity.HasKey(i => i.Id);
                entity.Property(p => p.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(i => i.Nota)
                    .IsRequired();

                entity.Property(i=> i.Situacion)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.HasOne(i=>i.Alumno).WithMany(a=>a.Inscripciones).HasForeignKey(i=>i.IdAlumno);
                entity.HasOne(i => i.Curso).WithMany(c => c.Inscripciones).HasForeignKey(i => i.IdCurso);

                entity.HasData(
                    new { Id = 1, IdAlumno = 1, IdCurso = 1, Nota = 9, Situacion = "Regular" },
                    new { Id = 2, IdAlumno = 2, IdCurso = 2, Nota = 7, Situacion = "Aprobado" }
                    );


            });

            modelBuilder.Entity<Dictado>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.Property(d=>d.Cargo).HasMaxLength(50).IsRequired();
                entity.HasOne(d=>d.Profesor).WithMany(p=>p.Dictados).HasForeignKey(d=>d.IdProfesor);
                entity.HasOne(d=>d.Curso).WithMany(c=>c.Dictados).HasForeignKey(d=>d.IdCurso);
                entity.HasData(
                    new { Id = 1, Cargo = "Docente", IdProfesor = 1, IdCurso = 1 },
                    new { Id = 2, Cargo = "Jefe Catedra", IdProfesor = 2, IdCurso = 2 }
                    );
            });
        }

    }
}
