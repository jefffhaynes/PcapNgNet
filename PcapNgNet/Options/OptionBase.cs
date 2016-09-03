using BinarySerialization;

namespace PcapNgNet.Options
{
    public class OptionBase
    {
        [FieldOrder(0)]
        public OptionCode Code { get; set; }

        [FieldOrder(1)]
        public ushort Length { get; set; }
    }
}
