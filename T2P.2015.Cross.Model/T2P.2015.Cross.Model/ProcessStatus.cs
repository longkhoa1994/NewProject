using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class ProcessStatus
    {
        public ProcessStatusCode Code { get; set; }
        public string Message { get; set; }
        public long? Value { get; set; }

        public int TotalRecords { get; set; }

        public ProcessStatus()
        {
            Code = ProcessStatusCode.NoData;
            Message = string.Empty;
            Value = 0; 
            TotalRecords = 0;
        }
        public static ProcessStatus Success
        {
            get
            {
                return new ProcessStatus
                {
                    Code = ProcessStatusCode.Success
                };
            }
        }
        public static ProcessStatus Error
        {
            get
            {
                return new ProcessStatus
                {
                    Code = ProcessStatusCode.Error
                };
            }
        }
        public ProcessStatus GetProcessStatus(List<ProcessStatus> listResult)
        {
            ProcessStatus result = new ProcessStatus();
            if (listResult != null && listResult.Count > 0)
            {
                if (listResult.Any(x => x.Code != ProcessStatusCode.Success && x.Code != ProcessStatusCode.NoData))
                {
                    
                    string message = string.Join("\n ", listResult.Where(x => !string.IsNullOrWhiteSpace(x.Message)).ToList().Select(x => x.Message));
                    if (string.IsNullOrWhiteSpace(message))
                    {
                        message = string.Join("\n ", listResult.Where(x => x.Code != ProcessStatusCode.Success && x.Code != ProcessStatusCode.NoData).ToList().Select(x => x.Code.ToString()));
                    }
                    T2P._2015.Cross.Utility.Log.Logging.Error(message);
                    listResult = listResult.Where(x => x.Code == ProcessStatusCode.Error).ToList();
                    result.Code = ProcessStatusCode.Error;

                }
                else if (listResult.Any(x => x.Code == ProcessStatusCode.Success))
                {
                    result.Code = ProcessStatusCode.Success;
                }
                else
                {
                    result.Code = ProcessStatusCode.NoData;
                }
            }
            return result;
        }

        public static ProcessStatus ErrorLog(Exception ex, MethodBase method = null, params object[] values)
        {
            string message = string.Empty;
            message = message + "\n" + T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex, method, values);
            return new ProcessStatus()
            {
                Code = ProcessStatusCode.Error,
                Message = message,
            };
        }

    }

    public enum ProcessStatusCode
    {
        Stop = -1,
        Success = 0,
        ErrorSystem = 1,
        InvalidSchema = 2,
        Invalidstring = 3,
        NoData = 4,
        ErrorConnectSFTP = 5,
        FileNotExist = 6,
        ErrorUploadSFTP = 7,
        Error = 8,
        ErrorConnectDB = 9,
        CouldNotDownloadFileSFTP = 10,
        FileFormatError = 11,
        CouldNotDeleteFileSFTP = 12,
        ErrorConnectMailbox = 13,
        FileExist = 13,
        ErrorRequire = 14,
        InvalidXML = 15,
        FileHasIsDuplicate = 16,
        New = 17,
        Duplicate = 18,
        Replace = 19,
        ErrorSendEmail = 20,
        ErrorUpdateDB = 21,
        ErrorSendFax = 22
    }
}