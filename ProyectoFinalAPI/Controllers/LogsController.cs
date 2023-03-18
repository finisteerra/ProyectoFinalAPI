using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace ProyectoFinalAPI.Controllers
{
    public class LogsController : ApiController
    {
        LogsModel logsModel = new LogsModel();


        [HttpPost]
        [Route("api/RegistrarBitacora")]
        public void RegistrarBitacora(LogsEnt entidad)
        {
            logsModel.RegistrarBitacora(entidad);
        }

    }
}
