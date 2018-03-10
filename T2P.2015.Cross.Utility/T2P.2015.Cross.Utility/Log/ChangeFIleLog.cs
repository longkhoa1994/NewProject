using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net.Appender;
using log4net;
namespace T2P._2015.Cross.Utility.Log
{
    public class Logging
    {
        public static void Error(string messageLog,string project = "Travel2Pay")
        {
            log4net.ILog log = Init<Logging>(project);
            log.Error(messageLog);
        }

        public static void Info(string messageLog, string project = "Travel2Pay")
        {
            log4net.ILog log = Init<Logging>(project);
            log.Info(messageLog);
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
                    string logFileLocation = FileLocationinWebConfig + _Project + sNowDate + ".txt";
                    fa.File = logFileLocation;
                    fa.ActivateOptions();
                    break;
                }
            }
        }
    }
}
