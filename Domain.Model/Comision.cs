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

        public Plan Plan { get; private set; }


    }
}
