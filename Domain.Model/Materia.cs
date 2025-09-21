using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Model
{
    public class Materia: BussinessEntity
    {

        public string Descripcion { get; private set; }
        public int HsSemanales { get; private set; }
        public int HsTotales { get; private set; }
        public int IdPlan { get; private  set; }

        public Materia() { }

        public Materia(int hsSemanales, string desc, int hsTotales, int idPlan, int id) {
            SetDescripcion(desc);
            SetHsSemanales(hsSemanales);
            SetHsTotales(hsTotales);
            SetIdPlan(idPlan);
            SetId(id);
        }
        

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripcion no puede ser nula o vacia.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetHsSemanales(int hsSemanales)
        {
            if (int.IsNegative(hsSemanales))
                throw new ArgumentException("Las horas semanales debe ser mayor que 0.", nameof(hsSemanales));
            HsSemanales = hsSemanales;
        }

        public void SetHsTotales(int hsTotales)
        {
            if (int.IsNegative(hsTotales))
                throw new ArgumentException("Las horas totales debe ser mayor que 0.", nameof(hsTotales));
            HsTotales = hsTotales;
        }
        public void SetIdPlan(int idPlan)
        {
            if (int.IsNegative(idPlan))
                throw new ArgumentException("El Id del plan debe ser mayor que 0.", nameof(idPlan));
            IdPlan = idPlan;
        }
    }
}
