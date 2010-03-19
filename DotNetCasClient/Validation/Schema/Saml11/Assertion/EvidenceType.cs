﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Saml11.Assertion {
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:1.0:assertion")]
    [XmlRoot("Evidence", Namespace="urn:oasis:names:tc:SAML:1.0:assertion", IsNullable=false)]
    public class EvidenceType {
        [XmlElement("Assertion", typeof(AssertionType)), XmlElement("AssertionIDReference", typeof(string), DataType="NCName")]
        public object[] Items
        {
            get;
            set;
        }
    }
}


