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
    
    public partial class Candidati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidati()
        {
            this.Programare_examen = new HashSet<Programare_examen>();
            this.Rezultate_probe = new HashSet<Rezultate_probe>();
            this.Olimpici = new HashSet<Olimpici>();
            this.Optiuni = new HashSet<Optiuni>();
            this.Utilizatori = new HashSet<Utilizatori>();
        }
    
        public decimal ID_Candidat { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Nullable<decimal> CNP { get; set; }
        public string Sex { get; set; }
        public string Adresa { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public Nullable<decimal> Nr_telefon { get; set; }
        public string Tara { get; set; }
        public string Nationalitate { get; set; }
        public string Religie { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> Nota_BAC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programare_examen> Programare_examen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezultate_probe> Rezultate_probe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Olimpici> Olimpici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Optiuni> Optiuni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizatori> Utilizatori { get; set; }
    }
}
