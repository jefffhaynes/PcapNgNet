using System;
using System.IO;
using BinarySerialization;

namespace PcapNgNet
{
    public class PcapNgSerializer
    {
        private readonly BinarySerializer _serializer = new BinarySerializer();
        private const uint LittleEndiannessMagic = 0x1A2B3C4D;
        private const uint BigEndiannessMagic = 0x4D3C2B1A;

        public BinarySerializer Serializer => _serializer;

        public PcapNgSerializer()
        {
        }

        private void SerializerOnMemberDeserialized(object sender, MemberSerializedEventArgs memberSerializedEventArgs)
        {
            if (memberSerializedEventArgs.MemberName == "ByteOrderMagic")
            {
                var endiannessMagic = Convert.ToUInt32(memberSerializedEventArgs.Value);

                if (endiannessMagic == LittleEndiannessMagic)
                    _serializer.Endianness = Endianness.Little;
                else if (endiannessMagic == BigEndiannessMagic)
                    throw new NotSupportedException("Big endian files not supported");
                else throw new InvalidDataException($"Endianness value {endiannessMagic} is not valid");

                // disconnect for performance
                Serializer.MemberDeserialized -= SerializerOnMemberDeserialized;
            }
        }

        public void Serialize(Stream stream, PcapNg pcapNg)
        {
            _serializer.Serialize(stream, pcapNg);
        }

        public PcapNg Deserialize(Stream stream)
        {
            _serializer.MemberDeserialized += SerializerOnMemberDeserialized;
            var pcapNg = _serializer.Deserialize<PcapNg>(stream);
            Serializer.MemberDeserialized -= SerializerOnMemberDeserialized;
            return pcapNg;
        }
    }
}
