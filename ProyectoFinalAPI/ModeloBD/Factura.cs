//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalAPI.ModeloBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int codigo_factura { get; set; }
        public int codigo_usuario { get; set; }
        public int codigo_promocion { get; set; }
        public int codigo_sucursal { get; set; }
        public decimal total { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Promocion Promocion { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
