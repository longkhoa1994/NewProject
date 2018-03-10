using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial
{
    public class F_TransactionEnriched : BaseModel
    {
        public long ID { get; set; }
        public long F_TransactionID { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string HotelVATNo { get; set; }
        public string ItemNo { get; set; }
        public string OriginalServiceDes { get; set; }
        public bool IsSendPartner { get; set; }
        public bool IsSendCustomer { get; set; }
        public string ServiceCode { get; set; }
        public string ExtendedServiceDes { get; set; }
        public DateTime? ServiceDate { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? Net { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public long? FinancialID { get; set; }
        public string ReservationNumber { get; set; }
        public override string Table { get { return "F_TransactionEnriched"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TransactionEnriched_InsertOrUpdate"; } }
    }
    public class F_TransactionEnrichedExtend : F_TransactionEnriched
    {
        public long M_CompanyProcessID { get; set; }
    }
    public enum F_TransactionEnrichedProcedure
    {
        p_CFM_GetData_EnrichFIN,
        p_CFM_GetData_ExportCSV
    }
    
}
