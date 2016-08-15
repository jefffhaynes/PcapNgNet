using BinarySerialization;

namespace PcapNgNet
{
    public class Block
    {
        [FieldOrder(0)]
        public BlockType Type { get; set; }

        [FieldOrder(1)]
        public int Length { get; set; }

        [FieldOrder(2)]
        [FieldAlignment(4)]
        [FieldLength("Length", ConverterType = typeof(SummingValueConverter), ConverterParameter = -12)]
        [FieldLength("Length2", ConverterType = typeof(SummingValueConverter), ConverterParameter = -12, 
            BindingMode = BindingMode.OneWayToSource)]
        [Subtype("Type", BlockType.SectionHeader, typeof(SectionHeaderBlockBody))]
        [Subtype("Type", BlockType.InterfaceDescrption, typeof(InterfaceDescriptionBlockBody))]
        [Subtype("Type", BlockType.EnhancedPacket, typeof(EnhancedPacketBlockBody))]
        [Subtype("Type", BlockType.SimplePacket, typeof(SimplePacketBlockBody))]
        [Subtype("Type", BlockType.NameResolution, typeof(NameResolutionBlockBody))]
        [Subtype("Type", BlockType.InterfaceStatistics, typeof(InterfaceStatisticsBlockBody))]
        [SubtypeDefault(typeof(UnknownBlockBody))]
        public BlockBody Body { get; set; }

        [FieldOrder(3)]
        public int Length2 { get; set; }
    }
}
