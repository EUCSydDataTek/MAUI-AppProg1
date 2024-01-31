using System.Globalization;

namespace AppProg1.Converters;
public class BoolColorConverter<T> : IValueConverter
{
    public T TrueColor { get; set; }
    public T FalseColor { get; set; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool)
        {
            if ((bool)value)
            {
                return TrueColor;
            }
            else
            {
                return FalseColor;
            }
        }
        return Colors.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}