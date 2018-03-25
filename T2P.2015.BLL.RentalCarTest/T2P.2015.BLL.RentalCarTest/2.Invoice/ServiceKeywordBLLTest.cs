//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using T2P._2015.BLL.CarRental._2.Invoice;
//using T2P._2015.Cross.Model;

//namespace T2P._2015.BLL.RentalCarTest._2.Invoice
//{
//    [TestClass]
//    public class ServiceKeywordBLLTest
//    {
//        [TestMethod]
//        public void Test_SetDataForObjectView_ServiceName_CheckStringSpance()
//        {
//            // arrange  
//            ServiceKeyworddBLL service = new ServiceKeyworddBLL();


//            // act
//            View_ServiceName serviceName = service.SetDataForObjectView_ServiceName("");

//            // assert
//            Assert.IsNull(serviceName);
//        }
//        [TestMethod]
//        public void Test_SetDataForObjectView_ServiceName_CheckStringEmpty()
//        {
//            // arrange  
//            ServiceKeyworddBLL service = new ServiceKeyworddBLL();


//            // act
//            View_ServiceName serviceName = service.SetDataForObjectView_ServiceName(string.Empty);

//            // assert
//            Assert.IsNull(serviceName);
//        }

//        [TestMethod]
//        public void Test_SetDataForObjectView_ServiceName_CheckString()
//        {
//            // arrange  
//            ServiceKeyworddBLL service = new ServiceKeyworddBLL();


//            // act
//            View_ServiceName serviceName = service.SetDataForObjectView_ServiceName("@");

//            // assert
//            Assert.IsNull(serviceName);
//        }
//        [TestMethod]
//        public void Test_SetDataForObjectView_ServiceName_CheckStringSpecial()
//        {
//            // arrange  
//            ServiceKeyworddBLL service = new ServiceKeyworddBLL();


//            // act
//            View_ServiceName serviceName = service.SetDataForObjectView_ServiceName("1@");

//            // assert
//            Assert.IsNull(serviceName);
//        }
//        [TestMethod]
//        public void Test_SetDataForObjectView_ServiceName_CheckStringSpecialA()
//        {
//            // arrange  
//            ServiceKeyworddBLL service = new ServiceKeyworddBLL();


//            // act
//            View_ServiceName serviceName = service.SetDataForObjectView_ServiceName("A@");

//            // assert
//            Assert.IsNull(serviceName);
//        }
//        [TestMethod]
//        public void Test_SetDataForObjectView_ServiceName_CheckStringNormal()
//        {
//            // arrange  
//            ServiceKeyworddBLL service = new ServiceKeyworddBLL();


//            // act
//            View_ServiceName serviceName = service.SetDataForObjectView_ServiceName("123@Test");

//            // assert
//            Assert.IsNotNull(serviceName);
//        }

//    }

//}
