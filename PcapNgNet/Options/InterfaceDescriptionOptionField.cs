namespace PcapNgNet.Options;

public class InterfaceDescriptionOptionField : OptionFieldBase<InterfaceDescriptionOptionCode>
{
    [FieldAlignment(4)]
    [FieldLength("Length")]
    [Subtype("Code", InterfaceDescriptionOptionCode.End, typeof(EndOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.Comment, typeof(CommentOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.Name, typeof(InterfaceDescriptionNameOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.Description, typeof(InterfaceDescriptionDescriptionOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.IP4Address, typeof(InterfaceDescriptionIPv4AddressOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.IP6Address, typeof(InterfaceDescriptionIPv6AddressOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.MacAddress, typeof(InterfaceDescriptionMacAddressOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.EuiAddress, typeof(InterfaceDescriptionEuiAddressOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.Speed, typeof(InterfaceDescriptionSpeedOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.TimeResolution, typeof(InterfaceDescriptionTimestampResolutionOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.TimeZone, typeof(InterfaceDescriptionTimeZoneOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.Filter, typeof(InterfaceDescriptionFilterOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.OperatingSystem, typeof(InterfaceDescriptionOperatingSystemOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.FrameCheckSequenceLength, typeof(InterfaceDescriptionFrameCheckSequenceLengthOption))]
    [Subtype("Code", InterfaceDescriptionOptionCode.TimeOffset, typeof(InterfaceDescriptionTimestampOffsetOption))]
    [SubtypeDefault(typeof(UnknownOption))]
    public Option Value { get; set; }
}
