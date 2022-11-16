using AppProg1.Views;
using System.Windows.Input;

namespace AppProg1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        BindingContext = this;      // nødvendig for at Command binding fungerer

        Routing.RegisterRoute("monkeydetails", typeof(MonkeyDetailPage));
        Routing.RegisterRoute("beardetails", typeof(BearDetailPage));
        Routing.RegisterRoute("catdetails", typeof(CatDetailPage));
        Routing.RegisterRoute("dogdetails", typeof(DogDetailPage));
        Routing.RegisterRoute("elephantdetails", typeof(ElephantDetailPage));
    }

    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
}
