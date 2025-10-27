using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class InscripcionRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Inscripcion inscripcion)
        {
            using var context = CreateContext();
            context.Inscripciones.Add(inscripcion);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var inscripcion = context.Inscripciones.Find(id);
            if (inscripcion != null)
            {
                context.Inscripciones.Remove(inscripcion);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Inscripcion? Get(int id)
        {
            using var context = CreateContext();
            return context.Inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Curso)
                .FirstOrDefault(i => i.Id == id)
                ;
        }

        public IEnumerable<Inscripcion> GetAll()
        {
            using var context = CreateContext();
            return context.Inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Curso)
                .ToList();
        }

        public bool Update(Inscripcion inscripcion)
        {
            Console.WriteLine(inscripcion.Id);
            using var context = CreateContext();
            var inscripcionToUpdate = context.Inscripciones.Find(inscripcion.Id);
            if (inscripcionToUpdate != null)
            {
                inscripcionToUpdate.SetNota(inscripcion.Nota);
                inscripcionToUpdate.SetSituacion(inscripcion.Situacion);
                inscripcionToUpdate.SetIdCurso(inscripcion.IdCurso);
                inscripcionToUpdate.SetIdAlumno(inscripcion.IdAlumno);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Inscripcion> GetByCurso(int idCurso)
        {
            using var context = CreateContext();
            return context.Inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Curso)
                .Where(i => i.IdCurso == idCurso)
                .ToList();
        }

        public IEnumerable<Curso> GetCursosWithoutInsc(int idAlumno)
        {
            using var context = CreateContext();
            
            var cursosInscriptoIds = context.Inscripciones
                .Where(i => i.IdAlumno == idAlumno)
                .Select(i => i.IdCurso)
                .ToList();

            return context.Cursos
                .Include(c => c.Materia)
                .Include(c => c.Comision)
                .Where(c => !cursosInscriptoIds.Contains(c.Id))
                .ToList();
        }

    }
}
