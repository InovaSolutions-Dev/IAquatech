//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galatee.Entity.Model.Fraude
{
    using System;
    using System.Collections.Generic;
    
    public partial class DENONCIATEUR
    {
        public DENONCIATEUR()
        {
            this.FRAUDE = new HashSet<FRAUDE>();
        }
    
        public System.Guid Id { get; set; }
        public string Nom { get; set; }
        public string Centre { get; set; }
        public string Contact { get; set; }
        public string LienAvecAbonne { get; set; }
        public Nullable<System.DateTime> DateDenonciation { get; set; }
        public Nullable<byte> IdMoyenDenonciation { get; set; }
    
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual ICollection<FRAUDE> FRAUDE { get; set; }
    }
}
