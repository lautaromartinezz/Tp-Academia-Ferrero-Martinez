using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Services
{
    public class UsuarioService
    {
        public UsuarioDTO Add(UsuarioDTO dto)
        {
            // Validar que el email no esté duplicado
            if (UsuarioInMemory.Usuarios.Any(c => c.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un Usuario con el Email '{dto.Email}'.");
            }

            var id = GetNextId();

            Usuario usuario = new Usuario(id, dto.Nombre, dto.NombreUsuario, dto.Apellido, dto.Email, dto.Habilitado);

            UsuarioInMemory.Usuarios.Add(usuario);

            dto.Id = usuario.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            Usuario? usuarioToDelete = UsuarioInMemory.Usuarios.Find(x => x.Id == id);

            if (usuarioToDelete != null)
            {
                UsuarioInMemory.Usuarios.Remove(usuarioToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public UsuarioDTO GetOne(int id)
        {
            Usuario? usuario = UsuarioInMemory.Usuarios.Find(x => x.Id == id);

            if (usuario == null)
                return null;

            return new UsuarioDTO
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                NombreUsuario = usuario.NombreUsuario,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Habilitado = usuario.Habilitado,
            };
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            return UsuarioInMemory.Usuarios.Select(usuario => new UsuarioDTO
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                NombreUsuario = usuario.NombreUsuario,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Habilitado = usuario.Habilitado,
            }).ToList();
        }

        public bool Update(UsuarioDTO dto)
        {
            Usuario? usuarioToUpdate = UsuarioInMemory.Usuarios.Find(x => x.Id == dto.Id);

            if (usuarioToUpdate != null)
            {
                // Validar que el email no esté duplicado (excluyendo el Usuario actual)
                if (UsuarioInMemory.Usuarios.Any(c => c.Id != dto.Id && c.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe otro Usuario con el Email '{dto.Email}'.");
                }

                usuarioToUpdate.SetNombre(dto.Nombre);
                usuarioToUpdate.SetNombreUsuario(dto.NombreUsuario);
                usuarioToUpdate.SetApellido(dto.Apellido);
                usuarioToUpdate.SetEmail(dto.Email);
                usuarioToUpdate.SetHabilitado(dto.Habilitado);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextId()
        {
            int nextId;

            if (UsuarioInMemory.Usuarios.Count > 0)
            {
                nextId = UsuarioInMemory.Usuarios.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
