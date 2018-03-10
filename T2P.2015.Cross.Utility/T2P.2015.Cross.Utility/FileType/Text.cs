using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.FileType
{
    public class Text
    {
        public bool Delete(string fileNameFullPath)
        {
            if (true == System.IO.File.Exists(fileNameFullPath))
            {
                // Use a try block to catch IOExceptions, to 
                // handle the case of the file already being 
                // opened by another process. 
                try
                {
                    System.IO.File.Delete(fileNameFullPath);
                    return true;
                }
                catch (System.IO.IOException e)
                {
                    e.ToString();
                    return false;
                }
            }
            return false;
        }
        public bool MoveFile(string sourceFileName, string destFileName)
        {
            try
            {
                if (!File.Exists(destFileName))
                {
                    // This statement ensures that the file is created, 
                    // but the handle is not kept. 
                    using (FileStream fs = File.Create(destFileName)) { }
                }

                // Ensure that the target does not exist. 
                if (File.Exists(destFileName))
                    File.Delete(destFileName);

                // Move the file.
                File.Move(sourceFileName, destFileName);

                // See if the original exists now. 
                if (File.Exists(sourceFileName))
                {
                    return false;
                }
                return true;

            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }

        public static Encoding GetFileEncoding(string srcFile)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            using (var reader = new System.IO.StreamReader(srcFile, true))
            {
                enc = reader.CurrentEncoding;
            }
            return enc;
        }

        public List<string> ReadFile3(string filePath)
        {
            try
            {
                string line;
                List<string> listData = new List<string>();
                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        Encoding end = GetFileEncoding(filePath);
                        file = new StreamReader(filePath, end);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listData.Add(line);
                            }
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                return listData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> ReadFile(string filePath)
        {
            try
            {
                string line;
                List<string> listData = new List<string>();
                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(filePath);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listData.Add(line);
                            }
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                return listData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadFile2(string filePath)
        {
            try
            {
                string line;
                string listData = string.Empty;
                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(filePath);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listData += line;
                            }
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                return listData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        public List<string> ReadFileEncoding(string filePath)
        {
            try
            {
                string line;
                List<string> listData = new List<string>();
                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(filePath, Encoding.Default);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listData.Add(line);
                            }
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                return listData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> ReadFileEncoding(string filePath, Encoding end)
        {
            try
            {
                string line;
                List<string> listData = new List<string>();
                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(filePath, end);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listData.Add(line);
                            }
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                return listData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadFileWithEncoding(string filePath, Encoding end)
        {
            try
            {
                string line;
                string resultData = string.Empty;
                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(filePath, end);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                resultData += line;
                            }
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                return resultData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string ReadFileShare(string filePath)
        {
            try
            {
                string result = string.Empty;
                // Open the stream and read it back.
                if (!File.Exists(filePath))
                {
                    return string.Empty;
                }
                using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(fs, Encoding.Default);
                        return file != null ? file.ReadToEnd() : string.Empty;
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void WriteText(StringBuilder data, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8);
                sw.Write(data);
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
            }
        }
        public void WriteText2(string data, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8);
                sw.Write(data);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public void WriteText(string data, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8);
                sw.Write(data);
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
            }
        }

        public void WriteText(StringBuilder data, string fileName, Encoding encode)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false, encode);
                sw.Write(data);
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
            }
        }
    }
}
