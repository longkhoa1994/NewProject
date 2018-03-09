using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace T2P._2015.Cross.Utility.FileType
{
    public class ToolReadWriteFile
    {
        public static Encoding GetEncoding(string filename)
        {
            
            var encoding = Encoding.Default;

            using (StreamReader reader = new StreamReader(filename, true))
            {
                reader.Peek(); // you need this!
                return reader.CurrentEncoding;
            }

        }
        
       
        
        public static List<string> ReadFile(Stream inputStream, Encoding end)
        {
            try
            {
                string line;
                List<string> listData = new List<string>();
                StreamReader file = null;
                try
                {
                    file = new StreamReader(inputStream, end);
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

                return listData;
            }
            catch (Exception ex)
            {
                throw ex;
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

        public static Encoding GetFileEncoding(Stream file)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];
            //FileStream file = new FileStream(srcFile, FileMode.Open);
            file.Read(buffer, 0, 5);
            //srcFilefile.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;
            else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                // 1201 unicodeFFFE Unicode (Big-Endian)
                enc = Encoding.GetEncoding(1201);
            else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                // 1200 utf-16 Unicode
                enc = Encoding.GetEncoding(1200);


            return enc;
        }
    }
}
