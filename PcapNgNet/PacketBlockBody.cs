using BinarySerialization;

namespace PcapNgNet
{
    public class PacketBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public ushort InterfaceId { get; set; }

        [FieldOrder(1)]
        public ushort DropsCount { get; set; }

        [FieldOrder(2)]
        public int TimestampHigh { get; set; }

        [FieldOrder(3)]
        public int TimestampLow { get; set; }

        [FieldOrder(4)]
        public int CaptureLength { get; set; }

        [FieldOrder(5)]
        public int PacketLength { get; set; }

        [FieldOrder(6)]
        [FieldLength("CaptureLength")]
        public byte[] PacketData { get; set; }

        // TODO real options
        [FieldOrder(7)]
        public byte[] Options { get; set; }
    }
}
