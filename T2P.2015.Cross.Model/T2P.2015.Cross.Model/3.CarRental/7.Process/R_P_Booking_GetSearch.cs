using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{

    public class R_P_ReservationSearch
    {

        public List<R_P_BookingCompany> ListBookingCompany { get; set; }

        public List<R_P_Reservation_GetSearch> ListReservation { get; set; }

        public long TotalRecords { get; set; }

        public R_P_ReservationSearch()
        {
            ListBookingCompany = new List<R_P_BookingCompany>();
            ListReservation = new List<R_P_Reservation_GetSearch>();
            TotalRecords = 0;
        }
    }


    public class R_P_BookingCompany
    {
        public long ID { get; set; }

        public string CompanyName { get; set; }

        public long ParentID { get; set; }

        public string ParentName { get; set; }

        public List<R_P_Reservation_GetSearch> ListReservation { get; set; }

        public R_P_BookingCompany()
        {
            ID = 0;
            CompanyName = string.Empty;
            ListReservation = new List<R_P_Reservation_GetSearch>();
        }
    }


    public class R_P_Reservation_GetSearch
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private long r_B_AccessID;

        public long R_B_AccessID
        {
            get { return r_B_AccessID; }
            set { r_B_AccessID = value; }
        }

        private long parentID;

        public long ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        private string parentName;

        public string ParentName
        {
            get { return parentName; }
            set { parentName = value; }
        }

        private long m_CompanyID;

        public long M_CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private long _m_CarRentalProviderID;

        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        private string provider;

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string traveler;

        public string Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }

        private DateTime receivedDate;

        public DateTime ReceivedDate
        {
            get { return receivedDate; }
            set { receivedDate = value; }
        }

        private DateTime bookedDate;

        public DateTime BookedDate
        {
            get { return bookedDate; }
            set { bookedDate = value; }
        }

        private DateTime pickupDate;

        public DateTime PickupDate
        {
            get { return pickupDate; }
            set { pickupDate = value; }
        }

        private string pickupTime;

        public string PickupTime
        {
            get { return pickupTime; }
            set { pickupTime = value; }
        }

        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        private string returnTime;

        public string ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
        }

        private string pickupCity;

        public string PickupCity
        {
            get { return pickupCity; }
            set { pickupCity = value; }
        }

        private string pickupCountry;

        public string PickupCountry
        {
            get { return pickupCountry; }
            set { pickupCountry = value; }
        }

        private string pickupCountryName;

        public string PickupCountryName
        {
            get { return pickupCountryName; }
            set { pickupCountryName = value; }
        }

        private string returnCity;

        public string ReturnCity
        {
            get { return returnCity; }
            set { returnCity = value; }
        }

        private string returnCountry;

        public string ReturnCountry
        {
            get { return returnCountry; }
            set { returnCountry = value; }
        }

        private string returnCountryName;

        public string ReturnCountryName
        {
            get { return returnCountryName; }
            set { returnCountryName = value; }
        }

        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }


        private string imageStatus;

        public string ImageStatus
        {
            get { return imageStatus; }
            set { imageStatus = value; }
        }

        private long _r_I_ImageID;

        public long R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        private int numberOfInv;

        public int NumberOfInv
        {
            get { return numberOfInv; }
            set { numberOfInv = value; }
        }

        private int numberOfFIN;

        public int NumberOfFIN
        {
            get { return numberOfFIN; }
            set { numberOfFIN = value; }
        }

        private int numberOfRej;

        public int NumberOfRej
        {
            get { return numberOfRej; }
            set { numberOfRej = value; }
        }

        private int numberOfMail;

        public int NumberOfMail
        {
            get { return numberOfMail; }
            set { numberOfMail = value; }
        }

        private int numberOfTask;

        public int NumberOfTask
        {
            get { return numberOfTask; }
            set { numberOfTask = value; }
        }

        private int numberOfEscalation;

        public int NumberOfEscalation
        {
            get { return numberOfEscalation; }
            set { numberOfEscalation = value; }
        }

    }

    public class R_P_BookingSearch : V_Pagination
    {
        public string ResNo { get; set; }
        public string Provider { get; set; }
        public DateTime? ReceivedFrom { get; set; }
        public DateTime? ReceivedTo { get; set; }
        public string Traveler { get; set; }
        public long CompanyID { get; set; }
        public string CompanyName { get; set; }
        public long ParentCompanyID { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerNo { get; set; }
        public string RentalNo { get; set; }
        public List<long> ListCompanyID { get; set; }
        public string PickupCity { get; set; }
        public string PickupCountry { get; set; }
        public string ReturnCity { get; set; }
        public string ReturnCountry { get; set; }
        public DateTime? PickupFrom { get; set; }
        public DateTime? PickupTo { get; set; }
        public DateTime? ReturnFrom { get; set; }
        public DateTime? ReturnTo { get; set; }
        public List<string> Status { get; set; }

        public bool isGetStatus { get; set; }

        public List<long> ListR_B_AccessID { get; set; }

        public R_P_BookingSearch()
        {
            ResNo = string.Empty;
            Provider = string.Empty;
            Traveler = string.Empty;
            CompanyID = 0;
            CompanyName = string.Empty;
            InvoiceNo = string.Empty;
            CustomerNo = string.Empty;
            RentalNo = string.Empty;
            ListCompanyID = new List<long>();
            Status = new List<string>();
            PickupCity = string.Empty;
            PickupCountry = string.Empty;
            ReturnCity = string.Empty;
            ReturnCountry = string.Empty;
            ListR_B_AccessID = new List<long>();
        }

    }

    public class R_P_ImportFileBooking : R_B_Import
    {
        public List<A_UserProfile> ListUser { get; set; } 

        public string ImportBy { get; set; }

        public long TotalRecords { get; set; }


    }
    public class R_P_ImportBooking
    {
        public string FileName { get; set; }

        public R_B_Import FileImport { get; set; }


        public List<P_RImportBooking> ListBooking { get; set; }

        public R_N_BillingEmail R_N_BillingEmail { get; set; }

        public R_N_BillingEmailDetail R_N_BillingEmailDetail { get; set; }

        public R_N_BillingEmailAttachment R_N_BillingEmailAttachment { get; set; }
        public R_N_BillingEmailAddition R_N_BillingEmailAddition { get; set; }

        public string MessageError { get; set; }

        public R_P_ImportBooking()
        {
            ListBooking = new List<P_RImportBooking>();
        }


    }

    public class R_P_Booking : R_B_Booking
    {
        public string FileName { get; set; }

        public string ReservationStatus { get; set; }

        public long TotalRecords { get; set; }

        public int TotalBooking { get; set; }

        public int TotalSuccess { get; set; }

        public int TotalError { get; set; }

    }
   
}
