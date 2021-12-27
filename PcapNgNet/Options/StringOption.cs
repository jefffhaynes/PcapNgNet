namespace PcapNgNet.Options;

public class StringOption : Option
{
    [SerializeAs(SerializedType.SizedString)]
    public string Value { get; set; }
}
