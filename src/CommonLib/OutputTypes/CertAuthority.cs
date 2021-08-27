﻿using System.Security.Cryptography.X509Certificates;
using SharpHoundCommonLib.Enums;

namespace SharpHoundCommonLib.OutputTypes
{
    public class CertAuthority : OutputBase
    {
        public PKICertificateAuthorityFlags Flags { get; set; }
        public X509Certificate2[] Certificates { get; set; }
        public string[] Templates { get; set; }
        public string DNSHostName { get; set; }
    }
}