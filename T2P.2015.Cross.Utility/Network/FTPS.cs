using AlexPilotti.FTPS.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using T2P._2015.Cross.Utility.StringExtension;

namespace T2P._2015.Cross.Utility.Network
{
    public class FTPS
    {
        private FTPSClient client;
        private string _host;
        private int _post;
        private string _userName;
        private string _passWord;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="host">Server Host</param>
        /// <param name="port">Server Port</param>
        /// <param name="username">User Name</param>
        /// <param name="password">Password</param>
        public FTPS(string host, int port, string username, string password)
        {
            _host = host;
            _post = port;
            _userName = username;
            _passWord = password;
        }

        public bool Connect()
        {
            try
            {
                client = new FTPSClient();
                client.Connect(_host, _post, new NetworkCredential(_userName, _passWord),
                        ESSLSupportMode.Implicit | ESSLSupportMode.CredentialsRequired | ESSLSupportMode.DataChannelRequested,
                    new RemoteCertificateValidationCallback(ValidateServerCertificate), null, 0, 0, 0, null);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (client != null)
                {
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckConnect()
        {
            bool isAvailable;
            using (FTPSClient cli = new FTPSClient())
            {
                try
                {
                    cli.Connect(_host, _post, new NetworkCredential(_userName, _passWord),
                                  ESSLSupportMode.Implicit | ESSLSupportMode.CredentialsRequired | ESSLSupportMode.DataChannelRequested,
                              new RemoteCertificateValidationCallback(ValidateServerCertificate), null, 0, 0, 0, null);
                    isAvailable = cli.WelcomeMessage == String.Empty ? false : true;
                }
                catch (Exception)
                {
                    isAvailable = false;
                }
            }
            return isAvailable;
        }

        public bool UploadFile(string filePath, string ftpsPath)
        {
            return UploadFile(Path.GetFileName(filePath), Path.GetDirectoryName(filePath), ftpsPath);
        }


        public bool UploadFile(string fileName, string localPath, string ftpsPath)
        {
            try
            {
                client.SetCurrentDirectory(ftpsPath);
                client.PutFile(StringExtensions.ConcatDirectoryPath(localPath, fileName), StringExtensions.ConcatUriPath(ftpsPath, fileName));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DownloadFile(string fileName, string localPath, string ftpsPath)
        {
            try
            {
                client.SetCurrentDirectory(ftpsPath);
                client.GetFile(StringExtensions.ConcatUriPath(ftpsPath, fileName), StringExtensions.ConcatDirectoryPath(localPath, fileName));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Download all files with extention from FTPS to local directory that match with extension (default is "*.csv")
        /// </summary>
        /// <param name="FTPSPath"></param>
        /// <param name="localPath"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public bool DownLoadMultiFiles(string FTPSPath, string localPath, string extension = "*.csv")
        {
            try
            {
                client.SetCurrentDirectory(FTPSPath);
                client.GetFiles(localPath, extension, EPatternStyle.Wildcard, false);
                client.GetFiles(localPath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<String> GetFileNameList(string workingdirectory, string extension = ".csv")
        {
            try
            {
                client.SetCurrentDirectory(workingdirectory);
                List<String> zipFile = client.GetDirectoryList().Where(x => Path.GetExtension(x.Name).Contains(extension)).Select(x => x.Name).ToList();
                return zipFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Private
        private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }
            //  Return true means allow this client to communicate with unauthenticated servers.
            return true;
        }
        #endregion
    }
}
