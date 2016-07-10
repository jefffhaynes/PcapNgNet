using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet
{
    public class PcapSection
    {
        [FieldOrder(0)]
        public SectionHeaderBlock Header { get; set; }

        [FieldOrder(1)]
        [ItemSerializeUntil("Type", BlockType.SectionHeader, ExcludeLastItem = true)]
        public List<Block> Blocks { get; set; }
    }
}
