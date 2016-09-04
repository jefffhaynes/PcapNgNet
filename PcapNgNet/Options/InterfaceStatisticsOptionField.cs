using BinarySerialization;

namespace PcapNgNet.Options
{
    public class InterfaceStatisticsOptionField : OptionFieldBase<InterfaceStatisticsOptionCode>
    {
        [FieldAlignment(4)]
        [FieldLength("Length")]
        [Subtype("Code", InterfaceStatisticsOptionCode.End, typeof(EndOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.Comment, typeof(CommentOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.StartTime, typeof(InterfaceStatisticsStartTimeOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.EndTime, typeof(InterfaceStatisticsEndTimeOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.PacketReceiveCount, typeof(InterfaceStatisticsPacketReceiveCountOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.PacketDropCount, typeof(InterfaceStatisticsPacketDropCountOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.FilterAcceptCount, typeof(InterfaceStatisticsFilterAcceptCountOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.OperatingSystemDropCount, typeof(InterfaceStatisticsOperatingSystemDropCountOption))]
        [Subtype("Code", InterfaceStatisticsOptionCode.PacketDeliverCount, typeof(InterfaceStatisticsPacketDeliveryCountOption))]
        [SubtypeDefault(typeof(UnknownOption))]
        public Option Value { get; set; }
    }
}
