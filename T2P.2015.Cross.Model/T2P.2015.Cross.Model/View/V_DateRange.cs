using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.View
{
    public class V_DateRange
    {
        private DateTime? _from;

        public DateTime? From
        {
            get { return _from; }
            set { _from = value; }
        }

        private DateTime? _to;

        public DateTime? To
        {
            get { return _to; }
            set { _to = value; }
        }

        public V_DateRange()
        {
            From = null;
            To = null;
        }
    }
}
