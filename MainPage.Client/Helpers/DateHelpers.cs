using System.Globalization;

namespace MainPage.Client.Helpers
{
    public static class DateHelpers
    {
        public readonly static CultureInfo CutlureInfo = new CultureInfo("en-US");
        public readonly static string DatePattern = "MMMM yyyy";
    }
}
