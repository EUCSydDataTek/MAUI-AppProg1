using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppProg1.Models;
public class Pie : INotifyPropertyChanged
{
    private int _id;
    private string _pieName;
    private string _description;
    private double _price;
    private string _imageUrl;
    private bool _inStock;
    private string _email;

    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            RaisePropertyChanged(nameof(Id));
        }
    }

    public string PieName
    {
        get => _pieName;
        set
        {
            _pieName = value;
            RaisePropertyChanged(nameof(PieName));
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            RaisePropertyChanged(nameof(Description));
        }
    }

    public double Price
    {
        get => _price;
        set
        {
            _price = value;
            RaisePropertyChanged(nameof(Price));
        }
    }

    public string ImageUrl
    {
        get => _imageUrl;
        set
        {
            _imageUrl = value;
            RaisePropertyChanged(nameof(ImageUrl));
        }
    }

    public bool InStock
    {
        get => _inStock;
        set
        {
            _inStock = value;
            RaisePropertyChanged(nameof(InStock));
        }
    }


    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            RaisePropertyChanged(nameof(Email));
        }
    }

    public List<string> Ingredients { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
