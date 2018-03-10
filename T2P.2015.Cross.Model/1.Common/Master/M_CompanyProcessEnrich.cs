using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._1.Common.Master
{
    [Serializable]
    public class M_CompanyProcessEnrich : BaseModel
    {
        public long ID { get; set; }
        public long M_CompanyProcessID { get; set; }
        public string SettingType { get; set; }
        public string DeliveryFequency { get; set; }
        public string DeliveryDate { get; set; }
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string DeliveryType { get; set; }
        public float? ExpireDate { get; set; }
        public string ServiceType { get; set; }
        public string LinkServer { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public string Path { get; set; }
        public string EmailAddress { get; set; }
        public string PathError { get; set; }
        public string Key { get; set; }
        public string Encryption { get; set; }

        public override string Table { get { return "M_CompanyProcessEnrich"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyProcessEnrich_InsertOrUpdate"; } }
    }
    public enum M_CompanyProcessEnrichColumns
    {
        ID,
        M_CompanyProcessID,
        DeliveryFequency,
        DeliveryDate,
        DeliveryTime,
        DeliveryType,
        ExpireDate,
        ServiceType,
        LinkServer,
        UserName,
        Password,
        Port,
        Path,
        PathError,
        Key,
        Encryption,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyProcessEnrichProcedure
    {
        p_M_CompanyProcessEnrich_GetByM_CompanyProcessID
    }
}
