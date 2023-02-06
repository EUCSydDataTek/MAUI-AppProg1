namespace AppProg1;

public partial class DetailsModalPage : ContentPage
{
	public DetailsModalPage()
	{
		InitializeComponent();
	}

    private async void btnModalGoBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return false;   // Her implementeres en logik for at styre GoBack
    }
}