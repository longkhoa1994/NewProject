using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model;
using T2P._2015.Cross.Model._5.Meetago.Contract;
using T2P._2015.Cross.Model._5.Meetago.Booking;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_ContractCapture
    {
        public long? B_EventID { get; set; }
        public long B_BookingID { get; set; }
        public long B_ContractID { get; set; }
        public long B_ContractFileID { get; set; }
        public long M_CompanyID { get; set; }
        public string BookingNo { get; set; }
        public string ContractNo { get; set; }
        public string OfferNo { get; set; }
        public string PDFFilePath { get; set; }
        public long B_AcccessID { get; set; }
        public List<B_Booker> ListBooker { get; set; }
        public B_ContractFile ContractFile { get; set; }
        public List<B_AdditionalService> ListAdditionalServices { get; set; }
        public List<B_Package> ListPackageService { get; set; }
        public List<B_Room> ListRoomService { get; set; }
        public List<M_ServiceCode> ListServiceCode { get; set; }
        public List<ServiceKeyword> ListServiceKeyword { get; set; }
        public List<B_CancellationPolicy> ListCancellationPolicies { get; set; }
        public bool IsLock { get; set; }
        public bool? IsSearchNotFound { get; set; }
        public List<ObjectRemoveSupplier> ListRemoveSupplier { get; set; }
        public P_ContractCapture()
        {
            ListBooker = new List<B_Booker>();
            ContractFile = new B_ContractFile();
            ListAdditionalServices = new List<B_AdditionalService>();
            ListServiceCode = new List<M_ServiceCode>();
            ListPackageService = new List<B_Package>();
            ListRoomService = new List<B_Room>();
            ListServiceKeyword = new List<ServiceKeyword>();
            ListCancellationPolicies = new List<B_CancellationPolicy>();
            ListRemoveSupplier = new List<ObjectRemoveSupplier>();
            IsLock = false;
        }
    }

    public class ObjectRemoveSupplier
    {
        public long B_AccessID { get; set; }
        public long B_BookingID { get; set; }

        public long B_ContractID { get; set; }

        public long B_ContractFileID { get; set; }
    }

    public class P_ConsolidateContract
    {
        public long B_AccessID { get; set; }
        public long B_EventID { get; set; }
        public string BookingNo { get; set; }
        public long ContractID { get; set; }
        public string ContractNumber { get; set; }
        public bool Verification { get; set; }

    }
}
