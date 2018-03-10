using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_351 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_350ID;
        public long? F_E_DTR_350ID
        {
            get { return _F_E_DTR_350ID; }
            set { _F_E_DTR_350ID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _businessIca;
        public string BusinessIca
        {
            get { return _businessIca; }
            set { _businessIca = value; }
        }
        private string _providerId3;
        public string ProviderId3
        {
            get { return _providerId3; }
            set { _providerId3 = value; }
        }
        private string _providerId2;
        public string ProviderId2
        {
            get { return _providerId2; }
            set { _providerId2 = value; }
        }
        private string _providerId1;
        public string ProviderId1
        {
            get { return _providerId1; }
            set { _providerId1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _tbr;
        public string Tbr
        {
            get { return _tbr; }
            set { _tbr = value; }
        }
        private string _acctNo;
        public string AcctNo
        {
            get { return _acctNo; }
            set { _acctNo = value; }
        }
        private string _aquirRefNum;
        public string AquirRefNum
        {
            get { return _aquirRefNum; }
            set { _aquirRefNum = value; }
        }
        private decimal? _addendumSeqNo;
        public decimal? AddendumSeqNo
        {
            get { return _addendumSeqNo; }
            set { _addendumSeqNo = value; }
        }
        private string _passengerName;
        public string PassengerName
        {
            get { return _passengerName; }
            set { _passengerName = value; }
        }
        private string _travelAgencyNumber;
        public string TravelAgencyNumber
        {
            get { return _travelAgencyNumber; }
            set { _travelAgencyNumber = value; }
        }
        private string _travelAgencyName;
        public string TravelAgencyName
        {
            get { return _travelAgencyName; }
            set { _travelAgencyName = value; }
        }
        private string _ticketNumber;
        public string TicketNumber
        {
            get { return _ticketNumber; }
            set { _ticketNumber = value; }
        }
        private decimal? _ticketIssueDate;
        public decimal? TicketIssueDate
        {
            get { return _ticketIssueDate; }
            set { _ticketIssueDate = value; }
        }
        private string _ticketIssueCity;
        public string TicketIssueCity
        {
            get { return _ticketIssueCity; }
            set { _ticketIssueCity = value; }
        }
        private string _origTicketNum;
        public string OrigTicketNum
        {
            get { return _origTicketNum; }
            set { _origTicketNum = value; }
        }
        private string _exchangeTicketNum;
        public string ExchangeTicketNum
        {
            get { return _exchangeTicketNum; }
            set { _exchangeTicketNum = value; }
        }
        private decimal? _tranAmt;
        public decimal? TranAmt
        {
            get { return _tranAmt; }
            set { _tranAmt = value; }
        }
        private decimal? _fareAmt;
        public decimal? FareAmt
        {
            get { return _fareAmt; }
            set { _fareAmt = value; }
        }
        private decimal? _tax;
        public decimal? Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
        private decimal? _salesTax;
        public decimal? SalesTax
        {
            get { return _salesTax; }
            set { _salesTax = value; }
        }
        private string _productCode;
        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
        private DateTime? _departDate;
        public DateTime? DepartDate
        {
            get { return _departDate; }
            set { _departDate = value; }
        }
        private string _departTime;
        public string DepartTime
        {
            get { return _departTime; }
            set { _departTime = value; }
        }
        private string _cityOrigAirCd;
        public string CityOrigAirCd
        {
            get { return _cityOrigAirCd; }
            set { _cityOrigAirCd = value; }
        }
        private string _carrierCode1;
        public string CarrierCode1
        {
            get { return _carrierCode1; }
            set { _carrierCode1 = value; }
        }
        private string _serviceClass1;
        public string ServiceClass1
        {
            get { return _serviceClass1; }
            set { _serviceClass1 = value; }
        }
        private string _stopoverCode1;
        public string StopoverCode1
        {
            get { return _stopoverCode1; }
            set { _stopoverCode1 = value; }
        }
        private string _flightNbr1;
        public string FlightNbr1
        {
            get { return _flightNbr1; }
            set { _flightNbr1 = value; }
        }
        private string _cityArrival1;
        public string CityArrival1
        {
            get { return _cityArrival1; }
            set { _cityArrival1 = value; }
        }
        private string _carrierCode2;
        public string CarrierCode2
        {
            get { return _carrierCode2; }
            set { _carrierCode2 = value; }
        }
        private string _serviceClass2;
        public string ServiceClass2
        {
            get { return _serviceClass2; }
            set { _serviceClass2 = value; }
        }
        private string _stopoverCode2;
        public string StopoverCode2
        {
            get { return _stopoverCode2; }
            set { _stopoverCode2 = value; }
        }
        private string _flightNbr2;
        public string FlightNbr2
        {
            get { return _flightNbr2; }
            set { _flightNbr2 = value; }
        }
        private string _cityArrival2;
        public string CityArrival2
        {
            get { return _cityArrival2; }
            set { _cityArrival2 = value; }
        }
        private string _carrierCode3;
        public string CarrierCode3
        {
            get { return _carrierCode3; }
            set { _carrierCode3 = value; }
        }
        private string _serviceClass3;
        public string ServiceClass3
        {
            get { return _serviceClass3; }
            set { _serviceClass3 = value; }
        }
        private string _stopoverCode3;
        public string StopoverCode3
        {
            get { return _stopoverCode3; }
            set { _stopoverCode3 = value; }
        }
        private string _flightNbr3;
        public string FlightNbr3
        {
            get { return _flightNbr3; }
            set { _flightNbr3 = value; }
        }
        private string _cityArrival3;
        public string CityArrival3
        {
            get { return _cityArrival3; }
            set { _cityArrival3 = value; }
        }
        private string _carrierCode4;
        public string CarrierCode4
        {
            get { return _carrierCode4; }
            set { _carrierCode4 = value; }
        }
        private string _serviceClass4;
        public string ServiceClass4
        {
            get { return _serviceClass4; }
            set { _serviceClass4 = value; }
        }
        private string _stopoverCode4;
        public string StopoverCode4
        {
            get { return _stopoverCode4; }
            set { _stopoverCode4 = value; }
        }
        private string _flightNbr4;
        public string FlightNbr4
        {
            get { return _flightNbr4; }
            set { _flightNbr4 = value; }
        }
        private string _cityArrival4;
        public string CityArrival4
        {
            get { return _cityArrival4; }
            set { _cityArrival4 = value; }
        }
        private string _airCarrierName;
        public string AirCarrierName
        {
            get { return _airCarrierName; }
            set { _airCarrierName = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_351"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_351_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_351Columns
    {
        ID,
        F_E_DTR_350ID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        AquirRefNum,
        AddendumSeqNo,
        PassengerName,
        TravelAgencyNumber,
        TravelAgencyName,
        TicketNumber,
        TicketIssueDate,
        TicketIssueCity,
        OrigTicketNum,
        ExchangeTicketNum,
        TranAmt,
        FareAmt,
        Tax,
        SalesTax,
        ProductCode,
        DepartDate,
        DepartTime,
        CityOrigAirCd,
        CarrierCode1,
        ServiceClass1,
        StopoverCode1,
        FlightNbr1,
        CityArrival1,
        CarrierCode2,
        ServiceClass2,
        StopoverCode2,
        FlightNbr2,
        CityArrival2,
        CarrierCode3,
        ServiceClass3,
        StopoverCode3,
        FlightNbr3,
        CityArrival3,
        CarrierCode4,
        ServiceClass4,
        StopoverCode4,
        FlightNbr4,
        CityArrival4,
        AirCarrierName,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_351Procedure
    {
        p_F_E_DTR_351_GetBy_F_E_DTR_350ID
    }
    public class F_E_DTR_351List : List<F_E_DTR_351>
    {

    }
}