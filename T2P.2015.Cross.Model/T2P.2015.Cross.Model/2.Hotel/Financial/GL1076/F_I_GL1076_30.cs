using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_30 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }

        private long _f_I_GL1076_01ID;

        public long F_I_GL1076_01ID
        {
            get { return _f_I_GL1076_01ID; }
            set { _f_I_GL1076_01ID = value; }
        }

        private string _serviceEstablishmentNumber;
        public string ServiceEstablishmentNumber
        {
            get { return _serviceEstablishmentNumber; }
            set { _serviceEstablishmentNumber = value; }
        }
        private string _serviceEstablishmentName1;
        public string ServiceEstablishmentName1
        {
            get { return _serviceEstablishmentName1; }
            set { _serviceEstablishmentName1 = value; }
        }
        private string _serviceEstablishmentName2;
        public string ServiceEstablishmentName2
        {
            get { return _serviceEstablishmentName2; }
            set { _serviceEstablishmentName2 = value; }
        }
        private string _serviceEstablishmentAddress1;
        public string ServiceEstablishmentAddress1
        {
            get { return _serviceEstablishmentAddress1; }
            set { _serviceEstablishmentAddress1 = value; }
        }
        private string _serviceEstablishmentAddress2;
        public string ServiceEstablishmentAddress2
        {
            get { return _serviceEstablishmentAddress2; }
            set { _serviceEstablishmentAddress2 = value; }
        }
        private string _serviceEstablishmentAddress3;
        public string ServiceEstablishmentAddress3
        {
            get { return _serviceEstablishmentAddress3; }
            set { _serviceEstablishmentAddress3 = value; }
        }
        private string _serviceEstablishmentCityName;
        public string ServiceEstablishmentCityName
        {
            get { return _serviceEstablishmentCityName; }
            set { _serviceEstablishmentCityName = value; }
        }
        private string _serviceEstablishmentCountyName;
        public string ServiceEstablishmentCountyName
        {
            get { return _serviceEstablishmentCountyName; }
            set { _serviceEstablishmentCountyName = value; }
        }
        private string _serviceEstablishmentStateProvinceCode;
        public string ServiceEstablishmentStateProvinceCode
        {
            get { return _serviceEstablishmentStateProvinceCode; }
            set { _serviceEstablishmentStateProvinceCode = value; }
        }
        private string _serviceEstablishmentPostalCode;
        public string ServiceEstablishmentPostalCode
        {
            get { return _serviceEstablishmentPostalCode; }
            set { _serviceEstablishmentPostalCode = value; }
        }
        private string _serviceEstablishmentCountryCode;
        public string ServiceEstablishmentCountryCode
        {
            get { return _serviceEstablishmentCountryCode; }
            set { _serviceEstablishmentCountryCode = value; }
        }
        private string _serviceEstablishmentCountryName;
        public string ServiceEstablishmentCountryName
        {
            get { return _serviceEstablishmentCountryName; }
            set { _serviceEstablishmentCountryName = value; }
        }
        private string _serviceEstablishmentTelephone;
        public string ServiceEstablishmentTelephone
        {
            get { return _serviceEstablishmentTelephone; }
            set { _serviceEstablishmentTelephone = value; }
        }
        private string _serviceEstablishmentChainCode;
        public string ServiceEstablishmentChainCode
        {
            get { return _serviceEstablishmentChainCode; }
            set { _serviceEstablishmentChainCode = value; }
        }
        private string _genesisMajorIndustryCode;
        public string GenesisMajorIndustryCode
        {
            get { return _genesisMajorIndustryCode; }
            set { _genesisMajorIndustryCode = value; }
        }
        private string _genesisSubIndustryCode;
        public string GenesisSubIndustryCode
        {
            get { return _genesisSubIndustryCode; }
            set { _genesisSubIndustryCode = value; }
        }
        private string _serviceEstablishmentPurchaseCardIndicator;
        public string ServiceEstablishmentPurchaseCardIndicator
        {
            get { return _serviceEstablishmentPurchaseCardIndicator; }
            set { _serviceEstablishmentPurchaseCardIndicator = value; }
        }
        private string _serviceEstablishmentMinorityCode;
        public string ServiceEstablishmentMinorityCode
        {
            get { return _serviceEstablishmentMinorityCode; }
            set { _serviceEstablishmentMinorityCode = value; }
        }
        private string _serviceEstablishmentTaxIdentifier;
        public string ServiceEstablishmentTaxIdentifier
        {
            get { return _serviceEstablishmentTaxIdentifier; }
            set { _serviceEstablishmentTaxIdentifier = value; }
        }
        private string _standardIndustryClassificationCode;
        public string StandardIndustryClassificationCode
        {
            get { return _standardIndustryClassificationCode; }
            set { _standardIndustryClassificationCode = value; }
        }
        private string _dunBradstreetNumber;
        public string DunBradstreetNumber
        {
            get { return _dunBradstreetNumber; }
            set { _dunBradstreetNumber = value; }
        }
        private string _serviceEstablishmentCorporateStatusCode;
        public string ServiceEstablishmentCorporateStatusCode
        {
            get { return _serviceEstablishmentCorporateStatusCode; }
            set { _serviceEstablishmentCorporateStatusCode = value; }
        }
        private string _filler1;
        public string Filler1
        {
            get { return _filler1; }
            set { _filler1 = value; }
        }
        private string _serviceEstablishmentChainName;
        public string ServiceEstablishmentChainName
        {
            get { return _serviceEstablishmentChainName; }
            set { _serviceEstablishmentChainName = value; }
        }
        private string _serviceEstablishmentBrandName;
        public string ServiceEstablishmentBrandName
        {
            get { return _serviceEstablishmentBrandName; }
            set { _serviceEstablishmentBrandName = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }

        public override string Table { get { return "F_I_GL1076_30"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_30_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_30Columns
    {
        ID,
        RecordType,
        F_I_GL1076_01ID,
        ServiceEstablishmentNumber,
        ServiceEstablishmentName1,
        ServiceEstablishmentName2,
        ServiceEstablishmentAddress1,
        ServiceEstablishmentAddress2,
        ServiceEstablishmentAddress3,
        ServiceEstablishmentCityName,
        ServiceEstablishmentCountyName,
        ServiceEstablishmentStateProvinceCode,
        ServiceEstablishmentPostalCode,
        ServiceEstablishmentCountryCode,
        ServiceEstablishmentCountryName,
        ServiceEstablishmentTelephone,
        ServiceEstablishmentChainCode,
        GenesisMajorIndustryCode,
        GenesisSubIndustryCode,
        ServiceEstablishmentPurchaseCardIndicator,
        ServiceEstablishmentMinorityCode,
        ServiceEstablishmentTaxIdentifier,
        StandardIndustryClassificationCode,
        DunBradstreetNumber,
        ServiceEstablishmentCorporateStatusCode,
        Filler1,
        ServiceEstablishmentChainName,
        ServiceEstablishmentBrandName,
        Filler2,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_30Procedure
    {
        p_F_I_GL1076_30_Get_By_F_I_GL_1076_01ID,
        p_F_I_GL1076_30_Get_By_F_TransactionID
    }
    public class F_I_GL1076_30List : List<F_I_GL1076_30>
    {

    }
}