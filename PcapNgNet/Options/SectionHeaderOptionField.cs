namespace PcapNgNet.Options;

public class SectionHeaderOptionField : OptionFieldBase<SectionHeaderOptionCode>
{
    [FieldAlignment(4)]
    [FieldLength("Length")]
    [Subtype("Code", SectionHeaderOptionCode.End, typeof(EndOption))]
    [Subtype("Code", SectionHeaderOptionCode.Comment, typeof(CommentOption))]
    [Subtype("Code", SectionHeaderOptionCode.Hardware, typeof(SectionHeaderHardwareOption))]
    [Subtype("Code", SectionHeaderOptionCode.OperatingSystem, typeof(SectionHeaderOperatingSystemOption))]
    [Subtype("Code", SectionHeaderOptionCode.Application, typeof(SectionHeaderApplicationOption))]
    [SubtypeDefault(typeof(UnknownOption))]
    public Option Value { get; set; }
}
