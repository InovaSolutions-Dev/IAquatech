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
    
    public partial class PERSONNEPHYSIQUE
    {
        public int PK_ID { get; set; }
        public Nullable<System.DateTime> DATENAISSANCE { get; set; }
        public string NUMEROPIECEIDENTITE { get; set; }
        public Nullable<System.DateTime> DATEFINVALIDITE { get; set; }
        public Nullable<int> FK_IDCLIENT { get; set; }
        public Nullable<int> FK_IDPIECEIDENTITE { get; set; }
        public string NOMABON { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        public virtual PIECEIDENTITE PIECEIDENTITE { get; set; }
    }
}
