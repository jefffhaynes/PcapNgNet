using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet.Options
{
    public class OptionSection<TCode>
    {
        [ItemSerializeUntil("Code", OptionCode.End)]
        public List<Option<TCode>> Options { get; set; }
    }
}
