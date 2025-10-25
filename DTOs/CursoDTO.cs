using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace DTOs
{
    public class CursoDTO
    {
        public int Id { get; set; }

        public DateTime AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public int IdMateria { get; set; }
        public int IdComision { get; set; }

        public string DescripcionMateria { get; set; }

        public string DescripcionComision { get; set; }

        //public MateriaDTO? Materia { get; set; }
    }
}
