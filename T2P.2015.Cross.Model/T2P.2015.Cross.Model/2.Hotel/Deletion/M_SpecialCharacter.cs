using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Deletion
{
    public class M_SpecialCharacter : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _binary;
        public string Binary
        {
            get { return _binary; }
            set { _binary = value; }
        }
        private string _hexadecimal;
        public string Hexadecimal
        {
            get { return _hexadecimal; }
            set { _hexadecimal = value; }
        }
        private string _unicodeCharacters;
        public string UnicodeCharacters
        {
            get { return _unicodeCharacters; }
            set { _unicodeCharacters = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public override string Table { get { return "M_SpecialCharacter"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_SpecialCharacter_InsertOrUpdate"; } }
    }
    public enum M_SpecialCharacterColumns
    {
        ID,
        Binary,
        Hexadecimal,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_SpecialCharacterProcedure
    {
        p_P_M_SpecialCharacter_CheckExistSpecial
    }
    public enum InsertOrUpdateSpecialCharacter
    {
        p_P_N_Task_CheckExistSpecialCharacter,
        p_P_N_Task_InsertOrUpdate_SpecialCharacter
    }
}
