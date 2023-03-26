using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class UsuariosEnt
    {
        public long ConsecutivoUsuario { get; set; }

        public string CorreoElectronico { get; set; }

        public string Contrasenna { get; set; }

        public string ConfirmarContrasenna { get; set; }

        public bool Estado { get; set; }

        public string Token { get; set; }

        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public byte IdProvincia { get; set; }

        public long Rol { get; set; }

    }
}
