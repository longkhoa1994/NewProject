using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ForwardLine : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_ForwardID;
        public long I_ForwardID
        {
            get { return _i_ForwardID; }
            set { _i_ForwardID = value; }
        }
        private long _i_ImageID;
        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private string _tiffFileName;
        public string TiffFileName
        {
            get { return _tiffFileName; }
            set { _tiffFileName = value; }
        }
        public override string Table { get { return "I_ForwardLine"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_ForwardLine_InsertOrUpdate"; } }
    }
    public enum I_ForwardLineColumns
    {
        ID,
        I_ForwardID,
        I_ImageID,
        TiffFileName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_ForwardLineProcedure
    {
        p_I_ForwardLine_Get_ByI_ImageID,
        p_I_ForwardLine_GetListByListImageID,
        p_I_ForwardLine_GetListForDeleting,
    }
    public class I_ForwardLineList : List<I_ForwardLine>
    {

    }
}