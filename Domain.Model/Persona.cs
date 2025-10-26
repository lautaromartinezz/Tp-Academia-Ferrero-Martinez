using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Persona : BussinessEntity
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Direccion { get; private set; }
        public string Email { get; private set; }
        public string Telefono { get; private set; }
        public DateTime FechaNac { get; private set; }
        public int Legajo { get; private set; }
        public string TipoPersona { get; private set; }
        public int IdPlan { get; private set; }
        public IEnumerable<Usuario> Usuarios {  get; private set; }
        public Plan Plan { get; private set; }

        public IEnumerable<Dictado> Dictados { get; private set; }
        public IEnumerable<Inscripcion> Inscripciones { get; set; }
        public Persona() { }

        public Persona(
            string nombre,
            string apellido,
            string direccion,
            string email,
            string telefono,
            DateTime fechaNac,
            int legajo,
            string tipoPersona,
            int idPlan,
            int id)
        {
            SetNombre(nombre);
            SetApellido(apellido);
            SetDireccion(direccion);
            SetEmail(email);
            SetTelefono(telefono);
            SetFechaNac(fechaNac);
            SetLegajo(legajo);
            SetTipoPersona(tipoPersona);
            SetIdPlan(idPlan);
            SetId(id);
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido no puede ser vacío.", nameof(apellido));
            Apellido = apellido;
        }

        public void SetDireccion(string direccion)
        {
            if (string.IsNullOrWhiteSpace(direccion))
                throw new ArgumentException("La dirección no puede ser vacía.", nameof(direccion));
            Direccion = direccion;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("El email no puede ser vacío.", nameof(email));
            Email = email;
        }

        public void SetTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El teléfono no puede ser vacío.", nameof(telefono));
            Telefono = telefono;
        }

        public void SetFechaNac(DateTime fechaNac)
        {
            FechaNac = fechaNac;
        }

        public void SetLegajo(int legajo)
        {
            if (int.IsNegative(legajo))
                throw new ArgumentException("El legajo debe ser mayor que 0.", nameof(legajo));
            Legajo = legajo;
        }

        public void SetTipoPersona(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo de persona no puede ser vacío.", nameof(tipo));
            TipoPersona = tipo;
        }

        public void SetIdPlan(int idPlan)
        {
            if (int.IsNegative(idPlan))
                throw new ArgumentException("El Id del plan debe ser mayor que 0.", nameof(idPlan));
            IdPlan = idPlan;
        }
    }
}
