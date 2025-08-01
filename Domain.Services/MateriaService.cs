using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Services
{
    public class MateriaService
    {
        public IEnumerable<MateriaDTO> getAll()
        {
            return MateriaInMemory.materias.Select(materia => new MateriaDTO
            {
                Id = materia.Id,
                Descripcion = materia.Descripcion,
                HsTotales = materia.HsTotales,
                HsSemanales = materia.HsSemanales,
                IdPlan = materia.IdPlan,

            }).ToList();
        }

        public MateriaDTO getOne(int id)
        {
            Materia? materia = MateriaInMemory.materias.Find(m => m.Id == id);
            if (materia == null)
                return null;
            return new MateriaDTO
            {
                Id=materia.Id,
                Descripcion = materia.Descripcion,
                HsTotales = materia.HsTotales,
                HsSemanales = materia.HsSemanales,
                IdPlan = materia.IdPlan,
            };
        }

        public MateriaDTO add(MateriaDTO dto)
        {
            var id = GetNextId();
            Materia materia = new Materia(dto.HsSemanales,dto.Descripcion, dto.HsTotales, dto.IdPlan, id);
            MateriaInMemory.materias.Add(materia);
            return dto;
        }
        public Materia delete(int id)
        {
            Materia? materiaToDelete = MateriaInMemory.materias.Find(m => m.Id == id);

            if (materiaToDelete != null)
            {
                MateriaInMemory.materias.Remove(materiaToDelete);
            }
            return materiaToDelete;
        }

        public Materia update(MateriaDTO dto)
        {
            Materia? materiaToUpdate = MateriaInMemory.materias.Find(m => m.Id == dto.Id);
            if (materiaToUpdate != null)
            {
                materiaToUpdate.SetDescripcion(dto.Descripcion);
                materiaToUpdate.SetHsSemanales(dto.HsSemanales);
                materiaToUpdate.SetHsTotales(dto.HsTotales);

            }
            return materiaToUpdate;

        }
        private static int GetNextId()
        {
            int nextId;

            if (MateriaInMemory.materias.Count > 0)
            {
                nextId = MateriaInMemory.materias.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
