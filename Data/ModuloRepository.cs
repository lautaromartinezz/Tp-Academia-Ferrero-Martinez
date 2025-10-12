using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Data
{
    public class ModuloRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Modulo mod)
        {
            using var context = CreateContext();
            context.Add(mod);
            context.SaveChanges();
        }

        public Modulo? Delete(Modulo mod) {
            using var context = CreateContext();
            Modulo? modFinded = context.Modulos.Find(mod.Id);
            if(modFinded != null)
            {
                context.Remove(modFinded);
                context.SaveChanges();
                return modFinded;
            }
            return modFinded;    
        }

        public Modulo? FindOne(Modulo mod)
        {
            using var context = CreateContext();
            Modulo? modFinded = context.Modulos.Find(mod.Id);
            return modFinded;
        }

        public IEnumerable<Modulo> GetAll() {
            using var context = CreateContext();
            return context.Modulos.ToList();
        }

        public Modulo? Update(Modulo mod)
        {
            using var context = CreateContext();
            Modulo? modFinded = context.Modulos.Find(mod.Id);
            if (modFinded != null)
            {
                modFinded.setDescripcion(mod.Descripcion);
                modFinded.setEjecuta(mod.Ejecuta);
                context.SaveChanges();
                return modFinded;
            }
            return modFinded;
        }
    }
}
