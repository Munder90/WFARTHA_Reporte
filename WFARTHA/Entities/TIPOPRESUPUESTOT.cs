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
    
    public partial class TIPOPRESUPUESTOT
    {
        public string SPRAS_ID { get; set; }
        public string TIPOPRE { get; set; }
        public string TEXT30 { get; set; }
    
        public virtual SPRA SPRA { get; set; }
        public virtual TIPOPRESUPUESTO TIPOPRESUPUESTO { get; set; }
    }
}