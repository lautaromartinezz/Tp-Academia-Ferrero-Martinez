using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Inscripcion:BussinessEntity
    {
        public string Situacion { get; private set; }
        public int Nota { get; private set; }

        public int IdAlumno { get; private set; }
        public int IdCurso { get; set; }
        public Persona Alumno { get; set; }
        public Curso Curso{ get; set; }
        public void SetSituacion(string situacion) 
        {
            if (situacion == null) 
            { 
                throw new ArgumentException("La situacion no puede ser nula",nameof(Situacion));
            }
            Situacion = situacion; 
        }
        public void SetNota(int nota) 
        {
            if (int.IsNegative(nota))
            {
                throw new ArgumentException("La nota debe ser mayor a 0",nameof(Nota));
            }
            Nota = nota; 
        }
        public void SetIdAlumno(int idAlumno)
        {
            if (int.IsNegative(idAlumno))
            {
                throw new ArgumentException("El id Alumno debe ser mayor a 0", nameof(Nota));
            }
            IdAlumno = idAlumno;
        }
        public void SetIdCurso(int idCurso)
        {
            if (int.IsNegative(idCurso))
            {
                throw new ArgumentException("El id Curso debe ser mayor a 0", nameof(Nota));
            }
            IdCurso = idCurso;
        }

        public Inscripcion(int id,string situacion, int nota, int idAlumno, int IdCurso)
        {
            SetId(id);
            SetSituacion(situacion);
            SetIdAlumno(idAlumno);
            SetNota(nota);
            SetIdAlumno(idAlumno);
            SetIdCurso(IdCurso);
        }

    }
}
