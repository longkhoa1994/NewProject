//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ICSharpCode.SharpZipLib.Core;
//using ICSharpCode.SharpZipLib.Zip;
//using System.IO;

//namespace T2P._2015.Cross.Utility.FileType
//{
//    public class Zip
//    {
//        public void ZipFile(string outPathname, string filename)
//        {
//            try
//            {
//                FileStream fsOut = File.Create(outPathname);
//                ZipOutputStream zipStream = new ZipOutputStream(fsOut);

//                zipStream.SetLevel(0); //0-9, 9 being the highest level of compression

//                zipStream.Password = null;  // optional. Null is the same as not setting. Required if using AES.
//                // This setting will strip the leading part of the folder path in the entries, to
//                // make the entries relative to the starting folder.
//                // To include the full path for each entry up to the drive root, assign folderOffset = 0.

//                CompressFolder(zipStream, filename);

//                zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
//                zipStream.Close();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public void CompressFolder(ZipOutputStream zipStream, string filename)
//        {
//            try
//            {
//                FileInfo fi = new FileInfo(filename);

//                string entryName = fi.Name; // Makes the name in zip based on the folder
//                entryName = ZipEntry.CleanName(entryName); // Removes drive from name and fixes slash direction
//                ZipEntry newEntry = new ZipEntry(entryName);
//                newEntry.DateTime = fi.LastWriteTime; // Note the zip format stores 2 second granularity

//                // Specifying the AESKeySize triggers AES encryption. Allowable values are 0 (off), 128 or 256.
//                // A password on the ZipOutputStream is required if using AES.
//                //   newEntry.AESKeySize = 256;

//                // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003, WinZip 8, Java, and other older code,
//                // you need to do one of the following: Specify UseZip64.Off, or set the Size.
//                // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, you do not need either,
//                // but the zip will be in Zip64 format which not all utilities can understand.
//                //   zipStream.UseZip64 = UseZip64.Off;
//                newEntry.Size = fi.Length;

//                zipStream.PutNextEntry(newEntry);

//                // Zip the file in buffered chunks
//                // the "using" will close the stream even if an exception occurs
//                byte[] buffer = new byte[4096];
//                using (FileStream streamReader = File.OpenRead(filename))
//                {
//                    StreamUtils.Copy(streamReader, zipStream, buffer);
//                }
//                zipStream.CloseEntry();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public void ExtractZipFile(string archiveFilenameIn, string outFolder)
//        {
//            ZipFile zf = null;
//            try
//            {
//                FileStream fs = File.OpenRead(archiveFilenameIn);
//                zf = new ZipFile(fs);
//                if (!String.IsNullOrEmpty(null))
//                {
//                    zf.Password = null;     // AES encrypted entries are handled automatically
//                }
//                foreach (ZipEntry zipEntry in zf)
//                {
//                    if (!zipEntry.IsFile)
//                    {
//                        continue;           // Ignore directories
//                    }
//                    String entryFileName = zipEntry.Name;
//                    // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
//                    // Optionally match entrynames against a selection list here to skip as desired.
//                    // The unpacked length is available in the zipEntry.Size property.

//                    byte[] buffer = new byte[4096];     // 4K is optimum
//                    Stream zipStream = zf.GetInputStream(zipEntry);

//                    // Manipulate the output filename here as desired.
//                    String fullZipToPath = Path.Combine(outFolder, entryFileName);
//                    string directoryName = Path.GetDirectoryName(fullZipToPath);
//                    if (directoryName.Length > 0)
//                        Directory.CreateDirectory(directoryName);

//                    // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
//                    // of the file, but does not waste memory.
//                    // The "using" will close the stream even if an exception occurs.
//                    using (FileStream streamWriter = File.Create(fullZipToPath))
//                    {
//                        StreamUtils.Copy(zipStream, streamWriter, buffer);
//                    }
//                }
//            }
//            finally
//            {
//                if (zf != null)
//                {
//                    zf.IsStreamOwner = true; // Makes close also shut the underlying stream
//                    zf.Close(); // Ensure we release resources
//                }
//            }
//        }

//        public void ZipMulti(string outPathname, List<string> listFile)
//        {
//            try
//            {
//                FileStream fsOut = File.Create(outPathname);
//                ZipOutputStream zipStream = new ZipOutputStream(fsOut);

//                zipStream.SetLevel(3); //0-9, 9 being the highest level of compression

//                zipStream.Password = null;  // optional. Null is the same as not setting. Required if using AES.
//                // This setting will strip the leading part of the folder path in the entries, to
//                // make the entries relative to the starting folder.
//                // To include the full path for each entry up to the drive root, assign folderOffset = 0.
//                foreach (string filename in listFile)
//                {
//                    try
//                    {
//                        FileInfo fi = new FileInfo(filename);
//                        if (fi.Exists)
//                        {
//                            string[] fileArr = filename.Split('\\');

//                            string entryName = fileArr[fileArr.Length - 1]; // Makes the name in zip based on the folder
//                            entryName = ZipEntry.CleanName(entryName); // Removes drive from name and fixes slash direction
//                            ZipEntry newEntry = new ZipEntry(entryName);
//                            newEntry.DateTime = fi.LastWriteTime; // Note the zip format stores 2 second granularity

//                            // Specifying the AESKeySize triggers AES encryption. Allowable values are 0 (off), 128 or 256.
//                            // A password on the ZipOutputStream is required if using AES.
//                            //   newEntry.AESKeySize = 256;

//                            // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003, WinZip 8, Java, and other older code,
//                            // you need to do one of the following: Specify UseZip64.Off, or set the Size.
//                            // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, you do not need either,
//                            // but the zip will be in Zip64 format which not all utilities can understand.
//                            //   zipStream.UseZip64 = UseZip64.Off;
//                            newEntry.Size = fi.Length;

//                            zipStream.PutNextEntry(newEntry);

//                            // Zip the file in buffered chunks
//                            // the "using" will close the stream even if an exception occurs
//                            byte[] buffer = new byte[4096];
//                            using (FileStream streamReader = File.OpenRead(filename))
//                            {
//                                StreamUtils.Copy(streamReader, zipStream, buffer);
//                            }
//                        }
//                    }
//                    catch (Exception)
//                    {
//                    }
//                }
//                zipStream.CloseEntry();
//                zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
//                zipStream.Close();
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void ZipMultiWithLimitSize(string outPathname, List<string> listFile, ref List<string> listFileNotZip, long limitSize)
//        {
//            try
//            {
//                FileStream fsOut = File.Create(outPathname);
//                ZipOutputStream zipStream = new ZipOutputStream(fsOut);
//                int posFileName = 0;

//                zipStream.SetLevel(3); //0-9, 9 being the highest level of compression

//                zipStream.Password = null;  // optional. Null is the same as not setting. Required if using AES.
                
//                foreach (string filename in listFile)
//                {
//                    try
//                    {
//                        FileInfo fi = new FileInfo(filename);
//                        if (fi.Exists)
//                        {
//                            string[] fileArr = filename.Split('\\');

//                            string entryName = fileArr[fileArr.Length - 1]; // Makes the name in zip based on the folder
//                            entryName = ZipEntry.CleanName(entryName); // Removes drive from name and fixes slash direction
//                            ZipEntry newEntry = new ZipEntry(entryName);
//                            newEntry.DateTime = fi.LastWriteTime; // Note the zip format stores 2 second granularity
                            
//                            newEntry.Size = fi.Length;

//                            zipStream.PutNextEntry(newEntry);

//                            // Zip the file in buffered chunks
//                            // the "using" will close the stream even if an exception occurs
//                            byte[] buffer = new byte[4096];
//                            using (FileStream streamReader = File.OpenRead(filename))
//                            {
//                                StreamUtils.Copy(streamReader, zipStream, buffer);                                
//                            }

//                            if (zipStream.Length > limitSize)
//                            {                                
//                                break;
//                            }

                            
//                            posFileName += 1;
                           
//                        }
//                    }
//                    catch (Exception)
//                    {
//                    }
//                }
//                zipStream.CloseEntry();
//                zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
//                zipStream.Close();

//                if (posFileName < listFile.Count)
//                {
//                    for (int i = posFileName; i < listFile.Count; i++)
//                    {
//                        listFileNotZip.Add(listFile[i]);
//                    }

//                    foreach(var fileName in listFileNotZip)
//                    {
//                        listFile.Remove(fileName);
//                    }

//                    if (listFile.Count > 0)
//                    {
//                        ZipMulti(outPathname, listFile);
//                    }                    
//                }
//                else
//                {
//                    listFileNotZip = listFileNotZip.Count > 0 ? new List<string>() : listFileNotZip;
//                }
                
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void ZipFolder(ZipFile f, string root, string folder)
//        {

//            string relative = folder.Substring(root.Length);
//            if (relative.Length > 0)
//            {
//                f.AddDirectory(relative);
//            }

//            foreach (string file in Directory.GetFiles(folder))
//            {
//                relative = file.Substring(root.Length);
//                f.Add(file, relative);
//            }

//            foreach (string subFolder in Directory.GetDirectories(folder))
//            {
//                this.ZipFolder(f, root, subFolder);
//            }
//        }

//        public void ZipMulti(string outPathname, string password, List<string> listFile)
//        {

//            try
//            {
//                FileStream fsOut = File.Create(outPathname);
//                ZipOutputStream zipStream = new ZipOutputStream(fsOut);

//                zipStream.SetLevel(3); //0-9, 9 being the highest level of compression

//                if (string.IsNullOrWhiteSpace(password))
//                {
//                    zipStream.Password = null;
//                }
//                else
//                {
//                    zipStream.Password = password;
//                }  // optional. Null is the same as not setting. Required if using AES.
//                // This setting will strip the leading part of the folder path in the entries, to
//                // make the entries relative to the starting folder.
//                // To include the full path for each entry up to the drive root, assign folderOffset = 0.
//                foreach (string filename in listFile)
//                {
//                    try
//                    {
//                        FileInfo fi = new FileInfo(filename);
//                        if (fi.Exists)
//                        {
//                            string[] fileArr = filename.Split('\\');

//                            string entryName = fileArr[fileArr.Length - 1]; // Makes the name in zip based on the folder
//                            entryName = ZipEntry.CleanName(entryName); // Removes drive from name and fixes slash direction
//                            ZipEntry newEntry = new ZipEntry(entryName);
//                            newEntry.DateTime = fi.LastWriteTime; // Note the zip format stores 2 second granularity

//                            // Specifying the AESKeySize triggers AES encryption. Allowable values are 0 (off), 128 or 256.
//                            // A password on the ZipOutputStream is required if using AES.
//                            //   newEntry.AESKeySize = 256;

//                            // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003, WinZip 8, Java, and other older code,
//                            // you need to do one of the following: Specify UseZip64.Off, or set the Size.
//                            // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, you do not need either,
//                            // but the zip will be in Zip64 format which not all utilities can understand.
//                            //   zipStream.UseZip64 = UseZip64.Off;
//                            newEntry.Size = fi.Length;

//                            zipStream.PutNextEntry(newEntry);

//                            // Zip the file in buffered chunks
//                            // the "using" will close the stream even if an exception occurs
//                            byte[] buffer = new byte[4096];
//                            using (FileStream streamReader = File.OpenRead(filename))
//                            {
//                                StreamUtils.Copy(streamReader, zipStream, buffer);
//                            }
//                        }
//                    }
//                    catch (Exception)
//                    {
//                    }
//                }
//                zipStream.CloseEntry();
//                zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
//                zipStream.Close();
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }
        
        
//        // Zip All File in Folder And PassWord
//        private void ZipFolderPassWord(string outPathname, string password, string folderName)
//        {
//            FileStream fsOut = File.Create(outPathname);
//            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

//            zipStream.SetLevel(3);

//            password = string.IsNullOrEmpty(password) ? string.Empty : password;

//            int folderOffset = folderName.Length + (folderName.EndsWith("\\") ? 0 : 1);

//            CompressFolder(folderName, zipStream, folderOffset);

//            zipStream.IsStreamOwner = true;
//            zipStream.Close();
//        }

//        private void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
//        {
//            string[] files = Directory.GetFiles(path);

//            foreach (string filename in files)
//            {
//                FileInfo fi = new FileInfo(filename);

//                string entryName = filename.Substring(folderOffset);
//                entryName = ZipEntry.CleanName(entryName);
//                ZipEntry newEntry = new ZipEntry(entryName);
//                newEntry.DateTime = fi.LastWriteTime;

//                newEntry.Size = fi.Length;

//                zipStream.PutNextEntry(newEntry);

//                byte[] buffer = new byte[4096];
//                using (FileStream streamReader = File.OpenRead(filename))
//                {
//                    StreamUtils.Copy(streamReader, zipStream, buffer);
//                }
//                zipStream.CloseEntry();
//            }
//            string[] folders = Directory.GetDirectories(path);
//            foreach (string folder in folders)
//            {
//                CompressFolder(folder, zipStream, folderOffset);
//            }
//        }
//    }
//}