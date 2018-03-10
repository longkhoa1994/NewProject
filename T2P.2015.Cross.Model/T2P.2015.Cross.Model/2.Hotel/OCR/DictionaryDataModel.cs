using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model.OCR
{
    [Serializable]
    public class DictionaryDataModel
    {
        private long _dictionaryId;
        public long DictionaryId
        {
            get { return _dictionaryId; }
            set { _dictionaryId = value; }
        }

        private string _dictionaryKey;
        public string DictionaryKey
        {
            get { return _dictionaryKey; }
            set { _dictionaryKey = value; }
        }

        private InvoiceZoneType _invoiceItemType;
        public InvoiceZoneType InvoiceItemType
        {
            get { return _invoiceItemType; }
            set { _invoiceItemType = value; }
        }
    }

    public enum DictionaryDataModel_Procedure
    {
        p_RD_GetDictionary_ByKey
    }
    
    [Serializable]
    public class RD_MaxLengthModel
    {
        private int _lengthOfName;
        public int LengthOfName
        {
            get { return _lengthOfName; }
            set { _lengthOfName = value; }
        }
    }

    public class M_Position
    {
        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
    public class M_Tax
    {
        private string _tax;
        public string Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
    }


    public enum RD_Company_Procedure
    {
        p_RD_GetAllCompanyNames,

        p_RD_GetAllCompanies_ByLengthOfName,
        p_RD_GetAllCompanies_ByLengthOfName_AndByHotelName,

        p_RD_GetMaxLengthOfLongestCompanyName,
        p_RD_GetMaxLengthOfLongestCompanyName_AndByHotelName,
    }
    public enum RD_Hotel_Procedure
    {
        p_RD_GetAllHotelNames,

        p_RD_GetAllHotels_ByLengthOfName,
        p_RD_GetAllHotels_ByLengthOfName_AndByCompanyName,

        p_RD_GetMaxLengthOfLongestHotelName,
        p_RD_GetMaxLengthOfLongestHotelName_AndByCompanyName
    }
}
