using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Cross.Model._5.Meetago.Process;
using T2P._2015.Cross.Model.History;
using T2P._2015.Model;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Data : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_ImportID;
        public long? I_ImportID
        {
            get { return _i_ImportID; }
            set { _i_ImportID = value; }
        }
        private long _i_ImageID;
        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private string _invoiceNo;
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        private DateTime? _invoiceDate;
        public DateTime? InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }
        private decimal? _grossAmount;
        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }
        private decimal? _netAmount;
        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }
        private string _currencyCode;
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private string _vATIdenNumber;
        public string VATIdenNumber
        {
            get { return _vATIdenNumber; }
            set { _vATIdenNumber = value; }
        }
        private string _tAXIdenNumber;
        public string TAXIdenNumber
        {
            get { return _tAXIdenNumber; }
            set { _tAXIdenNumber = value; }
        }
        private DateTime? _checkInDate;
        public DateTime? CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }
        private DateTime? _checkOutDate;
        public DateTime? CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }
        private string _imageFileName;
        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }
        private int? _readyVTI;
        public int? ReadyVTI
        {
            get { return _readyVTI; }
            set { _readyVTI = value; }
        }
        private string _hotelVATNumber;
        public string HotelVATNumber
        {
            get { return _hotelVATNumber; }
            set { _hotelVATNumber = value; }
        }
        private int? _isParking;
        public int? IsParking
        {
            get { return _isParking; }
            set { _isParking = value; }
        }

        private int? _isWaitingCorrection;
        public int? IsWaitingCorrection
        {
            get { return _isWaitingCorrection; }
            set { _isWaitingCorrection = value; }
        }        

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public long B_AccessID { get; set; }
        public bool isSkipFIN { get; set; }
        public List<int> ListRemove { get; set; }
        public List<long> ListSkipFIN { get; set; }
        public List<I_Position> ListPositions { get; set; }
        public override string Table { get { return "I_Data"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Data_InsertOrUpdate"; } }
    }

    public class I_Data_Extend: I_Data
    {
        public string ImageStatus { get; set; }
    }
    public enum I_DataColumns
    {
        ID,
        I_ImportID,
        I_ImageID,
        InvoiceNo,
        InvoiceDate,
        GrossAmount,
        NetAmount,
        CurrencyCode,
        VATIdenNumber,
        TAXIdenNumber,
        CheckInDate,
        CheckOutDate,
        ImageFileName,
        ReadyVTI,
        HotelVATNumber,
        IsParking,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_DataProcedure
    {
        p_I_Data_GetByImageID,
        p_P_GetListFinInvoice,
        p_I_Data_GetByID,
        p_I_Data_Update_ReadyVTI,
        p_P_FinInvoice_DebitCredit,
        p_InvoiceCorrection_Get_ByDataID,
        p_I_Data_Get_ByBooking,
        p_I_Data_Get_ForTAccount,
        p_I_Data_GetInfoForRejectionLetter,
        p_I_Data_SearchSuccessfulInvoice,
        p_I_Data_GetSuccessfulInvoiceDetail_Position,
        p_I_Data_GetSuccessfulInvoiceDetail_Tax,
        p_I_Data_GetSuccessfulInvoiceDetail_Header,
        p_I_Data_ExportSuccessfulInvoice_GetFilePath,
        p_I_Data_SuccessfulInvoiceDetail_GetInvoiceImageList,
        p_I_Data_CheckDuplicate,
        p_I_Data_GetListByListImageID,
        p_I_Data_GetListForCheckErrorVTI,
        p_I_Data_GetByFinID,
        p_I_Data_GetByB_AccessID,
        p_I_Data_GetListHasErrorServiceCode,
        p_I_Data_GetListHasSameErrors,
        p_I_Data_GetListForDeleting,
        p_I_Data_GetListForArchiving_Deleting,
        p_I_Data_CheckDuplicateInvoiceByYear,
        p_I_Data_GetList_ByListID,
        p_I_Data_GetList_FinalCheck,
        p_I_Data_GetList_FinalCheck_Count,
        p_I_Data_Get_ByBooking_ForVCC,
        p_I_Data_UpdateList_LockUnLockWaitingCorrection,
        p_I_Data_UpdateFirstCorrectionTime_ByID,
        p_B_Booking_Cancel_GetInvoice,
        p_I_Data_GetNotMatchedInvoiceByAccessID,
        p_I_Data_GetListOldInvoiceByBookingNo,
        p_I_DataCheckSuccessfulInvoice,
        p_I_Data_GetLastCapture,
        p_I_Image_GetImage_DuplicateData_With_InvoiceDeposit
    }
    public class I_DataList : List<I_Data>
    {

    }

    public class P_InvoiceImport
    {
        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        public I_Data I_Data { get; set; }
        public List<I_Tax> ListI_Tax { get; set; }
        public List<I_Position> ListI_Position { get; set; }
        public List<I_Error> ListI_Error { get; set; }
        public List<P_InvoiceError> ListP_InvoiceError { get; set; }
        public P_Validation P_Validation { get; set; }
        public List<P_I_ImageCorrection> ListImage { get; set; }

        public List<T2P._2015.Cross.Model._5.Meetago.Process.P_I_PositionMatching> PositionMatching { get; set; }
        public List<I_Relation> I_Relation { get; set; }

        public P_Invoice_TransferToHistory OldInvoiceHistory { get; set; }

        public P_Invoice_History InvoiceHistory { get; set; }

        public M_Hotel Hotel { get; set; }

        public bool IsUpdateHotel { get; set; }
       

        public P_InvoiceImport()
        {
            I_Data = new I_Data();
            ListI_Tax = new List<I_Tax>();
            ListI_Position = new List<I_Position>();
            ListI_Error = new List<I_Error>();
            ListP_InvoiceError = new List<P_InvoiceError>();
            P_Validation = new P_Validation();
            I_Relation = new List<I_Relation>();
            OldInvoiceHistory = new P_Invoice_TransferToHistory();
            InvoiceHistory = new P_Invoice_History();
            Hotel = new M_Hotel();
            IsUpdateHotel = false;
        }
    }

    public class P_Invoice_History
    {
        public H_I_Data H_I_Data { get; set; }
        public List<H_I_Tax> ListH_I_Tax { get; set; }
        public List<H_I_Position> ListH_I_Pos { get; set; }
        public List<H_P_InvoiceError> ListH_P_InvoiceError { get; set; }
        public List<H_P_Validation> ListH_P_Validation { get; set; }

        public P_Invoice_History()
        {
            H_I_Data = new H_I_Data();
            ListH_I_Tax = new List<H_I_Tax>();
            ListH_I_Pos = new List<H_I_Position>();
            ListH_P_Validation = new List<H_P_Validation>();
            ListH_P_InvoiceError = new List<H_P_InvoiceError>();            
        }
    }

    public class P_Invoice_TransferToHistory
    {
        public I_Data Data { get; set; }
        public List<I_Tax> ListI_Tax { get; set; }
        public List<I_Position> ListI_Pos { get; set; }
        public List<P_InvoiceError> ListP_InvoiceError { get; set; }
        public List<P_Validation> ListP_Validation { get; set; }

        public List<I_Tax> ListI_TaxOld { get; set; }
        public List<I_Position> ListI_PosOld { get; set; }
        public List<P_InvoiceError> ListP_InvoiceErrorOld { get; set; }
        public List<P_Validation> ListP_ValidationOld { get; set; }

        public H_I_Data H_I_Data { get; set; }
        public List<H_I_Tax> ListH_I_Tax { get; set; }
        public List<H_I_Position> ListH_I_Pos { get; set; }
        public List<H_P_InvoiceError> ListH_P_InvoiceError { get; set; }
        public List<H_P_Validation> ListH_P_Validation { get; set; }

        public List<P_I_PositionMatching> ListPositionMatching
        {
            get;
            set;
        }

        public List<P_I_PositionMatching> ListPositionMatchingOld
        {
            get;
            set;
        }

        public List<N_Task> ListDeleteTask { get; set; }

        public P_Invoice_TransferToHistory()
        {
            Data = null;
            ListI_Tax = new List<I_Tax>();
            ListI_Pos = new List<I_Position>();
            ListP_Validation = new List<P_Validation>();
            ListP_InvoiceError = new List<P_InvoiceError>();

            ListI_TaxOld = new List<I_Tax>();
            ListI_PosOld = new List<I_Position>();
            ListP_ValidationOld = new List<P_Validation>();
            ListP_InvoiceErrorOld = new List<P_InvoiceError>();

            H_I_Data = null;
            ListH_I_Tax = new List<H_I_Tax>();
            ListH_I_Pos = new List<H_I_Position>();
            ListH_P_Validation = new List<H_P_Validation>();
            ListH_P_InvoiceError = new List<H_P_InvoiceError>();

            ListDeleteTask = new List<N_Task>();
        }
    }

    public class P_Invoice_SpecialCases_DC0
    {
        public P_Invoice_SpecialCases_Detail DebitInvoice { get; set; }
        public P_Invoice_SpecialCases_Detail CreditInvoice { get; set; }
        public N_BillingEmail Email { get; set; }
        public N_BillingEmailDetail EmailDetail { get; set; }
        public List<N_BookingBillingEmail> ListBookingEmail { get; set; }
        public List<F_Transaction> ListFin_Reactive { get; set; }
        public List<N_Task> ListTask_Delete { get; set; }

        public P_Invoice_SpecialCases_DC0()
        {
            ListBookingEmail = new List<N_BookingBillingEmail>();
            ListFin_Reactive = new List<F_Transaction>();
            ListTask_Delete = new List<N_Task>();
        }
    }

    public class P_Invoice_SpecialCases_Detail
    {
        public List<P_NextBookingStep> ListNextBookingStep_Delete { get; set; }
        public List<P_NextFinancialStep> ListFinStepDelete { get; set; }

        public List<P_FinancialStep> ListFinInsert { get; set; }
        public N_BillingEmailAttachment Attachment { get; set; }
        public I_Image Image { get; set; }
        public I_Data Data { get; set; }
        public List<I_Tax> ListTax { get; set; }
        public List<I_Position> ListPosition { get; set; }
        public List<I_Tax> ListTax_Data { get; set; }
        public List<I_Position> ListPosition_Data { get; set; }
        public List<P_Validation> ListValidation { get; set; }
        public List<I_PageToImage> ListPageToImage { get; set; }
        public List<P_InvoiceStep> ListStep { get; set; }
        public List<P_NextInvoiceStep> ListNextStep { get; set; }
        public List<F_Transaction> ListTransaction { get; set; }
        public List<N_AttachmentPage> ListAttachmentPage { get; set; }
        public List<I_Relation> ListRelation { get; set; }
        public List<N_Task> ListTask { get; set; }
        public List<N_Task> ListDeleteTask { get; set; }
        
        //Apply for SND case
        public N_BillingEmail Email { get; set; }
        public N_BillingEmailDetail EmailDetail { get; set; }
        public List<N_BookingBillingEmail> ListBookingEmail { get; set; }
        public List<P_InvoiceError> ListInvoiceError { get; set; }

        public P_Invoice_SpecialCases_Detail()
        {
            Image = new I_Image();
            Data = new I_Data();
            ListTax = new List<I_Tax>();
            ListPosition = new List<I_Position>();
            ListTax_Data = new List<I_Tax>();
            ListPosition_Data = new List<I_Position>();
            ListValidation = new List<P_Validation>();
            ListPageToImage = new List<I_PageToImage>();
            ListStep = new List<P_InvoiceStep>();
            ListNextStep = new List<P_NextInvoiceStep>();
            ListTransaction = new List<F_Transaction>();
            ListRelation = new List<I_Relation>();
            ListAttachmentPage = new List<N_AttachmentPage>();
            ListTask = new List<N_Task>();
            ListDeleteTask = new List<N_Task>();

            Email = new N_BillingEmail();
            EmailDetail = new N_BillingEmailDetail();
            ListBookingEmail = new List<N_BookingBillingEmail>();
            ListInvoiceError = new List<P_InvoiceError>();

            ListFinStepDelete = new List<P_NextFinancialStep>();
            ListFinInsert = new List<P_FinancialStep>();
            ListNextBookingStep_Delete = new List<P_NextBookingStep>();
        }
    }

    

    public class P_InvoiceCorrectSameErrors
    {
        public P_Invoice_TransferToHistory OldInvoiceHistory { get; set; }

        public P_NextInvoiceStep NextInvoiceStep { get; set; }

        public P_InvoiceCorrectSameErrors()
        {            

            OldInvoiceHistory = new P_Invoice_TransferToHistory();

            NextInvoiceStep = new P_NextInvoiceStep();
        }
    }

    public class P_InvoiceRemoveServiceCodeError : P_InvoiceCorrectSameErrors
    {
        public List<I_Relation> I_Relation { get; set; }        

        public P_InvoiceRemoveServiceCodeError()
        {
            I_Relation = new List<I_Relation>();

            OldInvoiceHistory = new P_Invoice_TransferToHistory();

            NextInvoiceStep = new P_NextInvoiceStep();
        }
    }

    /// <summary>
    /// Apply for special cases: SNL, SND, DCI
    /// </summary>
    public class P_Invoice_SpecialCases
    {
        public List<I_Image> ListSuccessfulImage_Update { get; set; }
        public List<P_InvoiceError> ListIncorrectFin_Delete { get; set; }
        public List<P_NextInvoiceStep> ListNextInvoiceStep_Delete { get; set; }
        public List<P_InvoiceStep> ListInvoiceStep_Insert { get; set; }
        public List<P_Invoice_TransferToHistory> ListHistoryData { get; set; }
        public List<I_Tax> ListOriginalTax { get; set; }
        public List<I_Position> ListOriginalPosition { get; set; }
        public List<I_Relation> ListRelation { get; set; }
        public List<I_PageToImage> ListPageToImage { get; set; }
        public List<F_Transaction> ListFin_Active { get; set; }
        public List<F_Transaction> ListFin_Inactive { get; set; }

        public P_Invoice_SpecialCases()
        {
            ListSuccessfulImage_Update = new List<I_Image>();
            ListIncorrectFin_Delete = new List<P_InvoiceError>();
            ListNextInvoiceStep_Delete = new List<P_NextInvoiceStep>();
            ListInvoiceStep_Insert = new List<P_InvoiceStep>();
            ListHistoryData = new List<P_Invoice_TransferToHistory>();
            ListOriginalTax = new List<I_Tax>();
            ListOriginalPosition = new List<I_Position>();
            ListRelation = new List<I_Relation>();
            ListPageToImage = new List<I_PageToImage>();
            ListFin_Active = new List<F_Transaction>();
            ListFin_Inactive = new List<F_Transaction>();
        }
    }

    public class P_Data_Verification
    {
        public I_Data I_Data {get; set;}
        public bool IsCorrectServiceCode {get; set;}
        public bool IsCorrectNoShow { get; set; }

        public P_Data_Verification()
        {
            I_Data = new I_Data();
            IsCorrectServiceCode = false;
            IsCorrectNoShow = false;
        }
    }
}
