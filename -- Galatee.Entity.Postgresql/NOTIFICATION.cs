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
    
    public partial class NOTIFICATION
    {
        public int PK_ID { get; set; }
        public int FK_IDTYPENOTIFICATION { get; set; }
        public string MESSAGE { get; set; }
        public string MODULE { get; set; }
        public string MENU { get; set; }
    
        public virtual TYPENOTIFICATION TYPENOTIFICATION { get; set; }
    }
}
