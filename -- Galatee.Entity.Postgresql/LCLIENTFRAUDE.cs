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
    
    public partial class LCLIENTFRAUDE
    {
        public LCLIENTFRAUDE()
        {
            this.TRANSCAISBFRAUDE = new HashSet<TRANSCAISBFRAUDE>();
            this.TRANSCAISBFRAUDE1 = new HashSet<TRANSCAISBFRAUDE>();
            this.TRANSCAISSEFRAUDE = new HashSet<TRANSCAISSEFRAUDE>();
            this.TRANSCAISSEFRAUDE1 = new HashSet<TRANSCAISSEFRAUDE>();
        }
    
        public int PK_ID { get; set; }
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public string REFEM { get; set; }
        public string NDOC { get; set; }
        public string NATURE { get; set; }
        public string COPER { get; set; }
        public Nullable<System.DateTime> DENR { get; set; }
        public Nullable<int> EXIG { get; set; }
        public Nullable<decimal> MONTANT { get; set; }
        public string CAPUR { get; set; }
        public string CRET { get; set; }
        public string MODEREG { get; set; }
        public string DC { get; set; }
        public string ORIGINE { get; set; }
        public string CAISSE { get; set; }
        public Nullable<decimal> ECART { get; set; }
        public string MOISCOMPT { get; set; }
        public string TOP1 { get; set; }
        public Nullable<System.DateTime> EXIGIBILITE { get; set; }
        public Nullable<decimal> FRAISDERETARD { get; set; }
        public Nullable<int> REFERENCEPUPITRE { get; set; }
        public Nullable<int> IDLOT { get; set; }
        public Nullable<System.DateTime> DATEVALEUR { get; set; }
        public string REFERENCE { get; set; }
        public string REFEMNDOC { get; set; }
        public string ACQUIT { get; set; }
        public string MATRICULE { get; set; }
        public Nullable<decimal> TAXESADEDUIRE { get; set; }
        public Nullable<System.DateTime> DATEFLAG { get; set; }
        public Nullable<decimal> MONTANTTVA { get; set; }
        public string IDCOUPURE { get; set; }
        public string AGENT_COUPURE { get; set; }
        public Nullable<System.DateTime> RDV_COUPURE { get; set; }
        public string NUMCHEQ { get; set; }
        public string OBSERVATION_COUPURE { get; set; }
        public string USERCREATION { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public string BANQUE { get; set; }
        public string GUICHET { get; set; }
        public Nullable<int> FK_IDCENTRE { get; set; }
        public Nullable<int> FK_IDNATURE { get; set; }
        public Nullable<int> FK_IDADMUTILISATEUR { get; set; }
        public Nullable<int> FK_IDCOPER { get; set; }
        public Nullable<int> FK_IDLIBELLETOP { get; set; }
        public Nullable<int> FK_IDCLIENTFRAUDE { get; set; }
        public Nullable<int> FK_IDPOSTE { get; set; }
        public string POSTE { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> ISNONENCAISSABLE { get; set; }
        public Nullable<int> FK_IDMORATOIRE { get; set; }
        public Nullable<int> FK_IDMOTIFCHEQUEINPAYE { get; set; }
    
        public virtual ADMUTILISATEUR ADMUTILISATEUR { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual COPER COPER1 { get; set; }
        public virtual LIBELLETOP LIBELLETOP { get; set; }
        public virtual MORATOIRE MORATOIRE { get; set; }
        public virtual MOTIFCHEQUEIMPAYE MOTIFCHEQUEIMPAYE { get; set; }
        public virtual CLIENTFRAUDE CLIENTFRAUDE { get; set; }
        public virtual FACTUREFRAUDE FACTUREFRAUDE { get; set; }
        public virtual ICollection<TRANSCAISBFRAUDE> TRANSCAISBFRAUDE { get; set; }
        public virtual ICollection<TRANSCAISBFRAUDE> TRANSCAISBFRAUDE1 { get; set; }
        public virtual ICollection<TRANSCAISSEFRAUDE> TRANSCAISSEFRAUDE { get; set; }
        public virtual ICollection<TRANSCAISSEFRAUDE> TRANSCAISSEFRAUDE1 { get; set; }
    }
}
