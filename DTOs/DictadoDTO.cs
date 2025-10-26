using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DictadoDTO
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public int IdProfesor { get; set; }
        public int IdCurso { get; set; }
        public DateTime CursoAnio { get; set; }
        public int ProfesorLegajo { get; set; }
    }
}
