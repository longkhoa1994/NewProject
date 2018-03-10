using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class TransactionRecordMA : F_TamaraTransaction
    {
        public string ExpiryDate { get; set; }
        public string TransactionSerialNumber { get; set; }
        public int TransactionCurrencyCode { get; set; }
        public decimal NetAmountNonVAT { get; set; }
        public decimal NetAmountVAT { get; set; }
        public decimal VATAmount { get; set; }
        public decimal VATPercentage { get; set; }
        public int VATInd { get; set; }
        public int Filler2_MA1 { get; set; }
        public string ApprovalCode { get; set; }
        public string MerchantName { get; set; }
        public string Filler2_MA2 { get; set; }
        public int MerchantIATANumber { get; set; }
        public string MerchantInvoiceNumber { get; set; }
        public string MerchantOrderNumber { get; set; }
        public string MerchantCustomerNumber { get; set; }
        public string AgencyDossierNumber { get; set; }
        public TransactionRecordMA()
        {
            NetAmountNonVAT = 0;
            ExpiryDate = string.Empty;
            TransactionSerialNumber = string.Empty;
            Filler2_MA2 = string.Empty;
            ApprovalCode = string.Empty;
            MerchantName = string.Empty;
            MerchantInvoiceNumber = string.Empty;
            MerchantOrderNumber = string.Empty;
            MerchantCustomerNumber = string.Empty;
            AgencyDossierNumber = string.Empty;
        }
    }
    public enum TransactionRecordMAProcedure
    {
        p_F_Tamara_GetTransactionRecordMA
    }

    public class P_TamaraMARecord : TransactionRecordMA
    {
        public long M_HotelPlatformID { get; set; }
        public long B_AccessID { get; set; }
        public string TokenStringPCI { get; set; }
        public string CountryCode { get; set; }
        public string PartnerId { get; set; }
        public long N_CostAcceptanceID { get; set; }

        private string _employeeNo_PK;

        public string EmployeeNo_PK
        {
            get { return _employeeNo_PK; }
            set { _employeeNo_PK = value; }
        }

        private string _costCenter_KS;

        public string CostCenter_KS
        {
            get { return _costCenter_KS; }
            set { _costCenter_KS = value; }
        }

        private string _departmentNo_DS;

        public string DepartmentNo_DS
        {
            get { return _departmentNo_DS; }
            set { _departmentNo_DS = value; }
        }

        private string _accountingUnit_AE;

        public string AccountingUnit_AE
        {
            get { return _accountingUnit_AE; }
            set { _accountingUnit_AE = value; }
        }

        private string _internalAccount_IK;

        public string InternalAccount_IK
        {
            get { return _internalAccount_IK; }
            set { _internalAccount_IK = value; }
        }

        private DateTime? _processingDate_BD;

        public DateTime? ProcessingDate_BD
        {
            get { return _processingDate_BD; }
            set { _processingDate_BD = value; }
        }

        private string _projectNo_PR;

        public string ProjectNo_PR
        {
            get { return _projectNo_PR; }
            set { _projectNo_PR = value; }
        }

        private string _orderNo_AU;

        public string OrderNo_AU
        {
            get { return _orderNo_AU; }
            set { _orderNo_AU = value; }
        }

        private string _actionNo_AK;

        public string ActionNo_AK
        {
            get { return _actionNo_AK; }
            set { _actionNo_AK = value; }
        }

        private string _finalDestination_RZ;

        public string FinalDestination_RZ
        {
            get { return _finalDestination_RZ; }
            set { _finalDestination_RZ = value; }
        }
    }
}
