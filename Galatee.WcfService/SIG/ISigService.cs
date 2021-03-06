using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Galatee.Structure;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISigService" in both code and config file together.
    [ServiceContract]
    public interface ISigService
    {
        [OperationContract]
        List<CsAbonneCarte> RetourneCoordonneesAbon(CsClientRechercher client);

        [OperationContract]
        List<CsAbonneCarte> RetourneCoordonneesAbonCampagne(string IdCoupure);
    }
}
