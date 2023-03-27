using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Models
{
    public class CevichesModels
    {
        public List<CevichesEnt> ConsultarCeviches()
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                List<CevichesEnt> respuesta = new List<CevichesEnt>();
                var datosBD = (from x in conexion.Ceviches
                               select x).ToList();

                if (datosBD.Count > 0)
                {
                    foreach (var item in datosBD)
                    {
                        respuesta.Add(new CevichesEnt
                        {
                            ConsecutivoCeviche = item.ConsecutivoCeviche,
                            Descripcion = item.Descripcion,
                            Cantidad = item.Cantidad,
                            Precio = item.Precio
                        });
                    }
                }

                return respuesta;
            }
        }
    }
}