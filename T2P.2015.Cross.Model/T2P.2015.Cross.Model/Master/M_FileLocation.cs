using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_FileLocation : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_HotelPlatfomID;

        public long M_HotelPlatfomID
        {
            get { return _m_HotelPlatfomID; }
            set { _m_HotelPlatfomID = value; }
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

        public override string Table { get { return "M_FileLocation"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_FileLocation_InsertOrUpdate"; } }
    }

    public enum M_FileLocationColumns
    {
        ID,
        M_HotelPlatfomID,
        IP,
        IISPath,
        IsDefault,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_FileLocationProcedure
    {
        p_M_FileLocation_Get_byHotelPlatfomName,
        p_M_FileLocation_Get_byHotelPlatfomID,
        p_M_FileLocation_GetByM_HotelPlatformSettingID,
        p_M_FileLocation_Get_IISPathLogo
    }

    public class M_FileLocationList : List<M_FileLocation>
    {
    }
    public class M_FileLocationExtend : M_FileLocation
    {
        private string _iISHotelLogo;
        public string IISHotelLogo
        {
            get { return _iISHotelLogo; }
            set { _iISHotelLogo = value; }
        }
        private string _iIST2PLogo;
        public string IIST2PLogo
        {
            get { return _iIST2PLogo; }
            set { _iIST2PLogo = value; }
        }
        private string _iISAirPlusLogo;
        public string IISAirPlusLogo
        {
            get { return _iISAirPlusLogo; }
            set { _iISAirPlusLogo = value; }
        }
    }
}