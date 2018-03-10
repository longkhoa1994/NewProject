using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_DeliveryImage
    {
        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private string _additionalInformation;

        public string AdditionalInformation
        {
            get { return _additionalInformation; }
            set { _additionalInformation = value; }
        }
        private string _postalCode;

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        private string _vatNumber;

        public string VatNumber
        {
            get { return _vatNumber; }
            set { _vatNumber = value; }
        }
        private DateTime _invoiceDate;

        public DateTime InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }
        private string _invoiceNumber;

        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }
        private string _basisforassessment;

        public string Basisforassessment
        {
            get { return _basisforassessment; }
            set { _basisforassessment = value; }
        }
        private decimal _totalVAT;

        public decimal TotalVAT
        {
            get { return _totalVAT; }
            set { _totalVAT = value; }
        }
        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        private long rowNum;

        public long RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }
        private string _reservationNumber;

        public string ReservationNumber
        {
            get { return _reservationNumber; }
            set { _reservationNumber = value; }
        }




    }
}
