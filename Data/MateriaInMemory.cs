using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Data
{
    public class MateriaInMemory
    {
        public static List<Materia> materias;

        static MateriaInMemory() {
            materias = new List<Materia> {
                new Materia(4, "Matematica", 5, 12, 1),
                new Materia(5,"Fisica", 2, 23, 2),
                new Materia(2,"Algebra", 4, 44, 3)

            };
        }
    }   
}
