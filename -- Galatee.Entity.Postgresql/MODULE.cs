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
    
    public partial class MODULE
    {
        public MODULE()
        {
            this.ADMMENU = new HashSet<ADMMENU>();
            this.MODULESDEFONCTION = new HashSet<MODULESDEFONCTION>();
        }
    
        public int PK_ID { get; set; }
        public int FK_IDGROUPPROGRAM { get; set; }
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public string USERCREATION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
    
        public virtual ICollection<ADMMENU> ADMMENU { get; set; }
        public virtual GROUPPROGRAM GROUPPROGRAM { get; set; }
        public virtual ICollection<MODULESDEFONCTION> MODULESDEFONCTION { get; set; }
    }
}
