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
    public class ProveedoresController : ApiController
    {
        ProveedoresModels modelProveedores = new ProveedoresModels();

        [HttpGet]
        //[Authorize]
        [Route("api/ConsultarProveedores")]
        public List<ProveedoresEnt> ConsultarProveedores()
        {
            return modelProveedores.ConsultarProveedores();
        }
    }
}
