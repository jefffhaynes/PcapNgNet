namespace PcapNgNet.Options;

public class InterfaceDescriptionFilterOption : Option
{
    [FieldOrder(0)]
    public byte FilterCode { get; set; }

    [FieldOrder(1)]
    [SerializeAs(SerializedType.SizedString)]
    public string Filter { get; set; }
}
