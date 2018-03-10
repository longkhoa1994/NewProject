using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_DeliveryCSV
    {
        public List<InvoiceDataCSV> ListInvoiceDataCSV { get;set; }

       

    }

    public enum P_DeliveryCSVStoreProcedure
    {
        p_I_Data_GetListForDeliveryCSV,
        p_B_Traveller_GetListForDeliveryCSV
    }
    public class InvoiceDataCSV
    {
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
        private string companyCountryName;

        public string CompanyCountryName
        {
            get { return companyCountryName; }
            set { companyCountryName = value; }
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
        public TravelerCSV TrvelerCSV { get; set; }

        public List<I_Position> ListPosition { get; set; }
        public List<I_Tax> ListTax { get; set; }

        public List<P_NextInvoiceStep> ListInvoiceStep { get; set; }
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
