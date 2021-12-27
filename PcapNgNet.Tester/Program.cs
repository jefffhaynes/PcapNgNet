using System;
using System.IO;
using BinarySerialization;

namespace PcapNgNet.Tester;

class Program
{
    static void Main(string[] args)
    {
        var serializer = new BinarySerializer();

        serializer.MemberSerializing += OnMemberSerializing;
        serializer.MemberSerialized += OnMemberSerialized;
        serializer.MemberDeserializing += OnMemberDeserializing;
        serializer.MemberDeserialized += OnMemberDeserialized;

        using var stream = new FileStream(args[0], FileMode.Open, FileAccess.Read);
        var pcap = serializer.Deserialize<PcapNg>(stream);
    }

    private static void OnMemberSerializing(object sender, MemberSerializingEventArgs e)
    {
        Console.CursorLeft = e.Context.Depth * 4;
        Console.WriteLine("S-Start: {0} @ {1}", e.MemberName, e.Offset);
    }

    private static void OnMemberSerialized(object sender, MemberSerializedEventArgs e)
    {
        Console.CursorLeft = e.Context.Depth * 4;
        var value = e.Value ?? "null";
        Console.WriteLine("S-End: {0} ({1}) @ {2}", e.MemberName, value, e.Offset);
    }

    private static void OnMemberDeserializing(object sender, MemberSerializingEventArgs e)
    {
        Console.CursorLeft = e.Context.Depth * 4;
        Console.WriteLine("D-Start: {0} @ {1}", e.MemberName, e.Offset);
    }

    private static void OnMemberDeserialized(object sender, MemberSerializedEventArgs e)
    {
        Console.CursorLeft = e.Context.Depth * 4;
        var value = e.Value ?? "null";
        Console.WriteLine("D-End: {0} ({1}) @ {2}", e.MemberName, value, e.Offset);
    }
}
