//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalAPI.ModeloBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Errores
    {
        public long ConsecutivoError { get; set; }
        public System.DateTime FechaHora { get; set; }
        public string MensajeError { get; set; }
        public string Origen { get; set; }
        public long ConsecutivoUsuario { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
