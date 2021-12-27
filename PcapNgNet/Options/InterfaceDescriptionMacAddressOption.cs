namespace PcapNgNet.Options;

public class InterfaceDescriptionMacAddressOption : Option
{
    [FieldLength(6)]
    public byte[] MacAddress { get; set; }
}
