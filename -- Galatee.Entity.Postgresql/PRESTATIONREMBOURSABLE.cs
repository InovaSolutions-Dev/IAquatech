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
    
    public partial class PRESTATIONREMBOURSABLE
    {
        public PRESTATIONREMBOURSABLE()
        {
            this.DETAILparPRESTATIONREMBOURSABLE = new HashSet<DETAILparPRESTATIONREMBOURSABLE>();
        }
    
        public int PK_ID { get; set; }
        public string Libelle { get; set; }
        public decimal PrixUnitaire { get; set; }
        public Nullable<bool> EstModifiable { get; set; }
    
        public virtual ICollection<DETAILparPRESTATIONREMBOURSABLE> DETAILparPRESTATIONREMBOURSABLE { get; set; }
    }
}
