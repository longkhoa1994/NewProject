using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CarGroup : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _carGroup;
        public string CarGroup
        {
            get { return _carGroup; }
            set { _carGroup = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "R_M_CarGroup"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CarGroup_InsertOrUpdate"; } }
    }
    public enum R_M_CarGroupColumns
    {
        ID,
        CarGroup,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CarGroupProcedure
    {
        p_R_M_CarGroup_Get_Id_By_Code,
        p_R_M_CarGroup_Get_By_R_RG_RateGridID
    }
    public class R_M_CarGroupList : List<R_M_CarGroup>
    {

    }
}