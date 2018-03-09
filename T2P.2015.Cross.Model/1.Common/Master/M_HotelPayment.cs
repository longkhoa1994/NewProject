using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelPayment : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_HotelID;
        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private long _m_PaymentID;
        public long M_PaymentID
        {
            get { return _m_PaymentID; }
            set { _m_PaymentID = value; }
        }
        public override string Table { get { return "M_HotelPayment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelPayment_InsertOrUpdate"; } }
    }
    public enum M_HotelPaymentColumns
    {
        ID,
        M_HotelID,
        M_PaymentID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelPaymentProcedure
    {
        p_M_HotelPayment_GetList_ByM_HotelID,
        p_M_HotelPayment_GetListVCC_ByM_HotelID,
        p_M_HotelPayment_GetListVCC_ByM_HotelIDForHotelDetail,
     
    }
    public class M_HotelPaymentList : List<M_HotelPayment>
    {

    }
}