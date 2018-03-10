using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._2.Hotel.Booking;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class F_TamaraTransaction : BaseModel
    {
        public long ID { get; set; }
        public long F_TamaraFileID { get; set; }
        public string RecordType { get; set; }
        public string TransactionType { get; set; }
        public string CardNumber { get; set; }
        public int DocumentNumberFormat { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string TravellerName { get; set; }
        public string TransactionSign { get; set; }
        public decimal TransactionAmount { get; set; }
        public string AgencyDeliveryNoteNumber { get; set; }
        public string DBI_PK { get; set; }
        public string DBI_DS { get; set; }
        public string DBI_KS { get; set; }
        public string DBI_AE { get; set; }
        public string DBI_IK { get; set; }
        public string DBI_BD { get; set; }
        public string DBI_PR { get; set; }
        public string DBI_AU { get; set; }
        public string DBI_AK { get; set; }
        public string DBI_RZ { get; set; }
        public string Filler3 { get; set; }
        public string ServiceDescription { get; set; }
        public int UsageCode { get; set; }
        public string SICCode { get; set; }
        public F_TamaraTransaction()
        {
            RecordType = "D";
            TransactionType = "H";
            CardNumber = string.Empty;
            DocumentNumberFormat = 3;
            DocumentNumber = string.Empty;
            PurchaseDate = null;
            TravellerName = string.Empty;
            TransactionSign = "+";
            TransactionAmount = 0;
            AgencyDeliveryNoteNumber = string.Empty;
            DBI_PK = string.Empty;
            DBI_DS = string.Empty;
            DBI_KS = string.Empty;
            DBI_AE = string.Empty;
            DBI_IK = string.Empty;
            DBI_BD = string.Empty;
            DBI_PR = string.Empty;
            DBI_AU = string.Empty;
            DBI_AK = string.Empty;
            DBI_RZ = string.Empty;
            Filler3 = string.Empty;
            ServiceDescription = string.Empty;
            UsageCode = 2;
            SICCode = string.Empty;
        }

        public F_TamaraTransaction(B_DBIExtension dbi)
        {
            RecordType = "D";
            TransactionType = "H";
            CardNumber = string.Empty;
            DocumentNumberFormat = 3;
            DocumentNumber = string.Empty;
            PurchaseDate = null;
            TransactionSign = "+";
            TransactionAmount = 0;
            AgencyDeliveryNoteNumber = string.Empty;
            Filler3 = string.Empty;
            ServiceDescription = string.Empty;
            UsageCode = 2;
            SICCode = string.Empty;

            TravellerName = !string.IsNullOrEmpty(dbi.TravellerName) ? dbi.TravellerName : string.Empty;
            DBI_PK = !string.IsNullOrEmpty(dbi.EmployeeNo_PK) ? dbi.EmployeeNo_PK : string.Empty;
            DBI_DS = !string.IsNullOrEmpty(dbi.DepartmentNo_DS) ? dbi.DepartmentNo_DS : string.Empty;
            DBI_KS = !string.IsNullOrEmpty(dbi.CostCenter_KS) ? dbi.CostCenter_KS : string.Empty;
            DBI_AE = !string.IsNullOrEmpty(dbi.AccountingUnit_AE) ? dbi.AccountingUnit_AE : string.Empty;
            DBI_IK = !string.IsNullOrEmpty(dbi.InternalAccount_IK) ? dbi.InternalAccount_IK : string.Empty;
            DBI_BD = dbi.ProcessingDate_BD.HasValue ? dbi.ProcessingDate_BD.Value.ToString("yyyyMMdd") : string.Empty;
            DBI_PR = !string.IsNullOrEmpty(dbi.ProjectNo_PR) ? dbi.ProjectNo_PR : string.Empty;
            DBI_AU = !string.IsNullOrEmpty(dbi.OrderNo_AU) ? dbi.OrderNo_AU : string.Empty;
            DBI_AK = !string.IsNullOrEmpty(dbi.ActionNo_AK) ? dbi.ActionNo_AK : string.Empty; ;
            DBI_RZ = !string.IsNullOrEmpty(dbi.FinalDestination_RZ) ? dbi.FinalDestination_RZ : string.Empty;
        }
        public override string Table { get { return "F_TamaraTransaction"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TamaraTransaction_InsertOrUpdate"; } }
    }
    public enum F_TamaraTransactionColumns
    {
        ID,
        F_TamaraFileID,
        RecordType,
        TransactionType,
        CardNumber,
        ExpriryDate,
        Filler,
        DocumentNumberFormat,
        DocumentNumber,
        PurchaseDate,
        TravellerName,
        Filler1,
        TransactionSerialNumber,
        TransactionCurrencyCode,
        TransactionSign,
        TransactionAmount,
        Filler2,
        NetAmountNonVAT,
        NetAmountVAT,
        VATAmount,
        VATPercentage,
        VATInd,
        Filler2_MA1,
        ApprovalCode,
        MerchantName,
        Filler2_MA2,
        MerchantIATANumber,
        MerchantInvoiceNumber,
        MerchantOrderNumber,
        MerchantCustomerNumber,
        AgencyDossierNumber,
        AgencyDeliveryNoteNumber,
        DBI_PK,
        DBI_DS,
        DBI_KS,
        DBI_AE,
        DBI_IK,
        DBI_BD,
        DBI_PR,
        DBI_AU,
        DBI_AK,
        DBI_RZ,
        Filler3,
        ServiceDescription,
        UsageCode,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TamaraTransactionProcedure
    {

    }
    public class F_TamaraTransactionList : List<F_TamaraTransaction>
    {

    }
}