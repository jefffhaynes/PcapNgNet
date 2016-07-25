using BinarySerialization;
using PcapNgNet.Options;

namespace PcapNgNet
{
    public class InterfaceDescriptionBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public LinkType LinkType { get; set; }

        [FieldOrder(1)]
        public ushort Reserved { get; set; }

        [FieldOrder(2)]
        public int Length { get; set; }
        
        [FieldOrder(3)]
        [FieldAlignment(4)]
        public OptionSection<InterfaceOptionCode> Options { get; set; }
    }
}
