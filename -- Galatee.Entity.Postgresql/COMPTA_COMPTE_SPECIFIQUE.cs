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
    
    public partial class COMPTA_COMPTE_SPECIFIQUE
    {
        public string SOCIETE { get; set; }
        public string ACTIVITE { get; set; }
        public string OPERATION { get; set; }
        public string COMPTE { get; set; }
        public string CENTREIMPUTATION { get; set; }
        public string FILIERE { get; set; }
        public string SOUSCOMPTE { get; set; }
        public string LOC { get; set; }
        public string NATIMMO { get; set; }
        public string LIBRE { get; set; }
        public string LIBELLE { get; set; }
        public Nullable<int> FK_IDOPERATIONCOMPTA { get; set; }
        public Nullable<int> FK_IDTYPE_COMPTE { get; set; }
        public string DC { get; set; }
        public string COPERASSOCIE { get; set; }
        public string VALEURFILTRE { get; set; }
        public string VALEURFILTRE1 { get; set; }
        public string VALEURFILTRE2 { get; set; }
        public string VALEURMONTANT { get; set; }
        public int PK_ID { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFCATION { get; set; }
    
        public virtual COMPTA_OPERATIONCOMPTABLE COMPTA_OPERATIONCOMPTABLE { get; set; }
        public virtual COMPTA_TYPE_COMPTE COMPTA_TYPE_COMPTE { get; set; }
    }
}
