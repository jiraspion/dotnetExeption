
using System.Globalization;

namespace System
{
    static class extencao
    {
        public static string Cortar(this string thisObjeto, int count)
        {
            if(thisObjeto.Length <= count)
            {
                return thisObjeto;
            }
            else
            {
                return thisObjeto.Substring(0, count) + "...";
            }
        }

        public static string DataCortada(this DateTime thisObjeto)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObjeto);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " day";
            }

        }
    }
}
