using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Data;

namespace Domain.Services
{
    public class MateriaService
    {
        public List<Materia> getAll()
        {
            return MateriaInMemory.materias;
        }

        public Materia getOne(int id)
        {
            return MateriaInMemory.materias.Find(m => m.Id == id);
        }

        public void add(Materia materia)
        {
            MateriaInMemory.materias.Add(materia);
        }
        public Materia delete(int id)
        {
            Materia? materiaToDelete = MateriaInMemory.materias.Find(m => m.Id == id);

            if (materiaToDelete != null)
            {
                MateriaInMemory.materias.Remove(materiaToDelete);
            }
            return materiaToDelete;
        }

        public Materia update(Materia materia)
        {
            Materia? materiaToUpdate = MateriaInMemory.materias.Find(m => m.Id == materia.Id);
            if (materiaToUpdate != null)
            {
                if(materiaToUpdate.Descripcion != null) materiaToUpdate.Descripcion = materia.Descripcion;
                if(materiaToUpdate.HsSemanales != null) materiaToUpdate.HsSemanales = materia.HsSemanales;
                if(materiaToUpdate.HsTotales != null) materiaToUpdate.HsTotales = materia.HsTotales;
            
            }
            return materiaToUpdate;
        }
    }
}
