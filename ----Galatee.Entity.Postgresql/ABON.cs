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
    
    public partial class ABON
    {
        public ABON()
        {
            this.ANOMALIEFACTURATION = new HashSet<ANOMALIEFACTURATION>();
            this.CANALISATION = new HashSet<CANALISATION>();
            this.CTARCOMPPARPERIODE = new HashSet<CTARCOMPPARPERIODE>();
            this.EVENEMENT = new HashSet<EVENEMENT>();
            this.HISTORIQUE = new HashSet<HISTORIQUE>();
            this.PROFAC = new HashSet<PROFAC>();
            this.REDFAC = new HashSet<REDFAC>();
        }
    
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public string PRODUIT { get; set; }
        public string TYPETARIF { get; set; }
        public Nullable<decimal> PUISSANCE { get; set; }
        public string FORFAIT { get; set; }
        public string FORFPERSO { get; set; }
        public Nullable<decimal> AVANCE { get; set; }
        public Nullable<System.DateTime> DAVANCE { get; set; }
        public string REGROU { get; set; }
        public string PERFAC { get; set; }
        public string MOISFAC { get; set; }
        public Nullable<System.DateTime> DABONNEMENT { get; set; }
        public Nullable<System.DateTime> DRES { get; set; }
        public Nullable<System.DateTime> DATERACBRT { get; set; }
        public Nullable<int> NBFAC { get; set; }
        public string PERREL { get; set; }
        public string MOISREL { get; set; }
        public Nullable<System.DateTime> DMAJ { get; set; }
        public string RECU { get; set; }
        public Nullable<decimal> RISTOURNE { get; set; }
        public Nullable<int> CONSOMMATIONMAXI { get; set; }
        public string TYPECOMPTAGE { get; set; }
        public Nullable<int> FK_IDTYPECOMPTAGE { get; set; }
        public Nullable<bool> ISBORNEPOSTE { get; set; }
        public Nullable<int> COEFFAC { get; set; }
        public string USERCREATION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int FK_IDCLIENT { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDPRODUIT { get; set; }
        public Nullable<int> FK_IDFORFAIT { get; set; }
        public int FK_IDMOISREL { get; set; }
        public int FK_IDMOISFAC { get; set; }
        public int FK_IDTYPETARIF { get; set; }
        public int FK_IDPERIODICITEFACTURE { get; set; }
        public int FK_IDPERIODICITERELEVE { get; set; }
        public Nullable<bool> ESTEXONERETVA { get; set; }
        public string DEBUTEXONERATIONTVA { get; set; }
        public string FINEXONERATIONTVA { get; set; }
        public Nullable<int> NOMBREDEFOYER { get; set; }
    
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual CLIENT CLIENT1 { get; set; }
        public virtual DABON DABON { get; set; }
        public virtual FORFAIT FORFAIT1 { get; set; }
        public virtual MOIS MOIS { get; set; }
        public virtual MOIS MOIS1 { get; set; }
        public virtual PERIODICITE PERIODICITE { get; set; }
        public virtual PERIODICITE PERIODICITE1 { get; set; }
        public virtual PRODUIT PRODUIT1 { get; set; }
        public virtual TYPECOMPTAGE TYPECOMPTAGE1 { get; set; }
        public virtual TYPETARIF TYPETARIF1 { get; set; }
        public virtual ICollection<ANOMALIEFACTURATION> ANOMALIEFACTURATION { get; set; }
        public virtual ICollection<CANALISATION> CANALISATION { get; set; }
        public virtual ICollection<CTARCOMPPARPERIODE> CTARCOMPPARPERIODE { get; set; }
        public virtual ICollection<EVENEMENT> EVENEMENT { get; set; }
        public virtual ICollection<HISTORIQUE> HISTORIQUE { get; set; }
        public virtual ICollection<PROFAC> PROFAC { get; set; }
        public virtual ICollection<REDFAC> REDFAC { get; set; }
    }
}