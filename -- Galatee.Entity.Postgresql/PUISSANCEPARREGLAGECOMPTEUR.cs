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
    
    public partial class PUISSANCEPARREGLAGECOMPTEUR
    {
        public int PK_ID { get; set; }
        public int FK_IDPRODUIT { get; set; }
        public int FK_IDREGLAGECOMPTEUR { get; set; }
        public int FK_IDPUISSANCE { get; set; }
    
        public virtual PRODUIT PRODUIT { get; set; }
        public virtual PUISSANCESOUSCRITE PUISSANCESOUSCRITE { get; set; }
        public virtual REGLAGECOMPTEUR REGLAGECOMPTEUR { get; set; }
    }
}
