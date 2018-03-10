using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VCC;

namespace VCC
{
    public class AmexResponse
    {
        [JsonProperty("status")]
        public AmexTokenStatus Status { get; set; }

        [JsonProperty("token_issuance_data")]
        public AmexTokenIssuanceData TokenIssuanceData { get; set; }

        public AmexResponse()
        {
            Status = new AmexTokenStatus();
            TokenIssuanceData = new AmexTokenIssuanceData();
        }
    }

    public class AmexTokenStatus
    {
        [JsonProperty("response_time")]
        public string ResponseTime { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("short_message")]
        public string ShortMessage { get; set; }

        [JsonProperty("detailed_message")]
        public string DetailedMessage { get; set; }
        public AmexTokenStatus()
        {
            this.ResponseTime = string.Empty;
            this.Code = string.Empty;
            this.ShortMessage = string.Empty;
            this.DetailedMessage = string.Empty;
        }
    }

    public class AmexTokenIssuanceData
    {
        [JsonProperty("billing_account_id")]
        public string BillingAccountId { get; set; }

        [JsonProperty("maintained_by")]
        public string MaintainedBy { get; set; }

        [JsonProperty("token_details")]
        public AmexTokenDetailResponse TokenDetails { get; set; }

        [JsonProperty("token_domain_controls")]
        public AmexTokenDomainControls TokenDomainControls { get; set; }

        [JsonProperty("reconciliation_fields")]
        public AmexTokenReconciliationFields ReconciliationFields { get; set; }
        public AmexTokenIssuanceData() { }
    }

    public class AmexTokenDetailResponse
    {
        [JsonProperty("token_number")]
        public string TokenNumber { get; set; }

        [JsonProperty("token_expiry_date")]
        public string TokenExpiryDate { get; set; }

        [JsonProperty("token_security_code")]
        public string TokenSecurityCode { get; set; }

        [JsonProperty("token_reference_id")]
        public string TokenReferenceId { get; set; }

        [JsonProperty("token_amount")]
        public string TokenAmount { get; set; }

        [JsonProperty("token_start_date")]
        public string TokenStartDate { get; set; }

        [JsonProperty("token_end_date")]
        public string TokenEndDate { get; set; }
        public AmexTokenDetailResponse()
        {
            this.TokenNumber = string.Empty;
            this.TokenExpiryDate = string.Empty;
            this.TokenSecurityCode = string.Empty;
            this.TokenReferenceId = string.Empty;
            this.TokenAmount = string.Empty;
            this.TokenStartDate = string.Empty;
            this.TokenEndDate = string.Empty;
        }
    }

    public class AmexTokenDomainControls
    {
        public AmexTokenDomainControls() { }
    }
}
