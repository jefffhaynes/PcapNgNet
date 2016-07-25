using BinarySerialization;
using PcapNgNet.Options;

namespace PcapNgNet
{
    public class InterfaceStatisticsBlockBody : BlockBody
    {
        [FieldOrder(0)]
        public int InterfaceId { get; set; }

        [FieldOrder(1)]
        public int TimestampHigh { get; set; }

        [FieldOrder(2)]
        public int TimestampLow { get; set; }

        [FieldOrder(3)]
        [FieldAlignment(4)]
        public OptionSection<OptionCode> Options { get; set; }
    }
}
