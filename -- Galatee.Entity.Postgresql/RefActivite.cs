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
    
    public partial class RefActivite
    {
        public RefActivite()
        {
            this.ACTIVITEE_ORGANE = new HashSet<ACTIVITEE_ORGANE>();
            this.DSCELLE = new HashSet<DSCELLE>();
            this.TYPEDEMANDE = new HashSet<TYPEDEMANDE>();
            this.ActiviteCouleur = new HashSet<ActiviteCouleur>();
            this.tbLotMagasinGeneral = new HashSet<tbLotMagasinGeneral>();
        }
    
        public int Activite_ID { get; set; }
        public string Activite_Libelle { get; set; }
    
        public virtual ICollection<ACTIVITEE_ORGANE> ACTIVITEE_ORGANE { get; set; }
        public virtual ICollection<DSCELLE> DSCELLE { get; set; }
        public virtual ICollection<TYPEDEMANDE> TYPEDEMANDE { get; set; }
        public virtual ICollection<ActiviteCouleur> ActiviteCouleur { get; set; }
        public virtual ICollection<tbLotMagasinGeneral> tbLotMagasinGeneral { get; set; }
    }
}
