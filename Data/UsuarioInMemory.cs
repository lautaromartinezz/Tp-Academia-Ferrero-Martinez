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
                new Usuario(1, "Juan", "apodo","Pérez", "juan.perez@email.com", true),
                new Usuario(2, "María", "apodo","Gómez", "maria.gomez@email.com",true ),
                new Usuario(3, "Carlos", "apodo","López", "carlos.lopez@email.com", true),
                new Usuario(4, "Ana", "apodo","Martínez", "ana.martinez@email.com", true),
                new Usuario(5, "Lucía", "apodo","Fernández", "lucia.fernandez@email.com", true)
            };
        }
    }
}
