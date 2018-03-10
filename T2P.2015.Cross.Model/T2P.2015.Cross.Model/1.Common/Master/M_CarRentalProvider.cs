using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CarRentalProvider : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _logo;

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _emailCC;

        public string EmailCC
        {
            get { return _emailCC; }
            set { _emailCC = value; }
        }


        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private long _bufferTime;

        public long BufferTime
        {
            get { return _bufferTime; }
            set { _bufferTime = value; }
        }

        public override string Table { get { return "M_CarRentalProvider"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CarRentalProvider_InsertOrUpdate"; } }
    }
    public enum M_CarRentalProviderColumns
    {
        ID,
        M_CountryID,
        Name,
        Code,
        Description,
        Logo,
        Email,
        EmailCC,
        Phone,
        BufferTime,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CarRentalProviderProcedure
    {
        p_M_CarRentalProvider_GetByUserID,
        p_M_CarRentalProvider_GetBy_R_I_ImageID,
    }
    public class M_CarRentalProviderList : List<M_CarRentalProvider>
    {

    }
}