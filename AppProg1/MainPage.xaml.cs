using AppProg1.Models;

namespace AppProg1;

public partial class MainPage : ContentPage
{
    public Pie CherryPie { get; set; }

    public MainPage()
    {
        InitializeComponent();

        CherryPie = new Pie
        {
            Id = 1,
            PieName = "Cherry Pie",
            Price = 20
        };

        this.BindingContext = CherryPie;
    }

    private void btnIncreasePrice_Clicked(object sender, System.EventArgs e)
    {
        CherryPie.Price++;
        DisplayAlert("Price increaced!", $"{CherryPie.PieName} has the Price = {CherryPie.Price}", "Ok");
    }
}

