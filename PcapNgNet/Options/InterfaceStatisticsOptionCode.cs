namespace PcapNgNet.Options;

public enum InterfaceStatisticsOptionCode : ushort
{
    End = OptionCode.End,
    Comment = OptionCode.Comment,
    StartTime = 2,
    EndTime = 3,
    PacketReceiveCount = 4,
    PacketDropCount = 5,
    FilterAcceptCount = 6,
    OperatingSystemDropCount = 7,
    PacketDeliverCount = 8
}
