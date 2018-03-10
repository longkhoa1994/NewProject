using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{

    public class P_Activity
    {
        private P_Booking_Activity_Info bookingInfo;

        public P_Booking_Activity_Info BookingInfo
        {
            get { return bookingInfo; }
            set { bookingInfo = value; }
        }

        private List<P_Activity_Detail> listActivity;

        public List<P_Activity_Detail> ListActivity
        {
            get { return listActivity; }
            set { listActivity = value; }
        }

        public P_Activity()
        {
            ListActivity = new List<P_Activity_Detail>();
        }
    }

    public class P_Activity_Detail
    {
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }



        private List<P_Activity_Info> listBookingActivity;

        public List<P_Activity_Info> ListBookingActivity
        {
            get { return listBookingActivity; }
            set { listBookingActivity = value; }
        }

        
        public P_Activity_Detail()
        {
            ListBookingActivity = new List<P_Activity_Info>();
        }
    }

    public class P_Activity_Info
    {
        private string stepName;

        public string StepName
        {
            get { return stepName; }
            set { stepName = value; }
        }
        private DateTime processedDate;

        public DateTime ProcessedDate
        {
            get { return processedDate; }
            set { processedDate = value; }
        }
        private string processBy;

        public string ProcessBy
        {
            get { return processBy; }
            set { processBy = value; }
        }
        private string stepStatus;

        public string StepStatus
        {
            get { return stepStatus; }
            set { stepStatus = value; }
        }
        private long objectID;

        public long ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }

        private string objectType;

        public string ObjectType
        {
            get { return objectType; }
            set { objectType = value; }
        }

        private int objectNo;

        public int ObjectNo
        {
            get { return objectNo; }
            set { objectNo = value; }
        }


        private string step;

        public string Step
        {
            get { return step; }
            set { step = value; }
        }
        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }
        private string side;

        public string Side
        {
            get { return side; }
            set { side = value; }
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
        private string hotelPhone;

        public string HotelPhone
        {
            get { return hotelPhone; }
            set { hotelPhone = value; }
        }
        private string hotelEmail;

        public string HotelEmail
        {
            get { return hotelEmail; }
            set { hotelEmail = value; }
        }

        private string invoiceNo;

        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
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
        private string booker;

        public string Booker
        {
            get { return booker; }
            set { booker = value; }
        }

        private string travelerInfo;

        public string TravelerInfo
        {
            get { return travelerInfo; }
            set { travelerInfo = value; }
        }

        private int showOnTimeline;

        public int ShowOnTimeline
        {
            get { return showOnTimeline; }
            set { showOnTimeline = value; }
        }

    }

    public class P_Booking_Activity_Info
    {
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


        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
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
        private string companyCityname;

        public string CompanyCityname
        {
            get { return companyCityname; }
            set { companyCityname = value; }
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

        private string hotelCityName;

        public string HotelCityName
        {
            get { return hotelCityName; }
            set { hotelCityName = value; }
        }

        private string hotelCountryName;

        public string HotelCountryName
        {
            get { return hotelCountryName; }
            set { hotelCountryName = value; }
        }


        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string hotelEmail;

        public string HotelEmail
        {
            get { return hotelEmail; }
            set { hotelEmail = value; }
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

        private List<P_TravelerActivity> listTraveler;

        public List<P_TravelerActivity> ListTraveler
        {
            get { return listTraveler; }
            set { listTraveler = value; }
        }

        public P_Booking_Activity_Info()
        {
            ListTraveler = new List<P_TravelerActivity>();
        }
    }
    public class P_TravelerActivity
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
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

        private DateTime bookingDate;

        public DateTime BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }



        private DateTime? cancellationDate;

        public DateTime? CancellationDate
        {
            get { return cancellationDate; }
            set { cancellationDate = value; }
        }

     
    }
}
