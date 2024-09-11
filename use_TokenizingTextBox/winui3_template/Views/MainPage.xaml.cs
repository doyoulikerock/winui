using Microsoft.UI.Xaml.Controls;

using winui3_template.ViewModels;

namespace winui3_template.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
