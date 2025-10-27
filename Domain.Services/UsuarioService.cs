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
        public IEnumerable<UsuarioDTO> getAll()
        {
            var usuarioRepository = new UsuarioRepository();
            var usuarios = usuarioRepository.GetAll();

            return usuarios.Select(usuario => new UsuarioDTO()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                NombreUsuario = usuario.NombreUsuario,
                Email = usuario.Email,
                Habilitado = usuario.Habilitado,
                Clave = "",
                IdPersona = usuario.Persona.Id
            }).ToList();

        }

        public UsuarioDTO? getOne(int id)
        {
            var usuarioRepository = new UsuarioRepository();

            Usuario? usuario = usuarioRepository.Get(id);

            if (usuario == null) return null;

            return new UsuarioDTO
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                NombreUsuario = usuario.NombreUsuario,
                Email = usuario.Email,
                Habilitado = usuario.Habilitado,
                Clave = "",
                IdPersona = usuario.Persona.Id
            };

        }

        public UsuarioDTO? add(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            Usuario usuario = new Usuario(dto.Id, dto.Nombre, dto.NombreUsuario, dto.Apellido, dto.Email, dto.Habilitado, dto.Clave, dto.IdPersona);

            usuarioRepository.Add(usuario);
  
            dto.Id = usuario.Id;

            return dto;
            

        }
        public bool delete(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            return usuarioRepository.Delete(id);
        }

        public bool update(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            Usuario usuario = new Usuario(dto.Id, dto.Nombre, dto.NombreUsuario, dto.Apellido, dto.Email, dto.Habilitado,dto.Clave, dto.IdPersona);

            return usuarioRepository.Update(usuario);
            
        }
    }
}
