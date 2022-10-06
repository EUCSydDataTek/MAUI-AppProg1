using AppProg1.Models;
using AppProg1.ViewModels;

namespace AppProg1;

public partial class MainPage : ContentPage
{
    public Pie Pie { get; set; }        // #1 + #2 BINDING TO SINGLE OBJECT

    public PieDetailViewModel PieDetailViewModel { get; set; }  // #3 BINDING TO VIEWMODEL

    public MainPage()
    {
        InitializeComponent();

        #region #1 BINDING DIRECT TO SINGLE OBJECT
        Pie = new Pie
        {
            Id = 1,
            Description = "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            InStock = true,
            AvailableFromDate = new DateTime(2018, 12, 1),
            PieName = "Apple pie",
            Price = 20.95
        };
        this.BindingContext = Pie;      // #1 BINDING DIRECT TO SINGLE OBJECT
        //this.BindingContext = this;   // #2 BINDING VIA PAGE AND PROPERTY TO SINGLE OBJECT
        #endregion

        #region #3 BINDING TO VIEWMODEL
        //PieDetailViewModel = new PieDetailViewModel()
        //{
        //    Pie = new Pie
        //    {
        //        Id = 1,
        //        Description =
        //          "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
        //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
        //        InStock = true,
        //        AvailableFromDate = new DateTime(2018, 12, 1),
        //        PieName = "Apple pie",
        //        Price = 20.95
        //    },
        //    UserName = "Bethany"
        //};
        //this.BindingContext = PieDetailViewModel;
        #endregion
    }

    private async void SavePieButton_OnClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Pie saved", "Done");
    }
}

