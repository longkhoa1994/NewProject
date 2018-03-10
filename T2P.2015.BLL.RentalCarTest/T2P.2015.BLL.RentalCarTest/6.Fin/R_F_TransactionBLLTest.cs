using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.BLL.RentalCarTest._1.Booking;
using T2P._2015.BLL.CarRental;
using T2P._2015.Cross.Model;
using Newtonsoft.Json;
using T2P._2015.Cross.Enum.CarRental.CarProvider;

namespace T2P._2015.BLL.RentalCarTest._6.Fin
{
    [TestClass]
    public class R_F_TransactionBLLTest
    {
        private R_F_TransactionBLL bLL;
        public R_F_TransactionBLLTest()
        {
            bLL = R_F_TransactionBLL.BLL;
        }

        [TestMethod]
        public void TestCreateFIN()
        {
            var actual = bLL.CreateFakeFIN(0, string.Empty, 0, string.Empty, DateTime.Now);
            
            var expect = Tuple.Create((R_F_Header)null, (R_F_Transaction)null, (R_P_Validation)null);

            Assert.AreEqual(JsonConvert.SerializeObject(expect), JsonConvert.SerializeObject(actual));
        }

        [TestMethod]
        public void TestCreateFIN_WithValues()
        {
            var bookingID = 100;
            var invoiceDate = DateTime.Now.AddDays(-10);
            var invoiceCurrency = "VND";
            var invoiceGross = -21.23M;
            var actual = bLL.CreateFakeFIN(bookingID, "20170921001", invoiceGross, invoiceCurrency, invoiceDate);

            Assert.AreEqual("LARS", actual.Item1.FileType);
            Assert.AreEqual("EU", actual.Item2.DocumentNo.Substring(0,2));
            Assert.AreEqual(bookingID, actual.Item2.R_B_AccessID);
            Assert.AreEqual(invoiceDate, actual.Item2.SalesDate);
            Assert.AreEqual(invoiceCurrency, actual.Item2.Currency);
            Assert.AreEqual(invoiceGross, actual.Item2.GrossAmount);
            Assert.AreEqual(CarBrands.Europcar.ToString().ToUpper(), actual.Item2.CarRentalProvider);
            Assert.AreEqual(1, actual.Item3.Result);
        }
    }
}
