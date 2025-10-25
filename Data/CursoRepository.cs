using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CursoRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Curso curso)
        {
            using var context = CreateContext();
            context.Cursos.Add(curso);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var curso = context.Cursos.Find(id); 
            if (curso != null)
            {
                context.Cursos.Remove(curso);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Curso? Get(int id)
        {
            using var context = CreateContext();
            return context.Cursos
                .Include(c => c.Materia)
                .Include(c => c.Comision)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Curso> GetAll()
        {
            using var context = CreateContext();
            return context.Cursos
                .Include(c => c.Materia)
                .Include(c => c.Comision)
                .ToList();
        }

        public bool Update(Curso curso)
        {
            using var context = CreateContext();
            var cursoToUpdate = context.Cursos.Find(curso.Id);
            if (cursoToUpdate != null)
            {
                cursoToUpdate.SetCupo(curso.Cupo);
                cursoToUpdate.setAnioCalendario(curso.AnioCalendario);
                cursoToUpdate.SetIdComision(curso.IdComision);
                cursoToUpdate.SetIdMateria(curso.IdMateria);

                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
