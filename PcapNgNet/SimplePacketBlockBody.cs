using BinarySerialization;

namespace PcapNgNet
{
    public class SimplePacketBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public int PacketLength { get; set; }

        [FieldOrder(1)]
        //[FieldLength("PacketLength")]
        public byte[] PacketData { get; set; }
    }
}
