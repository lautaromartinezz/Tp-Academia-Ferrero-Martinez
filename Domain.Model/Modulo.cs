using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Modulo: BussinessEntity
    {
        public Modulo(int id)
        {
            Id = id;
        }

        public Modulo(int id, string descripcion, string ejecuta)
        {
            SetId(id);
            setDescripcion(descripcion);
            setEjecuta(ejecuta);
        }

        public string Descripcion { get; private set; }
        public string Ejecuta { get; private set; }
        public ICollection<Usuario> Usuarios { get; set; }

        public void setDescripcion(string desc) { 
            if(desc.Length > 50)
            {
                throw new ArgumentException("Caracteres sobrepasados");
            }
            else if (desc.Length == 0)
            {
                throw new ArgumentException("No se aceptan cadenas vacias");
            }
            Descripcion = desc;
        }

        public void setEjecuta(string e)
        {
            if (e.Length > 50)
            {
                throw new ArgumentException("Caracteres sobrepasados");
            }
            else if (e.Length == 0) {
                throw new ArgumentException("No se aceptan cadenas vacias");
            }
                Ejecuta = e;
        }
    }
}
