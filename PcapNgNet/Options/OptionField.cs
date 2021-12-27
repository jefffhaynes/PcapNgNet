namespace PcapNgNet.Options;

public class OptionFieldBase<TCode>
{
    [FieldOrder(0)]
    public TCode Code { get; set; }

    [FieldOrder(1)]
    public ushort Length { get; set; }
}

public class OptionField : OptionFieldBase<OptionCode>
{
    [FieldAlignment(4)]
    [FieldLength("Length")]
    public byte[] Value { get; set; }
}

public class OptionField<TCode> : OptionFieldBase<TCode>
{
    [FieldAlignment(4)]
    [FieldLength("Length")]
    public byte[] Value { get; set; }
}
