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
    
    public partial class STATUTJURIQUE
    {
        public STATUTJURIQUE()
        {
            this.DSOCIETEPRIVE = new HashSet<DSOCIETEPRIVE>();
            this.SOCIETEPRIVE = new HashSet<SOCIETEPRIVE>();
        }
    
        public int PK_ID { get; set; }
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
    
        public virtual ICollection<DSOCIETEPRIVE> DSOCIETEPRIVE { get; set; }
        public virtual ICollection<SOCIETEPRIVE> SOCIETEPRIVE { get; set; }
    }
}