using AppProg1.Models;

namespace AppProg1;

public partial class MainPage : ContentPage
{
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
}

