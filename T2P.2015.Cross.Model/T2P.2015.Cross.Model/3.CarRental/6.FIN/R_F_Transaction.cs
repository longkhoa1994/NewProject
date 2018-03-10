using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_F_Transaction : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _r_F_HeaderID;
        public long? R_F_HeaderID
        {
            get { return _r_F_HeaderID; }
            set { _r_F_HeaderID = value; }
        }
        private long? _r_B_AccessID;
        public long? R_B_AccessID
        {
            get { return _r_B_AccessID; }
            set { _r_B_AccessID = value; }
        }
        private long? _financialID;
        public long? FinancialID
        {
            get { return _financialID; }
            set { _financialID = value; }
        }
        private string _documentNo;
        public string DocumentNo
        {
            get { return _documentNo; }
            set { _documentNo = value; }
        }
        private string _reservationNumber;
        public string ReservationNumber
        {
            get { return _reservationNumber; }
            set { _reservationNumber = value; }
        }
        private DateTime? _salesDate;
        public DateTime? SalesDate
        {
            get { return _salesDate; }
            set { _salesDate = value; }
        }
        private decimal? _grossAmount;
        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }
        private string _currency;
        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        private string _carRentalProvider;
        public string CarRentalProvider
        {
            get { return _carRentalProvider; }
            set { _carRentalProvider = value; }
        }
        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private DateTime? pickupDate;

        public DateTime? PickupDate
        {
            get { return pickupDate; }
            set { pickupDate = value; }
        }

        private DateTime? returnDate;

        public DateTime? ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        private string errorCode;

        public string ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

        private string _financialStatus;
        public string FinancialStatus
        {
            get { return _financialStatus; }
            set { _financialStatus = value; }
        }
        private string _dBI_PK;
        public string DBI_PK
        {
            get { return _dBI_PK; }
            set { _dBI_PK = value; }
        }
        private string _dBI_KS;
        public string DBI_KS
        {
            get { return _dBI_KS; }
            set { _dBI_KS = value; }
        }
        private string _dBI_DS;
        public string DBI_DS
        {
            get { return _dBI_DS; }
            set { _dBI_DS = value; }
        }
        private string _dBI_AE;
        public string DBI_AE
        {
            get { return _dBI_AE; }
            set { _dBI_AE = value; }
        }
        private string _dBI_IK;
        public string DBI_IK
        {
            get { return _dBI_IK; }
            set { _dBI_IK = value; }
        }
        private string _dBI_BD;
        public string DBI_BD
        {
            get { return _dBI_BD; }
            set { _dBI_BD = value; }
        }
        private string _dBI_PR;
        public string DBI_PR
        {
            get { return _dBI_PR; }
            set { _dBI_PR = value; }
        }
        private string _dBI_AU;
        public string DBI_AU
        {
            get { return _dBI_AU; }
            set { _dBI_AU = value; }
        }
        private string _dBI_AK;
        public string DBI_AK
        {
            get { return _dBI_AK; }
            set { _dBI_AK = value; }
        }
        private string _dBI_RZ;
        public string DBI_RZ
        {
            get { return _dBI_RZ; }
            set { _dBI_RZ = value; }
        }

        public override string Table { get { return "R_F_Transaction"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_F_Transaction_InsertOrUpdate"; } }
    }
    public enum R_F_TransactionColumns
    {
        ID,
        R_F_HeaderID,
        R_B_AccessID,
        FinancialID,
        DocumentNo,
        ReservationNumber,
        SalesDate,
        GrossAmount,
        Currency,
        CarRentalProvider,
        TravelerName,
        FinancialStatus,
        DBI_PK,
        DBI_KS,
        DBI_DS,
        DBI_AE,
        DBI_IK,
        DBI_BD,
        DBI_PR,
        DBI_AU,
        DBI_AK,
        DBI_RZ,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_F_TransactionProcedure
    {
        p_R_F_Transaction_Get_By_R_I_DataID_ForMatchFIN,
        p_R_F_Transaction_Get_ForTAccount,
        p_R_F_Transaction_Get_List_NotMatchInv_By_R_B_AccessID,
        p_R_F_Transaction_GetBy_BookingNo,
        p_R_F_Transaction_Get_By_R_I_DataID,
        p_R_F_Transaction_Get_ByBooking,
        p_R_F_Transaction_Get_List_By_R_B_AccessID,
        p_R_I_Error_IFA_Get_By_R_F_TransactionID,
        p_R_F_Transaction_Get_List_Need_Collection_By_R_B_AccessID,
        p_R_F_Transaction_Inactive_By_R_F_TransactionID,
        p_R_F_Transaction_Get_List_By_R_B_AccessID_NotRelation,
        p_R_F_Transaction_Get_By_R_I_DataID_And_NotMatchInv_By_R_B_AccessID,

    }
    public class R_F_TransactionList : List<R_F_Transaction>
    {

    }

    public class R_F_Transaction_ATX : R_F_Transaction
    {
        private long? _result;
        public long? Result
        {
            get { return _result; }
            set { _result = value; }
        }

        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
    }
}