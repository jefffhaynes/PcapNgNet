using System;
using System.IO;
using BinarySerialization;

namespace PcapNgNet
{
    public class PcapNgSerializer
    {
        private readonly BinarySerializer _serializer = new BinarySerializer();
        private const int LittleEndiannessMagic = 0x1A2B3C4D;
        private const int BigEndiannessMagic = 0x4D3C2B1A;

        public BinarySerializer Serializer => _serializer;

        public PcapNgSerializer()
        {
            _serializer.MemberDeserialized += (sender, args) =>
            {
                if (args.MemberName == "ByteOrderMagic")
                {
                    var endiannessMagic = Convert.ToUInt32(args.Value);

                    if (endiannessMagic == LittleEndiannessMagic)
                        _serializer.Endianness = Endianness.Little;
                    else if (endiannessMagic == BigEndiannessMagic)
                        throw new NotSupportedException("Big endian files not supported");
                    else throw new InvalidDataException($"Endianness value {endiannessMagic} is not valid");
                }
            };
        }

        public void Serialize(Stream stream, PcapNg pcapNg)
        {
            _serializer.Serialize(stream, pcapNg);
        }

        public PcapNg Deserialize(Stream stream)
        {
            return _serializer.Deserialize<PcapNg>(stream);
        }
    }
}
