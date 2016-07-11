using BinarySerialization;

namespace PcapNgNet
{
    public class NameResolutionBlockRecord
    {
        [FieldOrder(0)]
        public NameResolutionBlockRecordType Type { get; set; }

        [FieldOrder(1)]
        public ushort Length { get; set; }

        [FieldOrder(2)]
        [FieldLength("Length")]
        [Subtype("Type", NameResolutionBlockRecordType.EndOfRecord, typeof(NameResolutionBlockRecordEndBody))]
        [Subtype("Type", NameResolutionBlockRecordType.Ipv4Record, typeof(NameResolutionBlockRecordIpv4Body))]
        [Subtype("Type", NameResolutionBlockRecordType.Ipv6Record, typeof(NameResolutionBlockRecordIpv6Body))]
        public NameResolutionBlockRecordBody Record { get; set; }
    }
}
