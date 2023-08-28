using AppProg1.Models;
using System.Collections.ObjectModel;

namespace AppProg1.ViewModels;
public class MainPageViewModel : BaseViewModel
{
    public ObservableCollection<Person> Persons { get; }

    #region CONSTRUCTOR
    public MainPageViewModel()
    {
        Persons = new ObservableCollection<Person>
                {
                    new Person { Name = "Anna", Age = 27 },
                    new Person { Name = "Christian", Age = 32 },
                    new Person { Name = "Helle", Age = 54 }
                };
    }
    #endregion

    #region PROPERTY
    Person _personSelectedItem = null;
    public Person PersonSelectedItem
    {
        get => _personSelectedItem;
        set
        {
            if (SetProperty(ref _personSelectedItem, value))
            {
                Name = value.Name;
                Age = value.Age;
            }
        }
    }

    string _name;
    public string Name
    {
        get { return _name; }
        set { SetProperty(ref _name, value); }
    }

    int _age;
    public int Age
    {
        get => _age;
        set { SetProperty(ref _age, value); }
    }
}
#endregion
