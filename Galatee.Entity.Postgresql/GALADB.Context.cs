﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class galadbEntities : DbContext
    {
        public galadbEntities()
            : base("name=galadbEntities")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 1200;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C____ZEG_OM_LETTRE_L> C____ZEG_OM_LETTRE_L { get; set; }
        public DbSet<C____ZEG_OM_LETTRE_T> C____ZEG_OM_LETTRE_T { get; set; }
        public DbSet<C___COPER_110_ANNULE> C___COPER_110_ANNULE { get; set; }
        public DbSet<C___COPER_120_ANNULE> C___COPER_120_ANNULE { get; set; }
        public DbSet<C___COPER_DEPOSIT_L_ANNULE> C___COPER_DEPOSIT_L_ANNULE { get; set; }
        public DbSet<C___COPER_DEPOSIT_T_ANNULE> C___COPER_DEPOSIT_T_ANNULE { get; set; }
        public DbSet<C___DOUBLON> C___DOUBLON { get; set; }
        public DbSet<C__depose_bt> C__depose_bt { get; set; }
        public DbSet<C__depose_fle> C__depose_fle { get; set; }
        public DbSet<C__depose_mt> C__depose_mt { get; set; }
        public DbSet<C__moi> C__moi { get; set; }
        public DbSet<C__zeg_110> C__zeg_110 { get; set; }
        public DbSet<C_a_a_2008_traiter> C_a_a_2008_traiter { get; set; }
        public DbSet<C_a_a_2009_traiter> C_a_a_2009_traiter { get; set; }
        public DbSet<C_a_a_201608> C_a_a_201608 { get; set; }
        public DbSet<C_a_a_201609> C_a_a_201609 { get; set; }
        public DbSet<C_a_a_a> C_a_a_a { get; set; }
        public DbSet<C_a_a_compteur_isago_a_mettre> C_a_a_compteur_isago_a_mettre { get; set; }
        public DbSet<C_a_a_compteur_isago_exist> C_a_a_compteur_isago_exist { get; set; }
        public DbSet<C_A_MIG_FROM_TRANSCAISB_DEPOSIT_LCLIENT> C_A_MIG_FROM_TRANSCAISB_DEPOSIT_LCLIENT { get; set; }
        public DbSet<C_A_MIG_FROM_TRANSCAISB_FLE> C_A_MIG_FROM_TRANSCAISB_FLE { get; set; }
        public DbSet<C_A_MIG_FROM_TRANSCAISB_SCA_BT> C_A_MIG_FROM_TRANSCAISB_SCA_BT { get; set; }
        public DbSet<C_A_MIG_FROM_TRANSCAISB_SCA_MT> C_A_MIG_FROM_TRANSCAISB_SCA_MT { get; set; }
        public DbSet<C_aa_zeg> C_aa_zeg { get; set; }
        public DbSet<C_DCANALISATION_fle> C_DCANALISATION_fle { get; set; }
        public DbSet<C_NUMEROTATION_COMPTEUR> C_NUMEROTATION_COMPTEUR { get; set; }
        public DbSet<C_REJET_BRT> C_REJET_BRT { get; set; }
        public DbSet<C_UNICITE_POINT> C_UNICITE_POINT { get; set; }
        public DbSet<ABON> ABON { get; set; }
        public DbSet<abonNonFact> abonNonFact { get; set; }
        public DbSet<ACTION> ACTION { get; set; }
        public DbSet<ACTIONFACTURATION> ACTIONFACTURATION { get; set; }
        public DbSet<ACTIVITEE_ORGANE> ACTIVITEE_ORGANE { get; set; }
        public DbSet<ACTIVITEE_TERRAIN> ACTIVITEE_TERRAIN { get; set; }
        public DbSet<ADMHISTORIQUECONNECTION> ADMHISTORIQUECONNECTION { get; set; }
        public DbSet<ADMHISTORIQUEPASSWORD> ADMHISTORIQUEPASSWORD { get; set; }
        public DbSet<ADMINISTRATION_INSTITUT> ADMINISTRATION_INSTITUT { get; set; }
        public DbSet<ADMMENU> ADMMENU { get; set; }
        public DbSet<ADMSTATUSCOMPTE> ADMSTATUSCOMPTE { get; set; }
        public DbSet<ADMSTRATEGIESECURITE> ADMSTRATEGIESECURITE { get; set; }
        public DbSet<ADMUTILISATEUR> ADMUTILISATEUR { get; set; }
        public DbSet<AFFECTATIONGESTIONAIRE> AFFECTATIONGESTIONAIRE { get; set; }
        public DbSet<AG> AG { get; set; }
        public DbSet<AGENCEBANQUE> AGENCEBANQUE { get; set; }
        public DbSet<AGENT> AGENT { get; set; }
        public DbSet<AJUFIN> AJUFIN { get; set; }
        public DbSet<ANNUL> ANNUL { get; set; }
        public DbSet<ANOMALIEFACTURATION> ANOMALIEFACTURATION { get; set; }
        public DbSet<APPAREILS> APPAREILS { get; set; }
        public DbSet<APPAREILSDEVIS> APPAREILSDEVIS { get; set; }
        public DbSet<APPLICATIONTAXE> APPLICATIONTAXE { get; set; }
        public DbSet<ARRETE> ARRETE { get; set; }
        public DbSet<AUTRECLIENTPRECONTENCIEUX> AUTRECLIENTPRECONTENCIEUX { get; set; }
        public DbSet<BANQUE> BANQUE { get; set; }
        public DbSet<BRT> BRT { get; set; }
        public DbSet<CAISSE> CAISSE { get; set; }
        public DbSet<CALIBRECOMPTEUR> CALIBRECOMPTEUR { get; set; }
        public DbSet<CAMPAGNE> CAMPAGNE { get; set; }
        public DbSet<CAMPAGNEGC> CAMPAGNEGC { get; set; }
        public DbSet<CAMPAGNEPRECONTENTIEUX> CAMPAGNEPRECONTENTIEUX { get; set; }
        public DbSet<CAMPAGNESGC> CAMPAGNESGC { get; set; }
        public DbSet<CANALISATION> CANALISATION { get; set; }
        public DbSet<CASIND> CASIND { get; set; }
        public DbSet<CATEGORIEBRANCHEMENT> CATEGORIEBRANCHEMENT { get; set; }
        public DbSet<CATEGORIECLIENT> CATEGORIECLIENT { get; set; }
        public DbSet<CATEGORIECLIENT_TYPECLIENT> CATEGORIECLIENT_TYPECLIENT { get; set; }
        public DbSet<CATEGORIECLIENT_USAGE> CATEGORIECLIENT_USAGE { get; set; }
        public DbSet<CELLULEDUSIEGE> CELLULEDUSIEGE { get; set; }
        public DbSet<CENTRE> CENTRE { get; set; }
        public DbSet<CENTREAFFECTATION> CENTREAFFECTATION { get; set; }
        public DbSet<CENTREDUPOSTESOURCE> CENTREDUPOSTESOURCE { get; set; }
        public DbSet<CENTREDUPOSTETRANSFORMATION> CENTREDUPOSTETRANSFORMATION { get; set; }
        public DbSet<CENTREDUPROFIL> CENTREDUPROFIL { get; set; }
        public DbSet<CLIENT> CLIENT { get; set; }
        public DbSet<CODECONSOMMATEUR> CODECONSOMMATEUR { get; set; }
        public DbSet<CODECONTROLE> CODECONTROLE { get; set; }
        public DbSet<COMMUNE> COMMUNE { get; set; }
        public DbSet<COMMUNEGROUPEDEPANNAGE> COMMUNEGROUPEDEPANNAGE { get; set; }
        public DbSet<COMPTA_BANQUECENTRE> COMPTA_BANQUECENTRE { get; set; }
        public DbSet<COMPTA_CENTRE> COMPTA_CENTRE { get; set; }
        public DbSet<COMPTA_COMPTE_SPECIFIQUE> COMPTA_COMPTE_SPECIFIQUE { get; set; }
        public DbSet<COMPTA_ECRITURECOMPTABLE> COMPTA_ECRITURECOMPTABLE { get; set; }
        public DbSet<COMPTA_OPERATIONCOMPTABLE> COMPTA_OPERATIONCOMPTABLE { get; set; }
        public DbSet<COMPTA_TYPE_COMPTE> COMPTA_TYPE_COMPTE { get; set; }
        public DbSet<COMPTEUR> COMPTEUR { get; set; }
        public DbSet<CONTENANTCRITERETARIF> CONTENANTCRITERETARIF { get; set; }
        public DbSet<CONTROLETRAVAUX> CONTROLETRAVAUX { get; set; }
        public DbSet<COPER> COPER { get; set; }
        public DbSet<COPEROD> COPEROD { get; set; }
        public DbSet<COUTDEMANDE> COUTDEMANDE { get; set; }
        public DbSet<CTARCOMP> CTARCOMP { get; set; }
        public DbSet<CTARCOMPPARPERIODE> CTARCOMPPARPERIODE { get; set; }
        public DbSet<DABON> DABON { get; set; }
        public DbSet<DADMINISTRATION_INSTITUT> DADMINISTRATION_INSTITUT { get; set; }
        public DbSet<DAG> DAG { get; set; }
        public DbSet<DANNOTATION> DANNOTATION { get; set; }
        public DbSet<DATA1CTARCOMP> DATA1CTARCOMP { get; set; }
        public DbSet<DAUTORISATIONCAISSE> DAUTORISATIONCAISSE { get; set; }
        public DbSet<DBRT> DBRT { get; set; }
        public DbSet<DCANALISATION> DCANALISATION { get; set; }
        public DbSet<DCLIENT> DCLIENT { get; set; }
        public DbSet<DCOMPTEUR> DCOMPTEUR { get; set; }
        public DbSet<DECHARGEPRECONTENSIEUX> DECHARGEPRECONTENSIEUX { get; set; }
        public DbSet<DEFPARAMABON> DEFPARAMABON { get; set; }
        public DbSet<DEMANDEANNULATION> DEMANDEANNULATION { get; set; }
        public DbSet<DENOMINATION> DENOMINATION { get; set; }
        public DbSet<DEPANNAGE> DEPANNAGE { get; set; }
        public DbSet<DEPARTHTA> DEPARTHTA { get; set; }
        public DbSet<DEPOSIT> DEPOSIT { get; set; }
        public DbSet<DETAILCAMPAGNE> DETAILCAMPAGNE { get; set; }
        public DbSet<DETAILCAMPAGNEGC> DETAILCAMPAGNEGC { get; set; }
        public DbSet<DETAILCAMPAGNEPRENCONTENTIEUX> DETAILCAMPAGNEPRENCONTENTIEUX { get; set; }
        public DbSet<DETAILCAMPAGNESGC> DETAILCAMPAGNESGC { get; set; }
        public DbSet<DETAILMANDATEMENTGC> DETAILMANDATEMENTGC { get; set; }
        public DbSet<DETAILMORATOIRE> DETAILMORATOIRE { get; set; }
        public DbSet<DETAILPAIEMENTCAMPAGNEGC> DETAILPAIEMENTCAMPAGNEGC { get; set; }
        public DbSet<DETAILTARIFFACTURATION> DETAILTARIFFACTURATION { get; set; }
        public DbSet<DETAILTARIFFACTURATION1> DETAILTARIFFACTURATION1 { get; set; }
        public DbSet<DEVENEMENT> DEVENEMENT { get; set; }
        public DbSet<DINFOPROPRIETAIRE> DINFOPROPRIETAIRE { get; set; }
        public DbSet<DOCUMENTSCANNE> DOCUMENTSCANNE { get; set; }
        public DbSet<DOMBANC> DOMBANC { get; set; }
        public DbSet<DORDRETRAVAIL> DORDRETRAVAIL { get; set; }
        public DbSet<DPERSONNEPHYSIQUE> DPERSONNEPHYSIQUE { get; set; }
        public DbSet<DSCELLE> DSCELLE { get; set; }
        public DbSet<DSOCIETEPRIVE> DSOCIETEPRIVE { get; set; }
        public DbSet<DTRANSFERT> DTRANSFERT { get; set; }
        public DbSet<EchecIsole> EchecIsole { get; set; }
        public DbSet<ELEMENTACHATTIMBRE> ELEMENTACHATTIMBRE { get; set; }
        public DbSet<ELEMENTDEVIS> ELEMENTDEVIS { get; set; }
        public DbSet<ENTFAC> ENTFAC { get; set; }
        public DbSet<ENTREPRISE> ENTREPRISE { get; set; }
        public DbSet<ETAPEDEMANDE> ETAPEDEMANDE { get; set; }
        public DbSet<ETATCOMPTEUR> ETATCOMPTEUR { get; set; }
        public DbSet<EVENEMENT> EVENEMENT { get; set; }
        public DbSet<FERMABLE> FERMABLE { get; set; }
        public DbSet<FONCTION> FONCTION { get; set; }
        public DbSet<FORFAIT> FORFAIT { get; set; }
        public DbSet<FOURNITURE> FOURNITURE { get; set; }
        public DbSet<FRAISTIMBRE> FRAISTIMBRE { get; set; }
        public DbSet<FRAIXPARICIPATIONDEVIS> FRAIXPARICIPATIONDEVIS { get; set; }
        public DbSet<FREQUENCE> FREQUENCE { get; set; }
        public DbSet<GEOGES> GEOGES { get; set; }
        public DbSet<GROUPERECLAMATION> GROUPERECLAMATION { get; set; }
        public DbSet<GROUPPROGRAM> GROUPPROGRAM { get; set; }
        public DbSet<HABILITATIONCAISSE> HABILITATIONCAISSE { get; set; }
        public DbSet<HISTORIQUE> HISTORIQUE { get; set; }
        public DbSet<HISTORIQUE_CONNECTION> HISTORIQUE_CONNECTION { get; set; }
        public DbSet<IMPORTCOLONNE> IMPORTCOLONNE { get; set; }
        public DbSet<INDEXCAMPAGNE> INDEXCAMPAGNE { get; set; }
        public DbSet<INDEXCAMPAGNESGC> INDEXCAMPAGNESGC { get; set; }
        public DbSet<INFOPROPRIETAIRE> INFOPROPRIETAIRE { get; set; }
        public DbSet<INTERVENTIONPLANNIFIEE> INTERVENTIONPLANNIFIEE { get; set; }
        public DbSet<LCLIENT> LCLIENT { get; set; }
        public DbSet<LIBELLEACTIONFACTURATION> LIBELLEACTIONFACTURATION { get; set; }
        public DbSet<LIBELLETOP> LIBELLETOP { get; set; }
        public DbSet<LIENREDEVANCE> LIENREDEVANCE { get; set; }
        public DbSet<LOCALISATION> LOCALISATION { get; set; }
        public DbSet<LOTRI> LOTRI { get; set; }
        public DbSet<MAGASINVIRTUEL> MAGASINVIRTUEL { get; set; }
        public DbSet<MANDATEMENTGC> MANDATEMENTGC { get; set; }
        public DbSet<MARQUE_MODELE> MARQUE_MODELE { get; set; }
        public DbSet<MARQUECOMPTEUR> MARQUECOMPTEUR { get; set; }
        public DbSet<MARQUETRANSFORMATEUR> MARQUETRANSFORMATEUR { get; set; }
        public DbSet<MATERIELBRANCHEMENT> MATERIELBRANCHEMENT { get; set; }
        public DbSet<MATERIELDEVIS> MATERIELDEVIS { get; set; }
        public DbSet<MAUVAISPAYEUR> MAUVAISPAYEUR { get; set; }
        public DbSet<MENUSDUPROFIL> MENUSDUPROFIL { get; set; }
        public DbSet<MESSAGE> MESSAGE { get; set; }
        public DbSet<MODEAPPLICATIONTARIF> MODEAPPLICATIONTARIF { get; set; }
        public DbSet<MODECALCUL> MODECALCUL { get; set; }
        public DbSet<MODELE> MODELE { get; set; }
        public DbSet<MODEPAIEMENT> MODEPAIEMENT { get; set; }
        public DbSet<MODERECEPTION> MODERECEPTION { get; set; }
        public DbSet<MODEREG> MODEREG { get; set; }
        public DbSet<MODULE> MODULE { get; set; }
        public DbSet<MODULESDEFONCTION> MODULESDEFONCTION { get; set; }
        public DbSet<MOIS> MOIS { get; set; }
        public DbSet<MONNAIE> MONNAIE { get; set; }
        public DbSet<MORATOIRE> MORATOIRE { get; set; }
        public DbSet<MOTIFCHEQUEIMPAYE> MOTIFCHEQUEIMPAYE { get; set; }
        public DbSet<NATGEN> NATGEN { get; set; }
        public DbSet<NATIONALITE> NATIONALITE { get; set; }
        public DbSet<NIVEAUTARIF> NIVEAUTARIF { get; set; }
        public DbSet<NOTIFICATION> NOTIFICATION { get; set; }
        public DbSet<NUMEROINSTALLATION> NUMEROINSTALLATION { get; set; }
        public DbSet<OBSERVATION> OBSERVATION { get; set; }
        public DbSet<OPENINGDAY> OPENINGDAY { get; set; }
        public DbSet<ORGANE_SCELLABLE> ORGANE_SCELLABLE { get; set; }
        public DbSet<ORIGINELOT> ORIGINELOT { get; set; }
        public DbSet<PAGERI> PAGERI { get; set; }
        public DbSet<PAGISOL> PAGISOL { get; set; }
        public DbSet<PAIEMENTCAMPAGNEGC> PAIEMENTCAMPAGNEGC { get; set; }
        public DbSet<PARAMABONUTILISE> PARAMABONUTILISE { get; set; }
        public DbSet<PARAMETRAGEIMPORT> PARAMETRAGEIMPORT { get; set; }
        public DbSet<PARAMETREBRANCHEMENT> PARAMETREBRANCHEMENT { get; set; }
        public DbSet<PARAMETRECOUPURESGC> PARAMETRECOUPURESGC { get; set; }
        public DbSet<PARAMETREEVENEMENT> PARAMETREEVENEMENT { get; set; }
        public DbSet<PARAMETRESGENERAUX> PARAMETRESGENERAUX { get; set; }
        public DbSet<PARAMETRESMTP> PARAMETRESMTP { get; set; }
        public DbSet<PAYEUR> PAYEUR { get; set; }
        public DbSet<PERIODICITE> PERIODICITE { get; set; }
        public DbSet<PERSONNEPHYSIQUE> PERSONNEPHYSIQUE { get; set; }
        public DbSet<PHASECOMPTEUR> PHASECOMPTEUR { get; set; }
        public DbSet<PIECEIDENTITE> PIECEIDENTITE { get; set; }
        public DbSet<POSE_SCELLE_DEMANDE> POSE_SCELLE_DEMANDE { get; set; }
        public DbSet<POSTECLIENT> POSTECLIENT { get; set; }
        public DbSet<POSTESOURCE> POSTESOURCE { get; set; }
        public DbSet<POSTETRANSFORMATION> POSTETRANSFORMATION { get; set; }
        public DbSet<PRESTATAIRE> PRESTATAIRE { get; set; }
        public DbSet<PRODUIT> PRODUIT { get; set; }
        public DbSet<PRODUITCENTRE> PRODUITCENTRE { get; set; }
        public DbSet<PROFAC> PROFAC { get; set; }
        public DbSet<PROFIL> PROFIL { get; set; }
        public DbSet<PROFILSUTILISATEUR> PROFILSUTILISATEUR { get; set; }
        public DbSet<PROGRAM> PROGRAM { get; set; }
        public DbSet<PROGRAMMATION> PROGRAMMATION { get; set; }
        public DbSet<PROGRAMMATION1> PROGRAMMATION1 { get; set; }
        public DbSet<PROPRIETAIRE> PROPRIETAIRE { get; set; }
        public DbSet<PUISSANCEINSTALLEE> PUISSANCEINSTALLEE { get; set; }
        public DbSet<PUISSANCEPARREGLAGECOMPTEUR> PUISSANCEPARREGLAGECOMPTEUR { get; set; }
        public DbSet<PUISSANCESOUSCRITE> PUISSANCESOUSCRITE { get; set; }
        public DbSet<QUARTIER> QUARTIER { get; set; }
        public DbSet<RECHERCHETARIF> RECHERCHETARIF { get; set; }
        public DbSet<RECLAMATION> RECLAMATION { get; set; }
        public DbSet<REDEVANCE> REDEVANCE { get; set; }
        public DbSet<REDFAC> REDFAC { get; set; }
        public DbSet<REGEXO> REGEXO { get; set; }
        public DbSet<REGLAGECOMPTEUR> REGLAGECOMPTEUR { get; set; }
        public DbSet<REGROUPEMENT> REGROUPEMENT { get; set; }
        public DbSet<RELANCE> RELANCE { get; set; }
        public DbSet<REVERSEMENTCAISSE> REVERSEMENTCAISSE { get; set; }
        public DbSet<RUBRIQUEDEMANDE> RUBRIQUEDEMANDE { get; set; }
        public DbSet<RUBRIQUEDEVIS> RUBRIQUEDEVIS { get; set; }
        public DbSet<RUES> RUES { get; set; }
        public DbSet<SCELLE> SCELLE { get; set; }
        public DbSet<SECTEUR> SECTEUR { get; set; }
        public DbSet<SECTEURACTIVITE> SECTEURACTIVITE { get; set; }
        public DbSet<SITE> SITE { get; set; }
        public DbSet<SMS> SMS { get; set; }
        public DbSet<SOCIETEPRIVE> SOCIETEPRIVE { get; set; }
        public DbSet<SORTIEAUTREMATERIEL> SORTIEAUTREMATERIEL { get; set; }
        public DbSet<SORTIECOMPTEUR> SORTIECOMPTEUR { get; set; }
        public DbSet<SORTIEMATERIEL> SORTIEMATERIEL { get; set; }
        public DbSet<STATUTCOMPTEUR> STATUTCOMPTEUR { get; set; }
        public DbSet<STATUTJURIQUE> STATUTJURIQUE { get; set; }
        public DbSet<STATUTRECLAMATION> STATUTRECLAMATION { get; set; }
        public DbSet<STATUTTRANSFERT> STATUTTRANSFERT { get; set; }
        public DbSet<SUIVIDEMANDE> SUIVIDEMANDE { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TARIFFACTURATION> TARIFFACTURATION { get; set; }
        public DbSet<TAXCOMP> TAXCOMP { get; set; }
        public DbSet<TAXE> TAXE { get; set; }
        public DbSet<TEMPENTFAC> TEMPENTFAC { get; set; }
        public DbSet<TOURNEE> TOURNEE { get; set; }
        public DbSet<TOURNEEPIA> TOURNEEPIA { get; set; }
        public DbSet<TOURNEERELEVEUR> TOURNEERELEVEUR { get; set; }
        public DbSet<TRANCHEREDEVANCE> TRANCHEREDEVANCE { get; set; }
        public DbSet<TRANSCAISB> TRANSCAISB { get; set; }
        public DbSet<TRANSCAISSE> TRANSCAISSE { get; set; }
        public DbSet<TRANSFERT> TRANSFERT { get; set; }
        public DbSet<TRANSFORMATEUR> TRANSFORMATEUR { get; set; }
        public DbSet<TRAVAUXDEVIS> TRAVAUXDEVIS { get; set; }
        public DbSet<TYPEBRANCHEMENT> TYPEBRANCHEMENT { get; set; }
        public DbSet<TYPEBRANCHEMENTPARPRODUIT> TYPEBRANCHEMENTPARPRODUIT { get; set; }
        public DbSet<TYPECENTRE> TYPECENTRE { get; set; }
        public DbSet<TYPECLIENT> TYPECLIENT { get; set; }
        public DbSet<TYPECOMPTAGE> TYPECOMPTAGE { get; set; }
        public DbSet<TYPECOMPTEUR> TYPECOMPTEUR { get; set; }
        public DbSet<TYPECOMPTEURCOMPTAGE> TYPECOMPTEURCOMPTAGE { get; set; }
        public DbSet<TYPECONTROLE> TYPECONTROLE { get; set; }
        public DbSet<TYPECOUPURE> TYPECOUPURE { get; set; }
        public DbSet<TYPEDEMANDE> TYPEDEMANDE { get; set; }
        public DbSet<TYPEDISJONCTEUR> TYPEDISJONCTEUR { get; set; }
        public DbSet<TYPEDISJONCTEURPARCALIBRECOMPTEUR> TYPEDISJONCTEURPARCALIBRECOMPTEUR { get; set; }
        public DbSet<TYPEDOCUMENT> TYPEDOCUMENT { get; set; }
        public DbSet<TYPEFACTURATION> TYPEFACTURATION { get; set; }
        public DbSet<TYPELIENPRODUIT> TYPELIENPRODUIT { get; set; }
        public DbSet<TYPELIENREDEVANCE> TYPELIENREDEVANCE { get; set; }
        public DbSet<TYPELOT> TYPELOT { get; set; }
        public DbSet<TYPEMATERIEL> TYPEMATERIEL { get; set; }
        public DbSet<TYPEMESSAGE> TYPEMESSAGE { get; set; }
        public DbSet<TYPENOTIFICATION> TYPENOTIFICATION { get; set; }
        public DbSet<TYPERECLAMATION> TYPERECLAMATION { get; set; }
        public DbSet<TYPEREDEVANCE> TYPEREDEVANCE { get; set; }
        public DbSet<TYPETARIF> TYPETARIF { get; set; }
        public DbSet<TYPETARIFPARCATEGORIE> TYPETARIFPARCATEGORIE { get; set; }
        public DbSet<TYPETARIFPARREGLAGECOMPTEUR> TYPETARIFPARREGLAGECOMPTEUR { get; set; }
        public DbSet<TYPETAXE> TYPETAXE { get; set; }
        public DbSet<TYPETIMBRE> TYPETIMBRE { get; set; }
        public DbSet<TYPETRANSFORMATEUR> TYPETRANSFORMATEUR { get; set; }
        public DbSet<UNITECOMPTAGE> UNITECOMPTAGE { get; set; }
        public DbSet<USAGE> USAGE { get; set; }
        public DbSet<VALIDATION> VALIDATION { get; set; }
        public DbSet<VARIABLETARIF> VARIABLETARIF { get; set; }
        public DbSet<VARIANTE> VARIANTE { get; set; }
        public DbSet<ACTIONSURCOMPTEUR> ACTIONSURCOMPTEUR { get; set; }
        public DbSet<APPAREILRECENSE> APPAREILRECENSE { get; set; }
        public DbSet<APPAREILSUTILISE> APPAREILSUTILISE { get; set; }
        public DbSet<AUDITION> AUDITION { get; set; }
        public DbSet<CLIENTFRAUDE> CLIENTFRAUDE { get; set; }
        public DbSet<COMPTEURFRAUDE> COMPTEURFRAUDE { get; set; }
        public DbSet<CONSOMMATION> CONSOMMATION { get; set; }
        public DbSet<CONTROLE> CONTROLE { get; set; }
        public DbSet<CONTROLEUR> CONTROLEUR { get; set; }
        public DbSet<DECISIONFRAUDE> DECISIONFRAUDE { get; set; }
        public DbSet<DENONCIATEUR> DENONCIATEUR { get; set; }
        public DbSet<DETAILparPRESTATIONEDM> DETAILparPRESTATIONEDM { get; set; }
        public DbSet<DETAILparPRESTATIONREMBOURSABLE> DETAILparPRESTATIONREMBOURSABLE { get; set; }
        public DbSet<DETAILparREGULARISATION> DETAILparREGULARISATION { get; set; }
        public DbSet<DETAILparTRANCHE> DETAILparTRANCHE { get; set; }
        public DbSet<FACTUREFRAUDE> FACTUREFRAUDE { get; set; }
        public DbSet<FRAUDE> FRAUDE { get; set; }
        public DbSet<LCLIENTFRAUDE> LCLIENTFRAUDE { get; set; }
        public DbSet<MARQUEDISJONCTEUR> MARQUEDISJONCTEUR { get; set; }
        public DbSet<MOISDEJAFACTURES> MOISDEJAFACTURES { get; set; }
        public DbSet<MOYENDENONCIATION> MOYENDENONCIATION { get; set; }
        public DbSet<ORGANEFRAUDE> ORGANEFRAUDE { get; set; }
        public DbSet<PRESTATIONEDM> PRESTATIONEDM { get; set; }
        public DbSet<PRESTATIONREMBOURSABLE> PRESTATIONREMBOURSABLE { get; set; }
        public DbSet<QUALITEEXPERT> QUALITEEXPERT { get; set; }
        public DbSet<REGULARISATION> REGULARISATION { get; set; }
        public DbSet<SOURCECONTROLE> SOURCECONTROLE { get; set; }
        public DbSet<TRANCHEFRAUDE> TRANCHEFRAUDE { get; set; }
        public DbSet<TRANSCAISBFRAUDE> TRANSCAISBFRAUDE { get; set; }
        public DbSet<TRANSCAISSEFRAUDE> TRANSCAISSEFRAUDE { get; set; }
        public DbSet<TYPEFRAUDE> TYPEFRAUDE { get; set; }
        public DbSet<GRC_GROUPE> GRC_GROUPE { get; set; }
        public DbSet<GRC_GROUPE_AFFECTE> GRC_GROUPE_AFFECTE { get; set; }
        public DbSet<GRC_MODE_COMMUNICATION> GRC_MODE_COMMUNICATION { get; set; }
        public DbSet<GRC_PANNE> GRC_PANNE { get; set; }
        public DbSet<GRC_TYPE_RECLAMATION> GRC_TYPE_RECLAMATION { get; set; }
        public DbSet<GRC_TYPE_VEHICULE> GRC_TYPE_VEHICULE { get; set; }
        public DbSet<GRC_VEHICULE> GRC_VEHICULE { get; set; }
        public DbSet<RCL_GroupeReclamation> RCL_GroupeReclamation { get; set; }
        public DbSet<RCL_ModeReception> RCL_ModeReception { get; set; }
        public DbSet<RCL_StatutReclamation> RCL_StatutReclamation { get; set; }
        public DbSet<RCL_TypeReclamation> RCL_TypeReclamation { get; set; }
        public DbSet<RCL_Validation> RCL_Validation { get; set; }
        public DbSet<ElementsDeCampagneBTA> ElementsDeCampagneBTA { get; set; }
        public DbSet<RefMethodesDeDetectionClientsBTA> RefMethodesDeDetectionClientsBTA { get; set; }
        public DbSet<tbCampagnesControleBTA> tbCampagnesControleBTA { get; set; }
        public DbSet<tbElementsLotDeControleBTA> tbElementsLotDeControleBTA { get; set; }
        public DbSet<tbLotsDeControleBTA> tbLotsDeControleBTA { get; set; }
        public DbSet<tbParametres> tbParametres { get; set; }
        public DbSet<ActiviteCouleur> ActiviteCouleur { get; set; }
        public DbSet<AffectationScelle> AffectationScelle { get; set; }
        public DbSet<DetailAffectationScelle> DetailAffectationScelle { get; set; }
        public DbSet<RefActivite> RefActivite { get; set; }
        public DbSet<RefCouleurlot> RefCouleurlot { get; set; }
        public DbSet<RefEtatCompteur> RefEtatCompteur { get; set; }
        public DbSet<RefFournisseurs> RefFournisseurs { get; set; }
        public DbSet<RefMotif> RefMotif { get; set; }
        public DbSet<RefOrigineScelle> RefOrigineScelle { get; set; }
        public DbSet<RefProvenance> RefProvenance { get; set; }
        public DbSet<RefStatus> RefStatus { get; set; }
        public DbSet<RefStatusLotScelle> RefStatusLotScelle { get; set; }
        public DbSet<RefStatutLotMagasinGeneral> RefStatutLotMagasinGeneral { get; set; }
        public DbSet<Scelles> Scelles { get; set; }
        public DbSet<TbCompteurBTA> TbCompteurBTA { get; set; }
        public DbSet<tbDetailRemiseScelles> tbDetailRemiseScelles { get; set; }
        public DbSet<TbDetailRetourScelles> TbDetailRetourScelles { get; set; }
        public DbSet<tbLot> tbLot { get; set; }
        public DbSet<tbLotMagasinGeneral> tbLotMagasinGeneral { get; set; }
        public DbSet<tbRemiseScelles> tbRemiseScelles { get; set; }
        public DbSet<TbRetourScelles> TbRetourScelles { get; set; }
        public DbSet<CONDITIONBRANCHEMENT> CONDITIONBRANCHEMENT { get; set; }
        public DbSet<COPIE_DMD_CIRCUIT> COPIE_DMD_CIRCUIT { get; set; }
        public DbSet<COPIE_DMD_CONDITIONBRANCHEMENT> COPIE_DMD_CONDITIONBRANCHEMENT { get; set; }
        public DbSet<DEMANDE_WORFKLOW> DEMANDE_WORFKLOW { get; set; }
        public DbSet<ETAPE> ETAPE { get; set; }
        public DbSet<FORMULAIRE> FORMULAIRE { get; set; }
        public DbSet<GROUPE_VALIDATION> GROUPE_VALIDATION { get; set; }
        public DbSet<JOURNAL_DEMANDE_WORKFLOW> JOURNAL_DEMANDE_WORKFLOW { get; set; }
        public DbSet<OPERATION> OPERATION { get; set; }
        public DbSet<RAFFECTATIONETAPEWORKFLOW> RAFFECTATIONETAPEWORKFLOW { get; set; }
        public DbSet<RENVOI_REJET> RENVOI_REJET { get; set; }
        public DbSet<RHABILITATIONGROUPEVALIDATION> RHABILITATIONGROUPEVALIDATION { get; set; }
        public DbSet<RWORFKLOWCENTRE> RWORFKLOWCENTRE { get; set; }
        public DbSet<STATUSDEMANDE> STATUSDEMANDE { get; set; }
        public DbSet<TABLETRAVAIL> TABLETRAVAIL { get; set; }
        public DbSet<WORKFLOW> WORKFLOW { get; set; }
        public DbSet<VW_DASHBORDDEMANDE> VW_DASHBORDDEMANDE { get; set; }
        public DbSet<VW_OPERATION_FORMULAIRE> VW_OPERATION_FORMULAIRE { get; set; }
        public DbSet<vwCONFIGURATIONWORKFLOWCENTRE> vwCONFIGURATIONWORKFLOWCENTRE { get; set; }
        public DbSet<RELEVEUR> RELEVEUR { get; set; }
        public DbSet<DETAILLOT> DETAILLOT { get; set; }
        public DbSet<LOTCOMPTECLIENT> LOTCOMPTECLIENT { get; set; }
        public DbSet<DEMANDE> DEMANDE { get; set; }
        public DbSet<REJET_DE_TRAITEMENT> REJET_DE_TRAITEMENT { get; set; }
        public DbSet<TRAITEMENT_FICHIER> TRAITEMENT_FICHIER { get; set; }
        public DbSet<RCL_Reclamation> RCL_Reclamation { get; set; }
        public DbSet<AFFECTATIONDEMANDEUSER> AFFECTATIONDEMANDEUSER { get; set; }
        public DbSet<VW_JOURNAL_DEMANDE> VW_JOURNAL_DEMANDE { get; set; }
        public DbSet<COMMENTAIRE_REJET> COMMENTAIRE_REJET { get; set; }
    }
}
