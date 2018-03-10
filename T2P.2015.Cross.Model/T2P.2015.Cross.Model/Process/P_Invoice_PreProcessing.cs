﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Invoice_PreProcessing
    {
        public List<A_UserProfile> ListServiceCenter { get; set; }

        public List<P_EmailPreprocessing> ListEmailPreprocessing { get; set; }

    }
    public class P_EmailPreprocessing
    {
        public long TotalRecord { get; set; }
        public long EmailID { get; set; }
        public int IsLock { get; set; }
        public string TypeEmail { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime ProcessDate { get; set; }
        public string ProcessBy { get; set; }

        public string LockedBy { get; set; }
    }


    //case get list new invoice
    public class P_Preprocessing
    {
        public int EmailID { get; set; }

        public string Comment { get; set; }

        public List<P_Preprocessing_ListPage> ListPage { get; set; }

        public List<P_Preprocessing_Invoice> ListInvoiceImage { get; set; }

        public P_Preprocessing()
        {
            EmailID = 0;
            Comment = string.Empty;
            ListPage = new List<P_Preprocessing_ListPage>();
            ListInvoiceImage = new List<P_Preprocessing_Invoice>();
        }

        //public List<P_Preprocessing_Invoice> ListInvoice { get; set; }

        //public List<P_Preprocessing_Invoice> ListInvoiceMatched { get; set; }

    }

    public class P_Preprocessing_Invoice
    {
        public long B_AccessID { get; set; }
        public long ImageID { get; set; }
        public long BookingID { get; set; }
        public string BookingNo { get; set; }
        public string DuplicatedBookingNo { get; set; }
        public int Deleted { get; set; }
        public int ShowIconRemove { get; set; }
        public int Index { get; set; }
        public List<P_Preprocessing_Page> ListPage { get; set; }
    }

    public class P_Preprocessing_Page
    {
        public long PageImageID { get; set; }
        public long PageID { get; set; }

        public long Rotate { get; set; }

        public int PageIndex { get; set; }

        public int Position { get; set; }
        public int Deleted { get; set; }
    }

    public class P_Preprocessing_Invoice_Page
    {
        public long AttachmentID { get; set; }
        public long PageImageID { get; set; }
        public long B_AccessID { get; set; }
        public long ImageID { get; set; }
        public long BookingID { get; set; }
        public string BookingNo { get; set; }
        public string DuplicatedBookingNo { get; set; }
        public long PageID { get; set; }
        public long Rotate { get; set; }
        public int Position { get; set; }
        public int PageIndex { get; set; }
        public int Deleted { get; set; }
    }

    public class P_Preprocessing_ListPage 
    {
        public int Index { get; set; }
        public int AdditionPosition { get; set; }
        public long EmailID { get; set; }
        public long AttachmentID { get; set; }
        public long PageID { get; set; }
        public int Rotate { get; set; }
        public int Page { get; set; }
        public string PathFile { get; set; }
        public string M_HotelPlatformName { get; set; }
        public int ZoomRatio { get; set; }
        public int Visibled { get; set; }
    }
}
