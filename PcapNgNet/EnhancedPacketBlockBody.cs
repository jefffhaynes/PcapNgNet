using BinarySerialization;
using PcapNgNet.Options;

namespace PcapNgNet
{
    public class EnhancedPacketBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public int InterfaceId { get; set; }

        [FieldOrder(1)]
        public int TimestampHigh { get; set; }

        [FieldOrder(2)]
        public int TimestampLow { get; set; }

        [FieldOrder(3)]
        public int CaptureLength { get; set; }

        [FieldOrder(4)]
        public int PacketLength { get; set; }

        [FieldOrder(5)]
        [FieldAlignment(4)]
        [FieldLength("CaptureLength")]
        public byte[] PacketData { get; set; }
        
        [FieldOrder(6)]
        [FieldAlignment(4)]
        public OptionSection<OptionField<EnhancedPacketOptionCode>, EnhancedPacketOptionCode> Options { get; set; }
    }
}
