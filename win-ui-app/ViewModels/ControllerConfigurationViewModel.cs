using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using win_ui_app.Contracts.Services;
using win_ui_app.Contracts.ViewModels;
using win_ui_app.Core.Contracts.Services;
using win_ui_app.Core.Enums;
using win_ui_app.Core.Models;

namespace win_ui_app.ViewModels;

public class ControllerConfigurationViewModel : ObservableRecipient, INavigationAware
{
    private readonly IControllerConfigurationService _ctrlCfgService;
    private readonly INavigationService _navigationService;
    private ControllerConfiguration? _config;

    public IEnumerable<SignalType> SignalTypes => Enum.GetValues(typeof(SignalType)).OfType<SignalType>().ToList();

    public IEnumerable<DimmingLevel> DimmingLevels => Enum.GetValues(typeof(DimmingLevel)).OfType<DimmingLevel>().ToList();

    public ControllerConfiguration? Config
    {
        get => _config;
        set => SetProperty(ref _config, value);
    }

    public ICommand InputMappingCardClickCommand
    {
        get;
    }

    public ControllerConfigurationViewModel(INavigationService navigationService, IControllerConfigurationService ctrlCfgService)
    {
        _navigationService = navigationService;
        _ctrlCfgService = ctrlCfgService;

        InputMappingCardClickCommand = new RelayCommand(OnInputMappingCardClick);
    }

    public async void OnNavigatedTo(object parameter)
    {
        Config = await _ctrlCfgService.GetControllerConfigurationAsync();
    }

    public void OnNavigatedFrom()
    {
    }

    private void OnInputMappingCardClick()
    {
        _navigationService.NavigateTo(typeof(InputMappingViewModel).FullName!);
    }
}
