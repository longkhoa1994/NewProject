using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Process;

namespace VCC
{
    public class AmexRequest
    {
        [JsonProperty("token_identifier")]
        public AmexTokenIdentifier TokenIdentifier { get; set; }

        [JsonProperty("token_issuance_params")]
        public AmexTokenParams TokenIssuanceParams { get; set; }
        public AmexRequest()
        {
            TokenIdentifier = new AmexTokenIdentifier();
            TokenIssuanceParams = new AmexTokenParams();
        }
    }

    public class AmexTokenIdentifier
    {
        [JsonProperty("token_number")]
        public string TokenNumber { get; set; }

        public AmexTokenIdentifier()
        {
            this.TokenNumber = string.Empty;
        }
    }
    public class AmexTokenParams
    {
        [JsonProperty("billing_account_id")]
        public string BillingAccountId { get; set; }

        [JsonProperty("maintained_by")]
        public string MaintainedBy { get; set; }

        [JsonProperty("token_details")]
        public AmexTokenDetail TokenDetails { get; set; }

        [JsonProperty("reconciliation_fields")]
        public AmexTokenReconciliationFields ReconciliationFields { get; set; }

        public AmexTokenParams()
        {
            this.BillingAccountId = String.Empty;
            this.MaintainedBy = String.Empty;
            this.TokenDetails = new AmexTokenDetail();
            this.ReconciliationFields = new AmexTokenReconciliationFields();
        }
    }

    public class AmexTokenDetail
    {

        [JsonProperty("token_reference_id")]
        public string TokenReferenceId { get; set; }

        [JsonProperty("token_amount")]
        public string TokenAmount { get; set; }

        [JsonProperty("token_start_date")]
        public string TokenStartDate { get; set; }

        [JsonProperty("token_end_date")]
        public string TokenEndDate { get; set; }
        public AmexTokenDetail()
        {
            this.TokenReferenceId = Guid.NewGuid().ToString();
            this.TokenAmount = string.Empty;        
            this.TokenStartDate = DateTime.Now.ToString("yyyyMMdd");
            this.TokenEndDate = DateTime.Now.AddDays(21).ToString("yyyyMMdd");
        }
    }

    public class AmexTokenReconciliationFields
    {
        [JsonProperty("user_defined_fields_group")]
        public List<AmexTokenUserDefinedField> UserDefinedFieldsGroup { get; set; }

        [JsonProperty("accounting_fields_group")]
        public List<AmexTokenAccountingField> AccountingFieldsGroup { get; set; }
        
        public AmexTokenReconciliationFields()
        {
            this.UserDefinedFieldsGroup = new List<AmexTokenUserDefinedField>();
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(1, "Custom Field 1"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(2, "Custom Field 2"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(3, "Custom Field 3"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(4, "Custom Field 4"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(5, "Custom Field 5"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(6, "Custom Field 6"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(7, "Custom Field 7"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(8, "Custom Field 8"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(9, "Custom Field 9"));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(10, "Custom Field 10"));

            this.AccountingFieldsGroup = new List<AmexTokenAccountingField>();
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(1, "Custom Field 1"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(2, "Custom Field 2"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(3, "Custom Field 3"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(4, "Custom Field 4"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(5, "Custom Field 5"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(6, "Custom Field 6"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(7, "Custom Field 7"));
            this.AccountingFieldsGroup.Add(new AmexTokenAccountingField(8, "Custom Field 8"));
        }

        public AmexTokenReconciliationFields(P_Booking_VCC data)
        {
            this.UserDefinedFieldsGroup = new List<AmexTokenUserDefinedField>();
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(1, data.BookingNo));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(2, data.CostCenter_KS));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(3, data.ProjectNo_PR));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(4, data.AccountingUnit_AE));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(5, data.DepartmentNo_DS));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(6, data.EmployeeNo_PK));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(7, data.OrderNo_AU));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(8, data.InternalAccount_IK));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(9, data.FinalDestination_RZ));
            this.UserDefinedFieldsGroup.Add(new AmexTokenUserDefinedField(10, data.ProcessingDate_BD.ToString()));

            this.AccountingFieldsGroup = new List<AmexTokenAccountingField>();
        }
    }

    public class AmexTokenUserDefinedField
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        public AmexTokenUserDefinedField()
        {
            this.Index = string.Empty;
            this.Value = string.Empty;
        }

        public AmexTokenUserDefinedField(int index, string value)
        {
            this.Index = index.ToString();
            this.Value = value;
        }
    }

    public class AmexTokenAccountingField
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        public AmexTokenAccountingField()
        {
            this.Index = string.Empty;
            this.Value = string.Empty;
        }

        public AmexTokenAccountingField(int index, string value)
        {
            this.Index = index.ToString();
            this.Value = value;
        }
    }
}
