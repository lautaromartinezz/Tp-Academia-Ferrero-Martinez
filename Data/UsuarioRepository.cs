using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UsuarioRepository
    {
        private AcademiaContext CreateContext()
        {
            return new AcademiaContext();
        }

        public void Add(Usuario usuario)
        {
            using var context = CreateContext();
            try
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx &&
                                   (sqlEx.Number == 2601 || sqlEx.Number == 2627))
            {
                string msg = sqlEx.Message;

                if (msg.Contains("UQ_Usuarios_Email"))
                {
                    throw new InvalidOperationException("El email ya está en uso.");
                }
                else if (msg.Contains("UQ_Usuarios_NombreUsuario"))
                {
                    throw new InvalidOperationException("El nombre de usuario ya está en uso.");
                }
                else
                {
                    throw new InvalidOperationException("Ya existe un registro con datos duplicados.");
                }
            }
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var usuario = context.Usuarios.Find(id);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario? Get(int id)
        {
            using var context = CreateContext();
            return context.Usuarios.Include(c => c.Persona)
                .FirstOrDefault(c => c.Id == id)
                ;
        }

        public IEnumerable<Usuario> GetAll()
        {
            using var context = CreateContext();
            return context.Usuarios.Include(c => c.Persona).ToList();
        }

        public bool Update(Usuario usuario)
        {
            using var context = CreateContext();
            var usuarioToUpdate = context.Usuarios.FirstOrDefault(c => c.Id == usuario.Id);
            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.SetNombre(usuario.Nombre);
                usuarioToUpdate.SetApellido(usuario.Apellido);
                usuarioToUpdate.SetEmail(usuario.Email);
                usuarioToUpdate.SetNombreUsuario(usuario.NombreUsuario);
                usuarioToUpdate.SetHabilitado(usuario.Habilitado); 
                usuarioToUpdate.Clave = usuario.Clave;

                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx &&
                                   (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    string msg = sqlEx.Message;

                    if (msg.Contains("IX_Usuarios_Email"))
                    {
                        throw new InvalidOperationException("El email ya está en uso.");
                    }
                    else if (msg.Contains("IX_Usuarios_NombreUsuario"))
                    {
                        throw new InvalidOperationException("El nombre de usuario ya está en uso.");
                    }
                    else
                    {
                        throw new InvalidOperationException("Ya existe un registro con datos duplicados.");
                    }
                }
            }
            return false;
        }

        public async Task<Usuario?> GetByUsernameAsync(string username)
        {
            using var context = CreateContext();
            return await context.Usuarios.Include(u=>u.Persona).FirstOrDefaultAsync(u => u.NombreUsuario == username && u.Habilitado);
        }
    }
}
