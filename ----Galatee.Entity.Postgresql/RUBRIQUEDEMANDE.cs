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
    
    public partial class RUBRIQUEDEMANDE
    {
        public string NUMDEM { get; set; }
        public string CENTRE { get; set; }
        public string NDOC { get; set; }
        public string REFEM { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public string COPER { get; set; }
        public Nullable<decimal> MONTANTHT { get; set; }
        public Nullable<decimal> MONTANTTAXE { get; set; }
        public string TAXE { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDTAXE { get; set; }
        public int FK_IDCOPER { get; set; }
        public int FK_IDDEMANDE { get; set; }
        public Nullable<bool> ISVALIDER { get; set; }
        public Nullable<bool> ISEXTENSION { get; set; }
        public Nullable<System.DateTime> DATECAISSE { get; set; }
    
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual COPER COPER1 { get; set; }
        public virtual TAXE TAXE1 { get; set; }
        public virtual DEMANDE DEMANDE { get; set; }
    }
}