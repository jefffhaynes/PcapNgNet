using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet
{
    public class NameResolutionBlockRecordIpv6Body : NameResolutionBlockRecordBody
    {
        [FieldOrder(0)]
        public IPv6Address Address { get; set; }

        [FieldOrder(1)]
        public List<string> DnsEntries { get; set; }
    }
}
