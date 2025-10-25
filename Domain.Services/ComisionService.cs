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
    public class ComisionService
    {
        public IEnumerable<ComisionDTO> getAll()
        {
            var ComisionRepository = new ComisionRepository();
            var coms = ComisionRepository.GetAll();

            return coms.Select(com => new ComisionDTO()
            {
                Id = com.Id,
                IdPlan = com.IdPlan,
                Descripcion = com.Descripcion,
                AnioEspecialidad = com.AnioEspecialidad,
                DescripcionPlan = com.Plan.Descripcion
            }).ToList();

        }

        public ComisionDTO? getOne(int id)
        {
            var ComisionRepository = new ComisionRepository();

            Comision? com = ComisionRepository.Get(id);

            if (com == null) return null;

            return new ComisionDTO
            {
                Id = com.Id,
                IdPlan = com.IdPlan,
                Descripcion = com.Descripcion,
                AnioEspecialidad = com.AnioEspecialidad,
                DescripcionPlan = com.Plan.Descripcion
            };

        }

        public ComisionDTO? add(ComisionDTO dto)
        {
            var planRepository = new PlanRepository();

            Plan? plan = planRepository.Get(dto.IdPlan);

            if (plan == null) return null;

            else
            {
                var ComisionRepository = new ComisionRepository();
                Comision com = new Comision(dto.Descripcion, dto.AnioEspecialidad, dto.IdPlan);

                ComisionRepository.Add(com);

                dto.Id = com.Id;

                return dto;
            }

        }
        public bool delete(int id)
        {
            var ComisionRepository = new ComisionRepository();
            return ComisionRepository.Delete(id);
        }

        public bool update(ComisionDTO dto)
        {
            var planRepository = new PlanRepository();

            Plan? plan = planRepository.Get(dto.IdPlan);

            if (plan == null) return false;

            else
            {
                var ComisionRepository = new ComisionRepository();
                Comision com = new Comision(dto.Id, dto.Descripcion, dto.AnioEspecialidad, dto.IdPlan);

                return ComisionRepository.Update(com);
            }
        }
    }
}
