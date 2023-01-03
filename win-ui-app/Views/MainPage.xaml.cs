using Microsoft.UI.Xaml.Controls;

using win_ui_app.ViewModels;

namespace win_ui_app.Views;

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
