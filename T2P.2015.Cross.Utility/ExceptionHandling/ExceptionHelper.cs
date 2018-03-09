using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using T2P._2015.Cross.Utility.FileType;
using T2P._2015.Cross.Utility.Log;

namespace T2P._2015.Cross.Utility.ExceptionHandling
{

    public class ExceptionHelper
    {
        public static string GetDetailMessage(Exception ex, MethodBase method = null, params object[] values)
        {

            StringBuilder messageBuilder = new StringBuilder();
            int step = 1;
            var attributes = GetStackTraceSteps(ex);
            if (attributes != null && attributes.Count > 0)
            {
                messageBuilder.AppendLine("Sorry there is a problem while processing step " + attributes.Count + ": ");
                foreach (var attribute in attributes)
                {
                    messageBuilder.Append("Step " + step + ": " + attribute);
                    messageBuilder.AppendLine();
                    step++;
                }
                messageBuilder.AppendLine();
                messageBuilder.AppendLine("Error Description : " + ex.Message);
                messageBuilder.AppendLine();

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
                return messageBuilder.ToString();
            }
            return string.Empty;

        }


        public static string GetDetailMessageAndLog(Exception ex, MethodBase method = null, params object[] values)
        {

            string formatedMessage = GetDetailMessage(ex, method, values);
            Logging.Error(formatedMessage);
            return formatedMessage;

        }

        private static List<string> GetStackTraceSteps(Exception ex)
        {
            List<string> traceSteps = new List<string>();
            StackTrace st = new StackTrace(ex, true);
            if (st.FrameCount > 0)
            {
                for (int index = st.FrameCount - 1; index >= 0; index--)
                {

                    var attribute = st.GetFrame(index).GetMethod().ReflectedType + "." + st.GetFrame(index).GetMethod().Name;
                    if (st.GetFrame(index).GetFileLineNumber() != 0)
                    {
                        attribute = attribute + " LineNumber " + st.GetFrame(index).GetFileLineNumber();
                    }
                    traceSteps.Add(attribute);
                }
            }

            return traceSteps;
        }




    }
}