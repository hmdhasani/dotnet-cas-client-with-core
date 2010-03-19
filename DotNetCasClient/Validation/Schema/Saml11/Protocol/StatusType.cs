﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Saml11.Protocol
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:1.0:protocol")]
    [XmlRoot("Status", Namespace="urn:oasis:names:tc:SAML:1.0:protocol", IsNullable=false)]
    public class StatusType {
        [XmlElement]
        public StatusCodeType StatusCode
        {
            get;
            set;
        }

        [XmlElement]
        public string StatusMessage
        {
            get;
            set;
        }

        [XmlElement]
        public StatusDetailType StatusDetail
        {
            get;
            set;
        }
    }
}