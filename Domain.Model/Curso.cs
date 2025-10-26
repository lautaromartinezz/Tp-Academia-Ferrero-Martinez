using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Curso: BussinessEntity
    {
        public Curso() { }

        public Curso(int id,DateTime anioCalendario, int cupo, int idComision, int idMateria)
        {
            SetId(id);   
            AnioCalendario = anioCalendario;
            SetCupo(cupo);
            SetIdComision(idComision);
            SetIdMateria(idMateria);
        }

        public DateTime AnioCalendario { get; private set; }

        public int Cupo { get; private set; }
        public int IdComision { get; private set; }
        public int IdMateria {  get; private set; }

        public Materia Materia { get; private set; }    

        public Comision Comision { get; private set; }

        public IEnumerable<Inscripcion> Inscripciones { get; set; }
        public IEnumerable<Dictado> Dictados { get; private set; }


        public void SetCupo(int cupo)
        {
            if (int.IsNegative(cupo))
                throw new ArgumentException("El cupo debe ser mayor que 0.", nameof(cupo));
            Cupo = cupo;
        }

        public void SetIdComision(int idCom)
        {
            if (int.IsNegative(idCom))
                throw new ArgumentException("El id de la comision debe ser mayor que 0.", nameof(idCom));
            IdComision = idCom;
        }
        public void SetIdMateria(int idMateria)
        {
            if (int.IsNegative(idMateria))
                throw new ArgumentException("El Id de la materia debe ser mayor que 0.", nameof(idMateria));
            IdMateria = idMateria;
        }

        public void setAnioCalendario(DateTime anioCalendario)
        {
            AnioCalendario = anioCalendario;
        }

    }
}
