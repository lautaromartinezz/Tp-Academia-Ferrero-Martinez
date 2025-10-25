using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Model;
using DTOs;

namespace Domain.Services
{
    public class PersonaService
    {
        public IEnumerable<PersonaDTO> getAll()
        {
            var personaRepository = new PersonaRepository();
            var personas = personaRepository.GetAll();

            return personas.Select(p => new PersonaDTO()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Direccion = p.Direccion,
                Email = p.Email,
                Telefono = p.Telefono,
                FechaNac = p.FechaNac,
                Legajo = p.Legajo,
                TipoPersona = p.TipoPersona,
                IdPlan = p.IdPlan,
                DescripcionPlan = p.Plan.Descripcion
            }).ToList();
        }

        public PersonaDTO? getOne(int id)
        {
            var personaRepository = new PersonaRepository();
            Persona? p = personaRepository.Get(id);

            if (p == null) return null;

            return new PersonaDTO
            {
                Id = id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Direccion = p.Direccion,
                Email = p.Email,
                Telefono = p.Telefono,
                FechaNac = p.FechaNac,
                Legajo = p.Legajo,
                TipoPersona = p.TipoPersona,
                IdPlan = p.IdPlan,
                DescripcionPlan = p.Plan.Descripcion
            };
        }

        public PersonaDTO add(PersonaDTO dto)
        {
            var planRepository = new PlanRepository();
            Plan? plan = planRepository.Get(dto.IdPlan);
            if (plan == null) return null;

            var personaRepository = new PersonaRepository();

            Persona persona = new Persona(
                dto.Nombre, dto.Apellido, dto.Direccion, dto.Email, dto.Telefono,
                dto.FechaNac, dto.Legajo, dto.TipoPersona, dto.IdPlan, 0);

            personaRepository.Add(persona);
            dto.Id = persona.Id;
            return dto;
        }

        public bool delete(int id)
        {
            var personaRepository = new PersonaRepository();
            return personaRepository.Delete(id);
        }

        public bool update(PersonaDTO dto)
        {
            var planRepository = new PlanRepository();
            if (planRepository.Get(dto.IdPlan) == null) return false;

            var personaRepository = new PersonaRepository();
            Persona persona = new Persona(
                dto.Nombre, dto.Apellido, dto.Direccion, dto.Email, dto.Telefono,
                dto.FechaNac, dto.Legajo, dto.TipoPersona, dto.IdPlan, dto.Id);

            return personaRepository.Update(persona);
        }
    }
}
