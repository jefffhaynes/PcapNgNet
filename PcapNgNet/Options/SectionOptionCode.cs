namespace PcapNgNet.Options
{
    public enum SectionOptionCode : ushort
    {
        End = OptionCode.End,
        Comment = OptionCode.Comment,
        Hardware = 0x2,
        OperatingSystem = 0x3,
        Application = 0x4
    }
}
