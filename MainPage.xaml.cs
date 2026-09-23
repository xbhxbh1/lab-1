using StudentCabinetMVVM.ViewModels;

namespace StudentCabinetMVVM;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new StudentViewModel();
    }
}
