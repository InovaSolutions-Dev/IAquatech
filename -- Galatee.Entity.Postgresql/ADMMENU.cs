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
    
    public partial class ADMMENU
    {
        public ADMMENU()
        {
            this.MENUSDUPROFIL = new HashSet<MENUSDUPROFIL>();
        }
    
        public string MODULE { get; set; }
        public int PK_ID { get; set; }
        public string MENUTEXT { get; set; }
        public Nullable<int> MAINMENUID { get; set; }
        public int MENUORDER { get; set; }
        public bool ISACTIVE { get; set; }
        public string FORMENAME { get; set; }
        public Nullable<bool> ISDOCK { get; set; }
        public string ICONNAME { get; set; }
        public bool ISCONTROLE { get; set; }
        public Nullable<int> TYPEREEDITION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public Nullable<int> FK_IDMODULE { get; set; }
    
        public virtual MODULE MODULE1 { get; set; }
        public virtual ICollection<MENUSDUPROFIL> MENUSDUPROFIL { get; set; }
    }
}
