using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Resource : M_ResourceTranslation
    {
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        private string defaultValue;

        public string DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }
    }
}
