using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using win_ui_app.Core.Enums;
using win_ui_app.Core.Models;

namespace win_ui_app.Models;

public class ObservableControllerConfiguration : ObservableObject
{
    private readonly ControllerConfiguration _config;

    public ObservableControllerConfiguration(ControllerConfiguration config)
    {
        _config = config;
    }

    public SignalType StartupSignal
    {
        get => _config.StartupSignal;
        set => SetProperty(_config.StartupSignal, value, _config, (u, n) => u.StartupSignal = n);
    }

    public SignalType StartupSignal2
    {
        get => _config.StartupSignal2;
        set => SetProperty(_config.StartupSignal2, value, _config, (u, n) => u.StartupSignal2 = n);
    }

    public bool RestartWhenLampsOn
    {
        get => _config.RestartWhenLampsOn;
        set => SetProperty(_config.RestartWhenLampsOn, value, _config, (u, n) => u.RestartWhenLampsOn = n);
    }

    public bool EnableDimming
    {
        get => _config.EnableDimming;
        set => SetProperty(_config.EnableDimming, value, _config, (u, n) => u.EnableDimming = n);
    }

    public DimmingLevel DimmingLevel
    {
        get => _config.DimmingLevel;
        set => SetProperty(_config.DimmingLevel, value, _config, (u, n) => u.DimmingLevel = n);
    }
}
