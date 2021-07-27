﻿using System.Collections.Generic;
using SharpHoundCommonLib.OutputTypes;

namespace SharpHoundCommonLib.Processors
{
    public class SPNProcessor
    {
        private readonly ILDAPUtils _utils;

        public SPNProcessor(ILDAPUtils utils)
        {
            _utils = utils;
        }

        public async IAsyncEnumerable<SPNTarget> ReadSPNTargets(string[] servicePrincipalNames,
            string distinguishedName)
        {
            if (servicePrincipalNames.Length == 0)
                yield break;

            var domain = Helpers.DistinguishedNameToDomain(distinguishedName);

            foreach (var spn in servicePrincipalNames)
            {
                //This SPN format isn't useful for us right now (username@domain)
                if (spn.Contains("@"))
                    continue;

                if (spn.ToLower().Contains("mssqlsvc"))
                {
                    var port = 1433;

                    if (spn.Contains(":"))
                        if (!int.TryParse(spn.Split(':')[1], out port))
                            port = 1433;
                    var host = await _utils.ResolveHostToSid(spn, domain);
                    if (host.StartsWith("S-1-"))
                        yield return new SPNTarget
                        {
                            ComputerSID = host,
                            Port = port,
                            Service = SPNService.MSSQL
                        };
                }
            }
        }
    }
}