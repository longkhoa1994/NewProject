using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model._5.Meetago.Contract;

namespace T2P._2015.Cross.Model._5.Meetago.Booking
{
    [Serializable]
    public class B_Contract : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _b_BookingID;

        public long? B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private string _contractNumber;

        public string ContractNumber
        {
            get { return _contractNumber; }
            set { _contractNumber = value; }
        }

        private DateTime? _contractDate;

        public DateTime? ContractDate
        {
            get { return _contractDate; }
            set { _contractDate = value; }
        }

        private bool _commissionable;

        public bool Commissionable
        {
            get { return _commissionable; }
            set { _commissionable = value; }
        }

        private string _requestLanguage;

        public string RequestLanguage
        {
            get { return _requestLanguage; }
            set { _requestLanguage = value; }
        }

        private string _offerNo;

        public string OfferNo
        {
            get { return _offerNo; }
            set { _offerNo = value; }
        }

        private DateTime? _offerDate;

        public DateTime? OfferDate
        {
            get { return _offerDate; }
            set { _offerDate = value; }
        }

        private string _newRequestID;

        public string NewRequestID
        {
            get { return _newRequestID; }
            set { _newRequestID = value; }
        }

        private string _statusID;

        public string StatusID
        {
            get { return _statusID; }
            set { _statusID = value; }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private long _verification;
        public long Verification
        {
            get { return _verification; }
            set { _verification = value; }
        }

        public override string Table { get { return "B_Contract"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Contract_InsertOrUpdate"; } }
    }

    public enum B_ContractColumns
    {
        ID,
        B_BookingID,
        ContractNumber,
        ContractDate,
        Commissionable,
        RequestLanguage,
        OfferNo,
        OfferDate,
        NewRequestID,
        StatusID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_ContractProcedure
    {
        p_B_Contract_GetBy_B_AccessID,
        p_P_B_Contract_GetID_ByNumber,
        p_B_ContractFile_CheckBooking,
        p_B_ContractFile_CheckLock,
        p_B_Contract_Get_By_B_BookingID,
        p_B_Contract_GetListContract_ByEvent
    }

    public class B_ContractList : List<B_Contract>
    {
    }

    public class SInvoiceMatchSContractVM
    {
        //public DateTime ServiceDate;

        public I_Position IService;

        public B_Room RoomCService;
        public B_Package PackageCService;
        public B_AdditionalService AdditionalCService;
        public B_CancellationPolicy CancellationCService;

        public SInvoiceMatchSContractVM()
        {
            RoomCService = null;
            PackageCService = null;
            AdditionalCService = null;
            CancellationCService = null;
        }
    }

    public class MappingInvoiceContractTemp
    {
        public int? ContractQuantity;
        public decimal? ContractPrice;
        public decimal? ContractGrossAmount;
        public int? InvoiceQuantity;
        public decimal? InvoicePrice;
        public decimal? InvoiceGrossAmount;
        public List<I_Position>  ServicesList;

        public MappingInvoiceContractTemp()
        {
            ContractQuantity = 0;
            ContractPrice = 0;
            ContractGrossAmount = 0;
            InvoiceQuantity = 0;
            InvoicePrice = 0;
            InvoiceGrossAmount = 0;

            ServicesList = new List<I_Position>();
        }
    }
}