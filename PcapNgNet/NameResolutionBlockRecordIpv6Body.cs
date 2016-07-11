using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet
{
    public class NameResolutionBlockRecordIpv6Body
    {
        [FieldOrder(0)]
        public Ipv6Address Address { get; set; }

        [FieldOrder(1)]
        public List<string> DnsEntries { get; set; }
    }
}
