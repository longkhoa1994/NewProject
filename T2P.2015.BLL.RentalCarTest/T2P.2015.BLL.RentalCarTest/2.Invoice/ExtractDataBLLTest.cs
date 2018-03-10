using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using T2P._2015.DAL.CarRental._2.Invoice;
using T2P._2015.Cross.Model;
using T2P._2015.BLL.CarRental;
namespace T2P._2015.BLL.RentalCarTest._2.Invoice
{
    /// <summary>
    /// Summary description for ExtractDataBLLTest
    /// </summary>
    [TestClass]
    public class ExtractDataBLLTest
    {
        private Mock<IExtractDataDAL> _mockExtractDataDAL;
        private ExtractDataBLL _extractDataBLL;
        public ExtractDataBLLTest()
        {
            _mockExtractDataDAL = new Mock<IExtractDataDAL>();
            _extractDataBLL = new ExtractDataBLL(_mockExtractDataDAL.Object);
        }
        private R_M_Customer GetCustomer(long imageId, long providerId)
        {
            return new R_M_Customer();
        }

        [TestMethod]
        public void GetCustomerNumberFromMaster_MasterEmpty()
        {
            var iData = new R_I_Data();
            iData.CustomerNumber = "BeforeTest";
            var imageId = 1;
            var providerId = 1;
            var customer = new R_M_Customer();
            _mockExtractDataDAL.Setup(x => x.GetCustomer(imageId, providerId)).Returns(customer);

            var actual = _extractDataBLL.SetMasterCustomerNumber(iData, imageId, providerId);
            Assert.AreEqual("BeforeTest", actual.CustomerNumber);
        }
        [TestMethod]
        public void GetCustomerNumberFromMaster_HasValue()
        {
            var iData = new R_I_Data();
            iData.CustomerNumber = "BeforeTest";
            var imageId = 1;
            var providerId = 1;
            var customer = new R_M_Customer()
            {
                CustomerNumber = "AfterTest"
            };
            _mockExtractDataDAL.Setup(x => x.GetCustomer(imageId, providerId)).Returns(customer);

            var actual = _extractDataBLL.SetMasterCustomerNumber(iData, imageId, providerId);
            Assert.AreEqual("AfterTest", actual.CustomerNumber);
        }
        [TestMethod]
        public void GetCustomerNumberFromMaster_MasterNull()
        {
            var iData = new R_I_Data();
            iData.CustomerNumber = "BeforeTest";
            var imageId = 1;
            var providerId = 1;
            var customer = (R_M_Customer)null;
            _mockExtractDataDAL.Setup(x => x.GetCustomer(imageId, providerId)).Returns(customer);

            var actual = _extractDataBLL.SetMasterCustomerNumber(iData, imageId, providerId);
            Assert.AreEqual("BeforeTest", actual.CustomerNumber);
        }
        [TestMethod]
        public void GetCustomerNumberFromMaster_IDataNull()
        {
            R_I_Data iData = null;
           
            var imageId = 1;
            var providerId = 1;
            var customer = (R_M_Customer)null;
            _mockExtractDataDAL.Setup(x => x.GetCustomer(imageId, providerId)).Returns(customer);

            var actual = _extractDataBLL.SetMasterCustomerNumber(iData, imageId, providerId);
            Assert.IsNull(actual);
        }
    }
}
