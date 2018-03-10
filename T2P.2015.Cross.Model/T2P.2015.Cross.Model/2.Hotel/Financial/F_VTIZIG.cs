using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_VTIZIG : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_VTITransactionID;

        public long F_VTITransactionID
        {
            get { return _f_VTITransactionID; }
            set { _f_VTITransactionID = value; }
        }

        private decimal _groupnumber;

        public decimal Groupnumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }

        private string _documentNumber;

        public string DocumentNumber
        {
            get { return _documentNumber; }
            set { _documentNumber = value; }
        }

        private decimal _posRecNumber;

        public decimal PosRecNumber
        {
            get { return _posRecNumber; }
            set { _posRecNumber = value; }
        }

        private DateTime _posBookingDate;

        public DateTime PosBookingDate
        {
            get { return _posBookingDate; }
            set { _posBookingDate = value; }
        }

        private string _posServiceDescription;

        public string PosServiceDescription
        {
            get { return _posServiceDescription; }
            set { _posServiceDescription = value; }
        }

        private string _posServiceDescriptionExt;

        
        public string PosServiceDescriptionExt
        {
            get { return _posServiceDescriptionExt; }
            set { _posServiceDescriptionExt = value; }
        }

        private decimal _posAmountGR;

        public decimal PosAmountGR
        {
            get { return _posAmountGR; }
            set { _posAmountGR = value; }
        }

        private decimal _posAmountNET;

        public decimal PosAmountNET
        {
            get { return _posAmountNET; }
            set { _posAmountNET = value; }
        }

        private decimal _posVATAmount;

        public decimal PosVATAmount
        {
            get { return _posVATAmount; }
            set { _posVATAmount = value; }
        }

        private decimal _posVATPercentage;

        public decimal PosVATPercentage
        {
            get { return _posVATPercentage; }
            set { _posVATPercentage = value; }
        }

        private string _posDebCredIndicator;

        public string PosDebCredIndicator
        {
            get { return _posDebCredIndicator; }
            set { _posDebCredIndicator = value; }
        }

        private string _posMISIndicator;

        public string PosMISIndicator
        {
            get { return _posMISIndicator; }
            set { _posMISIndicator = value; }
        }

        private string _comment;

        
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public override string Table { get { return "F_VTIZIG"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_F_VTIZIG_InsertOrUpdate"; } }
    }

    public enum F_VTIZIGColumns
    {
        ID,
        F_VTITransactionID,
        Groupnumber,
        DocumentNumber,
        PosRecNumber,
        PosBookingDate,
        PosServiceDescription,
        PosServiceDescriptionExt,
        PosAmountGR,
        PosAmountNET,
        PosVATAmount,
        PosVATPercentage,
        PosDebCredIndicator,
        PosMISIndicator,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum F_VTIZIGProcedure
    {
        p_F_VTIZIG_Create,
        p_F_VTIZIG_GetListForDeleting,
        p_F_VTIZIG_GetListForCorrection_Checking,

    }

    public class F_VTIZIGList : List<F_VTIZIG>
    {
    }
}