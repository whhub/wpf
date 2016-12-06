using System.ComponentModel;
using System.Globalization;

namespace XamlAttribute
{
    class StringToHumanTypeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                var h = new Human();
                h.Name = value as string;
                return h;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
