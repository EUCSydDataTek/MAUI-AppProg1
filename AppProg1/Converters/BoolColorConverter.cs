using System.Globalization;

namespace AppProg1.Converters;
public class BoolColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool)
        {
            if ((bool)value)
            {
                return Colors.Green;
            }
            else
            {
                return Colors.Red;
            }
        }
        return Colors.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}