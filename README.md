# PcapNgNet

A basic serializer/deserializer for PCAPNG files.

```c#

var serializer = new PcapNgSerializer();

using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
{
	var pcap = serializer.Deserialize(stream);

	// ...
}

```