using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Dictado:BussinessEntity
    {
        public string Cargo { get; private set; }
        public int IdCurso { get; private set; }
        public int IdProfesor { get; private set; }
        public Curso Curso { get; set; }
        public Persona Profesor { get; set; }

        public void SetIdCurso(int idCurso)
        {
            if (int.IsNegative(idCurso))
            {
                throw new ArgumentException("El id Curso debe ser mayor a 0", nameof(idCurso));
            }
            IdCurso = idCurso;
        }
        public void SetIdProefsor(int idProfesor)
        {
            if (int.IsNegative(idProfesor))
            {
                throw new ArgumentException("El id Profesor debe ser mayor a 0", nameof(idProfesor));
            }
            IdProfesor = idProfesor;
        }
        public void SetCargo(string cargo)
        {
            if (string.IsNullOrEmpty(cargo))
            {
                throw new ArgumentException("El cargo no puede ser nulo",nameof(cargo));

            }
            Cargo = cargo;
        }
        public Dictado(int id, string cargo,int idCurso,int idProfesor)
        {
            SetId(id);
            SetCargo(cargo);
            SetIdCurso(idCurso);
            SetIdProefsor(idCurso);
        }
    }
}
