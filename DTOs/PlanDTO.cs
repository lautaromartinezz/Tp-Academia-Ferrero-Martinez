using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PlanDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdEspecialidad { get; set; }

        public string DescripcionEspecialidad { get; set; }
    }
}
