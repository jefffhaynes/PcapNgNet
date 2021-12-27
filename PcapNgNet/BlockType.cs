namespace PcapNgNet;

public enum BlockType
{
    InterfaceDescrption = 0x00000001,
    PacketBlock = 0x00000002,
    SimplePacket = 0x00000003,
    NameResolution = 0x00000004,
    InterfaceStatistics = 0x00000005,
    EnhancedPacket = 0x00000006,
    Timestamp = 0x00000007,
    EncapsulationInformation = 0x00000008,
    SectionHeader = 0x0A0D0D0A
}
