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
        LogsModel modelLogs = new LogsModel();
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

        public string BuscarCorreo(string ValidarCorreo)
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                var respuesta = (from x in conexion.Usuarios
                                 where x.CorreoElectronico == ValidarCorreo
                                 select x).FirstOrDefault();
                if(respuesta == null)
                    return string.Empty;
                else
                {
                    if (respuesta.Estado == false)
                        return "Su cuenta de correo se encuentra inactiva.";
                    else
                        return "Su cuenta de correo ya se encuentra registrada.";
                }

            }
        }

        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                var respuesta = (from x in conexion.Usuarios
                                 where x.CorreoElectronico == entidad.CorreoElectronico
                                 select x).FirstOrDefault();
                if (respuesta != null)
                {
                    string Asunto = "Recuperar Contraseña";
                    string Body = "Su clave actual es: <BR/> " + respuesta.Contrasenna;
                    modelLogs.EnviarCorreo(entidad.CorreoElectronico, Asunto, Body);
                }
            }
        }



    }

    
}