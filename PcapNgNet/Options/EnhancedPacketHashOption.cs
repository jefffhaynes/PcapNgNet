namespace PcapNgNet.Options;

public class EnhancedPacketHashOption : Option
{
    [FieldOrder(0)]
    public EnhancedPacketHashAlgorithm HashAlgorithm { get; set; }

    [FieldOrder(1)]
    public byte[] Hash { get; set; }
}
