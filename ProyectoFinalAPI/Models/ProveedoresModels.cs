using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Models
{
    public class ProveedoresModels
    {
        public List<ProveedoresEnt> ConsultarProveedores()
        {
            using (var conexion = new ProyectoProgramacionEntities())
            {
                List<ProveedoresEnt> respuesta = new List<ProveedoresEnt>();
                var datosBD = (from x in conexion.Proveedores
                               select x).ToList();

                if (datosBD.Count > 0)
                {
                    foreach (var item in datosBD)
                    {
                        respuesta.Add(new ProveedoresEnt
                        {
                            ConsecutivoProveedor = item.ConsecutivoProveedor,
                            Nombre = item.Nombre,
                            Apellido = item.Apellido,
                            Compannia = item.Compañia,
                            Pais = item.Pais
                        });
                    }
                }

                return respuesta;
            }
        }
    }
}