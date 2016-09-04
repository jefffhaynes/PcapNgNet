namespace PcapNgNet.Options
{
    public enum EnhancedPacketFlags
    {
        None = 0x0,
        Outbound = 0x1,
        Inbound = 0x2,
        Unicast = 0x4,
        Multicast = 0x8,
        Broadcast = Unicast | Multicast,
        Promiscuous = 0x10
    }
}
