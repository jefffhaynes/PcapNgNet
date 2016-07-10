using BinarySerialization;

namespace PcapNgNet
{
    internal class SummingValueConverter : IValueConverter
    {
        public object Convert(object value, object parameter, BinarySerializationContext context)
        {
            var a = System.Convert.ToInt64(value);
            var b = System.Convert.ToInt64(parameter);
            return a + b;
        }

        public object ConvertBack(object value, object parameter, BinarySerializationContext context)
        {
            var a = System.Convert.ToInt64(value);
            var b = System.Convert.ToInt64(parameter);
            return a - b;
        }
    }
}
