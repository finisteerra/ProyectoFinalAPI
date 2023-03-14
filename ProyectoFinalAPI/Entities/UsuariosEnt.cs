using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Models
{
    public class UsuariosEnt
    {
        public string CorreoElectronico { get; set; }
        public string Contrasenna { get; set; }
        public string ConfirmarContrasenna { get; set; }
    }
}