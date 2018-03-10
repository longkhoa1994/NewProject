using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Matching_ImageInfo
    {
        public long I_ImageID { get; set; }
        public long DuplicateID { get; set; }
        public long B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public long M_HotelID { get; set; }
        public string HotelName { get; set; }
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public long M_TravellerID { get; set; }
        public string TravellerName { get; set; }
        public string ImageStr { get; set; }
        public long N_BillingEmailID { get; set; }
        public string Comment { get; set; }

        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }
        public P_Matching_ImageInfo()
        {
            I_ImageID = 0;
            B_AccessID = 0;
            BookingNo = string.Empty;
            M_HotelID = 0;
            HotelName = string.Empty;
            M_CompanyID = 0;
            CompanyName = string.Empty;
            IsGatewayInvoice = false;
            M_TravellerID = 0;
            TravellerName = string.Empty;
            ImageStr = string.Empty;
            N_BillingEmailID = 0;
            Comment = string.Empty;
            Checkin = null;
            Checkout = null;
        }
  
    }


    public class P_Matching_GetImage
    {        
        public long N_BillingEmailID { get; set; }
        public P_Matching_Suggestion Suggestion { get; set; }
        public P_Matching_Image I_Image { get; set; }
        public List<P_Matching_Booking> ListBookingNew { get; set; }
        public long TotalBookingNewRecord { get; set; }
        public List<P_Matching_Booking> ListBookingMatched { get; set; }
        public long TotalBookingMatchedRecord { get; set; }
        public string Comment { get; set; }
        public int CodeID { get; set; }

        public long DuplicatedID { get; set; }
        public P_Matching_GetImage()
        {            
            N_BillingEmailID = 0;
            Suggestion = null;
            I_Image = new P_Matching_Image();
            ListBookingNew = new List<P_Matching_Booking>();
            TotalBookingNewRecord = 0;
            ListBookingMatched = new List<P_Matching_Booking>();
            TotalBookingMatchedRecord = 0;
            Comment = string.Empty;
            CodeID = 0;
            DuplicatedID = 0;
        }
    }

    public class P_Matching_SearchResult
    {
        public List<P_Matching_Booking> ListBookingNew { get; set; }
        public long TotalBookingNewRecord { get; set; }
        public List<P_Matching_Booking> ListBookingMatched { get; set; }
        public long TotalBookingMatchedRecord { get; set; }
        public P_Matching_SearchResult()
        {
            ListBookingNew = new List<P_Matching_Booking>();
            TotalBookingNewRecord = 0;
            ListBookingMatched = new List<P_Matching_Booking>();
            TotalBookingMatchedRecord = 0;
        }
    }

    public class P_Matching_Search_GetNumber
    {
      
        public long TotalBookingNewRecord { get; set; }
   
        public long TotalBookingMatchedRecord { get; set; }
        public P_Matching_Search_GetNumber()
        {
          
            TotalBookingNewRecord = 0;
          
            TotalBookingMatchedRecord = 0;
        }
    }

    

    public class P_Matching_Suggestion
    {
        public string BookingNo { get; set; }
        public string HotelName { get; set; }
        public string CompanyName { get; set; }       
        public string TravellerName { get; set; }

        public DateTime? Checkin { get; set; }

        public DateTime? Checkout { get; set; }
       
        public P_Matching_Suggestion()
        {
            BookingNo = string.Empty;
            HotelName = string.Empty;
            CompanyName = string.Empty;
            TravellerName = string.Empty;           
        }
    }

    public class P_Matching_Booking
    {
        public long M_HotelPlatformID { get; set; }
        public long M_ProcessID { get; set; }
        public long B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public List<P_Matching_Traveller> ListTraveller { get; set; }
        public List<P_Matching_Image> ListImage { get; set; }
        public List<P_Matching_FIN> ListFIN { get; set; }
        public List<string> ListAllowedServiceCode { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public bool IsCopy 
        { 
            get
            {
                return IsMatch && !(M_ProcessID == (int)ProcessType.Basic || M_ProcessID == (int)ProcessType.ContractedMerchant) ;
            }             
        }
        public bool IsPrepaid
        {
            get
            {
                return (M_ProcessID == (int)ProcessType.NonContractedMerchant || M_ProcessID == (int)ProcessType.ContractedMerchant)        
                    && ListTraveller.Where(s=>s.TravellerStatus == 1).Count() > 0;
            }            
        }
        public bool IsMatch
        {
            get
            {
                return !(
                            (
                                (M_ProcessID == (int)ProcessType.NonContractedMerchant || M_ProcessID == (int)ProcessType.ContractedMerchant)                              
                                && ListTraveller.Where(s => s.TravellerStatus == 1).Count() == ListTraveller.Count
                            )
                            || (ListTraveller.Where(s => s.TravellerStatus == -1).Count() == ListTraveller.Count)
                        )
                    ;
            }            
        }

        public bool IsDeposit
        {
            get
            {
                return IsMatch && ListImage.Count == 0 && M_ProcessID != (int)ProcessType.Basic;
            }
        }



        public P_Matching_Booking()
        {
            M_HotelPlatformID = 0;
            M_ProcessID = 0;
            B_AccessID = 0;
            BookingNo = string.Empty;
            HotelName = string.Empty;
            HotelAddress = string.Empty;
            CompanyName = string.Empty;
            CompanyAddress = string.Empty;
            ListTraveller = new List<P_Matching_Traveller>();
            ListImage = new List<P_Matching_Image>();
            ListFIN = new List<P_Matching_FIN>();
            ListAllowedServiceCode = new List<string>();
            Amount = 0;
            Currency = string.Empty;
                
        }
    }

    public class P_Matching_Image
    {
        public long I_ImageID { get; set; }
        public string ImageStatus { get; set; }
        public bool IsReplace { get; set; }
        public bool IsUseOldData { get; set; }
        public List<P_Matching_Page> ListPage { get; set; }
        public List<P_Matching_ErrorCode> ListErrorCode { get; set; }
        public bool IsExportedVTI { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public bool AutoUseOldData { get; set; }
        public bool IsSpecialCase { get; set; }

        public P_Matching_Image()
        {
            I_ImageID = 0;
            ImageStatus = string.Empty;
            IsReplace = false;
            IsUseOldData = false;
            ListPage = new List<P_Matching_Page>();
            ListErrorCode = new List<P_Matching_ErrorCode>();
            IsExportedVTI = false;
            IsGatewayInvoice = false;
            AutoUseOldData = false;
            IsSpecialCase = false;
        }
    }

    public class P_Matching_FIN
    {
        public long ID { get; set; }
        public string FileType { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public P_Matching_FIN()
        {
            ID = 0;
            FileType = string.Empty;
            Amount = 0;
            CurrencyCode = string.Empty;
        }
    }
   
    public class P_Matching_Page
    {       
        public long N_AttachmentPageID { get; set; }            
        public int Position { get; set; }    
        public string LocalPath { get; set; }
        public string IISPath { get; set; }
        public int Rotate { get; set; }       

        public P_Matching_Page()
        {           
            N_AttachmentPageID = 0;          
            LocalPath = string.Empty;
            IISPath = string.Empty;
            Rotate = 0;
           
        }
    }

    public class P_Matching_Traveller
    {
        public string TravellerName { get; set; }
        public DateTime? CancellationDate { get; set; }
        public decimal CancellationFee { get; set; }
        public DateTime? CancellationDeadline { get; set; }
        public long M_ProcessID { get; set; }
        public bool BookingDepositRequired { get; set; }
        public decimal BookingDeposit { get; set; }
        
        public int TravellerStatus { get; set; }     
        public decimal PrepaidAmount { get; set; }
        public string CurrencyCode { get; set; }

        public P_Matching_Traveller()
        {
            TravellerStatus = 0; // 0: Normal, 1: Early invoice, -1: Cancel
            TravellerName = string.Empty;
            CancellationDate = null;
            CancellationFee = 0;
            CancellationDeadline = null;
            PrepaidAmount = 0;
            CurrencyCode = string.Empty;
        }
    }

    public class P_Matching_N_BillingEmail : N_BillingEmail
    {
        public long M_HotelPlatformID { get; set; }
        public long M_HotelPlatformSettingID { get; set; }
        public string MailUsername { get; set; }
        public string Body { get; set; }
        public List<N_BillingEmailAttachment_Extend> ListAttachment { get; set; }
        
        public P_Matching_N_BillingEmail()
        {
            M_HotelPlatformID = 0;
            M_HotelPlatformSettingID = 0;
            MailUsername = string.Empty;
            Body = string.Empty;
            ListAttachment = new List<N_BillingEmailAttachment_Extend>();
        }

        

    }

    public class P_Matching_ErrorCode
    {
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
    }

    public class P_Matching_MoveFileFromHRSToBCD
    {
        public string From { get; set; }
        public string To { get; set; }
    }

    public enum P_Invoice_MatchingProcedure
    {
        p_P_Matching_GetByN_BillingEmailID,
        p_P_Matching_Generate_PDFFilename,
        p_P_Matching_MoveFileFromHRSToBCD,

    }
}
