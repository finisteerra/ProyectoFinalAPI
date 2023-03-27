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

        [HttpPost]
        [AllowAnonymous]
        [Route("api/ValidarUsuario")]
        public UsuariosEnt ValidarUsuario(UsuariosEnt entidad)
        {
            return modelUsuarios.ValidarUsuario(entidad);
        }

        [HttpGet]
        //[Authorize]
        [Route("api/ConsultarUsuarios")]
        public List<UsuariosEnt> ConsultarUsuarios()
        {
            return modelUsuarios.ConsultarUsuarios();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/BuscarCorreo")]
        public string BuscarCorreo(string ValidarCorreo)
        {
            return modelUsuarios.BuscarCorreo(ValidarCorreo);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/RegistrarUsuario")]
        public int RegistrarUsuario(UsuariosEnt entidad)
        {
            return modelUsuarios.RegistrarUsuario(entidad);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/RecuperarContrasenna")]
        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            modelUsuarios.RecuperarContrasenna(entidad);
        }
    }
}
