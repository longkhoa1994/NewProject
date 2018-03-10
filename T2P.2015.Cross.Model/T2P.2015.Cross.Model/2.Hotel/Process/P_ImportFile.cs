using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._7.PaymentProvider;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_Import_GL1076_File
    {
        public F_I_GL1076_FH F_I_GL1076_FH { get; set; }
        public F_I_GL1076_FT F_I_GL1076_FT { get; set; }
        public List<F_I_GL1076_FH_Market> ListF_I_GL1076_FH_Market { get; set; }

        public P_Import_GL1076_File()
        {
            ListF_I_GL1076_FH_Market = new List<F_I_GL1076_FH_Market>();
        }
    }

    public class F_I_GL1076_FH_Market
    {
        public F_I_GL1076_00 F_I_GL1076_00 { get; set; }
        public List<F_I_GL1076_FH_Transaction> ListF_I_GL1076_FH_Transaction { get; set; }

        public F_Header F_Header { get; set; }

        public F_I_GL1076_FH_Market()
        {
            ListF_I_GL1076_FH_Transaction = new List<F_I_GL1076_FH_Transaction>();
        }
    }
    [Serializable]
    public class F_I_GL1076_FH_Transaction
    {
        public FINStructure BookingInformation { get; set; }
        public string TransactionType { get; set; }
        //01 .. 30 
        public F_I_GL1076_01 F_I_GL1076_01 { get; set; }
        public F_I_GL1076_02 F_I_GL1076_02 { get; set; }
        public F_I_GL1076_03 F_I_GL1076_03 { get; set; }
        public F_I_GL1076_04 F_I_GL1076_04 { get; set; }
        public F_I_GL1076_05 F_I_GL1076_05 { get; set; }
        public F_I_GL1076_30 F_I_GL1076_30 { get; set; }
        public F_I_GL1076_FH_Position ListF_I_GL1076_FH_Position { get; set; }
        public F_Transaction F_Transaction { get; set; }
        public P_NextFinancialStep nextTransactionStep { get; set; }
        public List<F_I_GL1076_FH_Position1> ListPositions { get; set; }
        public F_I_GL1076_FH_Transaction()
        {
            ListF_I_GL1076_FH_Position = new F_I_GL1076_FH_Position();
            ListPositions = new List<F_I_GL1076_FH_Position1>();
        }
    }
    [Serializable]
    public class F_I_GL1076_FH_Position1
    {
        public object Parent { get; set; }
        //10 .. 12
        public F_I_GL1076_10 F_I_GL1076_10 { get; set; }
        public F_I_GL1076_11 F_I_GL1076_11 { get; set; }
        public F_I_GL1076_12 F_I_GL1076_12 { get; set; }

        public F_I_GL1076_FH_Position1()
        {
            F_I_GL1076_10 = new F_I_GL1076_10();
            F_I_GL1076_11 = new F_I_GL1076_11();
            F_I_GL1076_12 = new F_I_GL1076_12();
        }
    }
    [Serializable]
    public class F_I_GL1076_FH_Position
    {
        //10 .. 12
        public List<F_I_GL1076_10> List_F_I_GL1076_10 { get; set; }
        public List<F_I_GL1076_11> List_F_I_GL1076_11 { get; set; }
        public List<F_I_GL1076_12> List_F_I_GL1076_12 { get; set; }

        public F_I_GL1076_FH_Position()
        {
            List_F_I_GL1076_10 = new List<F_I_GL1076_10>();
            List_F_I_GL1076_11 = new List<F_I_GL1076_11>();
            List_F_I_GL1076_12 = new List<F_I_GL1076_12>();
        }
    }
}
