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
    
    public partial class tbLot
    {
        public tbLot()
        {
            this.Scelles = new HashSet<Scelles>();
            this.tbDetailRemiseScelles = new HashSet<tbDetailRemiseScelles>();
        }
    
        public string lot_ID { get; set; }
        public int typeReception { get; set; }
        public System.DateTime DateReception { get; set; }
        public Nullable<int> Matricule_Creation { get; set; }
        public string Numero_depart { get; set; }
        public string Numero_fin { get; set; }
        public Nullable<int> Nombre_scelles_reçu { get; set; }
        public int Nombre_scelles_lot { get; set; }
        public Nullable<int> provenance_Scelle_ID { get; set; }
        public Nullable<int> Origine_ID { get; set; }
        public Nullable<int> Status_lot_ID { get; set; }
        public Nullable<int> lot_Couleur_ID { get; set; }
        public Nullable<System.DateTime> Date_Derniere_Modif { get; set; }
        public int TypeDeLot { get; set; }
        public Nullable<int> Matricule_AgentModification { get; set; }
        public Nullable<int> agence_centre_Appartenance { get; set; }
        public Nullable<int> agence_centre_Origine { get; set; }
    
        public virtual CENTRE CENTRE { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual RefCouleurlot RefCouleurlot { get; set; }
        public virtual RefOrigineScelle RefOrigineScelle { get; set; }
        public virtual RefProvenance RefProvenance { get; set; }
        public virtual RefStatusLotScelle RefStatusLotScelle { get; set; }
        public virtual ICollection<Scelles> Scelles { get; set; }
        public virtual ICollection<tbDetailRemiseScelles> tbDetailRemiseScelles { get; set; }
    }
}
