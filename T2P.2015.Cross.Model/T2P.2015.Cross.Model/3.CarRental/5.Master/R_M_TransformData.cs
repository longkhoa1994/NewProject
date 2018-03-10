using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_TransformData : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _serviceTemplate;

        public string ServiceTemplate
        {
            get { return _serviceTemplate; }
            set { _serviceTemplate = value; }
        }

        private string _serviceTranslation;

        public string ServiceTranslation
        {
            get { return _serviceTranslation; }
            set { _serviceTranslation = value; }
        }
        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _errorServiceCode;

        public string ErrorServiceCode
        {
            get { return _errorServiceCode; }
            set { _errorServiceCode = value; }
        }

        private string _columnCode;

        public string ColumnCode
        {
            get { return _columnCode; }
            set { _columnCode = value; }
        }

        private int _columnIndex;

        public int ColumnIndex
        {
            get { return _columnIndex; }
            set { _columnIndex = value; }
        }

        private string _serviceTemplateRemoveSpecial;

        public string ServiceTemplateRemoveSpecial
        {
            get { return _serviceTemplateRemoveSpecial; }
            set { _serviceTemplateRemoveSpecial = value; }
        }
        public override string Table { get { return "R_M_TransformData"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_TransformData_InsertOrUpdate"; } }
    }
    public enum R_M_TransformDataColumns
    {
        ID,
        ServiceTemplate,
        ServiceTranslation,
        ServiceCode,
        ColumnIndex,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_TransformDataProcedure
    {
    }
    public class R_M_TransformDataList : List<R_M_TransformData>
    {

    }
}