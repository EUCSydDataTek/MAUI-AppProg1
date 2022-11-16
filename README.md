# Data binding

Demonstrerer simpel data binding mellem en POCO Pie-klasse og nogle View-kontroller. Bindingen sker mellem UI og file-behind, altså i samme klasse.

1. Et `Pie`-objekt oprettes
2. `MainStackLayout.BindingContext` sættes til at pege på `pie`-objektet
3. Labels for `pie.PieName` og `pie.Price` binder til data fordi begge ligger inden for det StackLayout,hvis `BindingContext` har fat i `pie`-objektet. Men  `pie.Id` vises ikke.
4. Flytter man `BindingContext` til at omfatte hele UI, vises `Id` også.

**MainPage.xaml**

```xml
<VerticalStackLayout Margin="20" Spacing="20"
                        x:DataType="model:Pie">

    <Label Text="{Binding Id, StringFormat='ID: {0}'}"/>

    <VerticalStackLayout x:Name="MainStackLayout"                  
                        Spacing="20">
        <HorizontalStackLayout>
            <Label Text="Pie name: "/>
            <Label Text="{Binding PieName}"/>
        </HorizontalStackLayout>

        <HorizontalStackLayout>
            <Label Text="Price: "/>
            <Label Text="{Binding Price}"/>
        </HorizontalStackLayout>

    </VerticalStackLayout>
</VerticalStackLayout>
```


**MainPage.xaml.cs**

```csharp
public MainPage()
{
	InitializeComponent();

    // Oprettelse af Pie-objekt i koden
    Pie pie = new Pie
    {
        Id = 1,
        PieName = "Cherry Pie",
        Price = 20
    };

    MainStackLayout.BindingContext = pie;

    //this.BindingContext = pie;
}
```


