using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Reference.FaxService;
using System.IO;

namespace T2P._2015.Cross.Utility.Network
{
    public class Fax
    {
        public string SendFax(string userName, string password, string fileAttachment, string faxNumber)
        {
            string faxID = string.Empty;
            try
            {

                return SendFax(userName, password, faxNumber, Path.GetFileName(fileAttachment), File.ReadAllBytes(fileAttachment));
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return faxID;
            }
        }


        public virtual string SendFax(string userName, string password, string faxNumber, string fileName, byte[] fileContent)
        {
            string faxID = string.Empty;
            
            try
            {
                faxNumber = faxNumber.Replace("+", "00")
                                         .Replace("(", string.Empty)
                                         .Replace(")", string.Empty)
                                         .Replace("/", string.Empty)
                                         .Replace("-", string.Empty)
                                         .Replace(" ", string.Empty).Trim();
                if (!faxNumber.StartsWith("00"))
                {
                    faxNumber = "00" + faxNumber;
                }
                switch (Configuration.Config.Environment())
                {
                    case Configuration.TIMEnvironment.Development:
                    case Configuration.TIMEnvironment.Demo:
                    case Configuration.TIMEnvironment.Test:
                        faxID = Guid.NewGuid().ToString();
                        break;
                    case Configuration.TIMEnvironment.Production:
                        {
                            Faxolution201203Client client = new Faxolution201203Client();
                            jobRequest jobRequest = new jobRequest();
                            // Authentication:
                            jobRequest.username = userName;
                            jobRequest.password = password;
                            // Add recipient to request:
                            jobRequest.faxRecipient = new faxRecipient[1];

                            faxRecipient rcpt = new faxRecipient();
                            rcpt.number = faxNumber;

                            jobRequest.faxRecipient[0] = rcpt;
                            // Add document to request:

                            documentWithData[] documentList = new documentWithData[1];

                            documentWithData document = new documentWithData();
                            document.name = fileName;
                            document.data = fileContent;
                            documentList[0] = document;

                            jobRequest.document = documentList;

                            // Add options to request:
                            options options = new options();
                            options.resolution = resolution.HIGH;
                            options.billingCode = "";
                            options.jobReference = "";
                            //options.header = "Fax from " + options.csid + " to " + faxNumber;
                            jobRequest.options = options;
                            jobRequest.reportMail = new reportMail();
                            jobRequest.reportMail.failureAddress = "admin@travel2pay.com";
                            jobRequest.reportMail.successAddress = "admin@travel2pay.com";
                            jobResponse jobResponse = client.sendFaxJob(jobRequest);
                            faxID = jobResponse.jobId;
                        }
                        break;
                    default: break;
                }

                return faxID;
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return faxID;
            }
        }


        public string GetReportFax(string userName, string password, string faxID)
        {
            string status = string.Empty;
            switch (Configuration.Config.Environment())
            {
                case Configuration.TIMEnvironment.Development:
                case Configuration.TIMEnvironment.Demo:
                case Configuration.TIMEnvironment.Test:
                    Array values = System.Enum.GetValues(typeof(FaxResult));
                    Random random = new Random();
                    int randomValueCustom = GetRandomValue(values);
                    FaxResult randomStatus = (FaxResult)values.GetValue(randomValueCustom);
                    status = randomStatus.ToString();
                    break;
                case Configuration.TIMEnvironment.Production:
                    {
                        Faxolution201203Client client = new Faxolution201203Client();
                        reportRequest report = new reportRequest();
                        report.username = userName;
                        report.password = password;
                        report.jobId = faxID;
                        reportResponse reportResponse = client.getFaxReport(report);

                        status = reportResponse.faxRecipient[0].status;
                    }
                    break;
                default: break;
            }
            return status;
        }

        private int GetRandomValue(Array listResult)
        {
            Random random = new Random();
            var rate = random.Next(0, 10);

            if (rate <= 4)
                return 1;

            return random.Next(listResult.Length);
        }
    }

    public enum FaxStatus
    {
        //
        NEW,
        BUSY,
        EXCEPTION,
        OK,
        FAIL,
        WRONGNO,
    }
    public enum FaxResult
    {
        //Pending
        PENDING,
        //Success
        OK,
        //not confirmed as received but sent successfully
        EOD_FAILED,
        //line was busy
        BUSY,
        //Error while exchanging faxID
        NO_TRAIN,
        //out of paper or line was interrupted
        PAGE_SEND_ERR,
        PAGE_SEND_ERROR,
        //Receiver ended the communication
        REM_DIS,
        //
        NO_REMOTEINFO,
        //
        BAD_LINES,
        //
        FANS_GF,
        //
        DIAL_GF, //no fax machine
        NOFAX,
        //Receiver ended the communication
        NOFAX_DIS,
        //NO fax protocol was provided
        NOFAX_TO,
        //Fax machines does not answer
        RING_TO,
        //file is missing
        MISSING_FAX_FILE,
        //file error
        UNKNOWN_FAX_FILE,
        //file error
        TIFF_PAGE_ERR,
        //could not convert fax file
        RENDERING_ERROR,
        //cancelled by sender
        CANCELLED,
        //Dialled number is invalid or incomplete
        DIAL_NC,
        //number has changed
        CHANGED_NO,
        //no reaction when dialled
        WOUT_TO,
        //number has changed
        WRONG_NO,
        //number is in sender blacklist, not dialled
        PBLACKLIST,
        //number is in Retarus blacklist, not dialled
        BLACKLIST,
        //
        COMERROR
    }

    public class FaxResultCategory
    {
        public static string[] OK = { 
                                        FaxResult.OK.ToString(),
                             };
        public static string[] WrongNo = { 
                                        FaxResult.DIAL_NC.ToString(),
                                        FaxResult.CHANGED_NO.ToString(),
                                        FaxResult.WOUT_TO.ToString(),
                                        FaxResult.WRONG_NO.ToString(),
                                        FaxResult.BLACKLIST.ToString(),
                                        FaxResult.PBLACKLIST.ToString(),

                                        FaxResult.EOD_FAILED.ToString()

                                  };
        public static string[] Busy = {
                                        FaxResult.BUSY.ToString(),

                                        FaxResult.NO_TRAIN.ToString(),
                                        FaxResult.PAGE_SEND_ERR.ToString(),
                                        FaxResult.PAGE_SEND_ERROR.ToString(),
                                        FaxResult.REM_DIS.ToString(),
                                        FaxResult.NO_REMOTEINFO.ToString(),
                                        FaxResult.BAD_LINES.ToString(),
                                        FaxResult.FANS_GF.ToString(),
                                        FaxResult.DIAL_GF.ToString(),
                                        FaxResult.NOFAX.ToString(),
                                        FaxResult.NOFAX_DIS.ToString(),
                                        FaxResult.NOFAX_TO.ToString(),
                                        FaxResult.RING_TO.ToString(),
                                        FaxResult.CANCELLED.ToString(),
                                        FaxResult.COMERROR.ToString(),
                               };
        public static string[] Exception = {
                                        FaxResult.MISSING_FAX_FILE.ToString(),
                                        FaxResult.UNKNOWN_FAX_FILE.ToString(),
                                        FaxResult.TIFF_PAGE_ERR.ToString(),
                                        FaxResult.RENDERING_ERROR.ToString(),
                                    };

    }
}
