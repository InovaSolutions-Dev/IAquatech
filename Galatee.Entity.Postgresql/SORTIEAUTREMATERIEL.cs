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
    
    public partial class SORTIEAUTREMATERIEL
    {
        public int PK_ID { get; set; }
        public int FK_IDDEMANDE { get; set; }
        public int FK_IDTYPEMATERIEL { get; set; }
        public string LIBELLE { get; set; }
        public string NOMBRE { get; set; }
        public string LIVRE { get; set; }
        public string RECU { get; set; }
    }
}