namespace PcapNgNet
{
    public class SectionHeaderBlock : Block
    {
        public SectionHeaderBlock()
        {
            Body = new SectionHeaderBlockBody();
        }
    }
}
