using AppProg1.Models;

namespace AppProg1.Views;

public partial class MonkeysPage : ContentPage
{
	public MonkeysPage()
	{
		InitializeComponent();
	}

    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string monkeyName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

        await Shell.Current.GoToAsync($"monkeydetails?name={monkeyName}");
    }
}