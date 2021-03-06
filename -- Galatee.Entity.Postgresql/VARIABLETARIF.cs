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
    
    public partial class VARIABLETARIF
    {
        public VARIABLETARIF()
        {
            this.TARIFFACTURATION = new HashSet<TARIFFACTURATION>();
        }
    
        public string REDEVANCE { get; set; }
        public string REGION { get; set; }
        public string SREGION { get; set; }
        public string CENTRE { get; set; }
        public string COMMUNE { get; set; }
        public Nullable<byte> ORDREEDITION { get; set; }
        public System.DateTime DATEAPPLICATION { get; set; }
        public string RECHERCHETARIF { get; set; }
        public string MODECALCUL { get; set; }
        public string MODEAPPLICATION { get; set; }
        public string LIBELLECOMPTABLE { get; set; }
        public string COMPTECOMPTABLE { get; set; }
        public Nullable<bool> ESTANALYTIQUE { get; set; }
        public Nullable<bool> GENERATIONANOMALIE { get; set; }
        public string FORMULE { get; set; }
        public int PK_ID { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int FK_IDREDEVANCE { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDMODEAPPLICATION { get; set; }
        public int FK_IDMODECALCUL { get; set; }
        public int FK_IDRECHERCHETARIF { get; set; }
    
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual MODEAPPLICATIONTARIF MODEAPPLICATIONTARIF { get; set; }
        public virtual MODECALCUL MODECALCUL1 { get; set; }
        public virtual RECHERCHETARIF RECHERCHETARIF1 { get; set; }
        public virtual REDEVANCE REDEVANCE1 { get; set; }
        public virtual ICollection<TARIFFACTURATION> TARIFFACTURATION { get; set; }
    }
}
