namespace AppProg1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void menuDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DetailsPage(entryName.Text));
    }

    private async void menuDetailsModal_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DetailsModalPage());
    }

    private async void btnGotoDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DetailsPage(entryName.Text));
    }
}

