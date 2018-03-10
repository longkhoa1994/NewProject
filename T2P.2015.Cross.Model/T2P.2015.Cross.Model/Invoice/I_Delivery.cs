using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Delivery : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string Table { get { return "I_Delivery"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Delivery_InsertOrUpdate"; } }
    }
    public enum I_DeliveryColumns
    {
        ID,
        M_FileLocationID,
        FilePath,
        FileName,
        Message,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_DeliveryProcedure
    {
        p_I_Delivery_GetListForDeleting,
    }
    public class I_DeliveryList : List<I_Delivery>
    {

    }
}