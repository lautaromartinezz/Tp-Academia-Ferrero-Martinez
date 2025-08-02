using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioInMemory
    {
        public static List<Usuario> Usuarios;
        static UsuarioInMemory()
        {
            Usuarios = new List<Usuario>
            {
                new Usuario(1, "Juan", "Pérez","apodo", "juan.perez@email.com", true),
                new Usuario(2, "María", "Gómez","apodo", "maria.gomez@email.com",true ),
                new Usuario(3, "Carlos", "López","apodo", "carlos.lopez@email.com", true),
                new Usuario(4, "Ana", "Martínez","apodo", "ana.martinez@email.com", true),
                new Usuario(5, "Lucía", "Fernández","apodo", "lucia.fernandez@email.com", true)
            };
        }
    }
}
