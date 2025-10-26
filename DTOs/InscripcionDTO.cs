using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class InscripcionDTO
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public string Situacion { get; set; }
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public int AlumnoLegajo { get; set; }
        public DateTime CursoAnio { get; set; }

    }
}
