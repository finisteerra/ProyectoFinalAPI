using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Models
{
    public class UsuariosModel
    {
        public bool ValidarUsuario(UsuariosEnt entidad)
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                var respuesta = conexion.ValidarUsuario(entidad.CorreoElectronico, entidad.Contrasenna).FirstOrDefault();
                if (respuesta == null)
                    return false;

                return true;
            }
        }
    }
}