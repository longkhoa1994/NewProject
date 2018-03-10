using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_12 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }

        private long _f_I_GL1076_01ID;

        public long F_I_GL1076_01ID
        {
            get { return _f_I_GL1076_01ID; }
            set { _f_I_GL1076_01ID = value; }
        }

        private string _lIDTransactionID;
        public string LIDTransactionID
        {
            get { return _lIDTransactionID; }
            set { _lIDTransactionID = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private int? _lIDLineID;
        public int? LIDLineID
        {
            get { return _lIDLineID; }
            set { _lIDLineID = value; }
        }
        private int? _lineIdentifier;
        public int? LineIdentifier
        {
            get { return _lineIdentifier; }
            set { _lineIdentifier = value; }
        }
        private string _requisitionNumber;
        public string RequisitionNumber
        {
            get { return _requisitionNumber; }
            set { _requisitionNumber = value; }
        }
        private string _packingSlipNumber;
        public string PackingSlipNumber
        {
            get { return _packingSlipNumber; }
            set { _packingSlipNumber = value; }
        }
        private string _serialNumber;
        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }
        private string _clientMaterialNumber;
        public string ClientMaterialNumber
        {
            get { return _clientMaterialNumber; }
            set { _clientMaterialNumber = value; }
        }
        private string _clientAssetCode;
        public string ClientAssetCode
        {
            get { return _clientAssetCode; }
            set { _clientAssetCode = value; }
        }
        private string _customerReferenceNumber;
        public string CustomerReferenceNumber
        {
            get { return _customerReferenceNumber; }
            set { _customerReferenceNumber = value; }
        }
        private string _trackingNumber;
        public string TrackingNumber
        {
            get { return _trackingNumber; }
            set { _trackingNumber = value; }
        }
        private string _mSDSNumber;
        public string MSDSNumber
        {
            get { return _mSDSNumber; }
            set { _mSDSNumber = value; }
        }
        private string _chemicalAbstractsSvcNumber;
        public string ChemicalAbstractsSvcNumber
        {
            get { return _chemicalAbstractsSvcNumber; }
            set { _chemicalAbstractsSvcNumber = value; }
        }
        private string _divisionCode;
        public string DivisionCode
        {
            get { return _divisionCode; }
            set { _divisionCode = value; }
        }
        private string _generalLedgerNumber;
        public string GeneralLedgerNumber
        {
            get { return _generalLedgerNumber; }
            set { _generalLedgerNumber = value; }
        }
        private string _costCenterNumber;
        public string CostCenterNumber
        {
            get { return _costCenterNumber; }
            set { _costCenterNumber = value; }
        }
        private string _locationCode;
        public string LocationCode
        {
            get { return _locationCode; }
            set { _locationCode = value; }
        }
        private string _projectNumber;
        public string ProjectNumber
        {
            get { return _projectNumber; }
            set { _projectNumber = value; }
        }
        private string _workOrderNumber;
        public string WorkOrderNumber
        {
            get { return _workOrderNumber; }
            set { _workOrderNumber = value; }
        }
        private string _filler1;
        public string Filler1
        {
            get { return _filler1; }
            set { _filler1 = value; }
        }
        private string _operationFiscalCode;
        public string OperationFiscalCode
        {
            get { return _operationFiscalCode; }
            set { _operationFiscalCode = value; }
        }
        private string _operationType;
        public string OperationType
        {
            get { return _operationType; }
            set { _operationType = value; }
        }
        private string _productFiscalClassificationCode;
        public string ProductFiscalClassificationCode
        {
            get { return _productFiscalClassificationCode; }
            set { _productFiscalClassificationCode = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }

        public override string Table { get { return "F_I_GL1076_12"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_12_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_12Columns
    {
        ID,
        RecordType,
        F_I_GL1076_01ID,
        LIDTransactionID,
        Filler,
        LIDLineID,
        LineIdentifier,
        RequisitionNumber,
        PackingSlipNumber,
        SerialNumber,
        ClientMaterialNumber,
        ClientAssetCode,
        CustomerReferenceNumber,
        TrackingNumber,
        MSDSNumber,
        ChemicalAbstractsSvcNumber,
        DivisionCode,
        GeneralLedgerNumber,
        CostCenterNumber,
        LocationCode,
        ProjectNumber,
        WorkOrderNumber,
        Filler1,
        OperationFiscalCode,
        OperationType,
        ProductFiscalClassificationCode,
        Filler2,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_12Procedure
    {
        p_F_I_GL1076_12_Get_By_F_I_GL_1076_01ID,
        p_F_I_GL1076_12_Get_By_F_TransactionID
    }
    public class F_I_GL1076_12List : List<F_I_GL1076_12>
    {

    }
}