using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net.Appender;
using log4net;
using System.Reflection;
using T2P._2015.Cross.Utility.FileType;
namespace T2P._2015.Cross.Utility.Log
{
    public class Logging
    {
        public static string FileLocation { get; set; }
        public static void Error(string messageLog, string project = "Travel2Pay")
        {
            log4net.ILog log = Init<Logging>(project);
            log.Error(messageLog);
        }

        public static void Info(string messageLog, string project = "Travel2Pay")
        {
            log4net.ILog log = Init<Logging>(project);
            log.Info(messageLog);
        }

        public static void Info(TimeSpan messageLog,string project = "Travel2Pay")
        {
            log4net.ILog log = Init<Logging>(project);
            log.Info(messageLog.ToString());
        }

        public static void Info(string messageLog, string project = "Travel2Pay", MethodBase method = null, params object[] values)
        {
            log4net.ILog log = Init<Logging>(project);
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine(messageLog);
            if (method != null)
            {
                ParameterInfo[] parms = method.GetParameters();
                object[] namevalues = new object[2 * parms.Length];

                messageBuilder.AppendLine("Input ");
                string msg = string.Empty;
                for (int i = 0, j = 0; i < values.Length; i++, j += 2)
                {

                    namevalues[j] = parms[i].Name;
                    if (i < values.Length) namevalues[j + 1] = values[i];

                    string serialize = string.Empty;
                    if (values[i] != null)
                    {
                        serialize = XML.SerializeToString(values[i]);
                    }
                    else
                    {
                        serialize = "null";
                    }
                    msg = parms[i].Name + " = " + serialize;
                    messageBuilder.AppendLine(msg);
                }
            }


            log.Info(messageBuilder);
        }
        public static void Info(string messageLog, string project = "Travel2Pay", params object[] values)
        {
            log4net.ILog log = Init<Logging>(project);
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine(messageLog);

            //messageBuilder.AppendLine("Input ");
            string msg = string.Empty;
            for (int i = 0; i < values.Length; i++)
            {

                string serialize = string.Empty;
                if (values[i] != null)
                {
                    serialize = XML.SerializeToString(values[i]);
                }
                else
                {
                    serialize = "null";
                }
                msg = "Object " + i + " = " + serialize;
                messageBuilder.AppendLine(msg);
            }



            log.Info(messageBuilder);
        }

        public static void Warn(string messageLog, string project = "Travel2Pay")
        {
            log4net.ILog log = Init<Logging>(project);
            log.Warn(messageLog);
        }

        private static log4net.ILog Init<T>(string project = "Travel2Pay")
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(T));
            ChangeFileLog(project);
            return log;
        }

        private static void ChangeFileLog(string _Project)
        {
            try
            {
               XmlConfigurator.Configure();
                log4net.Repository.Hierarchy.Hierarchy h = (log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository();
                foreach (IAppender a in h.Root.Appenders)
                {
                    if (a is FileAppender)
                    {
                        FileAppender fa = (FileAppender)a;
                        string sNowDate = DateTime.Now.ToString("yyyyMMdd");
                        // Programmatically set this to the desired location here
                        string FileLocationinWebConfig = fa.File;
                        string logFileLocation = FileLocationinWebConfig + @"\" + sNowDate + @"\" + _Project + ".txt";
                        if (System.IO.Directory.Exists(FileLocationinWebConfig + @"\" + sNowDate + @"\"))
                        {
                            System.IO.Directory.CreateDirectory(FileLocationinWebConfig + @"\" + sNowDate + @"\");
                        }
                        fa.File = logFileLocation;
                        fa.ActivateOptions();
                        break;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
