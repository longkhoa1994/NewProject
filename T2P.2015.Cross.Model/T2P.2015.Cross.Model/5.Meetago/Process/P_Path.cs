using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_Path
    {
        private M_FileLocation m_FileLocation;

        public M_FileLocation M_FileLocation
        {
            get { return m_FileLocation; }
            set { m_FileLocation = value; }
        }

        private M_HotelPlatform m_HotelPlatform;

        public M_HotelPlatform M_HotelPlatform
        {
            get { return m_HotelPlatform; }
            set { m_HotelPlatform = value; }
        }

        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private long m_FileLocationID;

        public long M_FileLocationID
        {
            get { return m_FileLocationID; }
            set { m_FileLocationID = value; }
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string fileNameResult;

        public string FileNameResult
        {
            get { return fileNameResult; }
            set { fileNameResult = value; }
        }

        private string pathFolder;

        public string PathFolder
        {
            get { return pathFolder; }
            set { pathFolder = value; }
        }

        private string pathFolderResult;

        public string PathFolderResult
        {
            get { return pathFolderResult; }
            set { pathFolderResult = value; }
        }
    }
}
