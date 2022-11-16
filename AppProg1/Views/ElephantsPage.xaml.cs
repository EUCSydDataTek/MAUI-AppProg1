using AppProg1.Models;

namespace AppProg1.Views;

public partial class ElephantsPage : ContentPage
{
	public ElephantsPage()
	{
		InitializeComponent();
	}

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string elephantName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

        await Shell.Current.GoToAsync($"elephantdetails?name={elephantName}");
    }
}