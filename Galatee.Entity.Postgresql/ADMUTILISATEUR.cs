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
    
    public partial class ADMUTILISATEUR
    {
        public ADMUTILISATEUR()
        {
            this.ADMHISTORIQUECONNECTION = new HashSet<ADMHISTORIQUECONNECTION>();
            this.ADMHISTORIQUEPASSWORD = new HashSet<ADMHISTORIQUEPASSWORD>();
            this.AFFECTATIONGESTIONAIRE = new HashSet<AFFECTATIONGESTIONAIRE>();
            this.CAMPAGNE = new HashSet<CAMPAGNE>();
            this.CAMPAGNEGC = new HashSet<CAMPAGNEGC>();
            this.CAMPAGNEPRECONTENTIEUX = new HashSet<CAMPAGNEPRECONTENTIEUX>();
            this.CAMPAGNESGC = new HashSet<CAMPAGNESGC>();
            this.CENTREAFFECTATION = new HashSet<CENTREAFFECTATION>();
            this.CENTREDUPROFIL = new HashSet<CENTREDUPROFIL>();
            this.CONTROLETRAVAUX = new HashSet<CONTROLETRAVAUX>();
            this.CONTROLEUR = new HashSet<CONTROLEUR>();
            this.DORDRETRAVAIL = new HashSet<DORDRETRAVAIL>();
            this.DANNOTATION = new HashSet<DANNOTATION>();
            this.DSCELLE = new HashSet<DSCELLE>();
            this.GRC_GROUPE_AFFECTE = new HashSet<GRC_GROUPE_AFFECTE>();
            this.HABILITATIONCAISSE = new HashSet<HABILITATIONCAISSE>();
            this.INTERVENTIONPLANNIFIEE = new HashSet<INTERVENTIONPLANNIFIEE>();
            this.LCLIENT = new HashSet<LCLIENT>();
            this.LCLIENTFRAUDE = new HashSet<LCLIENTFRAUDE>();
            this.PROFILSUTILISATEUR = new HashSet<PROFILSUTILISATEUR>();
            this.RHABILITATIONGROUPEVALIDATION = new HashSet<RHABILITATIONGROUPEVALIDATION>();
            this.TOURNEEPIA = new HashSet<TOURNEEPIA>();
            this.TRANSCAISB = new HashSet<TRANSCAISB>();
            this.TRANSCAISB1 = new HashSet<TRANSCAISB>();
            this.TRANSCAISBFRAUDE = new HashSet<TRANSCAISBFRAUDE>();
            this.TRANSCAISBFRAUDE1 = new HashSet<TRANSCAISBFRAUDE>();
            this.TRANSCAISSE = new HashSet<TRANSCAISSE>();
            this.TRANSCAISSE1 = new HashSet<TRANSCAISSE>();
            this.TRANSCAISSEFRAUDE = new HashSet<TRANSCAISSEFRAUDE>();
            this.TRANSCAISSEFRAUDE1 = new HashSet<TRANSCAISSEFRAUDE>();
            this.RELEVEUR = new HashSet<RELEVEUR>();
            this.DETAILLOT = new HashSet<DETAILLOT>();
            this.DEMANDE = new HashSet<DEMANDE>();
            this.AFFECTATIONDEMANDEUSER = new HashSet<AFFECTATIONDEMANDEUSER>();
        }
    
        public string CENTRE { get; set; }
        public string MATRICULE { get; set; }
        public string LIBELLE { get; set; }
        public string PASSE { get; set; }
        public Nullable<System.DateTime> DMAJ { get; set; }
        public string TRANS { get; set; }
        public string LOGINNAME { get; set; }
        public string E_MAIL { get; set; }
        public Nullable<System.DateTime> DATEDERNIEREMODIFICATION { get; set; }
        public Nullable<System.DateTime> DATEDEBUTVALIDITE { get; set; }
        public Nullable<System.DateTime> DATEFINVALIDITE { get; set; }
        public Nullable<int> STATUSCOMPTE { get; set; }
        public Nullable<System.DateTime> DATEDERNIEREMODIFICATIONPASSWORD { get; set; }
        public Nullable<bool> INITUSERPASSWORD { get; set; }
        public Nullable<int> NOMBREECHECSOUVERTURESESSION { get; set; }
        public Nullable<System.DateTime> DATEDERNIERECONNEXION { get; set; }
        public Nullable<bool> DERNIERECONNEXIONREUSSIE { get; set; }
        public Nullable<System.DateTime> DATEDERNIERVERROUILLAGE { get; set; }
        public string BRANCHE { get; set; }
        public byte PERIMETREACTION { get; set; }
        public Nullable<bool> ESTSUPPRIMER { get; set; }
        public string USERCREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int PK_ID { get; set; }
        public byte FK_IDSTATUS { get; set; }
        public string COMPTEWINDOW { get; set; }
        public string TELEPHONE { get; set; }
        public Nullable<bool> ESTCONNECTE { get; set; }
    
        public virtual ICollection<ADMHISTORIQUECONNECTION> ADMHISTORIQUECONNECTION { get; set; }
        public virtual ICollection<ADMHISTORIQUEPASSWORD> ADMHISTORIQUEPASSWORD { get; set; }
        public virtual ADMSTATUSCOMPTE ADMSTATUSCOMPTE { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual ICollection<AFFECTATIONGESTIONAIRE> AFFECTATIONGESTIONAIRE { get; set; }
        public virtual ICollection<CAMPAGNE> CAMPAGNE { get; set; }
        public virtual ICollection<CAMPAGNEGC> CAMPAGNEGC { get; set; }
        public virtual ICollection<CAMPAGNEPRECONTENTIEUX> CAMPAGNEPRECONTENTIEUX { get; set; }
        public virtual ICollection<CAMPAGNESGC> CAMPAGNESGC { get; set; }
        public virtual ICollection<CENTREAFFECTATION> CENTREAFFECTATION { get; set; }
        public virtual ICollection<CENTREDUPROFIL> CENTREDUPROFIL { get; set; }
        public virtual ICollection<CONTROLETRAVAUX> CONTROLETRAVAUX { get; set; }
        public virtual ICollection<CONTROLEUR> CONTROLEUR { get; set; }
        public virtual ICollection<DORDRETRAVAIL> DORDRETRAVAIL { get; set; }
        public virtual ICollection<DANNOTATION> DANNOTATION { get; set; }
        public virtual ICollection<DSCELLE> DSCELLE { get; set; }
        public virtual ICollection<GRC_GROUPE_AFFECTE> GRC_GROUPE_AFFECTE { get; set; }
        public virtual ICollection<HABILITATIONCAISSE> HABILITATIONCAISSE { get; set; }
        public virtual ICollection<INTERVENTIONPLANNIFIEE> INTERVENTIONPLANNIFIEE { get; set; }
        public virtual ICollection<LCLIENT> LCLIENT { get; set; }
        public virtual ICollection<LCLIENTFRAUDE> LCLIENTFRAUDE { get; set; }
        public virtual ICollection<PROFILSUTILISATEUR> PROFILSUTILISATEUR { get; set; }
        public virtual ICollection<RHABILITATIONGROUPEVALIDATION> RHABILITATIONGROUPEVALIDATION { get; set; }
        public virtual ICollection<TOURNEEPIA> TOURNEEPIA { get; set; }
        public virtual ICollection<TRANSCAISB> TRANSCAISB { get; set; }
        public virtual ICollection<TRANSCAISB> TRANSCAISB1 { get; set; }
        public virtual ICollection<TRANSCAISBFRAUDE> TRANSCAISBFRAUDE { get; set; }
        public virtual ICollection<TRANSCAISBFRAUDE> TRANSCAISBFRAUDE1 { get; set; }
        public virtual ICollection<TRANSCAISSE> TRANSCAISSE { get; set; }
        public virtual ICollection<TRANSCAISSE> TRANSCAISSE1 { get; set; }
        public virtual ICollection<TRANSCAISSEFRAUDE> TRANSCAISSEFRAUDE { get; set; }
        public virtual ICollection<TRANSCAISSEFRAUDE> TRANSCAISSEFRAUDE1 { get; set; }
        public virtual ICollection<RELEVEUR> RELEVEUR { get; set; }
        public virtual ICollection<DETAILLOT> DETAILLOT { get; set; }
        public virtual ICollection<DEMANDE> DEMANDE { get; set; }
        public virtual ICollection<AFFECTATIONDEMANDEUSER> AFFECTATIONDEMANDEUSER { get; set; }
    }
}
