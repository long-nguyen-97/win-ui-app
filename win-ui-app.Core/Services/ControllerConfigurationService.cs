using win_ui_app.Core.Contracts.Services;
using win_ui_app.Core.Enums;
using win_ui_app.Core.Models;

namespace win_ui_app.Core.Services;
public class ControllerConfigurationService : IControllerConfigurationService
{
    private ControllerConfiguration _configuration;

    public ControllerConfigurationService()
    {
    }

    public async Task<ControllerConfiguration> GetControllerConfigurationAsync()
    {
        _configuration ??= new ControllerConfiguration
        {
            StartupSignal = SignalType.AllRed,
            StartupSignal2 = SignalType.AllGreen,
            RestartWhenLampsOn = true,
            EnableDimming = true,
            DimmingLevel = DimmingLevel.Level2
        };

        await Task.CompletedTask;
        return _configuration;
    }
}
