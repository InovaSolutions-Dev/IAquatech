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
    
    public partial class PRESTATAIRE
    {
        public PRESTATAIRE()
        {
            this.TRAVAUXDEVIS = new HashSet<TRAVAUXDEVIS>();
        }
    
        public int PK_ID { get; set; }
        public string NOM { get; set; }
        public string REGISTRECOMMERCE { get; set; }
        public string COMPTECONTRIBUABLE { get; set; }
        public System.DateTime DATENAISSANCE { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
    
        public virtual ICollection<TRAVAUXDEVIS> TRAVAUXDEVIS { get; set; }
    }
}