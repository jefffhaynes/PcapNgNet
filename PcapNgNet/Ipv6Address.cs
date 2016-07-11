using BinarySerialization;

namespace PcapNgNet
{
    public class Ipv6Address
    {
        [FieldLength(16)]
        public byte[] Address { get; set; }
    }
}
