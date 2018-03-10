using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model.OCR
{
    public class ReferenceDataModel
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _key;
        public string ReferenceKey
        {
            get { return _key; }
            set { _key = value; }
        }

        private InvoiceZoneType _invoiceItemType;
        public InvoiceZoneType InvoiceItemType
        {
            get { return _invoiceItemType; }
            set { _invoiceItemType = value; }
        }

        private int _countryId;
        public int CountryId
        {
            get { return _countryId; }
            set { _countryId = value; }
        }
    }

    public enum ReferenceDataModel_Procedure
    {
        p_GetReference_ByKey,
        p_GetFirstReference_ByKey
    }
}
