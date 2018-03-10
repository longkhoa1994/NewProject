using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._5.Meetago.Booking;
using T2P._2015.Cross.Model._5.Meetago.Contract;
using T2P._2015.Cross.Model.Process;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_BookingImport
    {
        private B_Header header;

        public B_Header Header
        {
            get { return header; }
            set { header = value; }
        }

        private B_Event _event;

        public B_Event Event
        {
            get { return _event; }
            set { _event = value; }
        }

        private List<P_BookingImport_Booking> listBooking;

        public List<P_BookingImport_Booking> ListBooking
        {
            get { return listBooking; }
            set { listBooking = value; }
        }

        private List<P_BookingImport_Booking> listBookingDelete;

        public List<P_BookingImport_Booking> ListBookingDelete
        {
            get { return listBookingDelete; }
            set { listBookingDelete = value; }
        }
        public P_BookingImport()
        {
            ListBooking = new List<P_BookingImport_Booking>();
        }
    }

    public class P_BookingImport_Booking
    {
        public bool IsChangeDBI { get; set; }
        public N_Task Task { get; set; }
        private B_Access access;

        public B_Access Access
        {
            get { return access; }
            set { access = value; }
        }


        private P_DuplicatedHotel mHotel;

        public P_DuplicatedHotel MHotel
        {
            get { return mHotel; }
            set { mHotel = value; }
        }

        private M_Traveler mBooker;

        public M_Traveler MBooker
        {
            get { return mBooker; }
            set { mBooker = value; }
        }

        private B_Booking booking;

        public B_Booking Booking
        {
            get { return booking; }
            set { booking = value; }
        }

        private B_Hotel hotel;

        public B_Hotel Hotel
        {
            get { return hotel; }
            set { hotel = value; }
        }

        private B_HotelChain hotelChain;

        public B_HotelChain HotelChain
        {
            get { return hotelChain; }
            set { hotelChain = value; }
        }

        private B_Company company;

        public B_Company Company
        {
            get { return company; }
            set { company = value; }
        }

        private B_Addition addition;

        public B_Addition Addition
        {
            get { return addition; }
            set { addition = value; }
        }

        private List<B_AllowedServiceCodes> listServiceCode;

        public List<B_AllowedServiceCodes> ListServiceCode
        {
            get { return listServiceCode; }
            set { listServiceCode = value; }
        }

        private List<B_Amount> listAmount;

        public List<B_Amount> ListAmount
        {
            get { return listAmount; }
            set { listAmount = value; }
        }

        private List<B_Request> listRequest;
        public List<B_Request> ListRequest
        {
            get { return listRequest; }
            set { listRequest = value; }
        }

        private B_Booker booker;

        public B_Booker Booker
        {
            get { return booker; }
            set { booker = value; }
        }

        private B_Contract contract;

        public B_Contract Contract
        {
            get { return contract; }
            set { contract = value; }
        }

        private B_ContractFile pdfContract;

        public B_ContractFile PdfContract
        {
            get { return pdfContract; }
            set { pdfContract = value; }
        }

        private B_History history;

        public B_History History
        {
            get { return history; }
            set { history = value; }
        }

        private List<B_HotelContact> listHotelContact;

        public List<B_HotelContact> ListHotelContact
        {
            get { return listHotelContact; }
            set { listHotelContact = value; }
        }

        private B_KeyValuePairBooking keyValue;

        public B_KeyValuePairBooking KeyValue
        {
            get { return keyValue; }
            set { keyValue = value; }
        }

        private List<B_Package> listPackage;

        public List<B_Package> ListPackage
        {
            get { return listPackage; }
            set { listPackage = value; }
        }

        private B_PaymentCard card;

        public B_PaymentCard Card
        {
            get { return card; }
            set { card = value; }
        }

        private B_Pos pos;

        public B_Pos Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        private List<B_Room> listRoom;

        public List<B_Room> ListRoom
        {
            get { return listRoom; }
            set { listRoom = value; }
        }

        private List<P_BookingImport_Detail> listDetail;

        public List<P_BookingImport_Detail> ListDetail
        {
            get { return listDetail; }
            set { listDetail = value; }
        }

        private List<F_Transaction> listTransaction;

        public List<F_Transaction> ListTransaction
        {
            get { return listTransaction; }
            set { listTransaction = value; }
        }

        private List<P_NextBookingStep> listNextStep;

        public List<P_NextBookingStep> ListNextStep
        {
            get { return listNextStep; }
            set { listNextStep = value; }
        }

        private List<P_BookingStep> listStep;

        public List<P_BookingStep> ListStep
        {
            get { return listStep; }
            set { listStep = value; }
        }

        public P_BookingImport_Booking()
        {
            ListNextStep = new List<P_NextBookingStep>();
            ListTransaction = new List<F_Transaction>();
            ListDetail = new List<P_BookingImport_Detail>();
            ListRoom = new List<B_Room>();
            ListAmount = new List<B_Amount>();
            ListPackage = new List<B_Package>();
            ListServiceCode = new List<B_AllowedServiceCodes>();
            ListTransaction = new List<F_Transaction>();
            ListHotelContact = new List<B_HotelContact>();
            ListStep = new List<P_BookingStep>();
            IsChangeDBI = false;
        }
    }

    public class P_BookingImport_Detail
    {
        public P_BookingImport_Detail()
        {
            AdditionalData = new List<B_AdditionalData>();
        }

        private B_AccessDetail accessDetail;

        public B_AccessDetail AccessDetail
        {
            get { return accessDetail; }
            set { accessDetail = value; }
        }

        private M_Traveler mTraveler;

        public M_Traveler MTraveler
        {
            get { return mTraveler; }
            set { mTraveler = value; }
        }

        private B_BookingDetail bookingDetail;

        public B_BookingDetail BookingDetail
        {
            get { return bookingDetail; }
            set { bookingDetail = value; }
        }

        private B_Traveler traveler;

        public B_Traveler Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }

        private List<B_AdditionalData> additionalData;
        public List<B_AdditionalData> AdditionalData
        {
            get { return additionalData; }
            set { additionalData = value; }
        }
        public string PANNo { get; set; }
        public string TokenStringPCI { get; set; }
        public bool IsUpdated { get; set; }
        public List<B_CancellationPolicy> CancellationPolicy { get; set; }
        public B_DBI DBI
        {
            get
            {
                var properties = typeof(B_DBI).GetProperties();
                B_DBI dbi = null;
                foreach (var item in AdditionalData)
                {
                    var prop = properties.Where(o => o.Name.IndexOf(string.Format("{0}", item.Key)) >= 0).FirstOrDefault();
                    if (prop != null)
                    {
                        if (dbi == null)
                        {
                            dbi = new B_DBI
                            {
                                CreatedBy = item.CreatedBy,
                                UpdatedBy = item.UpdatedBy,
                                CreatedDate = item.CreatedDate,
                                UpdatedDate = item.UpdatedDate,
                                PANNo = PANNo,
                                TokenStringPCI = TokenStringPCI,
                                IsUpdated = IsUpdated
                            };
                        }

                        // Specific case for DB field
                        object val = null;
                        if (prop.PropertyType == typeof(DateTime?) && item.Value.GetType() == typeof(string))
                        {
                            val = DateTime.Parse(item.Value);
                        }
                        else
                        {
                            val = Convert.ChangeType(item.Value, prop.PropertyType);
                        }
                        prop.SetValue(dbi, val);

                    }
                }
                return dbi;
            }
        }
    }
}
