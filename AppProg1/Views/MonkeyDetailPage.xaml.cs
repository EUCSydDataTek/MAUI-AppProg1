using AppProg1.Data;
using AppProg1.Models;

namespace AppProg1.Views;

[QueryProperty(nameof(Name), "name")]
public partial class MonkeyDetailPage : ContentPage
{
    public string Name
    {
        set
        {
            LoadAnimal(value);
        }
    }

    public MonkeyDetailPage()
	{
		InitializeComponent();
    }

    void LoadAnimal(string name)
    {
        try
        {
            Animal animal = MonkeyData.Monkeys.FirstOrDefault(a => a.Name == name);
            BindingContext = animal;
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to load animal.");
        }
    }
}