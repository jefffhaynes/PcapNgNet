using BinarySerialization;

namespace PcapNgNet
{
    public class HeaderBlock
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
        public SectionHeaderBlockBody Body { get; set; }

        [FieldOrder(3)]
        public int Length2 { get; set; }
    }
}
