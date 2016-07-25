using BinarySerialization;
using PcapNgNet.Options;

namespace PcapNgNet
{
    public class SectionHeaderBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public int ByteOrderMagic { get; set; }

        [FieldOrder(1)]
        public ushort MajorVersion { get; set; }

        [FieldOrder(2)]
        public ushort MinorVersion { get; set; }

        [FieldOrder(3)]
        public long Length { get; set; }
        
        [FieldOrder(4)]
        [FieldAlignment(4)]
        public OptionSection<SectionOptionCode> Options { get; set; }
    }
}
