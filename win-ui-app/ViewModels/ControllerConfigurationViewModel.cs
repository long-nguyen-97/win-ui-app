using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using win_ui_app.Contracts.Services;
using win_ui_app.Contracts.ViewModels;
using win_ui_app.Core.Contracts.Services;
using win_ui_app.Core.Enums;
using win_ui_app.Models;

namespace win_ui_app.ViewModels;

public class ControllerConfigurationViewModel : ObservableRecipient, INavigationAware
{
    private readonly IControllerConfigurationService _ctrlCfgService;
    private readonly INavigationService _navigationService;

    public IEnumerable<SignalType> SignalTypes => Enum.GetValues(typeof(SignalType)).OfType<SignalType>().ToList();

    public IEnumerable<DimmingLevel> DimmingLevels => Enum.GetValues(typeof(DimmingLevel)).OfType<DimmingLevel>().ToList();

    public ObservableControllerConfiguration? Config
    {
        get; set;
    }

    private bool _isValidStartupSignal;
    public bool IsValidStartupSignal
    {
        get => _isValidStartupSignal;
        set => SetProperty(ref _isValidStartupSignal, value);
    }

    private bool _isValidStartupSignal2;
    public bool IsValidStartupSignal2
    {
        get => _isValidStartupSignal2;
        set => SetProperty(ref _isValidStartupSignal2, value);
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

        IsValidStartupSignal = true;
        IsValidStartupSignal2 = true;
    }

    public async void OnNavigatedTo(object parameter)
    {
        var config = await _ctrlCfgService.GetControllerConfigurationAsync();
        Config = new ObservableControllerConfiguration(config);
        Config.PropertyChanged += OnControllerConfigurationPropertyChanged;
    }

    public void OnNavigatedFrom()
    {
    }

    private void OnInputMappingCardClick()
    {
        _navigationService.NavigateTo(typeof(InputMappingViewModel).FullName!);
    }

    private void OnControllerConfigurationPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(Config.StartupSignal) || e.PropertyName == nameof(Config.StartupSignal2))
        {
            var updatedConfig = sender as ObservableControllerConfiguration;
            if (updatedConfig?.StartupSignal == updatedConfig?.StartupSignal2)
            {
                IsValidStartupSignal = false;
                IsValidStartupSignal2 = false;
            }
            else
            {
                IsValidStartupSignal = true;
                IsValidStartupSignal2 = true;
            }
        }
    }
}
