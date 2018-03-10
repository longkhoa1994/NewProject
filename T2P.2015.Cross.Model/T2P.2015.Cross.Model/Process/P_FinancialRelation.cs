using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_FinancialRelation
    {
        private long? _sourceID;

        public long? SourceID
        {
            get { return _sourceID; }
            set { _sourceID = value; }
        }

        private string _sourceType;

        public string SourceType
        {
            get { return _sourceType; }
            set { _sourceType = value; }
        }

        private long? _desID;

        public long? DesID
        {
            get { return _desID; }
            set { _desID = value; }
        }

        private string _desType;

        public string DesType
        {
            get { return _desType; }
            set { _desType = value; }
        }


    }
}
