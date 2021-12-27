namespace PcapNgNet;

public class SectionHeader
{
    [FieldOrder(0)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public BlockType Type { get; set; }

    [FieldOrder(1)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public int HeaderLength { get; set; }

    [FieldOrder(2)]
    public int ByteOrderMagic { get; set; }

    [FieldOrder(3)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public ushort MajorVersion { get; set; }

    [FieldOrder(4)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public ushort MinorVersion { get; set; }

    [FieldOrder(5)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public long Length { get; set; }

    [FieldOrder(6)]
    [FieldAlignment(4)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public OptionSection<SectionHeaderOptionField, SectionHeaderOptionCode> Options { get; set; }

    [FieldOrder(7)]
    [FieldEndianness("ByteOrderMagic", typeof(EndiannessConverter))]
    public int HeaderLength2 { get; set; }
}
