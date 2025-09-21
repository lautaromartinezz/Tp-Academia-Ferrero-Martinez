using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CursoDTO
    {
        public int Id { get; set; }

        public DateTime AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public int IdMateria { get; set; }
        public int IdComision { get; set; }
    }
}
