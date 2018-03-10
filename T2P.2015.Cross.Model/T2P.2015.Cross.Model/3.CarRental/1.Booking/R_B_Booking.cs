using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_B_Booking : BaseModel
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

        private long r_B_HeaderID;

        public long R_B_HeaderID
        {
            get { return r_B_HeaderID; }
            set { r_B_HeaderID = value; }
        }
        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string customerNo;

        public string CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _travelerInformation;

        public string TravelerInformation
        {
            get { return _travelerInformation; }
            set { _travelerInformation = value; }
        }

        private string _carRentalProvider;

        public string CarRentalProvider
        {
            get { return _carRentalProvider; }
            set { _carRentalProvider = value; }
        }

        private string carCategory;

        public string CarCategory
        {
            get { return carCategory; }
            set { carCategory = value; }
        }

        private DateTime? _pickupDate;

        public DateTime? PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }

        private string pickupTime;

        public string PickupTime
        {
            get { return pickupTime; }
            set { pickupTime = value; }
        }

        private DateTime? _returnDate;

        public DateTime? ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        private string returnTime;

        public string ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
        }

        private string _pickupCity;

        public string PickupCity
        {
            get { return _pickupCity; }
            set { _pickupCity = value; }
        }

        private string _pickupCountry;

        public string PickupCountry
        {
            get { return _pickupCountry; }
            set { _pickupCountry = value; }
        }

        private string _returnCity;

        public string ReturnCity
        {
            get { return _returnCity; }
            set { _returnCity = value; }
        }

        private string _returnCountry;

        public string ReturnCountry
        {
            get { return _returnCountry; }
            set { _returnCountry = value; }
        }

        private string _additionInformation;

        public string AdditionInformation
        {
            get { return _additionInformation; }
            set { _additionInformation = value; }
        }

        private string ticketNo;

        public string TicketNo
        {
            get { return ticketNo; }
            set { ticketNo = value; }
        }

        private DateTime? _bookedDate;

        public DateTime? BookedDate
        {
            get { return _bookedDate; }
            set { _bookedDate = value; }
        }

        private string _pickupStation;

        public string PickupStation
        {
            get { return _pickupStation; }
            set { _pickupStation = value; }
        }

        private string _returnStation;

        public string ReturnStation
        {
            get { return _returnStation; }
            set { _returnStation = value; }
        }

        public bool IsManually { get; set; }
        public string Comment { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public bool ExistInv { get; set; }

        public bool ExistFIN { get; set; }

        public string BookingStatus { get; set; }
        public long M_CarRentalProviderID { get; set; }
        public long CompanyID { get; set; }
        public M_Country ObjCountry { get; set; }
        public M_Country ObjReturnCountry { get; set; }
        public M_Currency ObjCurrency { get; set; }
        public List<R_M_SippCode> ListSippCode { get; set; }
        public string RateGrid { get; set; }

        public override string Table { get { return "R_B_Booking"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_B_Booking_InsertOrUpdate"; } }


    }

    public enum R_B_BookingColumns
    {
        ID,
        R_B_AccessID,
        BookingNo,
        CustomerName,
        FirstName,
        LastName,
        Email,
        TravelerInformation,
        CarRentalProvider,
        PickupDate,
        ReturnDate,
        PickupCity,
        PickupCountry,
        ReturnCity,
        ReturnCountry,
        AdditionInformation,
        TicketNo,
        BookedDate,
        RateGrid,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_B_BookingProcedure
    {
        p_R_B_Booking_GetByBookingNo,
        p_R_B_Booking_Get_By_BookingNo,
        p_R_B_Booking_Get_Information,
        p_R_B_Booking_Get_By_B_AccessID,
        p_R_P_BookingStep_GetAllHistory,
        p_R_B_Booking_GetSearch,
        p_R_B_Booking_GetExactByBookingNo,
        p_R_B_Booking_Get_By_List_BookingNo,
        p_R_B_Booking_Get_List_By_BookingNo_ForBillingEmail,
        p_R_B_Booking_Get_ForServiceCenterTemplate,
        p_R_B_Booking_GetBy_R_F_TransactionID,
        p_R_B_Booking_Get_List_By_BookingNo_ForUnmatchable,
        p_R_B_Booking_GetByBookingNo_ForUpdate,
        p_R_B_Import_GetByCondition,
        p_R_B_Booking_Import_GetByCondition,
        p_R_B_Booking_CheckTravelerName,
        p_R_B_Booking_CheckTravelerName_TestEnviroment,
        p_R_B_Booking_GetStatus,
        p_R_B_Booking_GetByTicketNo
    }
    public enum listI_DataPass
    {
        M_PickupCountryID,
        M_ReturnCountryID,
        CustomerNumber,
        TravelerName,
        InvoiceNumber,
        InvoiceDate,
        CarGroup,
        NetAmount,
        GrossAmount,
        Currency,
        PickUpTime,
        ReturnTime,
        PickUpLocation,
        ReturnLocation,
        StartingKM,
        ReturnKM, 
        Distance

    }

    public class R_B_BookingList : List<R_B_Booking>
    {
    }
}