using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class F_TamaraHeader : BaseModel
    {
        public long ID { get; set; }
        public long F_TamaraFileID { get; set; }
        public string RecordType { get; set; }
        public string FileType { get; set; }
        public string PartnerId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public string Version { get; set; }
        public string Release { get; set; }
        public string CountryCode { get; set; }
        public string AcquirerPrefix { get; set; }
        public string AcquirerProcessingPage { get; set; }
        public string CreditCardInd { get; set; }
        public string SICCode { get; set; }
        public string FileId { get; set; }

        public F_TamaraHeader()
        {
            RecordType = "H";
            PartnerId = string.Empty;
            ProcessingDate = DateTime.Now;
            Version = "V01.40";
            Release = string.Empty;
            CountryCode = "DE";
            AcquirerPrefix = "LASG";
            CreditCardInd = "TP";
            SICCode = string.Empty;

            FileId = Guid.NewGuid().ToString("N").Substring(2);
        }

        public override string Table { get { return "F_TamaraHeader"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TamaraHeader_InsertOrUpdate"; } }
    }
    public enum F_TamaraHeaderColumns
    {
        ID,
        F_TamaraFileID,
        RecordType,
        FileType,
        PartnerId,
        ProcessingDate,
        Version,
        Release,
        CountryCode,
        AcquirerPrefix,
        AcquirerProcessingPage,
        CreditCardInd,
        FileId,
        BosId,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TamaraHeaderProcedure
    {

    }
    public class F_TamaraHeaderList : List<F_TamaraHeader>
    {

    }
}
