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
    
    public partial class FACTUREFRAUDE
    {
        public int PK_ID { get; set; }
        public string Refem { get; set; }
        public string NumeroFacture { get; set; }
        public string COPER { get; set; }
        public Nullable<System.DateTime> DateEnregistrement { get; set; }
        public Nullable<decimal> Montant { get; set; }
        public Nullable<System.DateTime> Exigibilite { get; set; }
        public string Origine { get; set; }
        public string MoisComptable { get; set; }
        public Nullable<decimal> FraisRetard { get; set; }
        public Nullable<decimal> MontantTVA { get; set; }
        public Nullable<byte> OrdreTraitement { get; set; }
        public Nullable<System.DateTime> DateValidation { get; set; }
        public Nullable<System.DateTime> DateAnnulation { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public Nullable<int> FK_IDCLIENTFRAUDE { get; set; }
        public Nullable<int> FK_IDFRAUDE { get; set; }
        public Nullable<int> FK_IDPRODUIT { get; set; }
        public Nullable<int> FK_IDCOPER { get; set; }
    
        public virtual COPER COPER1 { get; set; }
        public virtual PRODUIT PRODUIT { get; set; }
        public virtual CLIENTFRAUDE CLIENTFRAUDE { get; set; }
        public virtual FRAUDE FRAUDE { get; set; }
        public virtual LCLIENTFRAUDE LCLIENTFRAUDE { get; set; }
    }
}
