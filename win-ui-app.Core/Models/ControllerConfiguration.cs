using win_ui_app.Core.Enums;

namespace win_ui_app.Core.Models;
public class ControllerConfiguration
{
    public SignalType StartupSignal
    {
        get;
        set;
    }

    public SignalType StartupSignal2
    {
        get;
        set;
    }

    public bool RestartWhenLampsOn
    {
        get;
        set;
    }

    public bool EnableDimming
    {
        get;
        set;
    }

    public DimmingLevel DimmingLevel
    {
        get;
        set;
    }
}
