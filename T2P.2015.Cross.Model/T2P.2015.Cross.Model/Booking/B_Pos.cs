using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Pos : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingID;

        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private string _requesterID;

        public string RequesterID
        {
            get { return _requesterID; }
            set { _requesterID = value; }
        }

        private string _companyID;

        public string CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _vatIdentificationNumber;

        
        public string VatIdentificationNumber
        {
            get { return _vatIdentificationNumber; }
            set { _vatIdentificationNumber = value; }
        }

        private string _bookingChannelType;

        public string BookingChannelType
        {
            get { return _bookingChannelType; }
            set { _bookingChannelType = value; }
        }

        public override string Table { get { return "B_Pos"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Pos_InsertOrUpdate"; } }
    }

    public enum B_PosColumns
    {
        ID,
        B_BookingID,
        RequesterID,
        CompanyID,
        CompanyName,
        VatIdentificationNumber,
        BookingChannelType,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_PosProcedure
    {
        p_B_Pos_Get_By_B_BookingID,
        p_B_Pos_GetListForDeleting,
    }

    public class B_PosList : List<B_Pos>
    {
    }
}