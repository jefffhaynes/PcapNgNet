namespace PcapNgNet.Options;

public class SectionHeaderOption : OptionBase
{
    [FieldAlignment(4)]
    [FieldLength("Length")]
    public byte[] Value { get; set; }
}
