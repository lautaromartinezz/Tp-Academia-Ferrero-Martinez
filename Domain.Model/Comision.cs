using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Comision: BussinessEntity 
    {
        public string Descripcion { get; private set; }
        public int AnioEspecialidad { get; private set; }
        public int IdPlan { get; private set; }
        public Plan Plan { get; private set; }
        public ICollection<Curso> Cursos { get; private set; }

        public Comision() { }
        public Comision(string desc, int anio, int idPlan) {
            Descripcion = desc;
            setAnioEspecialidad(anio);
            IdPlan = idPlan;
        }

        public Comision(int id, string desc, int anio, int idPlan)
        {
            Id = id;
            Descripcion = desc;
            setAnioEspecialidad(anio);
            setIdPlan(idPlan);
        }

        public void setAnioEspecialidad(int anio)
        {
            if (anio < 1000)
            {
                throw new ArgumentException("El año de la especialidad no es valido.", nameof(anio));
            }
            else
            {
                AnioEspecialidad = anio;
            }
        }

        public void setIdPlan(int id)
        {
            IdPlan = id;
        }
        public void setDescripcion(string desc)
        {
            Descripcion = desc;
        }
    }
}
