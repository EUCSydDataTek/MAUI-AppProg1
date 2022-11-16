using AppProg1.Models;

namespace AppProg1.Views;

public partial class BearsPage : ContentPage
{
	public BearsPage()
	{
		InitializeComponent();
	}

    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string bearName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

        await Shell.Current.GoToAsync($"beardetails?name={bearName}");
    }
}