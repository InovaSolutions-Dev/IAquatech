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
    
    public partial class COMMUNEGROUPEDEPANNAGE
    {
        public Nullable<System.Guid> FK_IDGROUPEVALIDATION { get; set; }
        public string CODECOMMUNE { get; set; }
        public int PK_ID { get; set; }
    
        public virtual GROUPE_VALIDATION GROUPE_VALIDATION { get; set; }
    }
}
