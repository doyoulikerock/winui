using Microsoft.UI.Xaml.Controls;

using winui3_template.ViewModels;

namespace winui3_template.Views;

public sealed partial class 비어있음Page : Page
{
    public 비어있음ViewModel ViewModel
    {
        get;
    }

    public 비어있음Page()
    {
        ViewModel = App.GetService<비어있음ViewModel>();
        InitializeComponent();
    }
}
