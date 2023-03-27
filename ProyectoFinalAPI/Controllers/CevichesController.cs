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
    public class CevichesController : ApiController
    {
        CevichesModels modelCeviches = new CevichesModels();

        [HttpGet]
        //[Authorize]
        [Route("api/ConsultarCeviches")]
        public List<CevichesEnt> ConsultarCeviches()
        {
            return modelCeviches.ConsultarCeviches();
        }
    }
}
