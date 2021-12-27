namespace PcapNgNet.Options;

public enum EnhancedPacketOptionCode : ushort
{
    End = OptionCode.End,
    Comment = OptionCode.Comment,
    Flags = 2,
    Hash = 3,
    Dropcount = 4
}
