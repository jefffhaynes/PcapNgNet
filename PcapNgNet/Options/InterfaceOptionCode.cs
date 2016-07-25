namespace PcapNgNet.Options
{
    public enum InterfaceOptionCode : ushort
    {
        End = OptionCode.End,
        Comment = OptionCode.Comment,
        Name = 2,
        Description = 3,
        Ip4Address = 4,
        Ip6Adress = 5,
        MacAddress = 6,
        EuiAddress = 7,
        Speed = 8,
        TimeResolution = 9,
        TimeZone = 10,
        Filter = 11,
        OperatingSystem = 12,
        FrameCheckSequenceLength = 13,
        TimeOffset = 14
    }
}
