using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_TAccount_Table
    {
        private decimal _totalFinAmount;

        private List<P_TAccount_Table_Total> _listTotal;

        public List<P_TAccount_Table_Total> ListTotal
        {
            get { return _listTotal; }
            set { _listTotal = value; }
        }

        private List<P_TAccount_Row> _listRow;

        public List<P_TAccount_Row> ListRow
        {
            get { return _listRow; }
            set { _listRow = value; }
        }

        private List<P_TAccount> _listAccount;

        public List<P_TAccount> ListAccount
        {
            get { return _listAccount; }
            set { _listAccount = value; }
        }

        private bool useCLO;

        public bool UseCLO
        {
            get { return useCLO; }
            set { useCLO = value; }
        }

        private bool useReactivateFIN;

        public bool UseReactivateFIN
        {
            get { return useReactivateFIN; }
            set { useReactivateFIN = value; }
        }

        public P_TAccount_Table()
        {
            ListRow = new List<P_TAccount_Row>();
            ListTotal = new List<P_TAccount_Table_Total>();
            ListAccount = new List<P_TAccount>();
            UseCLO = false;
            UseReactivateFIN = false;
        }
    }

    public class P_TAccount_Table_Total
    {
        private decimal _totalFinAmount;

        public decimal TotalFinAmount
        {
            get { return _totalFinAmount; }
            set { _totalFinAmount = value; }
        }

        private decimal _totalInvoiceAmount;

        public decimal TotalInvoiceAmount
        {
            get { return _totalInvoiceAmount; }
            set { _totalInvoiceAmount = value; }
        }

        private decimal _different;

        public decimal Different
        {
            get { return _different; }
            set { _different = value; }
        }

        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
    }

   

    public class P_TAccount_Row
    {
        private int _rowIndex;

        public int RowIndex
        {
            get { return _rowIndex; }
            set { _rowIndex = value; }
        }

        private DateTime _matchingDate;

        public DateTime MatchingDate
        {
            get { return _matchingDate; }
            set { _matchingDate = value; }
        }

        private P_TAccount_FIN _tAccountFin;

        public P_TAccount_FIN TAccountFin
        {
            get { return _tAccountFin; }
            set { _tAccountFin = value; }
        }

        private P_TAccount_Invoice _tAccountInvoice;

        public P_TAccount_Invoice TAccountInvoice
        {
            get { return _tAccountInvoice; }
            set { _tAccountInvoice = value; }
        }
    }

    public class P_TAccount
    {
        private List<P_TAccount_FIN> _listFin;

        public List<P_TAccount_FIN> ListFin
        {
            get { return _listFin; }
            set { _listFin = value; }
        }

        private List<P_TAccount_Invoice> _listInvoice;

        public List<P_TAccount_Invoice> ListInvoice
        {
            get { return _listInvoice; }
            set { _listInvoice = value; }
        }

        public P_TAccount()
        {
            ListFin = new List<P_TAccount_FIN>();
            ListInvoice = new List<P_TAccount_Invoice>();
        }
    }

    public class P_TAccount_FIN
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _transactionNo;

        public string TransactionNo
        {
            get { return _transactionNo; }
            set { _transactionNo = value; }
        }

        private DateTime? _transactionDate;

        public DateTime? TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }

        private decimal? _purchasingAmount;

        public decimal? PurchasingAmount
        {
            get { return _purchasingAmount; }
            set { _purchasingAmount = value; }
        }

        private string _purchasingCurrency;

        public string PurchasingCurrency
        {
            get { return _purchasingCurrency; }
            set { _purchasingCurrency = value; }
        }

        private decimal _exchangeRate;

        public decimal ExchangeRate
        {
            get { return _exchangeRate; }
            set { _exchangeRate = value; }
        }

        private decimal _exchangeFee;

        public decimal ExchangeFee
        {
            get { return _exchangeFee; }
            set { _exchangeFee = value; }
        }

        private decimal? _billingAmount;

        public decimal? BillingAmount
        {
            get { return _billingAmount; }
            set { _billingAmount = value; }
        }

        private string _billingCurrency;

        public string BillingCurrency
        {
            get { return _billingCurrency; }
            set { _billingCurrency = value; }
        }

        private int _processStatus;

        public int ProcessStatus
        {
            get { return _processStatus; }
            set { _processStatus = value; }
        }

        private string _fileType;

        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
    }

    public class P_TAccount_Invoice
    {
        private int _isSpecialCase;

        public int IsSpecialCase
        {
            get { return _isSpecialCase; }
            set { _isSpecialCase = value; }
        }

        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _imageID;

        public long ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }

        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
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

        private decimal? _purchasingAmount;

        public decimal? PurchasingAmount
        {
            get { return _purchasingAmount; }
            set { _purchasingAmount = value; }
        }

        private string _purchasingCurrency;

        public string PurchasingCurrency
        {
            get { return _purchasingCurrency; }
            set { _purchasingCurrency = value; }
        }

        private decimal _exchangeRate;

        public decimal ExchangeRate
        {
            get { return _exchangeRate; }
            set { _exchangeRate = value; }
        }


        private decimal? _billingAmount;

        public decimal? BillingAmount
        {
            get { return _billingAmount; }
            set { _billingAmount = value; }
        }

        private string _billingCurrency;

        public string BillingCurrency
        {
            get { return _billingCurrency; }
            set { _billingCurrency = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _pdfFileName;

        public string PdfFileName
        {
            get { return _pdfFileName; }
            set { _pdfFileName = value; }
        }

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

        private string _imageStatus;

        public string ImageStatus
        {
            get { return _imageStatus; }
            set { _imageStatus = value; }
        }

        private DateTime _matchingDate;

        public DateTime MatchingDate
        {
            get { return _matchingDate; }
            set { _matchingDate = value; }
        }

        private long _replaceID;

        public long ReplaceID
        {
            get { return _replaceID; }
            set { _replaceID = value; }
        }

        private DateTime? _deliveryDate;

        public DateTime? DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        private string _checkingStatus;

        public string CheckingStatus
        {
            get { return _checkingStatus; }
            set { _checkingStatus = value; }
        }

        public List<dynamic> ListReplacedBy { get; set; }

        public List<dynamic> ListCombined { get; set; }

        public List<dynamic> ListSplited { get; set; }
        

        public P_TAccount_Invoice()
        {
            IsActive = true;
            ListReplacedBy = new List<dynamic>();
            ListCombined = new List<dynamic>();
            ListSplited = new List<dynamic>();
        }
    }

    public class P_TAccount_Invoice_Image
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _pdfFileName;

        public string PdfFileName
        {
            get { return _pdfFileName; }
            set { _pdfFileName = value; }
        }

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
    }

}
