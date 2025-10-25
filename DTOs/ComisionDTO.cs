using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace DTOs
{
    public class ComisionDTO
    {

        public int Id { get; set; }
        public string Descripcion { get;  set; }
        public int AnioEspecialidad { get;  set; }
        public int IdPlan { get;  set; }
        public string DescripcionPlan { get;  set; }


    }
}
