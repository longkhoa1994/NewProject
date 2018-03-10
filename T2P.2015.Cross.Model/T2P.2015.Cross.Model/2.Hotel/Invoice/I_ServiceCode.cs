using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Invoice
{
    [Serializable]
    public class I_ServiceCode : BaseModel
    {
        public string ServiceDescription { get; set; }
        public string ServiceCode { get; set; }
    }
    public enum I_ServiceCodeProcedure
    {
        p_I_ServiceCode_GetByDescription
    }
}
