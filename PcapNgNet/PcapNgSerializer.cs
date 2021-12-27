namespace PcapNgNet;

public class PcapNgSerializer
{
    public BinarySerializer Serializer { get; } = new BinarySerializer();

    public void Serialize(Stream stream, PcapNg pcapNg)
    {
        Serializer.Serialize(stream, pcapNg);
    }

    public PcapNg Deserialize(Stream stream)
    {
        return Serializer.Deserialize<PcapNg>(stream);
    }
}
