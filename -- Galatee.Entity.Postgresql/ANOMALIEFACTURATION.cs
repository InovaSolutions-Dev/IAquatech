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
    
    public partial class ANOMALIEFACTURATION
    {
        public int PK_ID { get; set; }
        public string CAUSE { get; set; }
        public string SOLUTION { get; set; }
        public string LOTRI { get; set; }
        public string COMPTEUR { get; set; }
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public int FK_IDCENTRE { get; set; }
        public string PERIODE { get; set; }
        public int FK_IDPRODUIT { get; set; }
        public int FK_IDABON { get; set; }
    
        public virtual ABON ABON { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual PRODUIT PRODUIT { get; set; }
    }
}
