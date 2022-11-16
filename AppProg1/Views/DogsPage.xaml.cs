using AppProg1.Models;

namespace AppProg1.Views;

public partial class DogsPage : ContentPage
{
	public DogsPage()
	{
		InitializeComponent();
	}


    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string dogName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

        await Shell.Current.GoToAsync($"dogdetails?name={dogName}");
    }
}