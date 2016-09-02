using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet
{
    public class Section
    {
        [FieldOrder(0)]
        public SectionHeader Header { get; set; }

        [FieldOrder(1)]
        [FieldEndianness("Header.ByteOrderMagic", typeof(EndiannessConverter))]
        [ItemSerializeUntil("Type", BlockType.SectionHeader, LastItemMode = LastItemMode.Defer)]
        public List<Block> Blocks { get; set; }
    }
}
