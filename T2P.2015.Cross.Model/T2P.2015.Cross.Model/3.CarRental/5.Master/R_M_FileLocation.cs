using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_FileLocation : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CarRentalProviderID;
        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }
        private string _iP;
        public string IP
        {
            get { return _iP; }
            set { _iP = value; }
        }
        private string _iISPath;
        public string IISPath
        {
            get { return _iISPath; }
            set { _iISPath = value; }
        }
        private bool _isDefault;
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        public override string Table { get { return "R_M_FileLocation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_FileLocation_InsertOrUpdate"; } }
    }
    public enum R_M_FileLocationColumns
    {
        ID,
        M_CarRentalProviderID,
        IP,
        IISPath,
        IsDefault,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_FileLocationProcedure
    {
        p_R_M_FileLocation_Get_By_M_CarRentalProviderID,
        p_R_M_FileLocation_Get_By_M_CarRentalProviderSettingID,

    }
    public class R_M_FileLocationList : List<R_M_FileLocation>
    {

    }
}