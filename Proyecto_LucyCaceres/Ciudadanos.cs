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
    
    public partial class Ciudadanos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudadanos()
        {
            this.TipoDocumentosxCiudadano = new HashSet<TipoDocumentosxCiudadano>();
            this.TransportexCiudadano = new HashSet<TransportexCiudadano>();
        }
    
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public Nullable<int> edad { get; set; }
        public string genero { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
        public string tipoSanguineo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoDocumentosxCiudadano> TipoDocumentosxCiudadano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportexCiudadano> TransportexCiudadano { get; set; }
    }
}
