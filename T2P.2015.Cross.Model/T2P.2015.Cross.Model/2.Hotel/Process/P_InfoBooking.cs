using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_InfoBooking
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string reservationNumber;

        public string ReservationNumber
        {
            get { return reservationNumber; }
            set { reservationNumber = value; }
        }

        private DateTime checkIn;
        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        private DateTime checkOut;
        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private string traveller;

        public string Traveller
        {
            get { return traveller; }
            set { traveller = value; }
        }

        private DateTime reservationDate;
        public DateTime ReservationDate
        {
            get { return reservationDate; }
            set { reservationDate = value; }
        }

        private string bookerFirstName;
        public string BookerFirstName
        {
            get { return bookerFirstName; }
            set { bookerFirstName = value; }
        }

        private string bookerLastName;
        public string BookerLastName
        {
            get { return bookerLastName; }
            set { bookerLastName = value; }
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

        private string companyCity;
        public string CompanyCity
        {
            get { return companyCity; }
            set { companyCity = value; }
        }

        private string companyCountryCode;
        public string CompanyCountryCode
        {
            get { return companyCountryCode; }
            set { companyCountryCode = value; }
        }

        private string companyCountryName;
        public string CompanyCountryName
        {
            get { return companyCountryName; }
            set { companyCountryName = value; }
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

        private string hotelCity;
        public string HotelCity
        {
            get { return hotelCity; }
            set { hotelCity = value; }
        }

        private string hotelCountryCode;
        public string HotelCountryCode
        {
            get { return hotelCountryCode; }
            set { hotelCountryCode = value; }
        }

        private string hotelCountryName;
        public string HotelCountryName
        {
            get { return hotelCountryName; }
            set { hotelCountryName = value; }
        }

        private List<P_InfoTraveller> listTraveller;
        public List<P_InfoTraveller> ListTraveller
        {
            get { return listTraveller; }
            set { listTraveller = value; }
        }

        private List<P_InfoInvoice> listInvoice;
        public List<P_InfoInvoice> ListInvoice
        {
            get { return listInvoice; }
            set { listInvoice = value; }
        }


        public P_InfoBooking()
        {
            listTraveller = new List<P_InfoTraveller>();
            listInvoice = new List<P_InfoInvoice>();
        }
    }

    public class P_InfoTraveller
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
    }

    public partial class P_InfoInvoice
    {
        private long index;
        public long Index
        {
            get { return index; }
            set { index = value; }
        }

        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        private long replaceIndex;
        public long ReplaceIndex
        {
            get { return replaceIndex; }
            set { replaceIndex = value; }
        }

        private P_InfoInvoiceStatus invoiceStatus;
        public P_InfoInvoiceStatus InvoiceStatus
        {
            get { return invoiceStatus; }
            set { invoiceStatus = value; }
        }

        private DateTime matchingTime;
        public DateTime MatchingTime
        {
            get { return matchingTime; }
            set { matchingTime = value; }
        }

        private bool isCopied;
        public bool IsCopied
        {
            get { return isCopied; }
            set { isCopied = value; }
        }

        private string errorText;

        public string ErrorText
        {
            get { return errorText; }
            set { errorText = value; }
        }

        private List<P_InfoInvoiceErrorCode> listInvoiceErrorCode;
        public List<P_InfoInvoiceErrorCode> ListInvoiceErrorCode
        {
            get { return listInvoiceErrorCode; }
            set { listInvoiceErrorCode = value; }
        }

        public P_InfoInvoice()
        {
            ListInvoiceErrorCode = new List<P_InfoInvoiceErrorCode>();
        }
    }

    public partial class P_InfoInvoiceErrorCode
    {
        private string errorText;
        public string ErrorText
        {
            get { return errorText; }
            set { errorText = value; }
        }
    }

    public class P_InfoInvoiceImage
    {
        private long invoiceImageID;
        public long InvoiceImageID
        {
            get { return invoiceImageID; }
            set { invoiceImageID = value; }
        }

        private string uRL;
        public string URL
        {
            get { return uRL; }
            set { uRL = value; }
        }

        private long replacedID;

        public long ReplacedID
        {
            get { return replacedID; }
            set { replacedID = value; }
        }

    }

    public enum P_InfoInvoiceStatus
    {
        NotAvailable,
        //Replaced = 10,
        Unuse,
        CopyInvoice,
        Processing = 20,
        WaitingForFin = 30,
        Error = 40,
        //VTIError = 60,
        InvalidData,
        Successful = 70,
        EarlyInvoice,
    }

    public enum P_InfoBookingProcedure
    {
        p_P_InfoInvoice_GetList_ByBookingID,
        p_P_InfoInvoice_GetList_ByDocumentNo,
        p_P_InfoBooking_GetList_ByDocumentNo,
        p_P_InfoBooking_GetList_ByReservationNo,
        p_P_InfoInvoiceImage_GetPath_ByDocumentNo,
    }
}
