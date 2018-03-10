using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Image : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_B_AccessID;

        public long? R_B_AccessID
        {
            get { return _r_B_AccessID; }
            set { _r_B_AccessID = value; }
        }

        private long? _r_m_FileLocationID;

        public long? R_M_FileLocationID
        {
            get { return _r_m_FileLocationID; }
            set { _r_m_FileLocationID = value; }
        }

        private long? _r_RG_RateGridID;

        public long? R_RG_RateGridID
        {
            get { return _r_RG_RateGridID; }
            set { _r_RG_RateGridID = value; }
        }

        private bool _hasRateGrid;

        public bool HasRateGrid
        {
            get { return _hasRateGrid; }
            set { _hasRateGrid = value; }
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

        private string _imageStatus;

        public string ImageStatus
        {
            get { return _imageStatus; }
            set { _imageStatus = value; }
        }

        private bool _isParking;

        public bool IsParking
        {
            get { return _isParking; }
            set { _isParking = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        public long M_CompanyID { get; set; }

        public string InvoiceNumber{ get; set; }

        public override string Table { get { return "R_I_Image"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Image_InsertOrUpdate"; } }
    }

    public enum R_I_ImageColumns
    {
        ID,
        R_B_AccessID,
        R_M_FileLocationID,
        _r_RG_RateGridID,
        FilePath,
        FileName,
        ImageStatus,
        IsParking,
        BookingNo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_I_ImageProcedure
    {
        p_R_I_Image_Get_By_R_I_DataID,
        p_R_I_Image_Get_ByID_ForNotification,
        p_R_I_Image_Get_ByBooking_WithPath,
        p_R_I_Image_Get_ForCROCR,
        p_R_I_Image_Error_Get_By_R_I_ImageID,
        p_R_I_Image_Get_ByBooking,
        p_R_I_Image_GetbyToken,
        p_R_I_Image_Relation_Get_By_R_I_ImageID,
        p_R_I_Image_Get_Unmatched_Image_By_R_B_AccessID,
        p_R_I_Image_Get_CreateCollectionCreditNote,
        p_R_I_Image_MatchBooking_Get_By_BillingEmailID,
        p_R_I_Image_IsUniqueInvoice,
        p_R_I_Image_Replace_Get_By_R_I_ImageID,
        p_R_I_Image_Get_Location_By_R_I_ImageID,
        p_R_I_Image_Get_Invoice_Delivery,
        p_R_I_Image_CreditNote_Get_By_R_B_AccessID,
        p_R_I_Image_GetListInvoiceDetail,
        p_R_I_Image_Get_By_CarProviderID_InvoiceNumber,
        p_R_I_Image_Get_NewDebitInvoice,
        p_R_I_Image_Get_By_List_InvoiceNumber,
    }

    public class R_I_ImageList : List<R_I_Image>
    {
    }

    public class R_P_InvoiceError_Image : R_M_InvoiceErrorCode
    {
        private long r_i_ImageID;

        public long R_I_ImageID
        {
            get { return r_i_ImageID; }
            set { r_i_ImageID = value; }
        }
    }

    public class R_P_Image_Path : I_Image
    {


        private string _iP;

        public string IP
        {
            get { return _iP; }
            set { _iP = value; }
        }

        private string _iISPath;

        public string IISPath
        {
            get { return _iISPath; }
            set { _iISPath = value; }
        }

        private List<R_P_InvoiceError_Image> _listErrorCode;

        public List<R_P_InvoiceError_Image> ListErrorCode
        {
            get { return _listErrorCode; }
            set { _listErrorCode = value; }
        }

        private List<P_Image_Path> _listCombinedInvoice;

        public List<P_Image_Path> ListCombinedInvoice
        {
            get { return _listCombinedInvoice; }
            set { _listCombinedInvoice = value; }
        }

        private List<P_Image_Path> _listSplitedInvoice;

        public List<P_Image_Path> ListSplitedInvoice
        {
            get { return _listSplitedInvoice; }
            set { _listSplitedInvoice = value; }
        }

        private string newID;

        public string NewID
        {
            get { return newID; }
            set { newID = value; }
        }

        private string _invoiceNo;

        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private string _groupCombined;

        public string GroupCombined
        {
            get { return _groupCombined; }
            set { _groupCombined = value; }
        }
    }
    public class R_P_Image_Extend : R_I_Image
    {
        private string _invoiceNo;

        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
    }

}