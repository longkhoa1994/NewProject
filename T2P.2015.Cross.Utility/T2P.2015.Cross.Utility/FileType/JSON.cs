using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace T2P._2015.Cross.Utility.FileType
{
    public class JSON
    {
        public static void WriteJsonToFile<T>(T obj, string fileName)
        {
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
                var json = new JavaScriptSerializer().Serialize(obj);
                file.Write(json);
                file.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string JsonToString<T>(T obj)
        {
            try
            {
                string result = new JavaScriptSerializer().Serialize(obj);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T JsonToObject<T>(string json)
        {
            try
            {
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
