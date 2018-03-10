using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using T2P._2015.DAL.CarRental._2.Invoice;
using T2P._2015.Cross.Model;
using T2P._2015.BLL.CarRental;
using T2P._2015.BLL.CarRental._2.Invoice;
namespace T2P._2015.BLL.RentalCarTest._2.Invoice
{
    /// <summary>
    /// Summary description for ExtractDataBLLTest
    /// </summary>
    [TestClass] 
    public class InvoiceDataBLLTest
    {
        private Mock<IInvoiceDataDAL> _mockInvoiceDataDAL;
        private InvoiceDataBLL _invoiceDataBLL;
        R_N_BillingEmail _billingEmail;
        R_N_BillingEmailAddition _billingEmailAddition;
        R_N_BillingEmailDetail _billingEmailDetail;
        List<R_N_BillingEmailAttachment> _lstBillingEmailAttachments;
        string _processType;
        public InvoiceDataBLLTest()
        {
            _mockInvoiceDataDAL = new Mock<IInvoiceDataDAL>();
            List<M_Country> _lstCountry = new List<M_Country>()
            {
                new M_Country(){ID = 82,CountryCode ="DE",CountryName = "Germany",CountryLanguageCode = "1" ,Flag ="DE.png",M_LanguageID = 3, CreatedBy = 1 , CreatedDate = DateTime.Now,UpdatedBy = 1 , UpdatedDate = DateTime.Now},
                new M_Country(){ID = 82,CountryCode ="IT",CountryName = "Italy",CountryLanguageCode = "1" ,Flag ="IT.png",M_LanguageID = 6, CreatedBy = 1 , CreatedDate = DateTime.Now,UpdatedBy = 1 , UpdatedDate = DateTime.Now},
            };
            _invoiceDataBLL = new InvoiceDataBLL(_mockInvoiceDataDAL.Object, _lstCountry);


        }

        [TestMethod]
        public void Test_InitCase()
        {
            // Arrange
            _processType = "ABC";
            _lstBillingEmailAttachments = new List<R_N_BillingEmailAttachment>() 
            {
                new R_N_BillingEmailAttachment(){ID = 1, Filename = "png" },
                new R_N_BillingEmailAttachment(){ID = 1, Filename = "xls",R_M_FileLocationID = 0 },
                new R_N_BillingEmailAttachment(){ID = 1, Filename = "xls",R_M_FileLocationID = 0 }
            };

            // Act
            bool result = true;//_invoiceDataBLL.ImportInvoiceData(_billingEmail, _billingEmailAddition, _billingEmailDetail, _lstBillingEmailAttachments, _processType);

            bool wrongExtension = _lstBillingEmailAttachments[0].Description == "Attachment extension is incorrected";
            bool wrongFileLocation = _lstBillingEmailAttachments[1].Description == "File location is incorrected";
            
            // Assert
            Assert.IsFalse(wrongExtension);
        }
        [TestMethod]
        public void GetCustomerNumberFromMaster_HasValue()
        {
       
        }
        [TestMethod]
        public void GetCustomerNumberFromMaster_MasterNull()
        {
      
        }
        [TestMethod]
        public void GetCustomerNumberFromMaster_IDataNull()
        {
           
        }
    }
}
