using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._2.Hotel.Booking;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_EventInfomation
    {
        public long ID { get; set; }
        public long EventID { get; set; }
        public long BookingID { get; set; }
        public string EventNo { get; set; }
        public string EventTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long Booker_ID { get; set; }
        public string Booker_FirstName { get; set; }
        public string Booker_LastName { get; set; }
        public string Booker_Phone { get; set; }
        public string Booker_Email { get; set; }
        public int Booker_Status { get; set; }
        
        public long Hotel_ID { get; set; }
        public string  Hotel_HotelNo { get; set; }
        public string Hotel_HotelName { get; set; }
        public string Hotel_Street { get;set;}
        public string Hotel_ZipCode { get; set; }
        public string Hotel_CityName { get; set; }
        public string Hotel_CountryCode { get; set; }
        public string Hotel_CountryName { get; set; }
        public string Hotel_CountryNumber { get; set; }
        public string Hotel_Phone { get; set; }
        public string Hotel_Fax { get; set; }
        public string Hotel_Email { get; set; }
        public string Package_ID { get; set; }
        public string Package_PackageID { get; set; }
        public DateTime Package_Date { get; set; }
        public string Package_Type { get; set; }
        public int Package_QuantityContract { get; set; }
        public float Package_PricePerPerson { get; set; }
        public int Package_Status { get; set; }
        public bool PCI_Allowed { get; set; }
        public string PCI_AccountName { get; set; }
        public string PCI_AccountStatus { get; set; }
        public bool IsUseCA { get; set; }
        public bool SetupPCI { get; set; }
        public List<P_ContractGroupByMapping> ListDataContract { get; set; }
        public List<P_ContractFilePDF> ListContractCombine { get; set; }
        public Mountain Mountain { get; set; }
        public long I_DataID { get; set; }

        public long Room_ID { get; set; }
        public string Room_RoomType { get; set; }
        public DateTime Room_CheckIn { get; set; }
        public DateTime Room_CheckOut { get; set; }
        public float Room_PricePerNight { get; set; }
        public int Room_QuantityContract { get; set; }
        public int Room_Status { get; set; }

        public long Contract_ID { get; set; }
        public DateTime Contract_ContractDate { get; set; }
        public string Contract_ContractNumber { get; set; }
        public bool Contract_Commissionable { get; set; }
        public long Contract_Verification { get; set; }
        public int Contract_Status { get; set; }
        public string ContractFilePath { get; set; }

        public string Company_CompanyName { get; set; }
        public string Company_CompanyAddress { get; set; }
        public string Company_CityName { get; set; }
        public string Company_ZipCode { get; set; }
        public string Company_CountryCode { get; set; }
        public string Contract_FullPathPdfFile { get; set; }

        public string ImageStatus { get; set; }

        public DateTime? CancellationDate { get; set; }

        #region Tung's field
        public long ImageID { get; set; }

        public bool IsInformationInvoice { get; set; }
        public string Inquirer { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int EventStatus { get; set; }
        public string BookingStatus { get; set; }

        public string BookerName { get; set; }
        public DateTime? Booking_CheckIn { get; set; }
        public DateTime? Booking_CheckOut { get; set; }

        public int Booking_MeetingPackage { get; set; }
        public int Booking_AdditionalService { get; set; }
        public int Booking_Room { get; set; }
        public string CompanyName { get; set; }
        public long? CompanyID { get; set; }
        public string CompanyShortName { get; set; }
        public string CompanyAddress {get;  set;}
        public string Fax { get; set; }
		public string CompanyEmail {get;set;}
        public string BookingNo { get; set; }
        public string Telephone { get; set; }
		public string CityName{get;set;}
		public string ZIPCode{get;set;}
        public string Logo { get; set; }
        public string FilePath { get; set; }
        public string IISPath { get; set; }
        public long M_HotelPlatformID { get; set; }
        public bool isEditPermission { get; set; }
        public List<A_UserProfile> ListUser { get; set; }
        public string Payment { get; set; }
        public string PaymentMethod { get;set; }
        public List<M_Code> ListStopCode { get; set; }
        public List<M_HotelContact> ListContact { get; set; }

        public List<P_InvoicePosition> ListInvoicePosition { get; set; }
        public List<I_Tax> ListInvoiceTax { get; set; }
        public List<dynamic> ListSetting { get; set; }
        public bool useDC0 {get;set;}
        public bool useSNL { get; set; }
        public bool useSND { get; set; }
        public bool useDCI { get; set; }
        public bool useSCI { get; set; }

        #endregion
        public List<B_DBIExtension> ListDBIs { get; set; }
        public P_EventInfomation()
        {
            ListDBIs = new List<B_DBIExtension>();
        }
    }
    public class P_ContractFilePDF
    {
        public long B_ContractID { get; set; }
        public string ContractFilePath { get; set; }
        public long BookingID { get; set; }
        public int Status { get; set; }

        public bool isRemove { get; set; }
    }
    public class P_Approval_Information
    {
        public int? Status { get; set; }
        public long? B_EventID { get; set; }
        public string Step { get; set; }
        public long? B_AccessID { get; set; }
        public bool? IsLocked { get; set; }
        public string LockedBy { get; set; }
    }
}
