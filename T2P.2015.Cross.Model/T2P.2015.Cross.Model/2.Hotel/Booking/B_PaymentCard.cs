using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIM_Reservation_Request_Cytric;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_PaymentCard : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _b_BookingID;
        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }
        private string _cardType;
        public string CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }
        private string _cardCode;
        public string CardCode
        {
            get { return _cardCode; }
            set { _cardCode = value; }
        }
        private string _cardHolderName;
        public string CardHolderName
        {
            get { return _cardHolderName; }
            set { _cardHolderName = value; }
        }

        private string _cardNumber;

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        private string _expireDate;

        public string ExpireDate
        {
            get { return _expireDate; }
            set { _expireDate = value; }
        }

        private string _addressLine;
        public string AddressLine
        {
            get { return _addressLine; }
            set { _addressLine = value; }
        }
        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        private string _postalCode;
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public List<B_PaymentCardField> CreditCardField { get; set; }
        public bool PaidByCompany { get; set; }
        public string CvnNumber { get; set; }
        public bool CorporateCard { get; set; }
        public bool CardIsPresentWithTraveller { get; set; }
        public string CompanyCode { get; set; }
        public override string Table { get { return "B_PaymentCard"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_PaymentCard_InsertOrUpdate"; } }
    }
    public enum B_PaymentCardColumns
    {
        ID,
        B_BookingID,
        CardType,
        CardCode,
        CardHolderName,
        CardNumber,
        ExpireDate,
        AddressLine,
        CityName,
        PostalCode,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum B_PaymentCardProcedure
    {
        p_B_PaymentCard_Get_by_B_BookingID
    }
    public class B_PaymentCardList : List<B_PaymentCard>
    {

    }
}