using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_Approval_Invoice_Data
    {
        public List<P_InvoiceError> ListInvoiceError { get; set; }
        public List<I_Position> ListService { get; set; }

        public P_Approval_Invoice_Data()
        {
            ListInvoiceError = new List<P_InvoiceError>();
            ListService = new List<I_Position>();
        }
    }

    public class P_Approval_Step
    {
        public P_NextInvoiceStep InvoiceNextStep { get; set; }
        public P_InvoiceStep InvoiceStep { get; set; }
        public P_NextBookingStep BookingNextStep { get; set; }

        public P_Approval_Step()
        {
            InvoiceNextStep = null;
            InvoiceStep = null;
            BookingNextStep = null;
        }
    }
}
