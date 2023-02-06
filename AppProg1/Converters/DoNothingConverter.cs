using System.Globalization;

namespace AppProg1.Converters;
public class DoNothingConverter : IValueConverter, IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value;
    }
}
