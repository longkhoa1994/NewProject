using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class AirbnbData
    {
        DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        decimal nightlyRate;

        public decimal NightlyRate
        {
            get { return nightlyRate; }
            set { nightlyRate = value; }
        }
        DateTime bookingDate;

        public DateTime BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }
        string vatLink;

        public string VatLink
        {
            get { return vatLink; }
            set { vatLink = value; }
        }
        string currencyCode;

        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }
        decimal grossAmount;

        public decimal GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }

        decimal baseFee;

        public decimal BaseFee
        {
            get { return baseFee; }
            set { baseFee = value; }
        }

        decimal vatFee;

        public decimal VatFee
        {
            get { return vatFee; }
            set { vatFee = value; }
        }
        decimal vatRate;

        public decimal VatRate
        {
            get { return vatRate; }
            set { vatRate = value; }
        }

        public  List<KeyValuePair<string, decimal>> Positions { get; set; }

        public  string VATRate { get; set; }

        public  decimal VATFee { get; set; }

        public  string VATLink { get; set; }

        public string BookingNo { get; set; }
    }
}
