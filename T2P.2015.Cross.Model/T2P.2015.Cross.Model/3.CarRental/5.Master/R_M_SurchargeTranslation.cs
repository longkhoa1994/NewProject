using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_SurchargeTranslation : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_M_SurchargeID;

        public long R_M_SurchargeID
        {
            get { return _r_M_SurchargeID; }
            set { _r_M_SurchargeID = value; }
        }

        private long _m_LanguageID;

        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }

        private string _serviceName;

        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }


        public override string Table { get { return "R_M_SurchargeTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_SurchargeTranslation_InsertOrUpdate"; } }
    }

    public enum R_M_SurchargeTranslationColumns
    {
        ID,
        R_M_SurchargeID,
        M_LanguageID,
        ServiceName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_M_SurchargeTranslationProcedure
    {
        p_R_M_SurchargeTranslationByLanguageID
    }

    public class R_M_SurchargeTranslationList : List<R_M_Surcharge>
    {
    }
}