# 11.1_ValueConverter

## Currency Converter
Sætter $ foran værdien.

&nbsp;

## DoNothingConverter
Benyttes til debug.

Viser også en alternativ måde at instantiere en converter med `IMarkupExtension`: 
```csharp
public class DoNothingConverter : IValueConverter, IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    { return this; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    { return value; }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    { return value; }
}
```

&nbsp;

## BoolColorConverter

In stock knappen styrer farven på Save Pie knappen. Der er oprettet en View-to-View binding mellem Switchen og knappen.
Der anvendes ElementPropertyBinding i XAML til at binde til en property på en anden view.
Desuden oprettes to parametre af typen  Color og deres værdier sættes i XAML.

**BoolColorConverter.cs:**

```csharp
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
```

**XAML:**

```xml
<Button.BackgroundColor>
    <Binding Path="IsToggled" Source="{x:Reference swInStock}">
        <Binding.Converter>
            <converters:BoolColorConverter
                x:TypeArguments="Color"
                FalseColor="Red"
                TrueColor="Green" />
        </Binding.Converter>
    </Binding>
</Button.BackgroundColor>
```

&nbsp;