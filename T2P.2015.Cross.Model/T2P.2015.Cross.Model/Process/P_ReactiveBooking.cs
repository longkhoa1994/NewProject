using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ReactiveBooking
    {
        public List<P_InvoiceStep> ListInvoiceStopStep { get; set; }
        public List<P_NextInvoiceStep> ListInvoiceNextStep { get; set; }
        public List<P_FinancialStep> ListFinancialStopStep { get; set; }
        public List<P_NextFinancialStep> ListFinancialNextStep { get; set; }
        public List<P_BookingStep> ListBookingStopStep { get; set; }
        public List<P_NextBookingStep> ListBookingNextStep { get; set; }
        public P_BookingStep BookingReactivateStep { get; set; }
        public List<P_FinancialStep> ListFinancialReactivateStep { get; set; }
        public List<P_InvoiceStep> ListInvoiceReactivateStep { get; set; }
        public List<I_Image> ListImage { get; set; }

        public P_ReactiveBooking()
        {            
            ListInvoiceStopStep = new List<P_InvoiceStep>();
            ListInvoiceNextStep = new List<P_NextInvoiceStep>();
            ListFinancialStopStep = new List<P_FinancialStep>();
            ListFinancialNextStep = new List<P_NextFinancialStep>();
            ListBookingStopStep = new List<P_BookingStep>();
            ListBookingNextStep = new List<P_NextBookingStep>();
            BookingReactivateStep = new P_BookingStep();
            ListInvoiceReactivateStep = new List<P_InvoiceStep>();
            ListFinancialReactivateStep = new List<P_FinancialStep>();
            ListImage = new List<I_Image>();

        }
    }
}
