//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KermesseApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ingresocom_det
    {
        public int id_ingresocom_det { get; set; }
        public int id_ingresocom { get; set; }
        public int id_bono { get; set; }
        public string denominacion { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
    
        public virtual tbl_bonos tbl_bonos { get; set; }
        public virtual tbl_ingreso_com tbl_ingreso_com { get; set; }
    }
}
