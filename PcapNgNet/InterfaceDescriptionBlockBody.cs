using BinarySerialization;

namespace PcapNgNet
{
    public class InterfaceDescriptionBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public ushort LinkType { get; set; }

        [FieldOrder(1)]
        public ushort Reserved { get; set; }

        [FieldOrder(2)]
        public int Length { get; set; }

        // TODO real options
        [FieldOrder(3)]
        public byte[] Options { get; set; }
    }
}
