namespace PcapNgNet.Options
{
    public enum EnhancedPacketHashAlgorithm : byte
    {
        TwosComplement = 0x0,
        Xor = 0x1,
        Crc32 = 0x2,
        MD5 = 0x3,
        Sha1 = 0x4
    }
}
