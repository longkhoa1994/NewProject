using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BookingBillingEmail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _n_BillingEmailID;

        public long N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }

        public override string Table { get { return "N_BookingBillingEmail"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_BookingBillingEmail_InsertOrUpdate"; } }
    }

    public class N_BookingBillingEmail_Extend : N_BookingBillingEmail
    {

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        public long HotelPlatformID { get; set; }
        public long EventID { get; set; }

    }

    public enum N_BookingBillingEmailColumns
    {
        ID,
        B_AccessID,
        N_BillingEmailID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_BookingBillingEmailProcedure
    {
        p_N_BookingBillingEmail_GetByN_BillingEmailID,
        p_N_BookingBillingEmail_GetByN_BillingEmailID_VanTest,
        p_N_BookingBillingEmail_GetByB_AccessID,
        p_N_BookingBillingEmail_GetListForDeleting,
        p_N_BookingBilliingEmailGetListForArchiving_Deleting,
        p_N_BookingBillingEmail_GetByB_AccessID_ListI_ImageID,
        p_N_BookingBillingEmail_CheckDifferentCompany,
        p_N_BookingBillingEmail_Check_Update_Email_Hotel
    }

    public class N_BookingBillingEmailList : List<N_BookingBillingEmail>
    {
    }
}