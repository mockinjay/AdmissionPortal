//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAdmissionPortal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Olimpici
    {
        public decimal ID_Olimpic { get; set; }
        public Nullable<decimal> ID_Candidat { get; set; }
    
        public virtual Candidati Candidati { get; set; }
    }
}