using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Utility.Conversion;

namespace T2P._2015.Cross.Model.Process
{
    public class P_DeliveryCSV
    {
        public List<InvoiceDataCSV> ListInvoiceDataCSV { get; set; }



    }

    public enum P_DeliveryCSVStoreProcedure
    {
        p_I_Data_GetListForDeliveryCSV,
        p_B_Traveller_GetListForDeliveryCSV
    }
    public class InvoiceDataCSV : P_NextInvoiceStep
    {
        private long dataID;

        public long DataID
        {
            get { return dataID; }
            set { dataID = value; }
        }

        private long imageID;

        public long ImageID
        {
            get { return imageID; }
            set { imageID = value; }
        }


        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private long bookingID;

        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private string invoiceNo;

        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }
        private DateTime invoiceDate;

        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
        private DateTime checkInDate;

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        private DateTime checkOutDate;

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        private long projectNumberID;

        public long ProjectNumberID
        {
            get { return projectNumberID; }
            set { projectNumberID = value; }
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }


        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private string hotelAddress;

        public string HotelAddress
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }
        private string hotelZipCode;

        public string HotelZipCode
        {
            get { return hotelZipCode; }
            set { hotelZipCode = value; }
        }
        private string hotelCityName;

        public string HotelCityName
        {
            get { return hotelCityName; }
            set { hotelCityName = value; }
        }
        private string hotelCountryCode;

        public string HotelCountryCode
        {
            get { return hotelCountryCode; }
            set { hotelCountryCode = value; }
        }


        private string hotelVATNumber;

        public string HotelVATNumber
        {
            get { return hotelVATNumber; }
            set { hotelVATNumber = value; }
        }
        private long companyID;

        public long CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string companyAddress;

        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }
        private string companyZipCode;

        public string CompanyZipCode
        {
            get { return companyZipCode; }
            set { companyZipCode = value; }
        }
        private string companyCityName;

        public string CompanyCityName
        {
            get { return companyCityName; }
            set { companyCityName = value; }
        }
        private string companyCountryCode;

        public string CompanyCountryCode
        {
            get { return companyCountryCode; }
            set { companyCountryCode = value; }
        }


        private string companyTaxCode;

        public string CompanyTaxCode
        {
            get { return companyTaxCode; }
            set { companyTaxCode = value; }
        }

        private string customerNo;

        public string CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }
        private decimal netAmount;

        public decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }
        private decimal taxAmount;

        public decimal TaxAmount
        {
            get { return taxAmount; }
            set { taxAmount = value; }
        }
        private decimal grossAmount;

        public decimal GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }
        private string currencyCode;

        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }

        private string pDFFileName;

        public string PDFFileName
        {
            get { return pDFFileName; }
            set { pDFFileName = value; }
        }




        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private long rowNum;

        public long RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }
        private long m_ProcessID;

        public long M_ProcessID
        {
            get { return m_ProcessID; }
            set { m_ProcessID = value; }
        }

        private long m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private long m_CompanyProcessID;

        public long M_CompanyProcessID
        {
            get { return m_CompanyProcessID; }
            set { m_CompanyProcessID = value; }
        }

        public string TravelerName
        {
            get { return TrvelerCSV.FirstName + "|" + TrvelerCSV.LastName; }

        }

        public string InvoiceDateStr
        {
            get { return InvoiceDate.ToString("dd.MM.yyyy"); }

        }
        public string CheckIn
        {
            get { return CheckInDate.ToString("dd.MM.yyyy"); }

        }
        public string CheckOut
        {
            get { return CheckOutDate.ToString("dd.MM.yyyy"); }

        }
        public TravelerCSV TrvelerCSV { get; set; }


        public string NetAmountStr
        {
            get
            {
                return Conversion.DecimalToString(NetAmount, 2);
            }
        }

        public string TaxAmountStr
        {
            get
            {
                return Conversion.DecimalToString(TaxAmount, 2);
            }
        }
        public string GrossAmountStr
        {
            get
            {
                return Conversion.DecimalToString(GrossAmount, 2);
            }
        }

        private long m_LanguageID;

        public long M_LanguageID
        {
            get { return m_LanguageID; }
            set { m_LanguageID = value; }
        }

        private string typeEmail;

        public string TypeEmail
        {
            get { return typeEmail; }
            set { typeEmail = value; }
        }

        private string ariPlusLogo;

        public string AriPlusLogo
        {
            get { return ariPlusLogo; }
            set { ariPlusLogo = value; }
        }

        private string t2PLogo;

        public string T2PLogo
        {
            get { return t2PLogo; }
            set { t2PLogo = value; }
        }

        private string hotelLogo;

        public string HotelLogo
        {
            get { return hotelLogo; }
            set { hotelLogo = value; }
        }
        private string companyLogo;

        public string CompanyLogo
        {
            get { return companyLogo; }
            set { companyLogo = value; }
        }

        private string mailServer;

        public string MailServer
        {
            get { return mailServer; }
            set { mailServer = value; }
        }

        private string mailUsername;

        public string MailUsername
        {
            get { return mailUsername; }
            set { mailUsername = value; }
        }
        private string mailPassword;

        public string MailPassword
        {
            get { return mailPassword; }
            set { mailPassword = value; }
        }

        private string iISPathCompany;

        public string IISPathCompany
        {
            get { return iISPathCompany; }
            set { iISPathCompany = value; }
        }

        private string iPLocalPathCompany;

        public string IPLocalPathCompany
        {
            get { return iPLocalPathCompany; }
            set { iPLocalPathCompany = value; }
        }
        private string faxNumber;

        public string FaxNumber
        {
            get { return faxNumber; }
            set { faxNumber = value; }
        }


        public List<I_PositionCSV> ListPosition { get; set; }
        public List<I_Tax> ListTax { get; set; }

        public List<P_NextInvoiceStep> ListInvoiceStep { get; set; }
    }

    public class I_PositionCSV : I_Position
    {
        public string NetAmountStr
        {
            get
            {
                return Conversion.DecimalToString(AmountBeforeTax, 2);
            }
        }
        public string TaxRateStr
        {
            get
            {
                return Conversion.DecimalToString(TaxRate, 2);
            }
        }
        public string TaxAmountStr
        {
            get
            {
                return Conversion.DecimalToString(TaxAmount, 2);
            }
        }
        public string GrossAmountStr
        {
            get
            {
                return Conversion.DecimalToString(AmountAfterTax, 2);
            }
        }
    }

    public enum CSVExport
    {


        BookingNo,
        InvoiceNo,
        InvoiceDate,
        InvoiceDateStr,
        CheckIn,
        CheckInDate,
        CheckOut,
        CheckOutDate,
        TravelerName,
        HotelName,
        HotelAddress,
        HotelZipCode,
        HotelCityName,
        HotelCountryCode,
        HotelVATNumber,
        CompanyName,
        CompanyAddress,
        CompanyZipCode,
        CompanyCityName,
        CompanyCountryCode,
        CompanyTaxCode,
        CustomerNo,
        NetAmount,
        TaxAmount,
        GrossAmount,
        TaxRate,

        NetAmountStr,
        TaxAmountStr,
        TaxRateStr,
        GrossAmountStr,
        OriginalService,
        ExtendService,
        CurrencyCode,
        ServiceCode,
        ServiceDate,
        ItemNo
    }


    public class TravelerCSV
    {
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
