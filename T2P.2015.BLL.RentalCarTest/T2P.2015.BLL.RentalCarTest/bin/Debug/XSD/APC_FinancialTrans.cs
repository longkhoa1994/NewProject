﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
namespace T2P.FINData
{
    // 
    // This source code was auto-generated by xsd, Version=4.0.30319.1.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FinancialHeader
    {
        private long userIDField;

        private HotelPlatform hotelPlatformNameField;

        private string transactionIndentifyField;

        private int transactionCountField;

        private string companyIdentifyField;

        private string sequenceIDField;

        private int reprintCountField;

        private TypeTran typeField;

        private FinancialTransaction[] financialTransactionField;

        private System.DateTime timestampField;

        private long totalTransaction;

        private string versionField;

        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HotelPlatform HotelPlatformName
        {
            get
            {
                return this.hotelPlatformNameField;
            }
            set
            {
                this.hotelPlatformNameField = value;
            }
        }
        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionIndentify
        {
            get
            {
                return this.transactionIndentifyField;
            }
            set
            {
                this.transactionIndentifyField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TransactionCount
        {
            get
            {
                return this.transactionCountField;
            }
            set
            {
                this.transactionCountField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyIdentify
        {
            get
            {
                return this.companyIdentifyField;
            }
            set
            {
                this.companyIdentifyField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SequenceID
        {
            get
            {
                return this.sequenceIDField;
            }
            set
            {
                this.sequenceIDField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ReprintCount
        {
            get
            {
                return this.reprintCountField;
            }
            set
            {
                this.reprintCountField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TypeTran Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute("FinancialTransaction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FinancialTransaction[] FinancialTransaction
        {
            get
            {
                return this.financialTransactionField;
            }
            set
            {
                this.financialTransactionField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long TotalTransaction
        {
            get
            {
                return this.totalTransaction;
            }
            set
            {
                this.totalTransaction = value;
            }
        }
        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    public enum HotelPlatform
    {

        /// <remarks/>
        HDE,

        /// <remarks/>
        HRS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum TypeTran
    {

        /// <remarks/>
        ATX,

        /// <remarks/>
        LARS,

        /// <remarks/>
        CSV,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FinancialTransaction
    {
        private long financialIDField;

        private string documentNoField;

        private decimal grossAmountField;

        private string currencyCodeField;

        private System.DateTime salesDateField;

        private string cardNumberField;

        private string travelerNameField;

        private string hotelField;

        private string reservationNumberField;

        private decimal grossAmountBCField;

        private bool grossAmountBCFieldSpecified;

        private string currencyCodeBCField;

        private decimal exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private decimal exchangeFeeField;

        private bool exchangeFeeFieldSpecified;

        private FinancialAddition financialAdditionField;

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long FinancialID
        {
            get
            {
                return this.financialIDField;
            }
            set
            {
                this.financialIDField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DocumentNo
        {
            get
            {
                return this.documentNoField;
            }
            set
            {
                this.documentNoField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime SalesDate
        {
            get
            {
                return this.salesDateField;
            }
            set
            {
                this.salesDateField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TravelerName
        {
            get
            {
                return this.travelerNameField;
            }
            set
            {
                this.travelerNameField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Hotel
        {
            get
            {
                return this.hotelField;
            }
            set
            {
                this.hotelField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReservationNumber
        {
            get
            {
                return this.reservationNumberField;
            }
            set
            {
                this.reservationNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal GrossAmountBC
        {
            get
            {
                return this.grossAmountBCField;
            }
            set
            {
                this.grossAmountBCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrossAmountBCSpecified
        {
            get
            {
                return this.grossAmountBCFieldSpecified;
            }
            set
            {
                this.grossAmountBCFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CurrencyCodeBC
        {
            get
            {
                return this.currencyCodeBCField;
            }
            set
            {
                this.currencyCodeBCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExchangeRateSpecified
        {
            get
            {
                return this.exchangeRateFieldSpecified;
            }
            set
            {
                this.exchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ExchangeFee
        {
            get
            {
                return this.exchangeFeeField;
            }
            set
            {
                this.exchangeFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExchangeFeeSpecified
        {
            get
            {
                return this.exchangeFeeFieldSpecified;
            }
            set
            {
                this.exchangeFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FinancialAddition FinancialAddition
        {
            get
            {
                return this.financialAdditionField;
            }
            set
            {
                this.financialAdditionField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FinancialAddition
    {

        private string dBI_PKField;

        private string dBI_KSField;

        private string dBI_DSField;

        private string dBI_AEField;

        private string dBI_IKField;

        private string dBI_BDField;

        private string dBI_PRField;

        private string dBI_AUField;

        private string dBI_AKField;

        private string dBI_RZField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_PK
        {
            get
            {
                return this.dBI_PKField;
            }
            set
            {
                this.dBI_PKField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_KS
        {
            get
            {
                return this.dBI_KSField;
            }
            set
            {
                this.dBI_KSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_DS
        {
            get
            {
                return this.dBI_DSField;
            }
            set
            {
                this.dBI_DSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_AE
        {
            get
            {
                return this.dBI_AEField;
            }
            set
            {
                this.dBI_AEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_IK
        {
            get
            {
                return this.dBI_IKField;
            }
            set
            {
                this.dBI_IKField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_BD
        {
            get
            {
                return this.dBI_BDField;
            }
            set
            {
                this.dBI_BDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_PR
        {
            get
            {
                return this.dBI_PRField;
            }
            set
            {
                this.dBI_PRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_AU
        {
            get
            {
                return this.dBI_AUField;
            }
            set
            {
                this.dBI_AUField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_AK
        {
            get
            {
                return this.dBI_AKField;
            }
            set
            {
                this.dBI_AKField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DBI_RZ
        {
            get
            {
                return this.dBI_RZField;
            }
            set
            {
                this.dBI_RZField = value;
            }
        }
    }




    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ResultFIN
    {

        private string transactionIndentifyField;

        private ErrorCode errorCodeField;

        private string errorTextField;

        private System.DateTime timestampField;

        private string versionField;

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionIndentify
        {
            get
            {
                return this.transactionIndentifyField;
            }
            set
            {
                this.transactionIndentifyField = value;
            }
        }

        /// <remarks/>
        [Required]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ErrorCode ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ErrorText
        {
            get
            {
                return this.errorTextField;
            }
            set
            {
                this.errorTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum ErrorCode
    {

        /// <remarks/>
        Success,

        /// <remarks/>
        Invalid,

        /// <remarks/>
        System,
    }
}