using Microsoft.UI.Xaml.Data;
using Newtonsoft.Json.Linq;
using win_ui_app.Core.Enums;

namespace win_ui_app.Helpers;
public class EnumToStringConverter : IValueConverter
{
    public EnumToStringConverter()
    {
    }

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        try
        {
            return EnumExtensions.ToEnumString((dynamic)value);
        }
        catch
        {
            return string.Empty;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
