using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoFinalAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        UsuariosModel modelUsuarios = new UsuariosModel();

        public bool ValidarUsuario(UsuariosEnt entidad)
        {
            return modelUsuarios.ValidarUsuario(entidad);
        }
        
        [HttpGet]
        [Route("api/BuscarCorreo")]
        public string BuscarCorreo(string ValidarCorreo)
        {
            return modelUsuarios.BuscarCorreo(ValidarCorreo);
        }

        [HttpPost]
        [Route("api/RecuperarContrasenna")]
        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            modelUsuarios.RecuperarContrasenna(entidad);
        }
    }
}
