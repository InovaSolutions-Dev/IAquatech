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
    
    public partial class DEPARTHTA
    {
        public DEPARTHTA()
        {
            this.BRT = new HashSet<BRT>();
            this.DBRT = new HashSet<DBRT>();
            this.POSTETRANSFORMATION = new HashSet<POSTETRANSFORMATION>();
        }
    
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDPOSTESOURCE { get; set; }
    
        public virtual ICollection<BRT> BRT { get; set; }
        public virtual ICollection<DBRT> DBRT { get; set; }
        public virtual POSTESOURCE POSTESOURCE { get; set; }
        public virtual ICollection<POSTETRANSFORMATION> POSTETRANSFORMATION { get; set; }
    }
}
