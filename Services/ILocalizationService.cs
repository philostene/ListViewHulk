using System.Globalization;

namespace ListViewHulk.Services
{
    public interface ILocalizationService
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
