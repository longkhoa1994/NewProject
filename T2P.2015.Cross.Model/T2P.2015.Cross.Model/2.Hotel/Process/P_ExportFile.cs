using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._2.Hotel.Financial.PaymentHub;
using T2P._2015.Cross.Model._7.PaymentProvider;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_ExportFile
    {
        public StringBuilder FileData { get; set; }
        public string ExportType { get; set; }
        public string FileName { get; set; }
        public F_ImportFile F_ImportFile { get; set; }
        public F_E_ExportFile F_E_ExportFile { get; set; }

        public List<F_E_ExportFileHistory> ListF_E_ExportFileHistory { get; set; }
        public P_ExportFile()
        {
            ListF_E_ExportFileHistory = new List<F_E_ExportFileHistory>();
        }
    }

    public class P_FileExport
    {
        public F_ImportFile F_ImportFile { get; set; }
        public M_F_FileType M_F_FileType { get; set; }

        public P_FileRecordExport P_FileRecordExport { get; set; }
        
    }
    public class P_FileRecordExport
    {
        public List<M_F_FileRecord> ListM_F_FileRecord { get; set; }
        public P_FileRecordFieldExport P_FileRecordFieldExport { get; set; }
        public P_FileRecordExport() 
        {
            ListM_F_FileRecord = new List<M_F_FileRecord>();
        }
    }

    public class P_FileRecordFieldExport
    {
        public List<M_F_RecordField> ListM_F_RecordField { get; set; }
        public P_FileRecordFieldExport()
        {
            ListM_F_RecordField = new List<M_F_RecordField>();
        }
    }




    public class P_Export_GL1076_File
    {
        public F_E_GL1076_FH F_E_GL1076_FH { get; set; }
        public F_E_GL1076_FT F_E_GL1076_FT { get; set; }

        public List<F_E_GL1076_FH_Market> ListF_E_GL1076_FH_Market { get; set; }

        public long F_ImportFileID { get; set; }

        public P_Export_GL1076_File()
        {
            ListF_E_GL1076_FH_Market = new List<F_E_GL1076_FH_Market>();
        }
    }

    [Serializable]
    public class F_E_GL1076_FH_Market
    {
        public F_E_GL1076_00 F_E_GL1076_00 { get; set; }
        public List<F_E_GL1076_FH_Transaction> ListF_E_GL1076_FH_Transaction { get; set; }

        public F_E_GL1076_FH_Market()
        {
            ListF_E_GL1076_FH_Transaction = new List<F_E_GL1076_FH_Transaction>();
        }
        public long F_HeaderID { get; set; }
    }

    [Serializable]
    public class F_E_GL1076_FH_Transaction
    {
        public object Parent { get; set; }
        public string TransactionType { get; set; }
        public FINStructure BookingInformation { get; set; }
        //02 .. 30
        public F_E_GL1076_01 F_E_GL1076_01 { get; set; }
        public F_E_GL1076_02 F_E_GL1076_02 { get; set; }
        public F_E_GL1076_03 F_E_GL1076_03 { get; set; }
        public F_E_GL1076_04 F_E_GL1076_04 { get; set; }
        public F_E_GL1076_05 F_E_GL1076_05 { get; set; }
        public F_E_GL1076_30 F_E_GL1076_30 { get; set; }
        public F_E_GL1076_FH_Position F_E_GL1076_FH_Position { get; set; }
        public List<F_E_GL1076_FH_Position1> ListPositions { get; set; }
        public F_E_GL1076_FH_Transaction()
        {
            F_E_GL1076_FH_Position = new F_E_GL1076_FH_Position();
            ListPositions = new List<F_E_GL1076_FH_Position1>();
        }
        public long F_TransactionID { get; set; }
    }

    [Serializable]
    public class F_E_GL1076_FH_Position1
    {
        public object Parent { get; set; }
        //10 .. 12
        public F_E_GL1076_10 F_E_GL1076_10 { get; set; }
        public F_E_GL1076_11 F_E_GL1076_11 { get; set; }
        public F_E_GL1076_12 F_E_GL1076_12 { get; set; }

        public F_E_GL1076_FH_Position1()
        {
            F_E_GL1076_10 = new F_E_GL1076_10();
            F_E_GL1076_11 = new F_E_GL1076_11();
            F_E_GL1076_12 = new F_E_GL1076_12();
        }
    }
    [Serializable]
    public class F_E_GL1076_FH_Position
    {
        //10 .. 12
        public List<F_E_GL1076_10> List_F_E_GL1076_10 { get; set; }
        public List<F_E_GL1076_11> List_F_E_GL1076_11 { get; set; }
        public List<F_E_GL1076_12> List_F_E_GL1076_12 { get; set; }

        public F_E_GL1076_FH_Position()
        {
            List_F_E_GL1076_10 = new List<F_E_GL1076_10>();
            List_F_E_GL1076_11 = new List<F_E_GL1076_11>();
            List_F_E_GL1076_12 = new List<F_E_GL1076_12>();
        }
    }
}
