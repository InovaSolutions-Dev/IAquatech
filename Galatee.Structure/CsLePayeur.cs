using System;
using System.Collections.Generic;
using System.Text;
using Inova.Tools.Utilities;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace Galatee.Structure
{
    [DataContract]
    public class CsLePayeur
    {
        [DataMember] public CsPayeur  Payeur { get; set; }
        [DataMember] public List<CsClient>  ClientPayeur { get; set; }
    }
}









