using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Package : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_ContractID;

        public long B_ContractID
        {
            get { return _b_ContractID; }
            set { _b_ContractID = value; }
        }

        private string _packageID;

        public string PackageID
        {
            get { return _packageID; }
            set { _packageID = value; }
        }

        private DateTime? _date;

        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set
            {
                if (value == null)
                    _serviceCode = "";
                else
                    _serviceCode = value;
            }
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _originalDescription;

        public string OriginalDescription
        {
            get { return _originalDescription; }
            set { _originalDescription = value; }
        }

        private decimal? _pricePerPerson;

        public decimal? PricePerPerson
        {
            get { return _pricePerPerson; }
            set { _pricePerPerson = value; }
        }

        private int? _quantityContract;

        public int? QuantityContract
        {
            get { return _quantityContract; }
            set { _quantityContract = value; }
        }

        private int? _quantityCurrent;

        public int? QuantityCurrent
        {
            get { return _quantityCurrent; }
            set { _quantityCurrent = value; }
        }

        public override string Table { get { return "B_Package"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Package_InsertOrUpdate"; } }
    }

    public enum B_PackageColumns
    {
        ID,
        B_ContractID,
        PackageID,
        Type,
        ServiceCode,
        Title,
        Description,
        OriginalDescription,
        PricePerPerson,
        QuantityContract,
        QuantityCurrent,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_PackageProcedure
    {
        p_B_Package_GetByBookingIDAndType,
        p_B_Package_GetByBookingID,
        p_B_Package_GetByAccessID,
        p_B_Package_GetByContractFileID,
        p_B_Package_Save,
        p_B_Package_Get_By_B_ContractID
    }

    public class B_PackageList : List<B_Package>
    {
    }
}