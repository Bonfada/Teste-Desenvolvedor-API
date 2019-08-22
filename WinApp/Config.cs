using System.Configuration;

namespace WinApp
{
    public class Config
    {
        public static string GetConectionString()
        {
            return ConfigurationManager.ConnectionStrings["WeatherMapBase"].ConnectionString;
        }
        private static string GetUrl()
        {
            return ConfigurationManager.AppSettings.Get("WeatherMapKey");
        }

        public static string[] GetEndPoint(string City_Name = "", int City_Id = 0)
        {
            string uri = "http://api.openweathermap.org";
            string endpoin = $@"/data/2.5/forecast?q={City_Name}&mode=XML&APPID={GetUrl()}";
            return new string[] { uri, endpoin };
        }
    }
}
