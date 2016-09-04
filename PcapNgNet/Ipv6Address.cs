using BinarySerialization;

namespace PcapNgNet
{
// ReSharper disable InconsistentNaming
    public class IPv6Address
// ReSharper restore InconsistentNaming
    {
        [FieldLength(16)]
        public byte[] Address { get; set; }
    }
}