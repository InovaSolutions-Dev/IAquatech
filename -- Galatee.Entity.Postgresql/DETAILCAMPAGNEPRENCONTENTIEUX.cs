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
    
    public partial class DETAILCAMPAGNEPRENCONTENTIEUX
    {
        public string IDCAMPAGNE { get; set; }
        public int PK_ID { get; set; }
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public string TOURNEE { get; set; }
        public string ORDTOUR { get; set; }
        public string CATEGORIE { get; set; }
        public Nullable<decimal> SOLDEDUE { get; set; }
        public Nullable<decimal> SOLDECLIENT { get; set; }
        public string USERCREATION { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDCLIENT { get; set; }
        public int FK_IDTOURNEE { get; set; }
        public int FK_IDCATEGORIE { get; set; }
        public int FK_IDCAMPAGNE { get; set; }
        public Nullable<bool> ISINVITATIONEDITER { get; set; }
        public Nullable<System.DateTime> DATERESILIATION { get; set; }
        public Nullable<System.DateTime> DATERDV { get; set; }
    
        public virtual CAMPAGNEPRECONTENTIEUX CAMPAGNEPRECONTENTIEUX { get; set; }
        public virtual CATEGORIECLIENT CATEGORIECLIENT { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual CLIENT CLIENT1 { get; set; }
        public virtual TOURNEE TOURNEE1 { get; set; }
        public virtual TOURNEE TOURNEE2 { get; set; }
    }
}
