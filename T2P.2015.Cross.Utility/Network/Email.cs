using AE.Net.Mail;
using OpenPop.Mime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace T2P._2015.Cross.Utility.Network
{
    public class EmailDetail
    {
        public string Server { get; set; }

        public string FromAddress { get; set; }

        public List<string> ListTo { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string MessageID { get; set; }

        public long CompanyID { get; set; }

        public List<string> ListAtt { get; set; }

        public string EmailBcc { get; set; }

        public string EmailCC { get; set; }

        public string CompanySignature { get; set; }

        public string EmailAdmin { get; set; }

        public string CompanyLogo { get; set; }

        public string CompanyLogoDefault { get; set; }

        public string HotelLogo { get; set; }

        public string T2pLogo { get; set; }

        public string CompanySignatureDefault { get; set; }

        public string AirPlusLogo { get; set; }

        public string IPLocalPathCompany { get; set; }

        public string IISPathCompany { get; set; }

        public string IpLocalPath { get; set; }

        public string IISPath { get; set; }

        public string InReplyTo { get; set; }
    }

    public class Email
    {

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolSendEmail));
        //private string version = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " ";

        //public static string MailServer = ConfigurationManager.AppSettings["MailServer"];

        //public static string[] EmailBCC = { "khoi.vu@travel2pay.com" };

        public bool SendMail(
            string eMAIL_SEND_USER,
            string eMAIL_SEND_PASSWORD,
            string eMAIL_SEND_SERVER,
            string from, string to, string inReplyTo, string cC, string bCC, string subject, string body, string[] listAttachment,
            string localPathCompanyLogo,
            string localPathHotelPlatformLogo,
            string localPathAirPlusLogo,
            string localPathCompanySignatureLogo,
            string localPathT2PLogo,
            string messageID = ""
            )
        {
            bool result = false;
            try
            {
                bool validateSendEmail = true;
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                List<string> listTo = new List<string>() { to };
                ValidateSendEmail(listTo, cC, bCC, ref subject, ref validateSendEmail, message);

                if (validateSendEmail)
                {
                    message.Headers.Add("Message-ID", "<" + (!string.IsNullOrWhiteSpace(messageID) ? messageID : Guid.NewGuid().ToString()) + ">");
                    message.From = new MailAddress(from);
                    message.Subject = subject;
                    message.IsBodyHtml = true;

                    if (!string.IsNullOrWhiteSpace(inReplyTo))
                    {
                        message.Headers.Add("In-Reply-To", inReplyTo);
                        message.Headers.Add("References", inReplyTo);
                    }

                    // embed logo
                    List<LinkedResource> listLinkedResource = new List<LinkedResource>();
                    if (!string.IsNullOrWhiteSpace(localPathCompanyLogo))
                    {
                        LinkedResource linkedResource = new LinkedResource(localPathCompanyLogo);
                        linkedResource.ContentId = Path.GetFileName(localPathCompanyLogo);
                        ContentType ct = new ContentType(MediaTypeNames.Image.Gif);
                        linkedResource.ContentType = ct;
                        listLinkedResource.Add(linkedResource);
                    }

                    if (!string.IsNullOrWhiteSpace(localPathHotelPlatformLogo))
                    {
                        LinkedResource linkedResource = new LinkedResource(localPathHotelPlatformLogo);
                        linkedResource.ContentId = Path.GetFileName(localPathHotelPlatformLogo);
                        ContentType ct = new ContentType(MediaTypeNames.Image.Gif);
                        linkedResource.ContentType = ct;
                        listLinkedResource.Add(linkedResource);
                    }

                    if (!string.IsNullOrWhiteSpace(localPathAirPlusLogo))
                    {
                        LinkedResource linkedResource = new LinkedResource(localPathAirPlusLogo);
                        linkedResource.ContentId = Path.GetFileName(localPathAirPlusLogo);
                        ContentType ct = new ContentType(MediaTypeNames.Image.Gif);
                        linkedResource.ContentType = ct;
                        listLinkedResource.Add(linkedResource);
                    }

                    if (!string.IsNullOrWhiteSpace(localPathCompanySignatureLogo))
                    {
                        LinkedResource linkedResource = new LinkedResource(localPathCompanySignatureLogo);
                        linkedResource.ContentId = Path.GetFileName(localPathCompanySignatureLogo);
                        ContentType ct = new ContentType(MediaTypeNames.Image.Gif);
                        linkedResource.ContentType = ct;
                        listLinkedResource.Add(linkedResource);
                    }

                    if (!string.IsNullOrWhiteSpace(localPathT2PLogo))
                    {
                        LinkedResource linkedResource = new LinkedResource(localPathT2PLogo);
                        linkedResource.ContentId = Path.GetFileName(localPathT2PLogo);
                        ContentType ct = new ContentType(MediaTypeNames.Image.Gif);
                        linkedResource.ContentType = ct;
                        listLinkedResource.Add(linkedResource);
                    }

                    // convert base64 image to embed
                    Regex r = new Regex(@"(<img\s(?>(?!src=)[^>])*?src=\"")data:image/(gif|png|jpeg);base64,([\w=+/]+)(\""[^>]*>)");
                    foreach (Match match in r.Matches(body))
                    {
                        Regex g = new Regex(@"data:image/(gif|png|jpeg);base64,([\w=+/]+)");
                        string src = g.Match(match.Value).Value;
                        string base64 = Regex.Replace(src, "data:image/(gif|png|jpeg);base64,", string.Empty, RegexOptions.IgnoreCase);

                        var imageData = Convert.FromBase64String(base64);

                        var contentId = Guid.NewGuid().ToString();
                        LinkedResource linkedResource = new LinkedResource(new MemoryStream(imageData), "image/jpeg");
                        linkedResource.ContentId = contentId;
                        linkedResource.TransferEncoding = TransferEncoding.Base64;

                        body = body.Replace(src, "cid:" + contentId);
                        listLinkedResource.Add(linkedResource);
                    }

                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
                    listLinkedResource.ForEach(x => htmlView.LinkedResources.Add(x));
                    message.AlternateViews.Add(htmlView);

                    // add attachment
                    if (listAttachment != null && listAttachment.Length > 0)
                    {
                        foreach (string item in listAttachment)
                        {
                            if (File.Exists(item))
                            {
                                System.Net.Mail.Attachment att = AttachmentHelper.CreateAttachment(item, Path.GetFileName(item), TransferEncoding.Base64);
                                message.Attachments.Add(att);
                            }
                        }
                    }

                    // send mail
                    SmtpClient client = new SmtpClient(eMAIL_SEND_SERVER);
                    client.Credentials = new System.Net.NetworkCredential(eMAIL_SEND_USER, eMAIL_SEND_PASSWORD);
                    client.EnableSsl = false;

                    client.Send(message);

                    foreach (System.Net.Mail.Attachment att in message.Attachments)
                    {
                        att.Dispose();
                    }

                    message.Dispose();
                }
                result = true;

                return result;
            }
            catch (Exception ex)
            {
                WriteLogEmail2(from, to, cC, bCC);

                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return false;
            }
        }



        private static void ValidateSendEmail(List<string> listTo, string cC, string bCC, ref string subject, ref bool validateSendEmail, System.Net.Mail.MailMessage message, string toAdmin = "admin@travel2pay.com", string bcc = "SystemMonitor@travel2pay.com")
        {
            switch (Configuration.Config.Environment())
            {
                case Configuration.TIMEnvironment.Development:
                //message.To.Add("nhi.nguyen@travel2pay.com");
                //break;
                case Configuration.TIMEnvironment.Test:
                    {
                        if (listTo.Any(x => x.Contains("abc@travel2pay.com")))
                        {
                            message.To.Add("abc@travel2pay.com");
                        }
                        else
                        {
                            //string toDuong = string.Empty;
                            if (string.IsNullOrWhiteSpace(toAdmin))
                            {
                                toAdmin = "admin@travel2pay.com";
                            }
                            message.To.Add(toAdmin);
                            if (!string.IsNullOrEmpty(cC))
                            {
                                message.CC.Add(cC);
                            }
                            if (!string.IsNullOrEmpty(bCC))
                            {
                                message.Bcc.Add(bCC);
                            }

                            if (!string.IsNullOrEmpty(bcc))
                            {
                                message.Bcc.Add(bcc);
                            }
                        }
                        subject = Configuration.Config.Environment().ToString() + ": " + subject;
                    }
                    break;

                case Configuration.TIMEnvironment.Demo:
                    validateSendEmail = false;
                    break;

                case Configuration.TIMEnvironment.Production:
                    {
                        //To Address
                        foreach (string email in listTo)
                        {
                            if (!string.IsNullOrWhiteSpace(email))
                            {
                                message.To.Add(email);
                            }
                        }
                        // CC
                        if (!string.IsNullOrWhiteSpace(cC))
                        {
                            string[] listCC = SplitEmail(cC);
                            foreach (string item in listCC)
                            {
                                if (!string.IsNullOrWhiteSpace(item))
                                {
                                    message.CC.Add(item);
                                }
                            }
                        }

                        // BCC
                        if (!string.IsNullOrWhiteSpace(bCC))
                        {
                            string[] listBCC = SplitEmail(bCC);

                            foreach (string item in listBCC)
                            {
                                if (!string.IsNullOrWhiteSpace(item))
                                {
                                    message.Bcc.Add(item);
                                }
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(toAdmin))
                        {
                            message.Bcc.Add(toAdmin);
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private static string[] SplitEmail(string strSplit)
        {
            string[] result;
            result = strSplit.Split(';', ',').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            return result;
        }

        public List<string> SplitMail(string email)
        {
            List<string> result = new List<string>();
            if (email.Contains(";") || email.Contains(","))
            {
                if (email.Contains(";"))
                {
                    string[] listEmail = email.Split(';');
                    foreach (string item in listEmail)
                    {
                        if (!string.IsNullOrWhiteSpace(item))
                        {
                            result.Add(item);
                        }
                    }
                }
                if (email.Contains(","))
                {
                    string[] listEmail = email.Split(',');
                    foreach (string item in listEmail)
                    {
                        if (!string.IsNullOrWhiteSpace(item))
                        {
                            result.Add(item);
                        }
                    }
                }
            }
            else
            {
                result.Add(email.ToString());
            }

            return result;
        }

        public virtual bool SendMailMessage(EmailDetail emailDetail)
        {
            try
            {
                bool validateSendEmail = true;
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                string subject = emailDetail.Subject;
                ValidateSendEmail(emailDetail.ListTo, emailDetail.EmailCC, emailDetail.EmailBcc, ref subject, ref validateSendEmail, message, "admin@travel2pay.com");

                if (validateSendEmail)
                {
                    message.Headers.Add("Message-ID", "<" + emailDetail.MessageID + ">");
                    message.From = new MailAddress(emailDetail.FromAddress);

                    message.Subject = emailDetail.Subject;
                    message.Body = emailDetail.Body;
                    message.IsBodyHtml = true;

                    SmtpClient client = new SmtpClient(emailDetail.Server);
                    client.Credentials = new System.Net.NetworkCredential(emailDetail.UserName, emailDetail.Password);
                    client.EnableSsl = false;
                    client.Send(message);

                    message.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                WriteLog(emailDetail);
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return false;
            }
        }
        private void WriteLogEmail2(string from, string to, string cC, string bCC)
        {
            try
            {
                EmailDetail emailDetail = new EmailDetail()
                {
                    FromAddress = from,
                    ListTo = new List<string>() { to },
                    EmailCC = cC,
                    EmailBcc = bCC,
                };
                WriteLog(emailDetail);
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
            }
        }
        private void WriteLog(EmailDetail emailDetail)
        {
            try
            {
                string cc = !string.IsNullOrWhiteSpace(emailDetail.EmailCC) ? emailDetail.EmailCC : string.Empty;
                string bcc = !string.IsNullOrWhiteSpace(emailDetail.EmailBcc) ? emailDetail.EmailBcc : string.Empty;
                string from = !string.IsNullOrWhiteSpace(emailDetail.FromAddress) ? emailDetail.FromAddress : string.Empty;
                string to = emailDetail.ListTo != null && emailDetail.ListTo.Any() ? string.Join(",", emailDetail.ListTo) : string.Empty;
                string Log = "\nFrom: " + from
                               + "\nTo: " + to
                               + "\nCC: " + cc
                           + "\nBCC: " + bcc;
                T2P._2015.Cross.Utility.Log.Logging.Error(Log);

            }
            catch (Exception ex)
            {

                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
            }
        }

        public bool SendMailMessage(string subject, string body, params string[] toEmail)
        {
            try
            {
                //string eMAIL_SEND_USER = "invoice.notification@travel2pay.com";
                //string eMAIL_SEND_PASSWORD = @"CL'YHREZ'qR\Tq;O";
                //string eMAIL_SEND_SERVER = "mail.travel2pay.com";
                string eMAIL_SEND_SERVER = Configuration.Config.GetAppSetting("MailServer", "mail.travel2pay.com");
                string eMAIL_SEND_USER = Configuration.Config.GetAppSetting("MailUser", "invoice.notification@travel2pay.com");
                string eMAIL_SEND_PASSWORD = Configuration.Config.GetAppSetting("MailPass", @"CL'YHREZ'qR\Tq;O");
                
                bool validateSendEmail = true;
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                ValidateSendEmail(toEmail.ToList(), string.Empty, string.Empty, ref subject, ref validateSendEmail, message);
                if (validateSendEmail)
                {
                    message.From = new MailAddress(eMAIL_SEND_USER);
                    message.Subject = subject;
                    message.Body = body;
                    SmtpClient client = new SmtpClient(eMAIL_SEND_SERVER);
                    client.Credentials = new System.Net.NetworkCredential(eMAIL_SEND_USER, eMAIL_SEND_PASSWORD);
                    client.EnableSsl = false;
                    client.Send(message);
                }
                message.Dispose();
                return true;
            }
            catch (Exception ex)
            {

                List<string> listTo = toEmail != null && toEmail.Any() ? toEmail.ToList() : new List<string>();
                WriteLogEmail2("invoice.notification@travel2pay.com", string.Join(",", listTo.ToArray()), string.Empty, string.Empty);
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return false;
            }
        }

        public bool ResultSendEmail(EmailDetail emailDetail)
        {
            bool resultSendMail = false;
            for (int i = 0; i < 3; i++)
            {
                resultSendMail = SendMailMessageWithDynamicLogo(emailDetail);
                if (resultSendMail == true)
                {
                    break;
                }
            }
            return resultSendMail;
        }

        public bool SendMailMessageWithDynamicLogo(EmailDetail emailDetail)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                // Instantiate a new instance of MailMessage
                bool validateSendEmail = true;
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                string subject = emailDetail.Subject;
                ValidateSendEmail(emailDetail.ListTo, emailDetail.EmailCC, emailDetail.EmailBcc, ref subject, ref validateSendEmail, message, emailDetail.EmailAdmin);

                if (validateSendEmail)
                {
                    #region Create Email Header

                    message.Headers.Add("Message-ID", "<" + emailDetail.MessageID + ">");

                    if (!string.IsNullOrWhiteSpace(emailDetail.InReplyTo))
                    {
                        message.Headers.Add("In-Reply-To", emailDetail.InReplyTo);
                        message.Headers.Add("References", emailDetail.InReplyTo);
                    }
                    message.From = new MailAddress(emailDetail.FromAddress);

                    message.Subject = subject;
                    message.IsBodyHtml = true;

                    #endregion Create Email Header

                    #region Embed Logo

                    List<LinkedResource> resourceCollection = new List<LinkedResource>();
                    EmbedLogo(emailDetail, "CompanyLogo", emailDetail.CompanyLogo, resourceCollection);
                    EmbedLogo(emailDetail, "CompanySignature", emailDetail.CompanySignature, resourceCollection);
                    EmbedLogo(emailDetail, "HotelPlatformLogo", emailDetail.HotelLogo, resourceCollection);
                    EmbedLogo(emailDetail, "T2PLogo", emailDetail.T2pLogo, resourceCollection);
                    EmbedLogo(emailDetail, "AirplusLogo", emailDetail.AirPlusLogo, resourceCollection);
                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(emailDetail.Body, null, "text/html");
                    resourceCollection.ForEach(x => htmlView.LinkedResources.Add(x));

                    message.AlternateViews.Add(htmlView);

                    #endregion Embed Logo

                    #region Attachment

                    if (emailDetail.ListAtt != null)
                    {
                        foreach (string item in emailDetail.ListAtt)
                        {
                            if (File.Exists(item))
                            {
                                System.Net.Mail.Attachment att = AttachmentHelper.CreateAttachment(item, Path.GetFileName(item), TransferEncoding.Base64);
                                message.Attachments.Add(att);
                            }
                        }
                    }

                    #endregion Attachment

                    #region Send Email

                    SmtpClient client = new SmtpClient(emailDetail.Server);
                    client.Credentials = new System.Net.NetworkCredential(emailDetail.UserName, emailDetail.Password);
                    client.EnableSsl = false;
                    client.Send(message);

                    #endregion Send Email

                    foreach (System.Net.Mail.Attachment att in message.Attachments)
                    {
                        att.Dispose();
                    }
                }
                message.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                WriteLog(emailDetail);
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return false;
            }
        }

        private void EmbedLogo(EmailDetail emailDetail, string pattern, string iisLogo, List<LinkedResource> resourceCollection)
        {
            Regex rgImage = new Regex("<img(?=[^>]+class=\"" + pattern + "\")[^>]+src=\"([^\">]+)\"");
            Regex rgScr = new Regex("src=\"([^\">]+)\"");

            if (!string.IsNullOrWhiteSpace(Path.GetFileName(iisLogo)))
            {
                foreach (Match match in rgImage.Matches(emailDetail.Body))
                {
                    emailDetail.Body = emailDetail.Body.Replace(iisLogo, "cid:" + Path.GetFileName(iisLogo));
                    string src = rgScr.Match(match.Value).Value;
                    string folderPath = string.Empty;
                    string saveLocation = string.Empty;
                    if ((pattern == "CompanyLogo" || pattern == "CompanySignature") && !string.IsNullOrWhiteSpace(emailDetail.IISPathCompany))
                    {
                        folderPath = Path.GetDirectoryName(iisLogo.Replace(emailDetail.IISPathCompany, string.Empty));
                        saveLocation = emailDetail.IPLocalPathCompany + folderPath + "\\" + Path.GetFileName(iisLogo);
                    }
                    else
                    {
                        folderPath = Path.GetDirectoryName(iisLogo.Replace(emailDetail.IISPath, string.Empty));
                        saveLocation = emailDetail.IpLocalPath + folderPath + "\\" + Path.GetFileName(iisLogo);
                    }
                    LinkedResource EmbeddedObjects1 = new LinkedResource(saveLocation);
                    EmbeddedObjects1.ContentId = Path.GetFileName(iisLogo);
                    ContentType ct = new ContentType(MediaTypeNames.Image.Gif);
                    EmbeddedObjects1.ContentType = ct;
                    resourceCollection.Add(EmbeddedObjects1);
                }
            }
        }
    }

    public class AttachmentHelper
    {
        public static System.Net.Mail.Attachment CreateAttachment(string attachmentFile, string displayName, TransferEncoding transferEncoding)
        {
            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(attachmentFile);
            attachment.TransferEncoding = transferEncoding;

            string tranferEncodingMarker = String.Empty;
            string encodingMarker = String.Empty;
            int maxChunkLength = 0;

            switch (transferEncoding)
            {
                case TransferEncoding.Base64:
                    tranferEncodingMarker = "B";
                    encodingMarker = "UTF-8";
                    maxChunkLength = 30;
                    break;

                case TransferEncoding.QuotedPrintable:
                    tranferEncodingMarker = "Q";
                    encodingMarker = "ISO-8859-1";
                    maxChunkLength = 76;
                    break;

                default:
                    throw (new ArgumentException(String.Format("The specified TransferEncoding is not supported: {0}", transferEncoding, "transferEncoding")));
            }

            attachment.NameEncoding = Encoding.GetEncoding(encodingMarker);

            string encodingtoken = String.Format("=?{0}?{1}?", encodingMarker, tranferEncodingMarker);
            string softbreak = "?=";
            string encodedAttachmentName = encodingtoken;

            if (attachment.TransferEncoding == TransferEncoding.QuotedPrintable)
                encodedAttachmentName = HttpUtility.UrlEncode(displayName, Encoding.Default).Replace("+", " ").Replace("%", "=");
            else
                encodedAttachmentName = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(displayName));

            encodedAttachmentName = SplitEncodedAttachmentName(encodingtoken, softbreak, maxChunkLength, encodedAttachmentName);
            attachment.Name = encodedAttachmentName;

            return attachment;
        }

        private static string SplitEncodedAttachmentName(string encodingtoken, string softbreak, int maxChunkLength, string encoded)
        {
            int splitLength = maxChunkLength - encodingtoken.Length - (softbreak.Length * 2);
            var parts = SplitByLength(encoded, splitLength);

            string encodedAttachmentName = encodingtoken;

            foreach (var part in parts)
                encodedAttachmentName += part + softbreak + encodingtoken;

            encodedAttachmentName = encodedAttachmentName.Remove(encodedAttachmentName.Length - encodingtoken.Length, encodingtoken.Length);
            return encodedAttachmentName;
        }

        private static IEnumerable<string> SplitByLength(string stringToSplit, int length)
        {
            while (stringToSplit.Length > length)
            {
                yield return stringToSplit.Substring(0, length);
                stringToSplit = stringToSplit.Substring(length);
            }

            if (stringToSplit.Length > 0) yield return stringToSplit;
        }
    }

    public class POP3
    {
        private OpenPop.Pop3.Pop3Client client;

        private Message message;

        private string Hostname = string.Empty;
        private int Port = 0;

        public bool Connect(string hostname, int port, bool useSsl)
        {
            try
            {
                client = new OpenPop.Pop3.Pop3Client();
                client.Connect(hostname, port, false);
                Hostname = hostname;
                Port = port;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                client.Authenticate(username, password);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int CountMessage()
        {
            try
            {
                return client.GetMessageCount();
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                return 0;
            }
        }

        public void GetMessage(int index)
        {
            message = client.GetMessage(index);
        }

        public void LoadFile(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            message = Message.Load(file);
        }

        public void SaveMessage(string filename)
        {
            // FileInfo about the location to save/load message
            FileInfo file = new FileInfo(filename);

            // Save the full message to some file
            message.Save(file);

            // Now load the message again. This could be done at a later point
            Message loadedMessage = Message.Load(file);
        }

        public void GetInfoAttachment(List<string> fileNameAttachmentList, List<ContentDisposition> contenDepostionList, List<Byte[]> bodyList)
        {
            List<string> fileNameList = new List<string>();

            List<MessagePart> attachments = message.FindAllAttachments();
            MessagePart part = message.MessagePart;
            if (part.MessageParts != null && part.MessageParts.Count > 0)
            {
                foreach (MessagePart item in part.MessageParts)
                {
                    if (item.Body != null)
                    {
                        Stream stream = new MemoryStream(item.Body);
                        Message mess = Message.Load(stream);
                        List<MessagePart> attachment = mess.FindAllAttachments();
                        attachments.AddRange(attachment);
                    }
                }
            }

            foreach (var att in attachments)
            {
                fileNameAttachmentList.Add(att.FileName);
                contenDepostionList.Add(att.ContentDisposition);
                bodyList.Add(att.Body);
            }
        }

        public string GetHeaderFrom()
        {
            return (message.Headers != null && !string.IsNullOrWhiteSpace(message.Headers.From.ToString())) ? message.Headers.From.Address.ToString() : string.Empty;
        }

        public string GetHeaderTo(string toEmail)
        {
            return (message.Headers != null && !string.IsNullOrWhiteSpace(message.Headers.To.ToString())) ? message.Headers.To.ToString() : toEmail;
        }

        public string GetHeaderSubject()
        {
            return (message.Headers != null && !string.IsNullOrWhiteSpace(message.Headers.Subject)) ? message.Headers.Subject : string.Empty;
        }

        public string GetMessageID()
        {
            return message.Headers.MessageId != null ? message.Headers.MessageId : string.Empty;
        }

        public DateTime GetDateSent()
        {
            return T2P._2015.Cross.Utility.Conversion.Conversion.ObjectToDateTime(message.Headers.DateSent.ToString("ddd, d MMM yyyy HH:mm:ss +0000"));
        }

        public System.Net.Mail.MailMessage GetToMailMessage()
        {
            return message.ToMailMessage();
        }

        public string GetBodyWithoutEmbed()
        {
            return message.ToMailMessage().Body;
        }

        public string GetBody(System.Net.Mail.MailMessage mail)
        {
            string body = string.Empty;
            body = message.Headers.From.Address.Contains("postmaster") ? GetFullMessageBody() : mail.Body;

            List<MessagePart> listAtt = message.FindAllAttachments();

            //process embed image
            foreach (MessagePart att in listAtt)
            {
                string imageBase64 = System.Convert.ToBase64String(att.Body);
                string replaceText = "data:" + att.ContentType.MediaType + ";base64," + imageBase64;
                if (att.ContentId != null)
                {
                    body = body.Replace("cid:" + att.ContentId, replaceText);
                }
            }

            return body;
        }

        private string GetFullMessageBody()
        {
            string body = string.Empty;
            body = GetChildBody(message.Headers.From.Address, message.MessagePart);
            body = body.Replace("\r\n", "<br/>");
            return body;
        }

        private string GetChildBody(string fromAddress, MessagePart messagePart)
        {
            if (messagePart == null)
                return string.Empty;

            string child = string.Empty;

            if (messagePart.IsMultiPart)
            {
                foreach (var message in messagePart.MessageParts)
                {
                    child += " <br/> " + GetChildBody(fromAddress, message);
                }
            }
            else
            {
                child = (messagePart.Body != null && ((messagePart.ContentType.MediaType.Contains("text/html") || messagePart.ContentType.MediaType.Contains("text/plain")) ||
                    (fromAddress.Contains("postmaster") && (messagePart.ContentType.MediaType.Contains("message/delivery-status") || messagePart.ContentType.MediaType.Contains("text/rfc822-headers"))))) ? messagePart.GetBodyAsText() : string.Empty;
            }
            return child;
        }

        public void ProcessEmbebImage(string body)
        {
            List<MessagePart> listAtt = message.FindAllAttachments();
            //process embed image
            foreach (MessagePart att in listAtt)
            {
                string imageBase64 = System.Convert.ToBase64String(att.Body);
                string replaceText = "data:" + att.ContentType.MediaType + ";base64," + imageBase64;
                if (att.ContentId != null)
                {
                    body = body.Replace("cid:" + att.ContentId, replaceText);
                }
            }
        }

        public string GetMessageUID(int index)
        {
            return Conversion.Conversion.ObjectToInt(client.GetMessageUid(index)).ToString();
        }

        public void Disconnect()
        {
            if (client.Connected)
            {
                client.Disconnect();
            }
        }

        public string GetReplyTo()
        {
            string replyTo = message.Headers.InReplyTo.FirstOrDefault();
            if (string.IsNullOrWhiteSpace(replyTo))
            {
                replyTo = string.Empty;
            }
            return replyTo;
        }

        public void DeleteMail(int index)
        {
            try
            {
                client.DeleteMessage(index);
            }
            catch (Exception ex)
            {
                string messageLog = "Can't delete email have Subject \"" + GetHeaderSubject() + "\"";
                messageLog = messageLog + "\n" + ExceptionHandling.ExceptionHelper.GetDetailMessage(ex);
            }
        }
    }

    public class Imap
    {
        private ImapClient clientImap;

        private AE.Net.Mail.Imap.Mailbox mailbox;

        public bool CheckConnect(string hostName, int port, string emailUser, string emailPassword, bool emailSSL)
        {
            try
            {
                clientImap = new ImapClient();
                clientImap.Connect(hostName, port, emailSSL, emailSSL);
                clientImap.Login(emailUser, emailPassword);
                return true;
            }
            catch (Exception ex)
            {
                //processStatus.Message = ex.Message;
                return false;
            }
        }

        public int GetMessageCount()
        {
            return clientImap.GetMessageCount();
        }

        public void CheckMailBox(string mailBox)
        {
            try
            {
                mailbox = clientImap.SelectMailbox(mailBox);
            }
            catch
            {
                clientImap.CreateMailbox(mailBox);
                mailbox = clientImap.SelectMailbox(mailBox);
            }
        }

        public void MoveMessage(string uid, string backupFolder)
        {
            clientImap.MoveMessage(uid, backupFolder);
        }
    }
}