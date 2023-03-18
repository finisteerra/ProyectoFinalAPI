using Newtonsoft.Json;
using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloBD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Web;

namespace ProyectoFinalAPI.Models
{
    public class LogsModel
    {
        public void RegistrarBitacora(LogsEnt entidad)
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                Bitacoras bitacora = new Bitacoras();
                bitacora.FechaHora = DateTime.Now;
                bitacora.Origen = entidad.origen;
                bitacora.MensajeError = entidad.mensajeError;

                conexion.Bitacoras.Add(bitacora);
                conexion.SaveChanges();
            }
        }

        public void EnviarCorreo(string Destinatario, string Asunto, string Body)
        {
            string correoSMTP = ConfigurationManager.AppSettings["correoSMTP"].ToString();
            string claveSMTP = ConfigurationManager.AppSettings["claveSMTP"].ToString();

            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(Destinatario, "User"));
            msg.From = new MailAddress(correoSMTP, "Admin");
            msg.Subject = Asunto;
            msg.Body = Body;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(correoSMTP, claveSMTP);
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Send(msg);
        }
    }
}