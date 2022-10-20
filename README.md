# CollectionView

#### 1. Demo af ItemsSource, der består af objekter oprettet direkte i xaml

```xml
<CollectionView 
            SelectionMode="None">

    <!--1. Med ItemsSource, der består af objekter oprettet direkte i xaml-->
    <!--2. Med ItemsSource="{Binding Monkeys}"-->
    <CollectionView.ItemsSource>
        <x:Array Type="{x:Type model:Monkey}">
            <model:Monkey
                    Name="Baboon"
                    ImageUrl="https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg"
                    Location="Africa and Asia" />
            <model:Monkey
                    Name="Capuchin Monkey"
                    ImageUrl="https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg"
                    Location="Central and South America" />
            <model:Monkey
                    Name="Red-shanked douc"
                    ImageUrl="https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/douc.jpg"
                    Location="Vietnam" />
        </x:Array>
    </CollectionView.ItemsSource>


    <CollectionView.ItemTemplate>
        <DataTemplate x:DataType="model:Monkey">
            <Grid Padding="10">
                <Frame HeightRequest="125" HasShadow="True">
                    <Grid Padding="0" ColumnDefinitions="125,*">
                        <Image Source="{Binding ImageUrl}"
                                Aspect="AspectFill"
                                WidthRequest="125"
                                HeightRequest="125"/>
                        <VerticalStackLayout
                                Grid.Column="1"
                                Padding="10">
                            <Label Text="{Binding Name}" />
                            <Label Text="{Binding Location}" />
                        </VerticalStackLayout>
                    </Grid>
                </Frame>
            </Grid>
        </DataTemplate>
    </CollectionView.ItemTemplate>

</CollectionView>
```

&nbsp;

#### 2. Demo af `ItemsSource` bindet til `Monkeys` collection

```xml
<CollectionView ItemsSource="{Binding Monkeys}"
            SelectionMode="None">
```

&nbsp;

#### 3. Demo af ObservableCollection

Prøv at klikke på knapperne Add eller Delete. Der sker intet på UI, selv om man kan debugge og se at Monkey-collection påvirkes. Hvorfor? Manglende trig af CollectionChanged eventet.

Ændrér List`<Monkey>` til `ObservableCollection<Monkey>` og se at nu virker det.


