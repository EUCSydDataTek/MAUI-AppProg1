namespace AppProg1;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(string name)
	{
		InitializeComponent();

        if (name.Length == 0) { return; }
        lblName.Text = $"Velkommen, {name}";
	}

    private async void btnGoBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}