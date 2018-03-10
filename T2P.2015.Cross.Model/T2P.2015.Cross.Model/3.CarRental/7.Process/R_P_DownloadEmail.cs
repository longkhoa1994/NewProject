using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_DownloadEmail
    {
         public R_N_BillingEmail BillingEmail { get; set; }

        public R_N_BillingEmailDetail BillingEmailDetail { get; set; }

        public R_N_BillingEmailAddition BillingEmailAddition { get; set; }

        public List<R_N_BillingEmailAttachment> BillingEmailAttachmentList { get; set; }

        public R_N_AttachmentToImage AttachmentToImage { get; set; }

        public List<R_N_AttachmentToImage> AttachmentToImageList { get; set; }

        public R_B_Access B_Access { get; set; }

        public R_B_Booking B_Booking { get; set; }

        List<R_B_Booking> ListBookingEuropcars { get; set; }

        public R_N_BookingBillingEmail BookingBillingEmail { get; set; }

        public R_N_BookingBillingEmail N_BookingBillingEmail { get; set; }
        public R_I_Image Image { get; set; }

        public List<R_I_Image> ImageList { get; set; }

        public List<R_P_InvoiceStep> InvoiceStepList { get; set; }

        public List<R_P_NextInvoiceStep> NextInvoiceStepList { get; set; }

        public R_N_Comment Comment { get; set; }

        public R_N_Task Task { get; set; }

        public bool IsDoneTask { get; set; }

        public R_P_DownloadEmail()
        {
            BillingEmail = new R_N_BillingEmail();
            BillingEmailDetail = new R_N_BillingEmailDetail();
            BillingEmailAddition = new R_N_BillingEmailAddition();
            BillingEmailAttachmentList = new List<R_N_BillingEmailAttachment>();
            AttachmentToImage = new R_N_AttachmentToImage();
            B_Access = new R_B_Access();
            BookingBillingEmail = new R_N_BookingBillingEmail();
            Image = new R_I_Image();
            InvoiceStepList = new List<R_P_InvoiceStep>();
            NextInvoiceStepList = new List<R_P_NextInvoiceStep>();
            B_Booking = new R_B_Booking();
            ImageList = new List<R_I_Image>();
            AttachmentToImageList = new List<R_N_AttachmentToImage>();
            N_BookingBillingEmail = new R_N_BookingBillingEmail();
            IsDoneTask = true;
        }
    }
}
