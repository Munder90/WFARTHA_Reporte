//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFARTHA.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class FORO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORO()
        {
            this.FORODs = new HashSet<FOROD>();
        }
    
        public byte ID_FORO { get; set; }
        public string ID_USUARIO { get; set; }
        public decimal NUM_DOC { get; set; }
        public string TITULO { get; set; }
        public System.DateTime CREADO { get; set; }
        public Nullable<System.DateTime> CERRADO { get; set; }
        public Nullable<bool> MAIL { get; set; }
    
        public virtual DOCUMENTO DOCUMENTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOROD> FORODs { get; set; }
    }
}