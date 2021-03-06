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
    
    public partial class PRODUIT
    {
        public PRODUIT()
        {
            this.ABON = new HashSet<ABON>();
            this.ACTIVITEE_ORGANE = new HashSet<ACTIVITEE_ORGANE>();
            this.ANOMALIEFACTURATION = new HashSet<ANOMALIEFACTURATION>();
            this.BRT = new HashSet<BRT>();
            this.CALIBRECOMPTEUR = new HashSet<CALIBRECOMPTEUR>();
            this.CANALISATION = new HashSet<CANALISATION>();
            this.COMPTEUR = new HashSet<COMPTEUR>();
            this.COUTDEMANDE = new HashSet<COUTDEMANDE>();
            this.CTARCOMPPARPERIODE = new HashSet<CTARCOMPPARPERIODE>();
            this.DABON = new HashSet<DABON>();
            this.DBRT = new HashSet<DBRT>();
            this.DCANALISATION = new HashSet<DCANALISATION>();
            this.DCOMPTEUR = new HashSet<DCOMPTEUR>();
            this.DEFPARAMABON = new HashSet<DEFPARAMABON>();
            this.DEVENEMENT = new HashSet<DEVENEMENT>();
            this.EVENEMENT = new HashSet<EVENEMENT>();
            this.FERMABLE = new HashSet<FERMABLE>();
            this.FORFAIT = new HashSet<FORFAIT>();
            this.FOURNITURE = new HashSet<FOURNITURE>();
            this.HISTORIQUE = new HashSet<HISTORIQUE>();
            this.LOTRI = new HashSet<LOTRI>();
            this.MAGASINVIRTUEL = new HashSet<MAGASINVIRTUEL>();
            this.MARQUE_MODELE = new HashSet<MARQUE_MODELE>();
            this.MATERIELBRANCHEMENT = new HashSet<MATERIELBRANCHEMENT>();
            this.PAGERI = new HashSet<PAGERI>();
            this.PAGISOL = new HashSet<PAGISOL>();
            this.PARAMABONUTILISE = new HashSet<PARAMABONUTILISE>();
            this.PARAMETREBRANCHEMENT = new HashSet<PARAMETREBRANCHEMENT>();
            this.APPAREILRECENSE = new HashSet<APPAREILRECENSE>();
            this.APPAREILSUTILISE = new HashSet<APPAREILSUTILISE>();
            this.COMPTEURFRAUDE = new HashSet<COMPTEURFRAUDE>();
            this.CONSOMMATION = new HashSet<CONSOMMATION>();
            this.DETAILparPRESTATIONEDM = new HashSet<DETAILparPRESTATIONEDM>();
            this.DETAILparPRESTATIONREMBOURSABLE = new HashSet<DETAILparPRESTATIONREMBOURSABLE>();
            this.DETAILparREGULARISATION = new HashSet<DETAILparREGULARISATION>();
            this.DETAILparTRANCHE = new HashSet<DETAILparTRANCHE>();
            this.FACTUREFRAUDE = new HashSet<FACTUREFRAUDE>();
            this.MOISDEJAFACTURES = new HashSet<MOISDEJAFACTURES>();
            this.PRODUITCENTRE = new HashSet<PRODUITCENTRE>();
            this.PROFAC = new HashSet<PROFAC>();
            this.PUISSANCESOUSCRITE = new HashSet<PUISSANCESOUSCRITE>();
            this.PUISSANCEINSTALLEE = new HashSet<PUISSANCEINSTALLEE>();
            this.PUISSANCEPARREGLAGECOMPTEUR = new HashSet<PUISSANCEPARREGLAGECOMPTEUR>();
            this.RECLAMATION = new HashSet<RECLAMATION>();
            this.REDEVANCE = new HashSet<REDEVANCE>();
            this.REDFAC = new HashSet<REDFAC>();
            this.REGEXO = new HashSet<REGEXO>();
            this.REGLAGECOMPTEUR = new HashSet<REGLAGECOMPTEUR>();
            this.RUBRIQUEDEVIS = new HashSet<RUBRIQUEDEVIS>();
            this.TARIFFACTURATION = new HashSet<TARIFFACTURATION>();
            this.TbCompteurBTA = new HashSet<TbCompteurBTA>();
            this.TRANCHEFRAUDE = new HashSet<TRANCHEFRAUDE>();
            this.TRANSFERT = new HashSet<TRANSFERT>();
            this.TYPEBRANCHEMENTPARPRODUIT = new HashSet<TYPEBRANCHEMENTPARPRODUIT>();
            this.TYPECOMPTEUR = new HashSet<TYPECOMPTEUR>();
            this.TYPEDISJONCTEUR = new HashSet<TYPEDISJONCTEUR>();
            this.TYPEMATERIEL = new HashSet<TYPEMATERIEL>();
            this.TYPETARIF = new HashSet<TYPETARIF>();
            this.TYPETARIFPARREGLAGECOMPTEUR = new HashSet<TYPETARIFPARREGLAGECOMPTEUR>();
            this.VARIANTE = new HashSet<VARIANTE>();
            this.DEMANDE = new HashSet<DEMANDE>();
        }
    
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public Nullable<bool> ESTSUPPRIMER { get; set; }
    
        public virtual ICollection<ABON> ABON { get; set; }
        public virtual ICollection<ACTIVITEE_ORGANE> ACTIVITEE_ORGANE { get; set; }
        public virtual ICollection<ANOMALIEFACTURATION> ANOMALIEFACTURATION { get; set; }
        public virtual ICollection<BRT> BRT { get; set; }
        public virtual ICollection<CALIBRECOMPTEUR> CALIBRECOMPTEUR { get; set; }
        public virtual ICollection<CANALISATION> CANALISATION { get; set; }
        public virtual ICollection<COMPTEUR> COMPTEUR { get; set; }
        public virtual ICollection<COUTDEMANDE> COUTDEMANDE { get; set; }
        public virtual ICollection<CTARCOMPPARPERIODE> CTARCOMPPARPERIODE { get; set; }
        public virtual ICollection<DABON> DABON { get; set; }
        public virtual ICollection<DBRT> DBRT { get; set; }
        public virtual ICollection<DCANALISATION> DCANALISATION { get; set; }
        public virtual ICollection<DCOMPTEUR> DCOMPTEUR { get; set; }
        public virtual ICollection<DEFPARAMABON> DEFPARAMABON { get; set; }
        public virtual ICollection<DEVENEMENT> DEVENEMENT { get; set; }
        public virtual ICollection<EVENEMENT> EVENEMENT { get; set; }
        public virtual ICollection<FERMABLE> FERMABLE { get; set; }
        public virtual ICollection<FORFAIT> FORFAIT { get; set; }
        public virtual ICollection<FOURNITURE> FOURNITURE { get; set; }
        public virtual ICollection<HISTORIQUE> HISTORIQUE { get; set; }
        public virtual ICollection<LOTRI> LOTRI { get; set; }
        public virtual ICollection<MAGASINVIRTUEL> MAGASINVIRTUEL { get; set; }
        public virtual ICollection<MARQUE_MODELE> MARQUE_MODELE { get; set; }
        public virtual ICollection<MATERIELBRANCHEMENT> MATERIELBRANCHEMENT { get; set; }
        public virtual ICollection<PAGERI> PAGERI { get; set; }
        public virtual ICollection<PAGISOL> PAGISOL { get; set; }
        public virtual ICollection<PARAMABONUTILISE> PARAMABONUTILISE { get; set; }
        public virtual ICollection<PARAMETREBRANCHEMENT> PARAMETREBRANCHEMENT { get; set; }
        public virtual ICollection<APPAREILRECENSE> APPAREILRECENSE { get; set; }
        public virtual ICollection<APPAREILSUTILISE> APPAREILSUTILISE { get; set; }
        public virtual ICollection<COMPTEURFRAUDE> COMPTEURFRAUDE { get; set; }
        public virtual ICollection<CONSOMMATION> CONSOMMATION { get; set; }
        public virtual ICollection<DETAILparPRESTATIONEDM> DETAILparPRESTATIONEDM { get; set; }
        public virtual ICollection<DETAILparPRESTATIONREMBOURSABLE> DETAILparPRESTATIONREMBOURSABLE { get; set; }
        public virtual ICollection<DETAILparREGULARISATION> DETAILparREGULARISATION { get; set; }
        public virtual ICollection<DETAILparTRANCHE> DETAILparTRANCHE { get; set; }
        public virtual ICollection<FACTUREFRAUDE> FACTUREFRAUDE { get; set; }
        public virtual ICollection<MOISDEJAFACTURES> MOISDEJAFACTURES { get; set; }
        public virtual ICollection<PRODUITCENTRE> PRODUITCENTRE { get; set; }
        public virtual ICollection<PROFAC> PROFAC { get; set; }
        public virtual ICollection<PUISSANCESOUSCRITE> PUISSANCESOUSCRITE { get; set; }
        public virtual ICollection<PUISSANCEINSTALLEE> PUISSANCEINSTALLEE { get; set; }
        public virtual ICollection<PUISSANCEPARREGLAGECOMPTEUR> PUISSANCEPARREGLAGECOMPTEUR { get; set; }
        public virtual ICollection<RECLAMATION> RECLAMATION { get; set; }
        public virtual ICollection<REDEVANCE> REDEVANCE { get; set; }
        public virtual ICollection<REDFAC> REDFAC { get; set; }
        public virtual ICollection<REGEXO> REGEXO { get; set; }
        public virtual ICollection<REGLAGECOMPTEUR> REGLAGECOMPTEUR { get; set; }
        public virtual ICollection<RUBRIQUEDEVIS> RUBRIQUEDEVIS { get; set; }
        public virtual ICollection<TARIFFACTURATION> TARIFFACTURATION { get; set; }
        public virtual ICollection<TbCompteurBTA> TbCompteurBTA { get; set; }
        public virtual ICollection<TRANCHEFRAUDE> TRANCHEFRAUDE { get; set; }
        public virtual ICollection<TRANSFERT> TRANSFERT { get; set; }
        public virtual ICollection<TYPEBRANCHEMENTPARPRODUIT> TYPEBRANCHEMENTPARPRODUIT { get; set; }
        public virtual ICollection<TYPECOMPTEUR> TYPECOMPTEUR { get; set; }
        public virtual ICollection<TYPEDISJONCTEUR> TYPEDISJONCTEUR { get; set; }
        public virtual ICollection<TYPEMATERIEL> TYPEMATERIEL { get; set; }
        public virtual ICollection<TYPETARIF> TYPETARIF { get; set; }
        public virtual ICollection<TYPETARIFPARREGLAGECOMPTEUR> TYPETARIFPARREGLAGECOMPTEUR { get; set; }
        public virtual ICollection<VARIANTE> VARIANTE { get; set; }
        public virtual ICollection<DEMANDE> DEMANDE { get; set; }
    }
}
