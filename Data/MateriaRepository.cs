using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MateriaRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Materia materia)
        {
            using var context = CreateContext();
            context.Materias.Add(materia);
            context.SaveChanges();  
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var materia = context.Materias.Find(id);
            if (materia != null)
            {
                context.Materias.Remove(materia);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Materia? Get(int id)
        {
            using var context = CreateContext();
            return context.Materias
                .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Materia> GetAll()
        {
            using var context = CreateContext();
            return context.Materias
                .ToList();
        }

        public bool Update(Materia materia)
        {
            Console.WriteLine(materia.Id);
            using var context = CreateContext();
            var materiaToUpdate = context.Materias.Find(materia.Id);
            if (materiaToUpdate != null)
            {
                materiaToUpdate.SetIdPlan(materia.IdPlan);
                materiaToUpdate.SetHsTotales(materia.HsTotales);
                materiaToUpdate.SetHsSemanales(materia.HsSemanales);
                materiaToUpdate.SetDescripcion(materia.Descripcion);

                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
