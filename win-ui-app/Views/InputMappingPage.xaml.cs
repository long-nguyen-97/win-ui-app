using Microsoft.UI.Xaml.Controls;

using win_ui_app.ViewModels;

namespace win_ui_app.Views;

public sealed partial class InputMappingPage : Page
{
    public InputMappingViewModel ViewModel
    {
        get;
    }

    public InputMappingPage()
    {
        ViewModel = App.GetService<InputMappingViewModel>();
        InitializeComponent();
    }
}
