//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_LucyCaceres
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoDocumentosxCiudadano
    {
        public int id { get; set; }
        public string codigoDocumento { get; set; }
        public string ciudadanoId { get; set; }
        public Nullable<bool> estadoExamenOral { get; set; }
        public Nullable<bool> estadoExamenPractico { get; set; }
        public Nullable<System.DateTime> fechaEmision { get; set; }
        public Nullable<System.DateTime> fechaVencimiento { get; set; }
        public bool esRenovacion { get; set; }
        public Nullable<System.DateTime> fechaCita { get; set; }
        public byte[] examenMedico { get; set; }
        public byte[] examenVista { get; set; }
        public byte[] examenPsico { get; set; }
        public byte[] deposito { get; set; }
    
        public virtual Ciudadanos Ciudadanos { get; set; }
        public virtual TipoDocumentos TipoDocumentos { get; set; }
    }
}
