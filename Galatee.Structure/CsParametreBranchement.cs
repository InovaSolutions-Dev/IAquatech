using System;
using System.Collections.Generic;
using System.Text;
using Inova.Tools.Utilities;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace Galatee.Structure
{
    [DataContract]
    public class CsParametreBranchement
    {
       [DataMember] public string CENTRE { get; set; }
       [DataMember] public string PRODUIT { get; set; }
       [DataMember] public int? NBPOINTSMAXI { get; set; }
       [DataMember] public int? GESTIONTRANSFO { get; set; }
       [DataMember] public int? MODESAISIEINDEX { get; set; }
       [DataMember] public string USERCREATION { get; set; }
       [DataMember] public System.DateTime DATECREATION { get; set; }
       [DataMember] public System.DateTime? DATEMODIFICATION { get; set; }
       [DataMember] public string USERMODIFICATION { get; set; }
       [DataMember] public int PK_ID { get; set; }
       [DataMember] public int FK_IDPRODUIT { get; set; }
       [DataMember] public int FK_IDCENTRE { get; set; }

    }

}









