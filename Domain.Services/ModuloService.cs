using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTOs;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace Domain.Services
{
    public class ModuloService
    {
        public ModuloDTO add(ModuloDTO dto)
        {
            ModuloRepository repo = new ModuloRepository();

            Modulo materia = new Modulo(0, dto.Descripcion, dto.Ejecuta);

            repo.Add(materia);

            dto.Id = materia.Id;

            return dto;
        }

        public IEnumerable<ModuloDTO> findAll()
        {
            ModuloRepository repo = new ModuloRepository();

            return repo.GetAll().Select(m => new ModuloDTO
            {
                Id = m.Id,
                Descripcion = m.Descripcion,
                Ejecuta = m.Ejecuta
            }).ToList();
        }

        public ModuloDTO? findOne(ModuloDTO dto)
        {
            ModuloRepository repo = new ModuloRepository();
            Modulo? modulo = new Modulo(dto.Id);
            modulo = repo.FindOne(modulo);
            if (modulo == null)
            {
                return null;
            }
            return new ModuloDTO { Id = modulo.Id, Descripcion = modulo.Descripcion, Ejecuta=modulo.Ejecuta };
        }

        public ModuloDTO? delete(ModuloDTO dto)
        {
            ModuloRepository repo = new ModuloRepository();
            Modulo? mod = new Modulo(dto.Id);
            mod = repo.Delete(mod);

            if (mod == null) return null;

            return new ModuloDTO
            {
                Id = mod.Id,
                Descripcion = mod.Descripcion,
                Ejecuta = mod.Ejecuta
            };
        }

        public ModuloDTO? update(ModuloDTO dto) {
            ModuloRepository repo = new ModuloRepository();
            Modulo? mod = new Modulo(dto.Id, dto.Descripcion, dto.Ejecuta);
            mod = repo.Update(mod);

            if (mod == null) return null;

            return new ModuloDTO
            {
                Id = mod.Id,   
                Descripcion = mod.Descripcion,
                Ejecuta = mod.Ejecuta
            };
        }
    }
}
