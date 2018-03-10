using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class FormatErrorException : Exception
    {
        public FormatErrorException()
        {

        }

        public FormatErrorException(string message)
            : base(message)
        {

        }

        public FormatErrorException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }

    public class FileNotExistException : Exception
    {
        public FileNotExistException()
        {

        }

        public FileNotExistException(string message)
            : base(message)
        {

        }

        public FileNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }

    public class DuplicateFileException : Exception
    {
        public DuplicateFileException()
        {

        }

        public DuplicateFileException(string message)
            : base(message)
        {

        }

        public DuplicateFileException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
