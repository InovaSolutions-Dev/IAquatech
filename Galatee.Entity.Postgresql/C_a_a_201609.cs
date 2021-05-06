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
    
    public partial class C_a_a_201609
    {
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string PRODUIT { get; set; }
        public int POINT { get; set; }
        public int NUMEVENEMENT { get; set; }
        public string ORDRE { get; set; }
        public string COMPTEUR { get; set; }
        public Nullable<System.DateTime> DATEEVT { get; set; }
        public string PERIODE { get; set; }
        public string CODEEVT { get; set; }
        public Nullable<int> INDEXEVT { get; set; }
        public string CAS { get; set; }
        public string ENQUETE { get; set; }
        public Nullable<int> CONSO { get; set; }
        public Nullable<int> CONSONONFACTUREE { get; set; }
        public string LOTRI { get; set; }
        public string FACTURE { get; set; }
        public Nullable<int> SURFACTURATION { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> TYPECONSO { get; set; }
        public string REGLAGECOMPTEUR { get; set; }
        public string TYPETARIF { get; set; }
        public string FORFAIT { get; set; }
        public string CATEGORIE { get; set; }
        public string CODECONSO { get; set; }
        public string PROPRIO { get; set; }
        public string STATUTCOMPTEUR { get; set; }
        public string MODEPAIEMENT { get; set; }
        public string MATRICULE { get; set; }
        public string FACPER { get; set; }
        public Nullable<int> QTEAREG { get; set; }
        public string DERPERF { get; set; }
        public string DERPERFN { get; set; }
        public Nullable<int> CONSOFAC { get; set; }
        public Nullable<int> REGIMPUTE { get; set; }
        public Nullable<int> REGCONSO { get; set; }
        public Nullable<decimal> COEFLECT { get; set; }
        public Nullable<int> COEFCOMPTAGE { get; set; }
        public Nullable<decimal> PUISSANCE { get; set; }
        public string TYPECOMPTAGE { get; set; }
        public string TYPECOMPTEUR { get; set; }
        public Nullable<decimal> COEFK1 { get; set; }
        public Nullable<decimal> COEFK2 { get; set; }
        public Nullable<decimal> COEFKR1 { get; set; }
        public Nullable<decimal> COEFKR2 { get; set; }
        public Nullable<int> COEFFAC { get; set; }
        public string USERCREATION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDCANALISATION { get; set; }
        public int FK_IDABON { get; set; }
        public int FK_IDCOMPTEUR { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDPRODUIT { get; set; }
        public Nullable<bool> ESTCONSORELEVEE { get; set; }
        public Nullable<int> FK_IDTOURNEE { get; set; }
        public string TOURNEE { get; set; }
        public string ORDTOUR { get; set; }
        public string PERFAC { get; set; }
        public Nullable<int> CONSOMOYENNEPRECEDENTEFACTURE { get; set; }
        public Nullable<System.DateTime> DATERELEVEPRECEDENTEFACTURE { get; set; }
        public string CASPRECEDENTEFACTURE { get; set; }
        public Nullable<int> INDEXPRECEDENTEFACTURE { get; set; }
        public string PERIODEPRECEDENTEFACTURE { get; set; }
        public Nullable<byte> ORDREAFFICHAGE { get; set; }
        public string NOUVEAUCOMPTEUR { get; set; }
        public Nullable<decimal> PUISSANCEINSTALLEE { get; set; }
        public Nullable<int> QTEAREGPRECEDENT { get; set; }
        public Nullable<bool> ISCONSOSEULE { get; set; }
        public Nullable<bool> ISEXONERETVA { get; set; }
        public string DEBUTEXONERATIONTVA { get; set; }
        public string FINEXONERATIONTVA { get; set; }
        public string COMMENTAIRE { get; set; }
        public Nullable<byte> NOUVEAUCADRAN { get; set; }
    }
}
