using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class ComisionRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Comision comision)
        {
            using var context = CreateContext();
            context.Comisiones.Add(comision);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var comision = context.Comisiones.Find(id);
            if (comision != null)
            {
                context.Comisiones.Remove(comision);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Comision? Get(int id)
        {
            using var context = CreateContext();
            return context.Comisiones
                .Include(c => c.Plan) 
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Comision> GetAll()
        {
            using var context = CreateContext();
            return context.Comisiones
                .Include(c => c.Plan) 
                .ToList();
        }

        public bool Update(Comision comision)
        {
            using var context = CreateContext();
            var comisionToUpdate = context.Comisiones.Find(comision.Id);
            if (comisionToUpdate != null)
            {
                comisionToUpdate.setAnioEspecialidad(comision.AnioEspecialidad);
                comisionToUpdate.setDescripcion(comision.Descripcion);
                comisionToUpdate.setIdPlan(comision.IdPlan);

                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
