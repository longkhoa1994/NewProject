using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model.Process
{
    public class P_StopProcessBooking
    {
        public List<P_InvoiceStep> ListInvoiceHistoryStep { get; set; }
        public List<P_NextInvoiceStep> ListInvoiceNextStep { get; set; }
        public List<P_FinancialStep> ListFinancialHistoryStep { get; set; }
        public List<P_NextFinancialStep> ListFinNextStep { get; set; }
        public List<P_BookingStep> ListBookingHistoryStep { get; set; }
        public List<P_NextBookingStep> ListBookingNextStep { get; set; }
        public P_BookingStep BookingStopStep { get; set; }
        public List<P_FinancialStep> ListFinancialStopStep { get; set; }
        public List<P_InvoiceStep> ListInvoiceStopStep { get; set; }

        public List<I_Image> ListImage { get; set; }

        public List<N_Task> ListN_Task { get; set; }
        public P_StopProcessBooking()
        {
            ListInvoiceHistoryStep = new List<P_InvoiceStep>();
            ListInvoiceNextStep = new List<P_NextInvoiceStep>();
            ListFinancialHistoryStep = new List<P_FinancialStep>();
            ListFinNextStep = new List<P_NextFinancialStep>();
            ListBookingHistoryStep = new List<P_BookingStep>();
            ListBookingNextStep = new List<P_NextBookingStep>();
            BookingStopStep = new P_BookingStep();
            ListInvoiceStopStep = new List<P_InvoiceStep>();
            ListFinancialStopStep = new List<P_FinancialStep>();
            ListImage = new List<I_Image>();
            ListN_Task = new List<N_Task>();
        }
    }
}
