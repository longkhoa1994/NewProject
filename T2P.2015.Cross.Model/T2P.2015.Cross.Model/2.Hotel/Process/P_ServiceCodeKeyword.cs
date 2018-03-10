using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ServiceCodeKeyword
    {
        private bool _isError;

        public bool IsError
        {
            get { return _isError; }
            set { _isError = value; }
        }
        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }
        private long i_PositionID;

        public long I_PositionID
        {
            get { return i_PositionID; }
            set { i_PositionID = value; }
        }
    }

       
}
