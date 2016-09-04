using BinarySerialization;

namespace PcapNgNet.Options
{
    public class InterfaceDescriptionIPv4AddressOption : Option
    {
        [FieldOrder(0)]
        public IPv4Address Address { get; set; }

        [FieldOrder(1)]
        public IPv4Address Mask { get; set; }
    }
}
