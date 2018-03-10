using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.History;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model
{
    public class P_InvoiceCorrectionDetail
    {
        public bool IsDuplicatedInvoiceNumber { get; set; }        
        public B_Booking DuplicatedBookingNo { get; set; }
        public bool IsSameUser { get; set; }
        

        public bool IsLock { get; set; }
        public long UserID { get; set; }
        public int StepStatus { get; set; }
        public string TypeCorrect { get; set; }
        public I_Image ReplaceImage { get; set; }
        public bool IsDisableWaitingFIN { get; set; }
        public string Action { get; set; }

        public bool IsShowSaveButton { get; set; }
        public bool IsHasNoTax { get; set; }
        public string ErrorType { get; set; }

        public bool IsSuccessful { get; set; }
        public bool IsStillHasVTI { get; set; }

        public string Message { get; set; }
        public int NotAllowedServiceCode { get; set; }
        public int NotAllowedNOS { get; set; }
        public bool IsCopiedError { get; set; }
        public string AllowedServiceCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public P_I_Data_Correction InvoiceData { get; set; }

        public List<P_I_ImageCorrection> ListImage { get; set; }
        public List<P_M_InvoiceErrorCode_Correction> ListInvoiceError { get; set; }

        public List<F_Transaction_Correction> ListTransaction_Correction { get; set; }
        public List<P_TotalFINAmount> ListSumFINAmount { get; set; }

        public List<P_I_Position_Correction> ListI_Position { get; set; }

        public List<P_I_Tax_Correction> ListI_Tax { get; set; }

        public bool IsReplace { get; set; }

        public bool IsUseOldData { get; set; }
        public bool IsVerifyInvoiceCompanySetup { get; set; }

        public bool IsSendRejeciton { get; set; }
        public bool IsCorrect14 { get; set; }
        public bool IsShowCopy { get; set; }
        public bool IsShowCompanyError { get; set; }
        public bool IsShowHotelError { get; set; }
        public bool IsShowCustomerVATError { get; set; }
        public bool IsHasVATError { get; set; }
        public bool IsErrorVATNumberCorrected { get; set; }
        public bool isSave { get; set; }

        public bool IsShowParking { get; set; }

        public bool IsSkipFinAtBeginning { get; set; }

        public bool IsModifiedData { get; set; }

        public bool isMatchFinAtBeginning { get; set; }

        

        private P_InvoiceCorrect_Result _result;

        public P_InvoiceCorrect_Result Result
        {
            get { return _result; }
            set { _result = value; }
        }

        private List<N_Rejection> _listRejection;

        public List<N_Rejection> ListRejection
        {
            get { return _listRejection; }
            set { _listRejection = value; }
        }

        private List<M_ServiceCode> _listServiceCode;

        public List<M_ServiceCode> ListServiceCode
        {
            get { return _listServiceCode; }
            set { _listServiceCode = value; }
        }

        private List<M_ServiceCodeTax> _listServiceCodeTax;

        public List<M_ServiceCodeTax> ListServiceCodeTax
        {
            get { return _listServiceCodeTax; }
            set { _listServiceCodeTax = value; }
        }

        private List<M_Currency> _listCurrency;

        public List<M_Currency> ListCurrency
        {
            get { return _listCurrency; }
            set { _listCurrency = value; }
        }

        private P_M_InvoiceErrorCode_Correction _copy_ErrorCode;

        public P_M_InvoiceErrorCode_Correction Copy_ErrorCode
        {
            get { return _copy_ErrorCode; }
            set { _copy_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _company_ErrorCode;

        public P_M_InvoiceErrorCode_Correction Company_ErrorCode
        {
            get { return _company_ErrorCode; }
            set { _company_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _hotel_ErrorCode;

        public P_M_InvoiceErrorCode_Correction Hotel_ErrorCode
        {
            get { return _hotel_ErrorCode; }
            set { _hotel_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _customerVAT_ErrorCode;

        public P_M_InvoiceErrorCode_Correction CustomerVAT_ErrorCode
        {
            get { return _customerVAT_ErrorCode; }
            set { _customerVAT_ErrorCode = value; }
        }

        private long finID;

        public long FinID
        {
            get { return finID; }
            set { finID = value; }
        }

        public P_InvoiceCorrectionDetail()
        {
            ListInvoiceError = new List<P_M_InvoiceErrorCode_Correction>();
            ListTransaction_Correction = new List<F_Transaction_Correction>();
            Result = new P_InvoiceCorrect_Result();
            ListServiceCodeTax = new List<M_ServiceCodeTax>();
            ListSumFINAmount = new List<P_TotalFINAmount>();
            InvoiceData = new P_I_Data_Correction();
            ListI_Tax = new List<P_I_Tax_Correction>();
            ListI_Position = new List<P_I_Position_Correction>();
        }


    }

    public class P_TotalFINAmount
    {
        private decimal _totalAmount;

        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
    }
    public enum P_InvoiceCorrectionDetailStoreProcedure
    {
        p_M_InvoiceErrorCode_GetByDataID,
        p_InvoiceCorrection_GetData_ByDataID,
        p_F_Transaction_GetBy_I_DataID,
        p_F_Transaction_GetBy_I_DataID_ForCorrection,
        p_ErrorText_GetByDataID,
        p_I_Image_GetList_ForCorrection,
        p_InvoiceCorrection_GetData_ByImageID,
        p_M_InvoiceErrorCode_GetByDataIDForCorrection,
        p_M_InvoiceErrorCodeTranslation_GetByID
    }

    public class P_I_ImageCorrection
    {
        public long I_ImageID { get; set; }
        public string IISPath { get; set; }
        public string FilePath { get; set; }
        public string ImageFileName { get; set; }

        public string ImageStatus { get; set; }
        public long Rotate { get; set; }
    }

    public class P_I_Data_Correction : I_Data
    {
        //public long I_ImageID { get; set; }

        public long M_ProcessID { get; set; }
        public string IISPath { get; set; }
        public string FilePath { get; set; }
        //public string ImageFileName { get; set; }
        public string ImageStatus { get; set; }
        public bool IsCopied { get; set; }
        public long B_AccessID { get; set; }
        public long B_BookingID { get; set; }

        public string PaymentMethod { get; set; }
        public string BookingNo { get; set; }
        // Company Data
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyZipCode { get; set; }
        public string CompanyCityName { get; set; }
        public string CompanyCountryName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyFlag { get; set; }
        //
        public long M_HotelID { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelCountryCode { get; set; }
        public string HotelZipCode { get; set; }
        public string HotelCityName { get; set; }
        public string HotelCountryName { get; set; }
        public long M_HotelPlatformID { get; set; }
        public string HotelFlag { get; set; }
        public string VATCode { get; set; }
        public string HotelVAT_MasterData { get; set; }

        public string Comment { get; set; }
        public string CommentParking { get; set; }
        //
        public long InvoiceReplace { get; set; }

        public long IsSelfCreated { get; set; }

        public bool IsLockOtherInvoice { get; set; }

        public bool IsSameInvoice { get; set; }
    }

    public class P_I_Position_Correction : I_Position
    {
        private bool _isAutoCalculate;

        public bool IsAutoCalculate
        {
            get { return _isAutoCalculate; }
            set { _isAutoCalculate = value; }
        }

        private bool _isUpdatedServiceCode;

        public bool IsUpdatedServiceCode
        {
            get { return _isUpdatedServiceCode; }
            set { _isUpdatedServiceCode = value; }
        }

        public P_I_Position_Correction()
        {
            IsAutoCalculate = true;
            IsUpdatedServiceCode = false;
        }
    }

    public class P_I_Tax_Correction : I_Tax
    {
        private bool _isAutoCalculate;

        public bool IsAutoCalculate
        {
            get { return _isAutoCalculate; }
            set { _isAutoCalculate = value; }
        }

        public P_I_Tax_Correction()
        {
            IsAutoCalculate = true;
        }
    }

    public class P_M_InvoiceErrorCode_Correction : M_InvoiceErrorCode
    {

        public bool IsErrorNew { get; set; }
        public long P_InvoiceErrorCodeID { get; set; }

        public bool IsCorrected { get; set; }
        

    }

    public class F_Transaction_Correction : F_Transaction
    {
        public long P_ValidationID { get; set; }

        public int ValidationResult { get; set; }

        public long I_DataID { get; set; }

        public bool IsMatched { get; set; }

        public bool IsDSC { get; set; }

        public bool IsShowExchangeInfo { get; set; }
        public decimal? CalculatedExchange { get; set; }
    }

    public class P_InvoiceDataSet_Hitory
    {

        private P_InvoiceDataSet _oldInvoiceDataSet;

        public P_InvoiceDataSet OldInvoiceDataSet
        {
            get { return _oldInvoiceDataSet; }
            set { _oldInvoiceDataSet = value; }
        }

        private P_InvoiceDataSet _invoiceDataSet;

        public P_InvoiceDataSet InvoiceDataSet
        {
            get { return _invoiceDataSet; }
            set { _invoiceDataSet = value; }
        }

        private P_HistoryInvoiceDataSet _historyDataSet;

        public P_HistoryInvoiceDataSet HistoryDataSet
        {
            get { return _historyDataSet; }
            set { _historyDataSet = value; }
        }

        public P_InvoiceDataSet_Hitory()
        {
            OldInvoiceDataSet = new P_InvoiceDataSet();
            InvoiceDataSet = new P_InvoiceDataSet();
            HistoryDataSet = new P_HistoryInvoiceDataSet();
        }
    }

    public class P_InvoiceDataSet
    {
        private I_Data _invoiceData;

        public I_Data InvoiceData
        {
            get { return _invoiceData; }
            set { _invoiceData = value; }
        }

        private List<I_Position> _listPosition;

        public List<I_Position> ListPosition
        {
            get { return _listPosition; }
            set { _listPosition = value; }
        }

        private List<I_Tax> _listTax;

        public List<I_Tax> ListTax
        {
            get { return _listTax; }
            set { _listTax = value; }
        }

        private List<P_InvoiceError> _listError;

        public List<P_InvoiceError> ListError
        {
            get { return _listError; }
            set { _listError = value; }
        }

        private List<P_Validation> _listValidation;

        public List<P_Validation> ListValidation
        {
            get { return _listValidation; }
            set { _listValidation = value; }
        }



    }

    public class P_HistoryInvoiceDataSet
    {
        private H_I_Data _invoiceData;

        public H_I_Data InvoiceData
        {
            get { return _invoiceData; }
            set { _invoiceData = value; }
        }

        private List<H_I_Position> _listPosition;

        public List<H_I_Position> ListPosition
        {
            get { return _listPosition; }
            set { _listPosition = value; }
        }

        private List<H_I_Tax> _listTax;

        public List<H_I_Tax> ListTax
        {
            get { return _listTax; }
            set { _listTax = value; }
        }

        private List<H_P_InvoiceError> _listError;

        public List<H_P_InvoiceError> ListError
        {
            get { return _listError; }
            set { _listError = value; }
        }

        private List<H_P_Validation> _listValidation;

        public List<H_P_Validation> ListValidation
        {
            get { return _listValidation; }
            set { _listValidation = value; }
        }
    }

    public class P_InvoiceCorrect_Result
    {
        private bool _isErrorTyping;

        public bool IsErrorTyping
        {
            get { return _isErrorTyping; }
            set { _isErrorTyping = value; }
        }

        private bool _isInvalidData;

        public bool IsInvalidData
        {
            get { return _isInvalidData; }
            set { _isInvalidData = value; }
        }

        private bool _isMatchFin;

        public bool IsMatchFin
        {
            get { return _isMatchFin; }
            set { _isMatchFin = value; }
        }

    }

    public class P_Invoice_Data_DSC
    {
        private decimal exchangeRate;

        public decimal ExchangeRate
        {
            get { return exchangeRate; }
            set { exchangeRate = value; }
        }
        private I_Data data;

        public I_Data Data
        {
            get { return data; }
            set { data = value; }
        }
        private List<I_Position> listPosition;

        public List<I_Position> ListPosition
        {
            get { return listPosition; }
            set { listPosition = value; }
        }

        private List<I_Tax> listTax;

        public List<I_Tax> ListTax
        {
            get { return listTax; }
            set { listTax = value; }
        }

        public P_Invoice_Data_DSC()
        {
            listPosition = new List<I_Position>();
            listTax = new List<I_Tax>();
        }
    }

    public enum TypeCorrection
    {
        InvoiceError,
        WaitingForFIN,
        Rejection,
        Parking,
        InvalidData,
    }
}
