﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UsuarioDTO:BussinessEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public bool Habilitado { get; set; }
        public string Clave { get; set; }

        public int IdPersona { get; set; }

    }
}
