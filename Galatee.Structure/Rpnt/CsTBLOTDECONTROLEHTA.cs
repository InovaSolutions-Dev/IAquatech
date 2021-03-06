using System;
using System.Data.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace  Galatee.Structure

{
     [DataContract]
    public class CsTBLOTDECONTROLEHTA
    {
		
		
[DataMember]
		public Guid LOT_ID { get; set; }
[DataMember]
		public String LIBELLE_LOT { get; set; }
[DataMember]
		public Int32 STATUTLOT_ID { get; set; }
[DataMember]
		public Guid CAMPAGNE_ID { get; set; }
[DataMember]
		public DateTime DATECREATION { get; set; }
[DataMember]
		public String MATRICULEAGENTCREATION { get; set; }
[DataMember]
		public DateTime? DATEFERMETURE { get; set; }
[DataMember]
		public String MATRICULEAGENTCONTROLEUR { get; set; }
[DataMember]
		public Int32 NBREELEMENTSDULOT { get; set; }
[DataMember]
		public Int32? CRITERE_TYPECLIENT { get; set; }
[DataMember]
		public Int32? CRITERE_TYPECOMPTEUR { get; set; }


    }
}
