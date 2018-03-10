using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Payment : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private int? _type;
        public int? Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string Table { get { return "M_Payment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Payment_InsertOrUpdate"; } }
    }
    public enum M_PaymentColumns
    {
        ID,
        Name,
        Description,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_PaymentProcedure
    {
        p_M_Payment_GetList_ByM_HotelID
    }
    public class M_PaymentList : List<M_Payment>
    {

    }
}