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
    
    public partial class GRC_GROUPE_AFFECTE
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ID_GROUPE { get; set; }
        public int FK_IDADGENT { get; set; }
        public string MATRICULE_AGENT { get; set; }
        public string CREER_PAR { get; set; }
        public System.DateTime DATE_CREATION { get; set; }
        public string DERNIER_UTILISATEUR { get; set; }
        public System.DateTime DATE_MODIFICATION { get; set; }
        public bool EST_SUPPRIME { get; set; }
        public Nullable<int> VALEURSPECIFIQUE { get; set; }
    
        public virtual ADMUTILISATEUR ADMUTILISATEUR { get; set; }
        public virtual GRC_GROUPE GRC_GROUPE { get; set; }
    }
}
