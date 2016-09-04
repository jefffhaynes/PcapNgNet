namespace PcapNgNet.Options
{
    public enum InterfaceDescriptionOptionCode : ushort
    {
        End = OptionCode.End,
        Comment = OptionCode.Comment,
        Name = 2,
        Description = 3,
        // ReSharper disable InconsistentNaming
        IP4Address = 4,
        IP6Address = 5,
        // ReSharper restore InconsistentNaming
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
