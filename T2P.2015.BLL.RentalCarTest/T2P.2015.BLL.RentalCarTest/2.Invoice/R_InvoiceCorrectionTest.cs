//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using T2P._2015.BLL.CarRental;
//using T2P._2015.Cross.Model;
//using System.Collections.Generic;
//using System.Linq;
//using T2P._2015.BLL;

//namespace T2P._2015.BLL.RentalCarTest._2.Invoice
//{
//    [TestClass]
//    public class R_InvoiceCorrectionTest
//    {
//        [TestMethod]
//        public void ServiceNameHasKeyWord()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Rental Rate"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = new List<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(68, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void SplitServiceNameHasKeyWord()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Rental Rate/"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(68, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void SplitServiceNameNumberHasKeyWord()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "10 Rental Rate/"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(68, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _16SplitServiceNameNumberHasKeyWord1()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "VLF by Car Class"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _16SplitServiceNameNumberHasKeyWord2()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% AZ Surcharge"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _16SplitServiceNameNumberHasKeyWord22()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% PA State Surcharge"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void SplitServiceNameNumberHasKeyWord3()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% PA State Surcharge"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void SplitServiceNameNumberHasKeyWord5()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Surcharge"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void SplitServiceNameNumberHasKeyWord4()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "VEHICLE LICENSE FEE"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void SplitServiceNameNumberHasKeyWord8()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Motor Veh Rental Fee"}
//            };
//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }


//        //[TestMethod]
//        //public void BugSplitServiceNameNumberHasKeyWord7()
//        //{
//        //    R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//        //    R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//        //     inputInvoice.CarProviderID = 4;        inputInvoice.R_RG_RateGridID = 132;        inputInvoice.M_PickupCountryID = 228;
//        //    inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//        //    {
//        //        new R_P_Invoice_Correction_Service(){ ServiceName = "Rental Rate x/"}
//        //    };
//        //    dynamic inputCR = new Dynamic();
//        //    inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//        //    List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//        //    List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//        //    invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//        //    Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        //}

//        [TestMethod]
//        public void _16BugSplitServiceNameSpecialHasKeyWord()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Veh Rental Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _16BugSplitServiceNameSpecialHasKeyWord_11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Motor Veh Rental Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _16_BugSplitServiceNameSpecialHasKeyWord1()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Vehicle Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _16_BugSplitServiceNameSpecialHasKeyWord2()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x%registration recoupment fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day / FBO CRF x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord2()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day CFC"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord3()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Transportation Fac Chg"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord4()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day; Addl CFC $x/day"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord5()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/rental  - Aprt Transport Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord_6()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/rental Security Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord7()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Facility Recovery Fee - x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord8()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "FBO CRF x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord10()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "AIRPORT CONCESSION FEE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "AIRPORT SECURITY FEE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_BugSplitServiceNameSpecialHasKeyWord12()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "ARPT COST RECOVERY FEE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void BugSplitServiceNameSpecialHasKeyWord()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "PRIV FEE RECOV CHG x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }



//        [TestMethod]
//        public void _59SplitServiceNameSpecialHasKeyWord1()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "(N)-x%-incl port fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _59SplitServiceNameSpecialHasKeyWord2()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "8% Seaport Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _59SplitServiceNameSpecialHasKeyWord4()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% All customers"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _59SplitServiceNameSpecialHasKeyWord5()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "CONCESSION RECOUP FEE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _59SplitServiceNameSpecialHasKeyWord6()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "CONCESSIONAIRE PRIVILEGE 11.11 PCT"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1SplitServiceNameSpecialHasKeyWord7()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Motor Veh Excise Tax - 1-31 day rentals only"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1SplitServiceNameSpecialHasKeyWordFixBug7922()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Rental Motor Veh Surchg"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug1()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x%-Anchorage Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug2()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day County Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _1_SplitServiceNameSpecialHasKeyWordFixBug3()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Trans Facility Charge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug4()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Trans Facility Charge/FBO CRF x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug5()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Transport Chg"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug6()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/rental Busing Fee "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug7()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/rental Convention Center Surcharge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug8()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/rental Lessor Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug9()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "FBO CRF x% / x% Comm. Services Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWordFixBug10()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "FBO CRF x% / x% Comm. Srvc Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitService33NameSpeci33alHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "FBO CRF x%/x% Sales Tax-Optional Items"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpeci33alHasKeyWordFixBug111()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Hotel Concession Fee x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpe33cialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x%  Rental Fee "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyW11ordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x%  Rental Fee / x% Communications Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceName11SpecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Automobile Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServic11eNameSpecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Automobile Rental Tax / FBO CRF 19%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameS11pecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% City Motor Veh Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpe1cialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Comm. Services Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpeci5alHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Convention Center Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpe4cialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Gross Receipt Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecial3HasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Hailey Motor Vehicle Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNam2eSpecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Hotel Conc Fee / x% Comm. Services Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServ1iceNameSpecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Hotel Conc Fee / x% Comm. Srvc Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpeci3alHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Hotel Concession Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialH0asKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Kansas Excise Tax "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHas9KeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Maricopa Surcharge - x/rntl min"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceName8SpecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Motor Veh Rental Tax "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpe9cialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Nevada Gov Surcharge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpec8ialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Occupation Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitSer7viceNameSpecia234lHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Phil Vehicle Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServ234iceN5ameSpecialHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Priv & Lic Tax; x% Non-Auto PL Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNa3meSpecia234lHasKeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNa2meSpecialHasKeyWordFisdfgxBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Tax & x% Sports Facility Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_Split1ServiceNameSpecialHasKxcvbeyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Tax (No Sports Facility Tax)"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNam5eSpecialHasKexvcbyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Tax / x% Entertainment Srvc Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameS4pecialHasKexvcbyWordFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Veh Surchg - x day MAX"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }


//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWoxcvbr2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Veh Surchg - x day MAX/FBO CRF x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpeetycialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Veh Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSetypecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Sales Tax-Optional Items"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKertyeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% State Excise Tax "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServwreticeNameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% State Tourism Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServwreticeNameSpecialHasKeyWor2dFhgfixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% State/x% County Tourism Tax Combined"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitSewertrviceNameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Tax on FUEL"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecwretialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Tourism Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpeciwretalHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% U Drive It Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpwretecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x/rental Pima County Surcharge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecsdfgialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "CUSTOMER FACILITY CHARGE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(36, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNaxcvbmeSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Rental Excise Tax x%"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNahgfjmeSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day - Maintenance Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        //[TestMethod]
//        //public void _232_SplitServisfdgceNameSpecialHasKeyWor2dFixBug11()
//        //{
//        //    R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//        //    R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//        //     inputInvoice.CarProviderID = 4;        inputInvoice.R_RG_RateGridID = 132;        inputInvoice.M_PickupCountryID = 228;
//        //    inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//        //    {
//        //        new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Airport Security Fee; x% Phone Accessories Tax"}
//        //    };

//        //    dynamic inputCR = new Dynamic();
//        //    inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//        //    List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//        //    List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//        //    invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//        //    Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        //}
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHawertsKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Arena Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialsertHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day CRF Surcharge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecisdfgalHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Domestic Security Fee-28 day MAX"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKexcvbyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Leased Veh Surchg"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpedfgcialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Rental Motor Veh Surchg"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHawersKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Tourism Surcharge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKeyWonhmr2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Transportation Assistance Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServdfsgiceNameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/day Transportation Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);

//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecikljlalHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$x/rental Omaha Occupation Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSphhjgfecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$xday FL Surchg - $.x/day Tire/Bat "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNasdfgmeSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "FLORIDA SURCHARGE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(69, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNametrySpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "TIRE/BATTERY FEE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(66, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServicedgfhjNameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "$xrental Parking Surcharge"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _16_SplitServicedfghNameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Veh Rental Tax $x/day "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        //[TestMethod]
//        //public void _232_SplitServicvbnceNameSpecialHasKeyWor2dFixBug11()
//        //{
//        //    R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//        //    R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//        //     inputInvoice.CarProviderID = 4;        inputInvoice.R_RG_RateGridID = 132;        inputInvoice.M_PickupCountryID = 228;
//        //    inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//        //    {
//        //        new R_P_Invoice_Correction_Service(){ ServiceName = "x% - Rental Vehicle Fee"}
//        //    };

//        //    dynamic inputCR = new Dynamic();
//        //    inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//        //    List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//        //    List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//        //    invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//        //    Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        //}
//        [TestMethod]
//        public void _232_SplitServiceNameSpecibnvalHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% - Tax on Fuel"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHashjgKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Alaska Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServiceNameSpeertycialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Amarillo Sports Venue Tax; x% Phone Accessories Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNamertyeSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Bexar Sports Venue Tax; x% Phone Accessories Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNdfghameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Boone Cnty Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNanbcvmeSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Business Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNamegfxdSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Caddo Parish Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSertpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Calcasieu Parish Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpdfghecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Car Rental Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasvbnmKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% County Car Rental Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHasKejhgyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% East Baton Rouge Parish Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialdgfhHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Euless Sports Venue Tax; x% Phone Accessories Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpeciagflHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Hospitality Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNsdfameSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Jefferson Parish Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNamesdfSpecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Lafayette Parish Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecialHfsdasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Marion Excise Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpeciafdslHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Midfield Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSspecialHasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Motor Veh Gross Receipts Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServiceNameSpecial123HasKeyWor2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% on travel accessory"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        //[TestMethod]
//        //public void _232_SplitServic1eNameSpe54cialHasKeyWor2dFixBug11()
//        //{
//        //    R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//        //    R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//        //     inputInvoice.CarProviderID = 4;        inputInvoice.R_RG_RateGridID = 132;        inputInvoice.M_PickupCountryID = 228;
//        //    inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//        //    {
//        //        new R_P_Invoice_Correction_Service(){ ServiceName = "c"}
//        //    };

//        //    dynamic inputCR = new Dynamic();
//        //    inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//        //    List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//        //    List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//        //    invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//        //    Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        //}


//        [TestMethod]
//        public void _232_SplitServic1eN123ameSpecialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Wayne County Stadium Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServic1eNameSpecialHas523KeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Veh Rental Sales/Use Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eNameSpecialHasK432eyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% U Drive It Tax/x% Sales Tax on RAP"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eNameSpecialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Tourism Fee; x% County Bus. Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(23, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServi567c1eNameSpecialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Tourism Fee"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(23, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eN134ameSpecialHasKeyWo2134r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Sunbowl Tax; x% Phone Accessories Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eNameS1234pecialHasKey134Wo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Sales Tax on RAP"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eNa134meSpecialHasKey134Wo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% RTA Tax  (discont x% Sta Tax 9/30)"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_Spl1234itServic1eNameSpec134ialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% RTA Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eNam2123eSpecialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rental Motor Veh Excise Tax - 1-31 day rentals only"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _232_SplitServic1eNameSpe2cialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Regional Transit Tax /x% Sales Tax on RAP"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void _232_SplitServic1eN1ameSpecialHasKeyWo2r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "x% Rapides Parish Tax"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(232, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void _59_SplitServic1eN1ameSpecialHasKeyWo21r2dFixBug11()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "CONCESSION RECOVERY FEE 11.11 PCT"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        //[TestMethod]
//        //public void _1_SplitServic1eN1ameSpecialHasK1eyWo2r2dFixBug11()
//        //{
//        //    R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//        //    R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//        //    inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//        //    inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//        //    {
//        //        new R_P_Invoice_Correction_Service(){ ServiceName = "AIR TRAN FEE 19.00/RNTL"}
//        //    };

//        //    dynamic inputCR = new Dynamic();
//        //    inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//        //    List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//        //    List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//        //    invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//        //    Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        //}

//        [TestMethod]
//        public void Test_GetServiceKeyWord_AirTranFee()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "AIR TRAN FEE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.IsNull(inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void Test_GetServiceKeyWord_Standortzuschlag()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Standortzuschlag (paschal service new)"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.IsNull(inputInvoice.ListService[0].R_M_SurchargeID);
//        }


//        [TestMethod]
//        public void Test_GetServiceKeyWord_RLFV_BugID9061()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "VEHICLE LIC FEE RECOVERY 1.20/DAY"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void Test_GetServiceKeyWord_RLFV_BugID9061_1()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "AIRPORT CONCESSION FEE 11.11 PCT"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void Test_GetServiceKeyWord_RLFV_BugID9193()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "CONCESSION RECOVERY FEE 11.11 PCT"}
//            };                                                  

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(59, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void Test_GetServiceKeyWord_RLFV_BugID9217()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "EXCESS DISTANCE CHARGE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = BaseBLL.Instance.GetList<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(15, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
//        [TestMethod]
//        public void Test_GetServiceKeyWord_RLFV_BugID9217_()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            List<R_I_Service> ListService = new  List<R_I_Service>()
//            {
//                new R_I_Service(){ ServiceName = "EXCESS DISTANCE CHARGE"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> ListServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);


//            InvoiceCaptureBLL invoiceCaptureBLL = new InvoiceCaptureBLL();
//            invoiceCaptureBLL.FindServiceCode(ListService, ListServiceKeyword, inputInvoice.ListSurcharge, inputInvoice.M_PickupCountryID, inputInvoice.M_ReturnCountryID, inputInvoice.CarProviderName, inputInvoice.PickupCountryCode, 1);


//            Assert.AreEqual(15, inputInvoice.ListService[0].R_M_SurchargeID);
//        }
    
//        [TestMethod]
//        public void Test_GetServiceKeyWord_EXTR_ServiceTeam()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "Customer facility charge 1.00/DAy"}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = new List<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(1, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//        [TestMethod]
//        public void Test_GetServiceKeyWord_EXTR_ServiceTeam1()
//        {
//            R_InvoiceCorrectionBLL invoicecorrection = new R_InvoiceCorrectionBLL();
//            R_P_Invoice_Correction inputInvoice = new R_P_Invoice_Correction();
//            inputInvoice.CarProviderID = 4; inputInvoice.R_RG_RateGridID = 132; inputInvoice.M_PickupCountryID = 228;
//            inputInvoice.ListService = new List<R_P_Invoice_Correction_Service>() 
//            {
//                new R_P_Invoice_Correction_Service(){ ServiceName = "VEH LIC COST RECOVERY FEE .76/DAY "}
//            };

//            dynamic inputCR = new Dynamic();
//            inputCR.CarRentalProviderId = inputInvoice.CarProviderID;
//            List<R_M_Service_Keyword> listServiceKeyword = BaseBLL.Instance.CommandStoredProcedureName<R_M_Service_Keyword>(R_M_Service_KeywordProcedure.p_R_M_Service_Keyword_GetBy_CarRentalProviderId.ToString(), inputCR);

//            List<R_M_Surcharge> lstSurcharge = new List<R_M_Surcharge>();

//            invoicecorrection.GetServiceKeyWord(inputInvoice, listServiceKeyword, lstSurcharge);

//            Assert.AreEqual(16, inputInvoice.ListService[0].R_M_SurchargeID);
//        }

//    }
//}
