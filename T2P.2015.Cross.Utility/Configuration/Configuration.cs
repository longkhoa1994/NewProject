using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T2P._2015.Cross.Utility.Configuration
{
    public enum TIMEnvironment
    {
        Development = 1,
        Test = 2,
        Demo = 3,
        Production = 4,
        Partner = 5
    }
    

    public class Config
    {
        public static string GetAppSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }

        public static string GetAppSetting(string name, string defaultValue)
        {
            var value = ConfigurationManager.AppSettings[name];
            if (string.IsNullOrEmpty(value))
                return defaultValue;
            return value;
        }

        public static T GetAppSetting<T>(string name)
        {
            string result = ConfigurationManager.AppSettings[name];
            if (string.IsNullOrWhiteSpace(result))
            {
                return default(T);
            }
            else
            {
                return Conversion.Conversion.Parse<T>(ConfigurationManager.AppSettings[name]);
            }
           
        }


        public static string GetConnectionString(string connectName = "T2PConnection")
        {

            return ConfigurationManager.ConnectionStrings[connectName].ToString();
        }

        public static int AllowCompany()
        {
            return ConfigurationManager.AppSettings["AlowCompany"] == "1" ? 0 : 2;
        }

        public static TIMEnvironment Environment()
        {

            TIMEnvironment result;
            if (!System.Enum.TryParse<TIMEnvironment>(T2P._2015.Cross.Utility.Conversion.Conversion.ObjectToString(ConfigurationManager.AppSettings["Environment"]), out result))
            {
                result = TIMEnvironment.Development;
            }
            return result;
        }

        public static bool IsProduction()
        {
            bool result = false;
            switch (Environment())
            {
                case Configuration.TIMEnvironment.Development:
                case Configuration.TIMEnvironment.Demo:
                case Configuration.TIMEnvironment.Test:
                    break;
                case Configuration.TIMEnvironment.Production:
                    result = true;
                    break;
                default: break;
            }
            return result;
        }

        public static int Nbit()
        {
            int result = T2P._2015.Cross.Utility.Conversion.Conversion.ObjectToInt(ConfigurationManager.AppSettings["Nbit"]);
            if (result != 1 && result != 8)
            {
                result = 1;
            }
            return result;
        }
    }
}
