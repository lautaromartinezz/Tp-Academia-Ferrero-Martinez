using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Materia: BussinessEntity
    {
        private string _descripcion;
        private int hsSemanales;
        private int hsTotales;
        private int iDPlan;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int HsSemanales { get => hsSemanales; set => hsSemanales = value; }
        public int HsTotales { get => hsTotales; set => hsTotales = value; }
        public int IDPlan { get => iDPlan; set => iDPlan = value; }

        public Materia(int hsSemanales, string desc, int hsTotales, int idPlan, int id) {
            Descripcion = desc;
            HsSemanales = hsSemanales;
            HsTotales = hsTotales;
            IDPlan = idPlan;
            Id = id;
        } 

    }
}
