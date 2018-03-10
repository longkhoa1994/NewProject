using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.DTR
{
    [Serializable]
    public class DTR_FileExport
    {
        public DTR_E_File File { get; set; }
        public DTR_E_Client Client { get; set; }
    }
    [Serializable]
    public class DTR_E_File
    {
        public F_ImportFile F_ImportFile { get; set; }
        public F_E_DTR_101 FileHeader { get; set; }
        public F_E_DTR_999 FileTrailer { get; set; }
    }
    [Serializable]
    public class DTR_E_Client
    {
        public F_E_DTR_201 BankHeader { get; set; }
        public List<F_E_DTR_401> ListCorpSummary { get; set; }
        public List<DTR_E_Card> ListCard { get; set; }
    }
    [Serializable]
    public class DTR_E_Card
    {
        public F_Header F_Header { get; set; }
        public F_E_DTR_310 CardHolderInformation { get; set; }
        public F_E_DTR_311 CardMemberDetail { get; set; }
        public List<DTR_E_Transaction> ListTransaction { get; set; }
        public List<F_E_DTR_402> ListFees { get; set; }
    }
    [Serializable]
    public class DTR_E_Transaction
    {
        public F_Transaction F_Transaction { get; set; }
        public F_E_DTR_320 TransactionDetail { get; set; }
        public DTR_E_Purchasing Purchasing { get; set; }
        public DTR_E_Addendum Addendum { get; set; }
    }
    [Serializable]
    public class DTR_E_Purchasing
    {
        public F_E_DTR_340 PurchasingAddendum { get; set; }
        public List<DTR_E_PurchasingAddendumAmex> ListPurchasingAddendumAmex { get; set; }
    }
    [Serializable]
    public class DTR_E_PurchasingAddendumAmex
    {
        public F_E_DTR_341 PurchasingHeaderAddendum { get; set; }
        public F_E_DTR_342 PurchasingDetailAddendum { get; set; }
        public F_E_DTR_349 PurchasingFooterAddendum { get; set; }
    }
    [Serializable]
    public class DTR_E_Addendum
    {
        public F_E_DTR_398 TempAddendumAmex { get; set; }
        public F_E_DTR_399 ShippingAddendumAmex { get; set; }
        public F_E_DTR_395 PreAuthAddendum { get; set; }
        public F_E_DTR_396 TempAddendum { get; set; }
        public F_E_DTR_397 ShippingAddendum { get; set; }
        public DTR_E_AirlineAddendum AirlineAddendum { get; set; }
        public DTR_E_CarRentAddendum CarRentAddendum { get; set; }
        public List<DTR_E_LodgingAddendum> ListLodgingAddendum { get; set; }
        public DTR_E_FuelAddendum FuelAddendum { get; set; }
    }
    [Serializable]
    public class DTR_E_AirlineAddendum
    {
        public F_E_DTR_350 AirlineAddendum { get; set; }
        public F_E_DTR_351 AirlineAddendumAmex { get; set; }
    }
    [Serializable]
    public class DTR_E_CarRentAddendum
    {
        public F_E_DTR_360 CarRentAddendum { get; set; }
        public F_E_DTR_361 CarRentAddendumAmex { get; set; }
    }
    [Serializable]
    public class DTR_E_LodgingAddendum
    {
        public F_E_DTR_370 LodgingAddendum { get; set; }
        public F_E_DTR_371 LodgingAddendumAmex { get; set; }
    }
    [Serializable]
    public class DTR_E_FuelAddendum
    {
        public F_E_DTR_390 FuelAddendum { get; set; }
        public F_E_DTR_391 NonFuelAddendum { get; set; }
    }
}
