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
    
    public partial class CONTROLEUR
    {
        public int PK_ID { get; set; }
        public int FK_IDCONTROLE { get; set; }
        public int FK_IDUSERCONTROLEUR { get; set; }
        public bool IsChefEquipe { get; set; }
    
        public virtual ADMUTILISATEUR ADMUTILISATEUR { get; set; }
        public virtual CONTROLE CONTROLE { get; set; }
    }
}
