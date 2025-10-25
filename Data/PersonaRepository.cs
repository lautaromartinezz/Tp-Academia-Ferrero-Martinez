using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class PersonaRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Persona persona)
        {
            using var context = CreateContext();
            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var persona = context.Personas.Find(id);
            if (persona != null)
            {
                context.Personas.Remove(persona);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Persona? Get(int id)
        {
            using var context = CreateContext();
            return context.Personas
                .Include(p => p.Plan)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Persona> GetAll()
        {
            using var context = CreateContext();
            return context.Personas
                .Include(p => p.Plan)
                .ToList();
        }

        public bool Update(Persona persona)
        {
            using var context = CreateContext();
            var personaToUpdate = context.Personas.Find(persona.Id);
            if (personaToUpdate != null)
            {
                personaToUpdate.SetNombre(persona.Nombre);
                personaToUpdate.SetApellido(persona.Apellido);
                personaToUpdate.SetDireccion(persona.Direccion);
                personaToUpdate.SetEmail(persona.Email);
                personaToUpdate.SetTelefono(persona.Telefono);
                personaToUpdate.SetFechaNac(persona.FechaNac);
                personaToUpdate.SetLegajo(persona.Legajo);
                personaToUpdate.SetTipoPersona(persona.TipoPersona);
                personaToUpdate.SetIdPlan(persona.IdPlan);

                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
