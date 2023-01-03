using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using win_ui_app.ViewModels;

namespace win_ui_app.Views;

public sealed partial class ControllerConfigurationPage : Page
{
    public ControllerConfigurationViewModel ViewModel
    {
        get;
    }

    public ControllerConfigurationPage()
    {
        ViewModel = App.GetService<ControllerConfigurationViewModel>();
        InitializeComponent();
    }
}
