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
    public class InscripcionService
    {
        public IEnumerable<InscripcionDTO> getAll()
        {
            var inscripcionRepository = new InscripcionRepository();
            var inscripciones = inscripcionRepository.GetAll();

            return inscripciones.Select(inscripcion => new InscripcionDTO()
            {
                Id = inscripcion.Id,
                Nota = inscripcion.Nota,
                Situacion = inscripcion.Situacion,
                IdCurso = inscripcion.IdCurso,
                IdAlumno = inscripcion.IdAlumno,
                CursoAnio = inscripcion.Curso.AnioCalendario,
                AlumnoLegajo = inscripcion.Alumno.Legajo

            }).ToList();

        }

        public InscripcionDTO? getOne(int id)
        {
            var inscripcionRepository = new InscripcionRepository();

            Inscripcion? inscripcion = inscripcionRepository.Get(id);

            if (inscripcion == null) return null;

            return new InscripcionDTO
            {
                Id = inscripcion.Id,
                Nota = inscripcion.Nota,
                Situacion = inscripcion.Situacion,
                IdCurso = inscripcion.IdCurso,
                IdAlumno = inscripcion.IdAlumno,
                CursoAnio = inscripcion.Curso.AnioCalendario,
                AlumnoLegajo = inscripcion.Alumno.Legajo
            };

        }

        public InscripcionDTO add(InscripcionDTO dto)
        {
            var personaRepository = new PersonaRepository();
            Persona? persona = personaRepository.Get(dto.IdAlumno);

            var cursoRepository = new CursoRepository();
            Curso? curso = cursoRepository.Get(dto.IdCurso);
            if (persona == null || curso == null) return null;
            if (curso.Cupo <= 0) return null;
            else
            {
                var inscripcionRepository = new InscripcionRepository();
                Inscripcion inscripcion = new Inscripcion(0, dto.Situacion, dto.Nota, dto.IdAlumno, dto.IdCurso);
                inscripcionRepository.Add(inscripcion);
                dto.Id = inscripcion.Id;

                CursoDTO cursoDTO = new CursoDTO()
                {
                    Id = curso.Id,
                    AnioCalendario = curso.AnioCalendario,
                    Cupo = curso.Cupo - 1,
                    IdComision = curso.IdComision,
                    IdMateria = curso.IdMateria,
                    DescripcionComision = curso.Comision.Descripcion,
                    DescripcionMateria = curso.Materia.Descripcion
                };
                cursoRepository.Update(new Curso(cursoDTO.Id, cursoDTO.AnioCalendario, cursoDTO.Cupo, cursoDTO.IdComision, cursoDTO.IdMateria));

                return dto;
            }
        }
        public bool delete(int id)
        {
            var inscripcionRepository = new InscripcionRepository();
            return inscripcionRepository.Delete(id);
        }

        public bool update(InscripcionDTO dto)
        {
            var personaRepository = new PersonaRepository();
            Persona? persona = personaRepository.Get(dto.IdAlumno);

            var cursoRepository = new CursoRepository();
            Curso? curso = cursoRepository.Get(dto.IdCurso);

            if (persona == null || curso == null) return false;
            if (curso.Cupo <= 0) return false;
            else
            {
                var inscripcionRepository = new InscripcionRepository();

                Inscripcion inscripcion = new Inscripcion(dto.Id, dto.Situacion, dto.Nota, dto.IdAlumno, dto.IdCurso);


                CursoDTO cursoDTO = new CursoDTO()
                {
                    Id = curso.Id,
                    AnioCalendario = curso.AnioCalendario,
                    Cupo = curso.Cupo - 1,
                    IdComision = curso.IdComision,
                    IdMateria = curso.IdMateria,
                    DescripcionComision = curso.Comision.Descripcion,
                    DescripcionMateria = curso.Materia.Descripcion
                };
                cursoRepository.Update(new Curso(cursoDTO.Id, cursoDTO.AnioCalendario, cursoDTO.Cupo, cursoDTO.IdComision, cursoDTO.IdMateria));


                return inscripcionRepository.Update(inscripcion);

            }
        }
        public IEnumerable<InscripcionDTO> getByCurso(int idCurso)
        {
            var inscripcionRepository = new InscripcionRepository();
            var inscripciones = inscripcionRepository.GetByCurso(idCurso);

            return inscripciones.Select(inscripcion => new InscripcionDTO()
            {
                Id = inscripcion.Id,
                Nota = inscripcion.Nota,
                Situacion = inscripcion.Situacion,
                IdCurso = inscripcion.IdCurso,
                IdAlumno = inscripcion.IdAlumno,
                CursoAnio = inscripcion.Curso.AnioCalendario,
                AlumnoLegajo = inscripcion.Alumno.Legajo

            }).ToList();

        }
    }
    }
