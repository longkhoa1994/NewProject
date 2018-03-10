using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyContact : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _salutation;
        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private string _cellPhone;
        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }
        private string _extensionNumber;
        public string ExtensionNumber
        {
            get { return _extensionNumber; }
            set { _extensionNumber = value; }
        }
        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        private string _skype;
        public string Skype
        {
            get { return _skype; }
            set { _skype = value; }
        }
        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int? _isSend;
        public int? IsSend
        {
            get { return _isSend; }
            set { _isSend = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }      
        public override string Table { get { return "M_CompanyContact"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyContact_InsertOrUpdate"; } }
    }
    public enum M_CompanyContactColumns
    {
        ID,
        M_CompanyID,
        Salutation,
        FirstName,
        LastName,
        PhoneNumber,
        CellPhone,
        ExtensionNumber,
        Position,
        Skype,
        Fax,
        Email,
        IsSend,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CompanyContactProcedure
    {
        p_M_CompanyContact_GetByCompanyID,
        p_M_CompanyContact_GetListByCompanyID,
        p_P_CompanyContact_GetList_ByCompanyID,
        P_P_CompanyContact_GetByCompany
    }

    public class M_CompanyContactList : List<M_CompanyContact>
    {
    }
}