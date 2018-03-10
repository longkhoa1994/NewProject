using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum.CarRental.Invoice;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Error : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }


        private long? _r_I_DataID;
        public long? R_I_DataID
        {
            get { return _r_I_DataID; }
            set { _r_I_DataID = value; }
        }


        private long? _r_I_ServiceID;
        public long? R_I_ServiceID
        {
            get { return _r_I_ServiceID; }
            set { _r_I_ServiceID = value; }
        }


        private long? _r_M_InvoiceErrorCodeID;
        public long? R_M_InvoiceErrorCodeID
        {
            get { return _r_M_InvoiceErrorCodeID; }
            set { _r_M_InvoiceErrorCodeID = value; }
        }


        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private long? _correctServiceID;

        public long? CorrectServiceID
        {
            get { return _correctServiceID; }
            set { _correctServiceID = value; }
        }

        private bool _isSkip;

        public bool IsSkip
        {
            get { return _isSkip; }
            set { _isSkip = value; }
        }

        private decimal? _expectedAmount;

        public decimal? ExpectedAmount
        {
            get { return _expectedAmount; }
            set { _expectedAmount = value; }
        }


        public override string Table { get { return "R_I_Error"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Error_InsertOrUpdate"; } }
    }

    public enum R_I_ErrorColumns
    {
        ID,
        R_I_DataID,
        R_I_ServiceID,
        R_M_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_I_ErrorProcedure
    {
        p_R_I_Error_Get_By_R_I_DataID,
        p_R_I_Error_GetFullBy_R_I_DataID,
        p_R_I_Error_GetBy_CorrectServiceId,
        p_R_I_Error_GetBy_ListR_I_DataID,
        p_R_I_Error_Get_By_R_I_DataID_ErrorCode
    }

    public class R_I_ErrorList : List<R_I_Error>
    {
    }
}