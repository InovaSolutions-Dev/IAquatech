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
    
    public partial class DETAILLOT
    {
        public int IDLOT { get; set; }
        public string NUMEROLIGNE { get; set; }
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public string REFEM { get; set; }
        public string NDOC { get; set; }
        public Nullable<decimal> MONTANT { get; set; }
        public string COPER { get; set; }
        public string MODEREG { get; set; }
        public string ACQUIT { get; set; }
        public Nullable<System.DateTime> DATEPIECE { get; set; }
        public Nullable<System.DateTime> DATESAISIE { get; set; }
        public Nullable<System.DateTime> EXIGIBILITE { get; set; }
        public Nullable<decimal> ECART { get; set; }
        public string CODEERR { get; set; }
        public string SENS { get; set; }
        public string REFERENCE { get; set; }
        public string MATRICULE { get; set; }
        public Nullable<System.DateTime> DATETRAIT { get; set; }
        public string REFEMNDOC { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDLOTCOMPECLIENT { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDCOPER { get; set; }
        public int FK_IDMATRICULE { get; set; }
        public Nullable<int> FK_IDCLIENT { get; set; }
        public Nullable<int> FK_IDLCLIENT { get; set; }
        public Nullable<bool> STATUT { get; set; }
        public Nullable<decimal> MONTANT_AJUSTEMENT { get; set; }
    
        public virtual ADMUTILISATEUR ADMUTILISATEUR { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual CLIENT CLIENT1 { get; set; }
        public virtual COPER COPER1 { get; set; }
        public virtual LOTCOMPTECLIENT LOTCOMPTECLIENT { get; set; }
        public virtual LCLIENT LCLIENT { get; set; }
    }
}
