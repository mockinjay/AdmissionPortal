//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locuri_taxa
    {
        public Nullable<decimal> ID_Specializare { get; set; }
        public Nullable<decimal> Nr_locuri { get; set; }
        public int ID { get; set; }
    
        public virtual Specializari Specializari { get; set; }
    }
}
