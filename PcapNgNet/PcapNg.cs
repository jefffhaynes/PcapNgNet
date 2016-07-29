using System.Collections.Generic;
using System.IO;
using BinarySerialization;

namespace PcapNgNet
{
    public class PcapNg
    {
        [FieldOrder(0)]
        public Block Header { get; set; }

        [FieldOrder(1)]
        [FieldEndianness("Header.Body.ByteOrderMagic", typeof(EndiannessConverter))]
        public List<Block> Blocks { get; set; }
    }
}
