using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PlanRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Plan plan)
        {
            using var context = CreateContext();
            context.Planes.Add(plan);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var plan = context.Planes.Find(id);
            if (plan != null)
            {
                context.Planes.Remove(plan);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Plan? Get(int id)
        {
            using var context = CreateContext();
            return context.Planes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Plan> GetAll()
        {
            using var context = CreateContext();
            return context.Planes.ToList();
        }

        public bool Update(Plan plan)
        {
            using var context = CreateContext();
            var planToUpdate = context.Planes.Find(plan.Id);
            if (planToUpdate != null)
            {
                planToUpdate.SetDesc(plan.Descripcion);
                planToUpdate.SetIdEsp(plan.IdEspecialidad);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
