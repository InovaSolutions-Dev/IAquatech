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
    
    public partial class PAYEUR
    {
        public PAYEUR()
        {
            this.CLIENT = new HashSet<CLIENT>();
            this.DCLIENT = new HashSet<DCLIENT>();
        }
    
        public Nullable<int> PAYEUR1 { get; set; }
        public string NOM { get; set; }
        public string TELEPHONE { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public Nullable<short> ACCEPTFACTURE { get; set; }
        public Nullable<short> ACCEPTPENALITE { get; set; }
        public string REGISTRE { get; set; }
        public string CODENATIONAL { get; set; }
        public string ACTIVITE { get; set; }
        public string DISTRIBUTION { get; set; }
        public string CENTRE { get; set; }
        public string COMMUNE { get; set; }
        public string QUARTIER { get; set; }
        public string CODERUE { get; set; }
        public string NUMRUE { get; set; }
        public string NOMRUE { get; set; }
        public string COMPRUE { get; set; }
        public string CPOS { get; set; }
        public string CADR { get; set; }
        public int PK_ID { get; set; }
    
        public virtual ICollection<CLIENT> CLIENT { get; set; }
        public virtual ICollection<DCLIENT> DCLIENT { get; set; }
    }
}
