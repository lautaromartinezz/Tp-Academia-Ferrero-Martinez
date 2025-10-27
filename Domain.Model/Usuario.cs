using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public string Salt { get; private set; }
        public string Email { get; private set; }

        public string Clave { get; set; }

        public int IdPersona { get; private set; }
        public Persona Persona { get; private set; }
        public ICollection<Modulo> Modulos { get; set; }
        
        private Usuario() { }

        public Usuario(int id, string nombre, string nombreUsuario,string apellido, string email, bool habilitado, string clave, int idPersona)
        {
            SetId(id);
            SetNombre(nombre);
            SetNombreUsuario(nombreUsuario);
            SetApellido(apellido);
            SetEmail(email);
            SetHabilitado(habilitado);
            SetClave(clave);
            SetIdPersona(idPersona);
        }

        public void SetClave(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) && password.Length < 6)
                throw new ArgumentException("La contraseña no puede ser nula o vacía.", nameof(password));

            Salt = GenerateSalt();
            Clave = HashPassword(password, Salt); // ESTA REALMENTE SERIA LA CLAVE HASHEADA (LA QUE SE ESTA GUARDANDO EN EL BACK)
        }

        public void SetClaveSinHash(string password)
        {
            Clave = password;
        }
        public void SetHabilitado(bool habil)
        {
           Habilitado = habil;
        }
        public void SetIdPersona(int id)
        {
            if (int.IsNegative(id))
                throw new ArgumentException("El Id de persona debe ser mayor que 0.", nameof(id));
            IdPersona = id;
        }
        public void setPersona(Persona u)
        {
               Persona = u;
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

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            string hashedInput = HashPassword(password, Salt);
            return Clave == hashedInput; // COMPARA LA CLAVE HASHEADA INGRESADA CON LA GUARDADA
        }
        private static string HashPassword(string password, string salt)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);
            return Convert.ToBase64String(hashBytes);
        }
        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            RandomNumberGenerator.Fill(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }
    }
}
