using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet
{
    public class NameResolutionBlockBody : BlockBody
    {
        [FieldOrder(0)]
        [ItemSerializeUntil("Type", NameResolutionBlockRecordType.EndOfRecord)]
        public List<NameResolutionBlockRecord> Records { get; set; }

        [FieldOrder(1)]
        public byte[] Options { get; set; }
    }
}
