using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet.Options
{
    public class OptionSection<TOptionField, TCode> where TOptionField : OptionFieldBase<TCode>
    {
        [ItemSerializeUntil("Code", OptionCode.End)]
        public List<TOptionField> Options { get; set; }
    }

    public class OptionSection : OptionSection<OptionField<OptionCode>, OptionCode>
    {
    }
}
