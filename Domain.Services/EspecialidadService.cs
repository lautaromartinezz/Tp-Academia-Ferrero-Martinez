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
    public class EspecialidadService
    {
        public IEnumerable<EspecialidadDTO> getAll()
        {
            var especialidadRepository = new EspecialidadRepository();
            var esp = especialidadRepository.GetAll();

            return esp.Select(esp => new EspecialidadDTO()
            {
                Id = esp.Id,
                DescEspecialidad = esp.DescEspecialidad
            }).ToList();

        }

        public EspecialidadDTO? getOne(int id)
        {
            var especialidadRepository = new EspecialidadRepository();

            Especialidad? esp = especialidadRepository.Get(id);

            if (esp == null) return null;

            return new EspecialidadDTO
            {
                Id = id,
                DescEspecialidad = esp.DescEspecialidad
            };

        }

        public EspecialidadDTO add(EspecialidadDTO dto)
        {
          
                var especialidadRepository = new EspecialidadRepository();
                Especialidad esp = new Especialidad(0, dto.DescEspecialidad);
                especialidadRepository.Add(esp);
                dto.Id = esp.Id;
                return dto;
        }
        public bool delete(int id)
        {
            var especialidadRepository = new EspecialidadRepository();
            return especialidadRepository.Delete(id);
        }

        public bool update(EspecialidadDTO dto)
        {
            var especialidadRepository = new EspecialidadRepository();
            var esp = new Especialidad(dto.Id, dto.DescEspecialidad);
            
            return especialidadRepository.Update(esp);

            
        }
    }
}
