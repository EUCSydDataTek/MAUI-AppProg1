using AppProg1.Data;
using AppProg1.Models;

namespace AppProg1.Views;

[QueryProperty(nameof(Name), "name")]
public partial class CatDetailPage : ContentPage
{
    public string Name
    {
        set
        {
            LoadAnimal(value);
        }
    }

    public CatDetailPage()
    {
        InitializeComponent();
    }

    void LoadAnimal(string name)
    {
        try
        {
            Animal animal = CatData.Cats.FirstOrDefault(a => a.Name == name);
            BindingContext = animal;
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to load animal.");
        }
    }
}