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
        public UsuariosEnt ValidarUsuario(UsuariosEnt entidad)
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                UsuariosEnt respuesta = new UsuariosEnt();

                var datosDB = conexion.ValidarUsuario(entidad.CorreoElectronico, entidad.Contrasenna).FirstOrDefault();
                if (datosDB != null)
                {
                    respuesta.ConsecutivoUsuario = datosDB.ConsecutivoUsuario;
                    respuesta.CorreoElectronico = datosDB.CorreoElectronico;
                }
                    
                return respuesta;
            }
        }

        public List<UsuariosEnt> ConsultarUsuarios()
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                List<UsuariosEnt> respuesta = new List<UsuariosEnt>();
                var datosBD = (from x in conexion.Usuarios
                               select x).ToList();

                if (datosBD.Count > 0)
                {
                    foreach (var item in datosBD)
                    {
                        respuesta.Add(new UsuariosEnt
                        {
                            ConsecutivoUsuario = item.ConsecutivoUsuario,
                            Nombre = item.Nombre,
                            Apellido = item.Apellido,
                            Edad = item.Edad,
                            Telefono = item.Telefono,
                            CorreoElectronico = item.CorreoElectronico,
                            Estado = item.Estado,
                        });
                    }
                }

                return respuesta;
            }
        }

        public int RegistrarUsuario(UsuariosEnt entidad)
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                return conexion.RegistrarUsuario(entidad.Nombre, entidad.Apellido, entidad.Edad, entidad.Telefono, 
                    entidad.CorreoElectronico, entidad.Contrasenna);
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
