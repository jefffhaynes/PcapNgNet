using BinarySerialization;
using PcapNgNet.Options;

namespace PcapNgNet
{
    public class SectionHeaderBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public int ByteOrderMagic { get; set; }

        [FieldOrder(1)]
        [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
        public ushort MajorVersion { get; set; }

        [FieldOrder(2)]
        [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
        public ushort MinorVersion { get; set; }

        [FieldOrder(3)]
        [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
        public long Length { get; set; }
        
        [FieldOrder(4)]
        [FieldAlignment(4)]
        [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
        public OptionSection<SectionOptionCode> Options { get; set; }
    }
}
