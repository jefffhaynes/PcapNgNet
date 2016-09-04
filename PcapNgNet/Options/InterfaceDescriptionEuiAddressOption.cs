using BinarySerialization;

namespace PcapNgNet.Options
{
    public class InterfaceDescriptionEuiAddressOption : Option
    {
        [FieldLength(8)]
        public byte[] EuiAddress { get; set; }
    }
}
