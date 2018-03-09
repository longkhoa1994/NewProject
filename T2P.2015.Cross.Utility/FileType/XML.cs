using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace T2P._2015.Cross.Utility.FileType
{
    public static class XML
    {
        public static string SerializeToString<T>(T obj, bool omitXmlDeclaration = false)
        {
            try
            {
                Type type = obj.GetType();
                DataContractSerializer dcSer = new DataContractSerializer(type);
                StringBuilder xmlString = new StringBuilder();
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = omitXmlDeclaration;

                XmlWriter writer = XmlWriter.Create(xmlString, settings);
                dcSer.WriteObject(writer, obj);
                writer.Close();

                return xmlString.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", string.Empty)
                    .Replace("\r\n", string.Empty)
                    .Replace("xmlns:q1=\"http://www.w3.org/2001/XMLSchema\"", string.Empty)
                    .Replace("xmlns:d2p1=\"http://www.w3.org/2001/XMLSchema-instance\"", string.Empty)
                    .Replace("xmlns:d2p1=\"http://schemas.microsoft.com/2003/10/Serialization/Arrays\"", string.Empty)
                    .Replace("d2p1:", string.Empty)
                    .Replace("xmlns:d4p1=\"http://www.w3.org/2001/XMLSchema\" i:type=\"d4p1:string\"", string.Empty)
                    .Replace("xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\"", string.Empty)
                    .Replace("xmlns=\"http://schemas.datacontract.org/2004/07/" + type.Namespace + "\"", string.Empty)
                    .Replace(" xmlns=\"http://schemas.microsoft.com/2003/10/Serialization/", string.Empty)
                    .Replace(" xmlns:d4p1=\"http://www.w3.org/2001/XMLSchema\" i:type=\"d4p1:long\"", string.Empty)
                    .Replace("><", ">\n<")
                    ;
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return string.Empty;
            }
        }

        public static object DeserializeToXML(this string serialized, Type type)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(type);

            using (TextReader reader = new StringReader(serialized))
            {
                return serializer.Deserialize(reader);
            }
        }

        public static T DeserializeToXML<T>(this string serialized)
        {
            var serializer = new DataContractSerializer(typeof(T));
            using (var reader = new StringReader(serialized))
            using (var stm = new XmlTextReader(reader))
            {
                return (T)serializer.ReadObject(stm);
            }
        }
        public static T DeserializeToXML<T>(string serialized, string namespacePath)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), namespacePath);
            T result = default(T);

            using (TextReader reader = new StringReader(serialized))
            {
                return (T)serializer.Deserialize(reader);
            }
        }



        public static T DeserializeToXML2<T>(string serialized)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            T result = default(T);

            using (TextReader reader = new StringReader(serialized))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static T FileToObject<T>(string fileName)
        {
            T result = default(T);
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                result = (T)xs.Deserialize(file);
                file.Close();
            }
            return result;
        }

        public static string XMLToString<T>(T obj)
        {
            try
            {
                MemoryStream mem = new MemoryStream();
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                System.IO.StreamWriter file = new System.IO.StreamWriter(mem);
                writer.Serialize(file, obj);
                string result = System.Text.Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                file.Close();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void WriteXML<T>(T obj, string fileName)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
                writer.Serialize(file, obj);
                file.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void WriteXML2<T>(T obj, string fileName)
        {
            try
            {
                string xml = SerializeToString(obj);
                T2P._2015.Cross.Utility.FileType.Text text = new Text();
                StreamWriter sw = new StreamWriter(fileName, false);
                sw.Write(xml);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void WriteXMLDataContract<T>(T obj, string fileName)
        {
            try
            {
                DataContractSerializer s = new DataContractSerializer(typeof(T));
                using (FileStream fs = File.Open(fileName, FileMode.Create))
                {
                    s.WriteObject(fs, obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T FileToObjectDataContract<T>(string fileName)
        {
            T result = default(T);
            DataContractSerializer dcs = new DataContractSerializer(typeof(T));
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());

                result = (T)dcs.ReadObject(reader);
            }
            return result;
        }

        public static List<string> XMLValidate(string fileXML, string fileSchema, string nameSpace)
        {
            try
            {
                List<string> result = new List<string>();
                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add(nameSpace, fileSchema);
                XDocument doc = XDocument.Load(fileXML);
                doc.Validate(schemas, (o, e) =>
                {
                    result.Add(e.Message);
                });

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static List<string> XMLValidate<T>(T objectType, string fileSchema, string nameSpace)
        //{
        //    try
        //    {
        //        List<string> result = new List<string>();
        //        XmlSchemaSet schemas = new XmlSchemaSet();
        //        schemas.Add(nameSpace, fileSchema);
        //        Stream temp = (Stream)SerializeToStream<T>(objectType);
        //        XDocument doc = XDocument.Load(temp);
        //        doc.Validate(schemas, (o, e) =>
        //        {
        //            result.Add(e.Message);
        //        });
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<string> XMLValidate<T>(T objectType, string fileSchema, string nameSpace)
        {
            string fileXML = AppDomain.CurrentDomain.BaseDirectory + @"XSD\fileValidate.xml";
            try
            {
                //List<string> result = new List<string>();
                //XmlSchemaSet schemas = new XmlSchemaSet();
                //schemas.Add(nameSpace, fileSchema);

                //XDocument doc = new XDocument();
                //using (var writer = doc.CreateWriter())
                //{
                //    // write xml into the writer
                //    var serializer = new DataContractSerializer(objectType.GetType());
                //    serializer.WriteObject(writer, objectType);
                //}

                //Stream temp = (Stream)SerializeToStream<T>(objectType);

                WriteXML(objectType, fileXML);

                return XMLValidate(fileXML, fileSchema, nameSpace);

                //return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (File.Exists(fileXML)) File.Delete(fileXML);
            }
        }

        public static MemoryStream SerializeToStream<T>(T objectType)
        {
            MemoryStream stream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, objectType);
            return stream;
        }

        public static string HTMLDecode(string body)
        {
            return HttpUtility.HtmlDecode(body);
        }

        public static string HTMLEncode(string body)
        {
            return HttpUtility.HtmlEncode(body);
        }
        public static string SerializeToString<T>(T obj, string namespacePath)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(obj.GetType(), namespacePath);

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }
        public static string SerializeToString2<T>(T obj)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }
    }
}