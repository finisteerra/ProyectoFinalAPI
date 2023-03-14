using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace ProyectoFinalAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        UsuariosModel modelUsuarios = new UsuariosModel();

        [HttpPost]
        [Route("api/ValidarUsuario")]
        public bool ValidarUsuario(UsuariosEnt entidad)
        {
            return modelUsuarios.ValidarUsuario(entidad);
        }
    }
}
