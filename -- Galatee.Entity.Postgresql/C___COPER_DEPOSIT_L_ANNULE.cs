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
    
    public partial class C___COPER_DEPOSIT_L_ANNULE
    {
        public int PK_ID { get; set; }
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public string REFEM { get; set; }
        public string NDOC { get; set; }
        public string COPER { get; set; }
        public System.DateTime DENR { get; set; }
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
        public int FK_IDCENTRE { get; set; }
        public Nullable<int> FK_IDADMUTILISATEUR { get; set; }
        public int FK_IDCOPER { get; set; }
        public int FK_IDLIBELLETOP { get; set; }
        public int FK_IDCLIENT { get; set; }
        public Nullable<int> FK_IDPOSTE { get; set; }
        public string POSTE { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> ISNONENCAISSABLE { get; set; }
        public Nullable<bool> ESTSYNCHRONISE { get; set; }
        public Nullable<int> FK_IDMORATOIRE { get; set; }
        public Nullable<int> FK_IDMOTIFCHEQUEINPAYE { get; set; }
    }
}
