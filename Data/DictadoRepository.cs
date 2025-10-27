using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DictadoRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Dictado dictado)
        {
            using var context = CreateContext();
            context.Dictados.Add(dictado);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var dictado = context.Dictados.Find(id);
            if (dictado != null)
            {
                context.Dictados.Remove(dictado);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Dictado? Get(int id)
        {
            using var context = CreateContext();
            return context.Dictados
                .Include(i => i.Profesor)
                .Include(i => i.Curso)
                .FirstOrDefault(i => i.Id == id)
                ;
        }

        public IEnumerable<Dictado> GetAll()
        {
            using var context = CreateContext();
            return context.Dictados
                .Include(i => i.Profesor)
                .Include(i => i.Curso)
                .ToList();
        }

        public bool Update(Dictado dictado)
        {
            Console.WriteLine(dictado.Id);
            using var context = CreateContext();
            var dictadoToUpdate = context.Dictados.Find(dictado.Id);
            if (dictadoToUpdate != null)
            {
                dictadoToUpdate.SetCargo(dictado.Cargo);
                dictadoToUpdate.SetIdCurso(dictado.IdCurso);
                dictadoToUpdate.SetIdProefsor(dictado.IdProfesor);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Dictado> GetByProfesorId(int profesorId)
        {
            using var context = CreateContext();
            return context.Dictados
                .Include(i => i.Profesor)
                .Include(i => i.Curso)
                .Where(i => i.IdProfesor == profesorId)
                .ToList();
        }
    }
}
