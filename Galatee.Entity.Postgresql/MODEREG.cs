//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galatee.Entity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MODEREG
    {
        public MODEREG()
        {
            this.TRANSCAISB = new HashSet<TRANSCAISB>();
            this.TRANSCAISBFRAUDE = new HashSet<TRANSCAISBFRAUDE>();
            this.TRANSCAISSE = new HashSet<TRANSCAISSE>();
            this.TRANSCAISSEFRAUDE = new HashSet<TRANSCAISSEFRAUDE>();
        }
    
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public Nullable<decimal> ECARTPOS { get; set; }
        public Nullable<decimal> ECARTNEG { get; set; }
        public string COPER { get; set; }
        public string TRANS { get; set; }
        public string COMPTE { get; set; }
        public string COMPTEANNEXE1 { get; set; }
        public string USERCREATION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDCOPER { get; set; }
    
        public virtual COPER COPER1 { get; set; }
        public virtual ICollection<TRANSCAISB> TRANSCAISB { get; set; }
        public virtual ICollection<TRANSCAISBFRAUDE> TRANSCAISBFRAUDE { get; set; }
        public virtual ICollection<TRANSCAISSE> TRANSCAISSE { get; set; }
        public virtual ICollection<TRANSCAISSEFRAUDE> TRANSCAISSEFRAUDE { get; set; }
    }
}