using System;
using System.Collections.Generic;
using System.Text;
using Inova.Tools.Utilities;
using System.Runtime.Serialization;

namespace Galatee.Structure
{
    [DataContract]

    public class CsPuissance
    {
        
       [DataMember] public int PK_ID { get; set; }
       [DataMember] public string PRODUIT { get; set; }
       [DataMember] public string CODE { get; set; }
       [DataMember] public string LIBELLE { get; set; }
       [DataMember] public decimal VALEUR { get; set; }
       [DataMember] public Nullable<decimal> KPERTEACTIVE1 { get; set; }
       [DataMember] public Nullable<decimal> KPERTEACTIVE2 { get; set; }
       [DataMember] public Nullable<decimal> KPERTEREACTIVE1 { get; set; }
       [DataMember] public Nullable<decimal> KPERTEREACTIVE2 { get; set; }
       [DataMember] public System.DateTime DATECREATION { get; set; }
       [DataMember] public string USERCREATION { get; set; }
       [DataMember] public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
       [DataMember] public string USERMODIFICATION { get; set; }
       [DataMember] public int FK_IDPRODUIT { get; set; }


       [DataMember] public int FK_IDREGLAGECOMPTEUR { get; set; }
       [DataMember] public int? FK_IDPUISSANCE { get; set; }
       [DataMember] public string REGLAGECOMPTEUR { get; set; }
       [DataMember] public string LIBELLEREGLAGECOMPTEUR { get; set; }




    }
}









