using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Usuario:BussinessEntity
    {
        public string Nombre { get; private set; }
        public string NombreUsuario { get; private set; }

        public string Apellido { get; private set; }

        public bool Habilitado { get; private set; }


        public string Email { get; private set; }


        public Usuario(int id, string nombre, string nombreUsuario,string apellido, string email, bool habil)
        {
            SetId(id);
            SetNombre(nombre);
            SetNombreUsuario(nombreUsuario);
            SetApellido(apellido);
            SetEmail(email);
            SetHabilitado(habil);
        }

        public void SetHabilitado(bool habil)
        {
           Habilitado = habil;
        }

        public void SetId(int id)
        {
            if (int.IsNegative(id))
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido no puede ser nulo o vacío.", nameof(apellido));
            Apellido = apellido;
        }
        public void SetNombreUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede ser nulo o vacío.", nameof(nombreUsuario));
            NombreUsuario = nombreUsuario;
        }
        public void SetEmail(string email)
        {
            if (!EsEmailValido(email))
                throw new ArgumentException("El email no tiene un formato válido.", nameof(email));
            Email = email;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

    }
}
