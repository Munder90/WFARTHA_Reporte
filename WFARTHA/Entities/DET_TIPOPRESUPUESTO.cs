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
    
    public partial class DET_TIPOPRESUPUESTO
    {
        public string BUKRS { get; set; }
        public string ID_USER { get; set; }
        public string TIPOPRE { get; set; }
    
        public virtual SOCIEDAD SOCIEDAD { get; set; }
        public virtual TIPOPRESUPUESTO TIPOPRESUPUESTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}