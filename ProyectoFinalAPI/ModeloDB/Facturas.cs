//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalAPI.ModeloDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturas
    {
        public long ConsecutivoFactura { get; set; }
        public long ConsecutivoUsuario { get; set; }
        public long ConsecutivoPromocion { get; set; }
        public long ConsecutivoSucursal { get; set; }
        public decimal Total { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Promociones Promociones { get; set; }
        public virtual Sucursales Sucursales { get; set; }
    }
}
