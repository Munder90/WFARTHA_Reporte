//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFARTHA.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class FOROD
    {
        public byte ID_RESPUESTA { get; set; }
        public byte ID_FORO { get; set; }
        public string ID_USUARIO { get; set; }
        public System.DateTime CREADO { get; set; }
        public string COMENTARIO { get; set; }
        public Nullable<bool> MAIL { get; set; }
    
        public virtual FORO FORO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
