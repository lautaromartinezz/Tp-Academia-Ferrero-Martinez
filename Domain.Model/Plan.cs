using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Plan : BussinessEntity
    {
        public string Descripcion { get; private set; }
        public int IdEspecialidad { get; private set; }
        Plan() { }
        public Plan(int id, string desc, int idEsp)
        {
            SetId(id);
            SetDesc(desc);
            SetIdEsp(idEsp);
        }

        public void SetDesc(string desc)
        {
            if (string.IsNullOrWhiteSpace(desc))
                throw new ArgumentException("La descripcion no puede ser nula o vacia.", nameof(desc));
            Descripcion = desc;
        }
        public void SetIdEsp(int idEsp)
        {
            if (int.IsNegative(idEsp))
                throw new ArgumentException("El Id de la especialidad debe ser mayor que 0.", nameof(idEsp));
            IdEspecialidad = idEsp;
        }
    }
}
