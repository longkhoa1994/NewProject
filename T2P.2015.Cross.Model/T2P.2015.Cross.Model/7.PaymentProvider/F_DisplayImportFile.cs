using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model
{
    public class F_DisplayImportFile 
    {
        public long ImportFileID { get; set; }
        public string FileName { get; set; }
        public string CompanyName { get; set; }

        public DateTime ImportDate { get; set; }
        public DateTime? Delivery_ExportDate { get; set; }

        public long ProcessingTransaction { get; set; }

        public long SpecialTransaction { get; set; }

        public long EnrichedTransaction { get; set; }

        public long TotalTransaction { get; set; }

        public long OtherTransaction { get; set; }

        public int FileStatusNumber { get; set; }
        FileStatus fileStatus;

        public FileStatus FileStatus
        {
            get {
                return (FileStatus)FileStatusNumber;
            }
            set { fileStatus = value; }
        }


        public int DeliveryStatusNumber { get; set; }
        DeliveryStatus deliveryStatus;

        public DeliveryStatus DeliveryStatus
        {
            get
            {
                return (DeliveryStatus)DeliveryStatusNumber;
            }
            set { deliveryStatus = value; }
        }
         

        public bool IsDownloaded { get; set; }

        public long CompanyDeliveryID { get; set; }

        public string FileType { get; set; }
    }
}