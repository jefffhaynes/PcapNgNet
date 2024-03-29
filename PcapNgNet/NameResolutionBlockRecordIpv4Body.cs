﻿namespace PcapNgNet;

public class NameResolutionBlockRecordIpv4Body : NameResolutionBlockRecordBody
{
    [FieldOrder(0)]
    public IPv4Address Address { get; set; }

    [FieldOrder(1)]
    public List<string> DnsEntries { get; set; }
}
