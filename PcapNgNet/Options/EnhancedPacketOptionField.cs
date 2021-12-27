namespace PcapNgNet.Options;

public class EnhancedPacketOptionField : OptionFieldBase<EnhancedPacketOptionCode>
{
    [FieldAlignment(4)]
    [FieldLength("Length")]
    [Subtype("Code", EnhancedPacketOptionCode.End, typeof(EndOption))]
    [Subtype("Code", EnhancedPacketOptionCode.Comment, typeof(CommentOption))]
    [Subtype("Code", EnhancedPacketOptionCode.Flags, typeof(EnhancedPacketFlagsOption))]
    [Subtype("Code", EnhancedPacketOptionCode.Hash, typeof(EnhancedPacketHashOption))]
    [Subtype("Code", EnhancedPacketOptionCode.Dropcount, typeof(EnhancedPacketDropCountOption))]
    [SubtypeDefault(typeof(UnknownOption))]
    public Option Value { get; set; }
}
