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
    public class DictadoService
    {
        public IEnumerable<DictadoDTO> getAll()
        {
            var dictadoRepository = new DictadoRepository();
            var dictadoes = dictadoRepository.GetAll();

            return dictadoes.Select(dictado => new DictadoDTO()
            {
                Id = dictado.Id,
                Cargo = dictado.Cargo,
                IdCurso = dictado.IdCurso,
                IdProfesor = dictado.IdProfesor,
                CursoAnio = dictado.Curso.AnioCalendario,
                ProfesorLegajo = dictado.Profesor.Legajo

            }).ToList();

        }

        public DictadoDTO? getOne(int id)
        {
            var dictadoRepository = new DictadoRepository();

            Dictado? dictado = dictadoRepository.Get(id);

            if (dictado == null) return null;

            return new DictadoDTO
            {
                Id = dictado.Id,
                Cargo = dictado.Cargo,
                IdCurso = dictado.IdCurso,
                IdProfesor = dictado.IdProfesor,
                CursoAnio = dictado.Curso.AnioCalendario,
                ProfesorLegajo = dictado.Profesor.Legajo
            };

        }

        public DictadoDTO add(DictadoDTO dto)
        {
            var personaRepository = new PersonaRepository();
            Persona? persona = personaRepository.Get(dto.IdProfesor);

            var cursoRepository = new CursoRepository();
            Curso? curso = cursoRepository.Get(dto.IdCurso);

            if (persona == null || curso == null) return null;
            else
            {
                var dictadoRepository = new DictadoRepository();
                Dictado dictado = new Dictado(0, dto.Cargo, dto.IdCurso, dto.IdProfesor);
                dictadoRepository.Add(dictado);
                dto.Id = dictado.Id;
                return dto;
            }
        }
        public bool delete(int id)
        {
            var dictadoRepository = new DictadoRepository();
            return dictadoRepository.Delete(id);
        }

        public bool update(DictadoDTO dto)
        {
            var personaRepository = new PersonaRepository();
            Persona? persona = personaRepository.Get(dto.IdProfesor);

            var cursoRepository = new CursoRepository();
            Curso? curso = cursoRepository.Get(dto.IdCurso);

            if (persona == null || curso == null) return false;
            else
            {
                var dictadoRepository = new DictadoRepository();

                Dictado dictado = new Dictado(dto.Id, dto.Cargo, dto.IdCurso, dto.IdProfesor);
                return dictadoRepository.Update(dictado);

            }
        }

        public IEnumerable<DictadoDTO> getByProfesorId(int idProfesor)
        {
            var dictadoRepository = new DictadoRepository();
            var dictados = dictadoRepository.GetByProfesorId(idProfesor);
            return dictados.Select(dictado => new DictadoDTO()
            {
                Id = dictado.Id,
                Cargo = dictado.Cargo,
                IdCurso = dictado.IdCurso,
                IdProfesor = dictado.IdProfesor,
                CursoAnio = dictado.Curso.AnioCalendario,
                ProfesorLegajo = dictado.Profesor.Legajo

            }).ToList();
        }
    }
}
