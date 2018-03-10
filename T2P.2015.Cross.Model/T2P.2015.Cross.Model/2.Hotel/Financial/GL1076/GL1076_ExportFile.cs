using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.GL1076
{
    public class GL1076_ExportFile
    {
        public F_E_GL1076_FH FileHeader { get; set; }
        public F_E_GL1076_FT FileTrailer { get; set; }
        public List<GL1076_E_Market> ListMarket { get; set; }

        public GL1076_ExportFile()
        {
            ListMarket = new List<GL1076_E_Market>();
        }
    }

    public class GL1076_E_Market
    {
        public F_E_GL1076_00 ClientMarket { get; set; }
        public List<GL1076_E_Transaction> ListTransaction { get; set; }

        public F_Header F_Header { get; set; }

        public GL1076_E_Market()
        {
            ListTransaction = new List<GL1076_E_Transaction>();
        }
    }
    [Serializable]
    public class GL1076_E_Transaction
    {
        //public FINStructure BookingInformation { get; set; }
        //public string TransactionType { get; set; }
        //01 .. 30 
        public F_E_GL1076_01 TransactionDetail { get; set; }
        public F_E_GL1076_02 TransactionTaxSummary { get; set; }
        public F_E_GL1076_03 PreAuthorizationData { get; set; }
        public F_E_GL1076_04 PreAuthorizationUserDefinedFields { get; set; }
        public F_E_GL1076_05 PreAuthorizationAccountingFields { get; set; }
        public F_E_GL1076_30 ServiceEstablishmentInformation { get; set; }
        //public GL1076_E_Position ListPosition { get; set; }
        public F_Transaction F_Transaction { get; set; }
        public P_NextFinancialStep nextTransactionStep { get; set; }
        public List<GL1076_E_Position> ListPosition { get; set; }
        public GL1076_E_Transaction()
        {
            ListPosition = new List<GL1076_E_Position>();
        }
    }
    [Serializable]
    public class GL1076_E_Position
    {
        public object Parent { get; set; }
        //10 .. 12
        public F_E_GL1076_10 BasicLineItemDetail { get; set; }
        public F_E_GL1076_11 LineItemDetailTax { get; set; }
        public F_E_GL1076_12 LineItemDetailProperties { get; set; }

        public GL1076_E_Position()
        {
            BasicLineItemDetail = new F_E_GL1076_10();
            LineItemDetailTax = new F_E_GL1076_11();
            LineItemDetailProperties = new F_E_GL1076_12();
        }
    }

    //[Serializable]
    //public class GL1076_E_Position
    //{
    //    //10 .. 12
    //    public List<F_E_GL1076_10> ListBasicLineItemDetail { get; set; }
    //    public List<F_E_GL1076_11> ListLineItemDetailTax { get; set; }
    //    public List<F_E_GL1076_12> ListLineItemDetailProperties { get; set; }

    //    public GL1076_E_Position()
    //    {
    //        ListBasicLineItemDetail = new List<F_E_GL1076_10>();
    //        ListLineItemDetailTax = new List<F_E_GL1076_11>();
    //        ListLineItemDetailProperties = new List<F_E_GL1076_12>();
    //    }
    //}
}
