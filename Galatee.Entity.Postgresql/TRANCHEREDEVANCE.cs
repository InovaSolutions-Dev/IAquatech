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
    
    public partial class TRANCHEREDEVANCE
    {
        public int PK_ID { get; set; }
        public int FK_IDREDEVANCE { get; set; }
        public byte ORDRE { get; set; }
        public string LIBELLE { get; set; }
        public Nullable<bool> GRATUIT { get; set; }
    
        public virtual REDEVANCE REDEVANCE { get; set; }
    }
}
