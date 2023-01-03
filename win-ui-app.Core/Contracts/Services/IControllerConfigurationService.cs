using win_ui_app.Core.Models;

namespace win_ui_app.Core.Contracts.Services;
public interface IControllerConfigurationService
{
    Task<ControllerConfiguration> GetControllerConfigurationAsync();
}
