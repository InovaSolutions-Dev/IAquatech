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
    
    public partial class APPAREILS
    {
        public APPAREILS()
        {
            this.APPAREILRECENSE = new HashSet<APPAREILRECENSE>();
            this.APPAREILSDEVIS = new HashSet<APPAREILSDEVIS>();
            this.APPAREILSUTILISE = new HashSet<APPAREILSUTILISE>();
        }
    
        public string CODEAPPAREIL { get; set; }
        public string DESIGNATION { get; set; }
        public string DETAILS { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public Nullable<int> TEMPSUTILISATION { get; set; }
        public Nullable<int> PUISSANCE { get; set; }
    
        public virtual ICollection<APPAREILRECENSE> APPAREILRECENSE { get; set; }
        public virtual ICollection<APPAREILSDEVIS> APPAREILSDEVIS { get; set; }
        public virtual ICollection<APPAREILSUTILISE> APPAREILSUTILISE { get; set; }
    }
}
