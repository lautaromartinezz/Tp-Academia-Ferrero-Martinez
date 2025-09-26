using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Data;
using DTOs;
using Microsoft.Identity.Client;

namespace Domain.Services
{
    public class MateriaService
    {
        public IEnumerable<MateriaDTO> getAll()
        {
            var materiaRepository = new MateriaRepository();
            var materias = materiaRepository.GetAll();

            return materias.Select(materia => new MateriaDTO()
            {
                Id = materia.Id,
                Descripcion = materia.Descripcion,
                HsTotales = materia.HsTotales,
                HsSemanales = materia.HsSemanales,
                IdPlan = materia.IdPlan,
                DescripcionPlan = materia.Plan.Descripcion
            }).ToList();

        }

        public MateriaDTO? getOne(int id)
        {
            var materiaRepository = new MateriaRepository();

            Materia? materia = materiaRepository.Get(id);

            if (materia == null) return null;

            return new MateriaDTO
            {
                Id = id,
                Descripcion = materia.Descripcion,
                HsTotales = materia.HsTotales,
                HsSemanales = materia.HsSemanales,
                IdPlan = materia.IdPlan,
                DescripcionPlan = materia.Plan.Descripcion
            };

        }

        public MateriaDTO add(MateriaDTO dto)
        {
            var planRepository = new PlanRepository();
            Plan? plan = planRepository.Get(dto.IdPlan);
            if (plan == null) return null;
            else
            {
                var materiaRepository = new MateriaRepository();
                Materia materia = new Materia(dto.HsSemanales, dto.Descripcion, dto.HsTotales, dto.IdPlan, 0);
                materiaRepository.Add(materia);
                dto.Id = materia.Id;
                return dto;
            }
        }
        public bool delete(int id)
        {
            var materiaRepository = new MateriaRepository();
            return materiaRepository.Delete(id);
        }

        public bool update(MateriaDTO dto)
        {
            var planRepository = new PlanRepository();
            Plan? plan = planRepository.Get(dto.IdPlan);
            if (plan == null) return false;
            else { 
                var materiaRepository = new MateriaRepository();

                Materia materia = new Materia(dto.HsSemanales, dto.Descripcion, dto.HsTotales, dto.IdPlan, dto.Id);
                return materiaRepository.Update(materia);
    
            }
        }
    }
}
