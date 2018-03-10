using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental
{
    public class R_P_StopProcessBooking
    {
        public List<R_P_InvoiceStep> ListInvoiceHistoryStep { get; set; }
        public List<R_P_NextInvoiceStep> ListInvoiceNextStep { get; set; }
        public List<R_P_InvoiceStep> ListInvoiceStopStep { get; set; }

        public List<R_I_Image> ListImage { get; set; }

        public List<R_N_Task> ListN_Task { get; set; }

        public List<R_P_FinancialStep> ListFinHistoryStep { get; set; }
        public List<R_P_NextFinancialStep> ListFinNextStep { get; set; }
        public List<R_P_FinancialStep> ListFinStopStep { get; set; }

        public R_P_StopProcessBooking()
        {
            ListInvoiceHistoryStep = new List<R_P_InvoiceStep>();
            ListInvoiceNextStep = new List<R_P_NextInvoiceStep>();
            ListInvoiceStopStep = new List<R_P_InvoiceStep>();
            ListFinHistoryStep = new List<R_P_FinancialStep>();
            ListFinNextStep = new List<R_P_NextFinancialStep>();
            ListFinStopStep = new List<R_P_FinancialStep>();
            ListImage = new List<R_I_Image>();
            ListN_Task = new List<R_N_Task>();
        }
    }

    public class R_P_ReactiveBooking
    {
        public List<R_P_InvoiceStep> ListInvoiceStopStep { get; set; }
        public List<R_P_NextInvoiceStep> ListInvoiceNextStep { get; set; }
        public List<R_P_InvoiceStep> ListInvoiceReactivateStep { get; set; }
        public List<R_I_Image> ListImage { get; set; }

        public List<R_P_FinancialStep> ListFinancialReactivateStep { get; set; }
        public List<R_P_FinancialStep> ListFinancialStopStep { get; set; }
        public List<R_P_NextFinancialStep> ListFinancialNextStep { get; set; }
        public R_P_ReactiveBooking()
        {
            ListInvoiceStopStep = new List<R_P_InvoiceStep>();
            ListInvoiceNextStep = new List<R_P_NextInvoiceStep>();
            ListInvoiceReactivateStep = new List<R_P_InvoiceStep>();
            ListImage = new List<R_I_Image>();
            ListFinancialReactivateStep = new List<R_P_FinancialStep>();
            ListFinancialStopStep = new List<R_P_FinancialStep>();
            ListFinancialNextStep = new List<R_P_NextFinancialStep>();

        }
    }
}
