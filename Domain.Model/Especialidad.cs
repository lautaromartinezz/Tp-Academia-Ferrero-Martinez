using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Especialidad: BussinessEntity
    {
        public string DescEspecialidad { get; set; }
        public ICollection<Plan> Planes { get; set; }

        public Especialidad(int id, string desc)
        {
            SetId(id);
            DescEspecialidad = desc;
        }

        public Especialidad() { }

    }
}
