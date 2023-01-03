using System.Runtime.Serialization;

namespace win_ui_app.Core.Enums;
public enum SignalType
{
    [EnumMember(Value = "All Red")]
    AllRed = 1,
    [EnumMember(Value = "All Green")]
    AllGreen = 2
}
