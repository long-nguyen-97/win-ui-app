using Microsoft.UI.Xaml.Data;

namespace win_ui_app.Helpers;
public class EnumToNumberConverter : IValueConverter
{
    public EnumToNumberConverter()
    {
    }

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return (int)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
