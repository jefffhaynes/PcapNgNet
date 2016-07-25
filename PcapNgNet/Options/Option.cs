using BinarySerialization;

namespace PcapNgNet.Options
{
    public class Option<TCode>
    {
        [FieldOrder(0)]
        public TCode Code { get; set; }

        [FieldOrder(1)]
        public ushort Length { get; set; }

        [FieldOrder(2)]
        [FieldAlignment(4)]
        [FieldLength("Length")]
        public byte[] Value { get; set; }
    }
}
