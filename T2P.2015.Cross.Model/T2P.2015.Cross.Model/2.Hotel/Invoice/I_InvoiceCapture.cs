using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Invoice
{
    public class I_InvoiceCapture :  BaseModel
    {
         public long ImageID { get; set; }
		 public string	FilePath { get; set; }
		 public string	PDFFilename { get; set; }
		 public string	M_FileLocationID { get; set; }
		 public string	CompanyName { get; set; }
		 public string	CompanyAddress{ get; set; }
		 public string	CompanyZipCode { get; set; }
		 public string	CompanyCity { get; set; }
		 public string	CompanyCountry { get; set; }
		 public string	CompanyCountryCode { get; set; }
		 public string	CompanyVAT { get; set; }
		 public string	HotelName { get; set; }
		 public string	HotelAddress { get; set; }
		 public string	HotelZipCode { get; set; }
		 public string	HotelCity { get; set; }
		 public string	HotelCountry { get; set; }
		 public string	HotelCountryCode { get; set; }
		 public string	HotelVAT { get; set; }
		 public string	BookingNo { get; set; }
		 public DateTime	BCheckin { get; set; }
		 public DateTime	BCheckout { get; set; }
		 public long?	M_HotelID { get; set; }
		 public long	M_CompanyID { get; set; }
         public long B_AccessID { get; set; }
         public long HotelCountryID { get; set; }
         public long? CurrencyID { get; set; }
         public string SuggestCurrency { get; set; }
         public long? M_ProcessID { get; set; }
         public long EventID { get; set; }
         public bool? IsInformationInvoice { get; set; }
         public bool IsSkipInfoValidation { get; set; }
    }
}
