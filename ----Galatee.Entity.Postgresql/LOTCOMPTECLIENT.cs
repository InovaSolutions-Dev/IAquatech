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
    
    public partial class LOTCOMPTECLIENT
    {
        public LOTCOMPTECLIENT()
        {
            this.DETAILLOT = new HashSet<DETAILLOT>();
        }
    
        public string NUMEROLOT { get; set; }
        public string MOISCOMPTABLE { get; set; }
        public int IDLOT { get; set; }
        public string STATUS { get; set; }
        public Nullable<decimal> MONTANT { get; set; }
        public int PK_ID { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public string DC { get; set; }
    
        public virtual ICollection<DETAILLOT> DETAILLOT { get; set; }
    }
}
