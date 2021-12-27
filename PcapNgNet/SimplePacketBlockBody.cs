namespace PcapNgNet;

public class SimplePacketBlockBody : BlockBody
{
    [FieldOrder(0)]
    public int PacketLength { get; set; }

    [FieldOrder(1)]
    [FieldAlignment(4)]
    public byte[] PacketData { get; set; }
}
