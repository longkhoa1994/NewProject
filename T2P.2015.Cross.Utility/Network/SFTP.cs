//using Renci.SshNet;
//using Renci.SshNet.Sftp;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;


//namespace T2P._2015.Cross.Utility.Network
//{
//    public class SFTPSetting
//    {
//        public int Port { get; set; }
//        public string Host { get; set; }
//        public string UserName { get; set; }
//        public string Password { get; set; }
//        public string LocalFileName { get; set; }
//        public string WorkingDirectory { get; set; }
//    }
//    public class SFTP
//    {
//        private SftpClient client;

//        public bool Connect(int port, string host, string username, string password)
//        {
//            //SftpClient client = null;
//            try
//            {
//                client = new SftpClient(host, port, username, password);
//                client.OperationTimeout = new TimeSpan(1, 0, 0);
//                client.Connect();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
//        public bool CheckConnect()
//        {
//            return client.IsConnected;
//        }
//        public bool IsConnect(int port, string host, string username, string password)
//        {
//            try
//            {
//                SftpClient client = new SftpClient(host, port, username, password);
//                client.Connect();
//                client.Disconnect();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public void Disconnect()
//        {
//            try
//            {
//                if (client != null)
//                {
//                    client.Disconnect();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public bool Upload(string fileLocaName, string workingdirectory)
//        {
//            try
//            {
//                client.ChangeDirectory(workingdirectory);
//                FileStream fileStream = new FileStream(fileLocaName, FileMode.Open);
//                client.BufferSize = 4 * 1024; // bypass Payload error large files
//                client.UploadFile(fileStream, Path.GetFileName(fileLocaName));
//                fileStream.Close();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//                //throw ex;
//            }
//        }

//        public bool DownLoad(string fileDownloadPath, string fileLocalSavePath)
//        {
//            try
//            {
//                FileStream fileInfo = new FileStream(fileLocalSavePath, FileMode.Create);
//                client.DownloadFile(fileDownloadPath, fileInfo);
//                fileInfo.Close();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
//                return false;
//            }
//        }

//        public bool Delete(string fileDeletePath)
//        {
//            try
//            {
//                client.DeleteFile(fileDeletePath);

//                return true;
//            }
//            catch (Exception ex)
//            {
//                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
//                return false;
//            }
//        }

//        public List<string> GetFile(string workingdirectory, string extension = ".zip")
//        {
//            try
//            {
//                IEnumerable<SftpFile> sftpFileArr = client.ListDirectory(workingdirectory);
//                List<string> sftpFileList = sftpFileArr.Where(x => Path.GetExtension(x.FullName).Contains(extension)).Select(x => x.FullName).ToList();
//                return sftpFileList;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public List<Tuple<string, DateTime>> getListFileSFTP(string workingdirectory, string extension = ".zip")
//        {
//            try
//            {
//                IEnumerable<SftpFile> SftpFileArr = client.ListDirectory(workingdirectory);
//                List<SftpFile> sftpFileList = SftpFileArr.Where(x => x.FullName.Contains(extension)).ToList();

//                List<Tuple<string, DateTime>> listFileSFTP = new List<Tuple<string, DateTime>>();

//                foreach (SftpFile file in sftpFileList)
//                {
//                    listFileSFTP.Add(new Tuple<string, DateTime>(file.FullName, file.LastWriteTime));
//                }

//                return listFileSFTP;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public void Download(List<string> sftpFileList, string workingdirectory, string dirDownloadLocal)
//        {
//            try
//            {
//                foreach (string sftpFile in sftpFileList)
//                {
//                    string fileNameLocal = dirDownloadLocal + "\\" + Path.GetFileName(sftpFile);
//                    DownLoad(sftpFile, fileNameLocal);

//                    Upload(fileNameLocal, workingdirectory);

//                    client.DeleteFile(sftpFile);
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                client.Disconnect();
//            }
//        }

//        public bool CheckExistDirectory(string directoryPath, string ftpUser, string ftpPassword)
//        {
//            bool isExists = true;
//            try
//            {
//                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(directoryPath);
//                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
//                request.Method = WebRequestMethods.Ftp.PrintWorkingDirectory;

//                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
//            }
//            catch (WebException)
//            {
//                isExists = false;
//            }
//            catch (Exception)
//            {
//                isExists = false;
//            }
//            return isExists;
//        }

//        public int ValidateInfo(int port, string host, string username, string password, string workingdirectory)
//        {
//            try
//            {
//                SftpClient client = new SftpClient(host, port, username, password);
//                try
//                {
//                    client.Connect();
//                }
//                catch
//                {
//                    return 1;
//                }
//                IEnumerable<SftpFile> SftpFileArr = client.ListDirectory(workingdirectory);
//                client.Disconnect();
//                return 0;
//            }
//            catch (Exception)
//            {
//                return 2;
//            }
//        }

//        public List<string> GetListFileSFTP(string workingdirectory)
//        {
//            try
//            {
//                IEnumerable<SftpFile> SftpFileArr = client.ListDirectory(workingdirectory);
//                List<SftpFile> sftpFileList = new List<SftpFile>();
//                foreach (SftpFile sftpfile in SftpFileArr)
//                {

//                    if (sftpfile.Name.Equals(".") == false && sftpfile.Name.Equals("..") == false)
//                    {
//                        sftpFileList.Add(sftpfile);
//                    }
//                }
//                return sftpFileList.Select(x => x.FullName).ToList();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }


//}