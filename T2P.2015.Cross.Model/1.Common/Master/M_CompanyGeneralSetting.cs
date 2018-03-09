using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyGeneralSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        //private long m_CompanyProcessID;

        //public long M_CompanyProcessID
        //{
        //    get { return m_CompanyProcessID; }
        //    set { m_CompanyProcessID = value; }
        //}

        private long _m_CompanyProcessDetailID;
        public long M_CompanyProcessDetailID
        {
            get { return _m_CompanyProcessDetailID; }
            set { _m_CompanyProcessDetailID = value; }
        }
        private long _captureCenterID;
        public long CaptureCenterID
        {
            get { return _captureCenterID; }
            set { _captureCenterID = value; }
        }
        private string _attribute;
        public string Attribute
        {
            get { return _attribute; }
            set { _attribute = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_CompanyGeneralSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyGeneralSetting_InsertOrUpdate"; } }
    }


    public class M_CompanyGeneralSetting_Gateway
    {
        public long M_CompanyProcessDetailID { get; set; }
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public long M_HotelPlatformID { get; set; }
        public string HotelPlatformName { get; set; }
        public long M_HotelPlatformSettingID { get; set; }
        public long M_FileLocationID { get; set; }
        public string Gateway_MailUsername { get; set; }
        public string Gateway_MailPassword { get; set; }
        public string MailServer { get; set; }
        public string AttachementFolderPath { get; set; }
        public string ImageFolderPath { get; set; }
        public int LimitFileSize { get; set; }

    }


    

    public enum M_CompanyGeneralSettingColumns
    {
        ID,
        //M_CompanyProcessID,
        M_CompanyProcessDetailID,
        CaptureCenterID,
        Attribute,
        Value,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyGeneralSettingProcedure
    {
        p_M_CompanyGeneralSetting_GetByCompanyProcessID,
        p_M_CompanyGeneralSetting_Get_Single,
        p_M_CompanyGeneralSetting_GetList_ByCompanyProcess,
        p_M_CompanyGeneralSetting_Gateway_GetSetting,
        p_M_CompanyGeneralSetting_GetBy_BookingAccessID,
        p_M_CompanyGeneralSetting_GetListByCompanyID_StepCode,
        p_M_CompanyGeneralSetting_GetBy_Attribute_Value,
        p_M_CompanyGeneralSetting_GetDefaultByCompanyID_StepCode,
        p_M_CompanyGeneralSetting_Delete_ByStep,
        p_M_CompanyGeneralSetting_Airbnb_GetSetting,
        p_M_CompanyGeneralSetting_GetByBAccessID,
        p_M_CompanyGeneralSetting_GetList_CompanyCode_ForCarRental,
        p_M_CompanyGeneralSetting_Get_ByImageID_ForFinalCheck,
        p_M_CompanyGeneralSetting_Get_ByM_CompanyProcessDetailID,


        // Used for Rental Car module
        p_R_M_CompanyGeneralSetting_Get_CheaperSetting_By_R_I_ImageID
    }
    public class M_CompanyGeneralSettingList : List<M_CompanyGeneralSetting>
    {

    }
}