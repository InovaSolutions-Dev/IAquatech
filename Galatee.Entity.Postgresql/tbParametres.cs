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
    
    public partial class tbParametres
    {
        public int Parametre_ID { get; set; }
        public int TypeValeur { get; set; }
        public string LibelleParametre { get; set; }
        public string Description { get; set; }
        public Nullable<int> ValeurGlobaleInt { get; set; }
        public string ValeurGlobaleChaine { get; set; }
        public Nullable<decimal> ValeurGlobaleDecimal { get; set; }
        public Nullable<int> Methode_ID { get; set; }
    
        public virtual RefMethodesDeDetectionClientsBTA RefMethodesDeDetectionClientsBTA { get; set; }
    }
}