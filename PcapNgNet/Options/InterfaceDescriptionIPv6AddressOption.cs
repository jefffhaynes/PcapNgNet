namespace PcapNgNet.Options;

public class InterfaceDescriptionIPv6AddressOption : Option
{
    [FieldOrder(0)]
    public IPv6Address Address { get; set; }

    [FieldOrder(1)]
    public byte PrefixLength { get; set; }
}
