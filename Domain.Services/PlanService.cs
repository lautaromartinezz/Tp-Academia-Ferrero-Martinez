using Data;
using Domain.Model;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PlanService
    {
        public IEnumerable<PlanDTO> getAll()
        {
            var planRepository = new PlanRepository();
            var plans = planRepository.GetAll();

            return plans.Select(plan => new PlanDTO()
            {
                Id = plan.Id,
                Descripcion = plan.Descripcion,
                IdEspecialidad = plan.IdEspecialidad
            }).ToList();

        }

        public PlanDTO? getOne(int id)
        {
            var planRepository = new PlanRepository();

            Plan? plan = planRepository.Get(id);

            if (plan == null) return null;

            return new PlanDTO
            {
                Id = id,
                Descripcion = plan.Descripcion,
                IdEspecialidad = plan.IdEspecialidad
            };

        }

        public PlanDTO add(PlanDTO dto)
        {
            var planRepository = new PlanRepository();

            Plan plan = new Plan(dto.Id,dto.Descripcion, dto.IdEspecialidad);

            planRepository.Add(plan);

            dto.Id = plan.Id;

            return dto;
        }
        public bool delete(int id)
        {
            var planRepository = new PlanRepository();
            return planRepository.Delete(id);
        }

        public bool update(PlanDTO dto)
        {
            var planRepository = new PlanRepository();

            Plan plan = new Plan(dto.Id, dto.Descripcion, dto.IdEspecialidad);
            return planRepository.Update(plan);
        }
    }
}
