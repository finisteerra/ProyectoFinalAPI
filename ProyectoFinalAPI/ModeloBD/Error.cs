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
    
    public partial class Error
    {
        public int consecutivo_error { get; set; }
        public System.DateTime fechaHora { get; set; }
        public string mensajeError { get; set; }
        public string origen { get; set; }
        public int codigo_usuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
