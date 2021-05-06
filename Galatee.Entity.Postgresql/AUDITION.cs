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
    
    public partial class AUDITION
    {
        public AUDITION()
        {
            this.APPAREILSUTILISE = new HashSet<APPAREILSUTILISE>();
        }
    
        public int PK_ID { get; set; }
        public System.DateTime DateRendezVous { get; set; }
        public Nullable<System.DateTime> DateAudition { get; set; }
        public string NomRepondant { get; set; }
        public string QualiteRepondant { get; set; }
        public Nullable<bool> IsProprietaire { get; set; }
        public Nullable<bool> IsMaisonHabitee { get; set; }
        public Nullable<int> NombreHabitant { get; set; }
        public Nullable<bool> IsDejaDepanne { get; set; }
        public string MotifDepannage { get; set; }
        public Nullable<bool> IsDejaPenaliseSurCompteur { get; set; }
        public Nullable<bool> IsFacturePenaliteDejaRecue { get; set; }
        public Nullable<bool> IsDemandeVerificationDejaEmise { get; set; }
        public Nullable<bool> IsAccuseReceptionDemande { get; set; }
        public Nullable<bool> IsCertificatPlombageRecu { get; set; }
        public Nullable<bool> IsNewAppareilAcquis { get; set; }
        public Nullable<System.Guid> FK_IDPROCESVERBALSCANNE { get; set; }
        public int FK_IDFRAUDE { get; set; }
    
        public virtual DOCUMENTSCANNE DOCUMENTSCANNE { get; set; }
        public virtual ICollection<APPAREILSUTILISE> APPAREILSUTILISE { get; set; }
        public virtual FRAUDE FRAUDE { get; set; }
    }
}
