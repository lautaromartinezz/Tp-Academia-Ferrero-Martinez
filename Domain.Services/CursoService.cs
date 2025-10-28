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
    public class CursoService
    {
        public IEnumerable<CursoDTO> getAll()
        {
            var cursoRepository = new CursoRepository();
            var cursos = cursoRepository.GetAll();

            return cursos.Select(curso => new CursoDTO()
            {
                Id = curso.Id,
                Cupo = curso.Cupo,
                IdComision = curso.IdComision,
                //Materia = new MateriaDTO            LO SACO PORQUE EL AUTOGENERATE COLUMNS DEL GRID DATA VIEW ME HACE UNA COLUMNA DE MateriaDTO
                //{                                   Además de que lo adecuado sería ir a ver los datos de la materia desde su crud
                //    Id = curso.Materia.Id,
                //    HsSemanales = curso.Materia.HsSemanales,
                //    HsTotales = curso.Materia.HsTotales,
                //    Descripcion = curso.Materia.Descripcion,
                //    IdPlan = curso.Materia.IdPlan,
                //},
                AnioCalendario = curso.AnioCalendario,
                IdMateria = curso.IdMateria,
                DescripcionMateria = curso.Materia.Descripcion,
                DescripcionComision = curso.Comision.Descripcion
            }).ToList();

        }

        public CursoDTO? getOne(int id)
        {
            var cursoRepository = new CursoRepository();

            Curso? curso = cursoRepository.Get(id);

            if (curso == null) return null;

            return new CursoDTO
            {
                Id = curso.Id,
                Cupo = curso.Cupo,
                IdComision = curso.IdComision,
                //Materia = new MateriaDTO
                //{
                //    Id = curso.Materia.Id,
                //    HsSemanales = curso.Materia.HsSemanales,
                //    HsTotales = curso.Materia.HsTotales,
                //    Descripcion = curso.Materia.Descripcion,
                //    IdPlan = curso.Materia.IdPlan,
                //},
                AnioCalendario = curso.AnioCalendario,
                IdMateria = curso.IdMateria,
                DescripcionMateria = curso.Materia.Descripcion,
                DescripcionComision = curso.Comision.Descripcion

            };

        }

        public CursoDTO? add(CursoDTO dto)
        {
            var materiaRepository = new MateriaRepository();

            Materia? materia = materiaRepository.Get(dto.IdMateria);

            var comisionRepository = new ComisionRepository();
            Comision? comision = comisionRepository.Get(dto.IdComision);

            if (materia == null || comision == null) return null;

            else
            {
                var cursoRepository = new CursoRepository();
                Curso curso = new Curso(dto.Id, dto.AnioCalendario, dto.Cupo, dto.IdComision, dto.IdMateria);

                cursoRepository.Add(curso);

                dto.Id = curso.Id;

                return dto;
            }
                
        }
        public bool delete(int id)
        {  
            var cursoRepository = new CursoRepository();
            return cursoRepository.Delete(id);
        }

        public bool update(CursoDTO dto)
        {
            var materiaRepository = new MateriaRepository();

            Materia? materia = materiaRepository.Get(dto.IdMateria);

            var comisionRepository = new ComisionRepository();
            Comision? comision = comisionRepository.Get(dto.IdComision);

            if (materia == null || comision == null) return false;

            else
            {
                var cursoRepository = new CursoRepository();
                Curso curso = new Curso(dto.Id, dto.AnioCalendario, dto.Cupo, dto.IdComision, dto.IdMateria);

                return cursoRepository.Update(curso);
            }
        }

        public IEnumerable<CursoDTO> getByPlan(int idPlan)
        {
            var cursoRepository = new CursoRepository();
            var cursos = cursoRepository.GetByPlan(idPlan);
            return cursos.Select(curso => new CursoDTO()
            {
                Id = curso.Id,
                Cupo = curso.Cupo,
                IdComision = curso.IdComision,
                AnioCalendario = curso.AnioCalendario,
                IdMateria = curso.IdMateria,
                DescripcionMateria = curso.Materia.Descripcion,
                DescripcionComision = curso.Comision.Descripcion
            }).ToList();
        }
    }
}
