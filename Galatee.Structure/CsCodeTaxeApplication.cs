﻿using System;
using System.Collections.Generic;
using System.Text;
using Inova.Tools.Utilities;
using System.Runtime.Serialization;

namespace Galatee.Structure
{
    [DataContract]

    public class CsCodeTaxeApplication : CsPrint
    {
        [DataMember]
        public string PK_ID { get; set; }
        [DataMember]
        public string PK_CODEAPPLICATION { get; set; }
        [DataMember]
        public string LIBELLE { get; set; }
        [DataMember]
        public DateTime? DATECREATION { get; set; }
        [DataMember]
        public DateTime? DATEMODIFICATION { get; set; }
        [DataMember]
        public string USERCREATION { get; set; }
        [DataMember]
        public string USERMODIFICATION { get; set; }
    }
 }









