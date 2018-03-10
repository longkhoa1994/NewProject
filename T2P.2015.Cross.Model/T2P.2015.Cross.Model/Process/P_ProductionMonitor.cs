using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ProductionMonitor_CheckOuts
    {
        public long CheckoutsBooking { get; set; }
        public long MissingInvoice { get; set; }
        public long IncommingInvoice { get; set; }

        public List<P_ProductionMonitor_CheckOuts_Chart> ListCheckOuts { get; set; }
    }
    public class P_ProductionMonitor_CheckOuts_Chart
    {
        public string CheckoutDate { get; set; }
        public long CountBooking { get; set; }
        public long CountInvoice { get; set; }
    }

    public class P_ProductionMonitor_Invoice
    {
        public long PreProcessing { get; set; }
        public long Matching { get; set; }
        public long Unmatchable { get; set; }
        public P_ProductionMonitor_Invoice_Typing Typing { get; set; }
        public long Correction { get; set; }
    }

    public class P_ProductionMonitor_BillingEmail
    {
        public P_ProductionMonitor_BillingEmail_Information Information { get; set; }       
        public long Other { get; set; }      
    }

    public class P_ProductionMonitor_BillingEmail_Information
    {
        public long TotalProcessing { get; set; }
        public long TotalDone { get; set; }
    }

    public class P_ProductionMonitor_ServiceDesk
    {
        public long Priority_1 { get; set; }
        public long Priority_2 { get; set; }
        public long Priority_3 { get; set; }
        public long Priority_4 { get; set; }
        public long Priority_5 { get; set; }
    }

    public class P_ProductionMonitor_Invoice_Typing
    {
        public long Processing { get; set; }
        public long Delay { get; set; }      
    }

    public class P_ProductionMonitor_TotalRecord
    {
        public long TotalRecord { get; set; }
       
    }


    public enum P_ProductionMonitorProcedure {
        p_ProductionMonitor_Checkout,
        p_ProductionMonitor_InformationEmail,
        p_ProductionMonitor_InvoiceCorrection,
        p_ProductionMonitor_Matching,
        p_ProductionMonitor_OtherEmail,
        p_ProductionMonitor_PreProcessing,
        p_ProductionMonitor_Typing,
        p_ProductionMonitor_Unmatchable,
        p_ProductionMonitor_ServiceDesk
    }


    
}
