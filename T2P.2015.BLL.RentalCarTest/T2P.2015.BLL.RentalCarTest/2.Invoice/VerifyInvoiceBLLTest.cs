//using System;
//using System.Text;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using T2P._2015.Cross.Model;
//using T2P._2015.BLL.CarRental;
//using Newtonsoft.Json;
//using System.Linq;
//using Moq;
//using T2P._2015.Cross.Enum.CarRental.Invoice;

//namespace T2P._2015.BLL.RentalCarTest._2.Invoice
//{
//    /// <summary>
//    /// Summary description for VerifyInvoiceBLLTest
//    /// </summary>
//    [TestClass]
//    public class VerifyInvoiceBLLTest
//    {
//        #region OldCode

//        [TestMethod]
//        public void IsValidateSurcharge_SurchargeNoRange()
//        {
//            // Prepare data
//            var currentService = new R_I_Service();
//            var currentCondition = new R_RG_SurchargeCondition();
//            var listChargeService = new List<R_I_Service>();
//            //Exec\
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_ChargeHasErrorAndNotMinThresholdAndHasMaxThreshold()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 30
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_ChargeHasErrorAndHasMinThresholdAndHasMaxThreshold()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 30,
//                Min = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            //Exec\
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_ChargeHasErrorWithMinThreshold()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            //Exec\
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_ChargeHasErrorLackOfIdAndHasMinThresholdAndHasMaxThreshold()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 30,
//                Min = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_ChargeHasErrorLackOfIdAndNoMinThresholdAndNoMaxThreshold()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition();
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }

//        [TestMethod]
//        public void IsValidationSurcharge_ChargeHasErrorLackOfIdAndNoMinThresholdAndHasMaxThreshold()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_OutOfRange()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 40,
//                Min = 30
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidationSurcharge_OutOfRangeWithMin()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 30
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void HasErrorService_HasError()
//        {
//            var listChargeSerivce = new List<R_I_Service>()
//            {
//                new R_I_Service{ID = 1},
//                new R_I_Service{ID = 2}
//            };
//            var listErrors = new List<R_I_Error>()
//            {
//                new R_I_Error{R_I_ServiceID = 1}
//            };
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.HasErrorService(listChargeSerivce, listErrors);
//            Assert.IsTrue(actual);
//        }
//        [TestMethod]
//        public void HasErrorService_NoError()
//        {
//            var listChargeSerivce = new List<R_I_Service>()
//            {
//                new R_I_Service{ID = 1},
//                new R_I_Service{ID = 2}
//            };
//            var listErrors = new List<R_I_Error>()
//            {
//                new R_I_Error{R_I_ServiceID = 3}
//            };
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.HasErrorService(listChargeSerivce, listErrors);
//            Assert.IsFalse(actual);
//        }
//        [TestMethod]
//        public void IsCancellationInvoice_HasCancellation()
//        {
//            var currentService = new R_I_Service { NetAmount = 3 };
//            var listChargeSerivce = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 2},
//                new R_I_Service{NetAmount = -1}
//            };
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsDebitInvoice(currentService, listChargeSerivce);
//            Assert.IsTrue(actual);
//        }
//        [TestMethod]
//        public void IsCancellationInvoice_HasNegativeAmount()
//        {
//            var currentService = new R_I_Service { NetAmount = -3 };
//            var listChargeSerivce = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 2},
//                new R_I_Service{NetAmount = 1}
//            };
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsDebitInvoice(currentService, listChargeSerivce);
//            Assert.IsTrue(actual);
//        }
//        [TestMethod]
//        public void IsCancellationInvoice_NoCancellation()
//        {
//            var currentService = new R_I_Service { NetAmount = 3 };
//            var listChargeSerivce = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 2},
//                new R_I_Service{NetAmount = 1}
//            };
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsDebitInvoice(currentService, listChargeSerivce);
//            Assert.IsFalse(actual);
//        }

//        [TestMethod]
//        public void IsValidateSurcharge_DebitNoRange()
//        {
//            // Prepare data
//            var currentService = new R_I_Service();
//            var currentCondition = new R_RG_SurchargeCondition();
//            var listChargeService = new List<R_I_Service>();
//            var prevService = new R_I_Service();
//            var listPrevChargeService = new List<R_I_Service>();
//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinAndRefundCharge()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -100
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 30
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }

//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinAndRefundChargeMoreThan()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }

//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinAndRefundChargeMoreThan_HelloWolrdVersion()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                //Min = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }

//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinAndRefundChargeLessThan()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 100
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMaxAndRefundChargeLessThan()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 100
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }
//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMaxAndRefundChargeMoreThan()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Max = 10
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinMaxAndRefundChargeLeftOutRange()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 81,
//                Max = 100
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinMaxAndRefundChargeRightOutRange()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 50,
//                Max = 79
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void IsValidateSurcharge_DebitRangeHasMinMaxAndRefundChargeInRange()
//        {
//            // Prepare data
//            var currentService = new R_I_Service()
//            {
//                NetAmount = -20
//            };

//            var prevService = new R_I_Service()
//            {
//                NetAmount = 100
//            };
//            var currentCondition = new R_RG_SurchargeCondition()
//            {
//                Min = 79,
//                Max = 81
//            };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -200, ID = 1},
//                new R_I_Service{NetAmount = -200, ID = 3}
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 300, ID = 3}
//            };

//            //Exec
//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.IsValidateSurcharge(currentService, currentCondition, listChargeService, prevService, listPrevChargeService);
//            //Compare
//            Assert.AreEqual(true, actual);
//        }
//        //[TestMethod]
//        //public void CheckSurchargeValidation_NoDebitNoCharge()
//        //{
//        //    var currentService = new R_I_Service();
//        //    var currentCondition = new R_RG_SurchargeCondition();
//        //    var listChargeService = new List<R_I_Service>();
//        //    var listPrevService = new List<R_I_Service>();
//        //    var listPrevChargeService = new List<R_I_Service>();
//        //    var listError = new List<R_I_Error>();

//        //    var verifyInvoice = new VerifyInvoiceBLL();
//        //    var actual = verifyInvoice.CheckSurchargeValidation(currentService, currentCondition, listChargeService, listPrevService, listPrevChargeService, listError);
//        //    Assert.AreEqual(false, actual);
//        //}
//        [TestMethod]
//        public void CheckSurchargeValidation_NoDebitHasChargeInRange()
//        {
//            var currentService = new R_I_Service() { NetAmount = 50 };
//            var currentCondition = new R_RG_SurchargeCondition() { Min = 10, Max = 50 };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            var listPrevService = new List<R_I_Service>();
//            var listPrevChargeService = new List<R_I_Service>();
//            var listError = new List<R_I_Error>()
//            {
//                new R_I_Error{R_I_ServiceID = 3}
//            };

//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.CheckSurchargeValidation(currentService, currentCondition, listChargeService, listPrevService, listPrevChargeService, listError);
//            Assert.AreEqual(true, actual);
//        }
//        [TestMethod]
//        public void CheckSurchargeValidation_NoDebitHasChargeOutRange()
//        {
//            var currentService = new R_I_Service() { NetAmount = 50 };
//            var currentCondition = new R_RG_SurchargeCondition() { Min = 30, Max = 50 };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            var listPrevService = new List<R_I_Service>();
//            var listPrevChargeService = new List<R_I_Service>();
//            var listError = new List<R_I_Error>()
//            {
//                new R_I_Error{R_I_ServiceID = 3}
//            };

//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.CheckSurchargeValidation(currentService, currentCondition, listChargeService, listPrevService, listPrevChargeService, listError);
//            Assert.AreEqual(false, actual);
//        }
//        [TestMethod]
//        public void CheckSurchargeValidation_HasDebitHasChargeOutRange()
//        {
//            var currentService = new R_I_Service() { ID = 10, NetAmount = 50 };
//            var currentCondition = new R_RG_SurchargeCondition() { Min = 30, Max = 50 };
//            var listChargeService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };
//            var listPrevService = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = -10, ID = 10}, 
//            };
//            var listPrevChargeService = new List<R_I_Service>()
//            {

//            };
//            var listError = new List<R_I_Error>()
//            {
//                new R_I_Error{R_I_ServiceID = 3}
//            };

//            var verifyInvoice = new VerifyInvoiceBLL();
//            var actual = verifyInvoice.CheckSurchargeValidation(currentService, currentCondition, listChargeService, listPrevService, listPrevChargeService, listError);
//            Assert.AreEqual(false, actual);
//        }

//        #endregion

//        #region GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturnEmptyObject_InCaseOfEmptyInput()
//        {
//            // Arrange
//            var invoiceCorrection = new R_P_Invoice_Correction();
//            var _bll = new VerifyInvoiceBLL();

//            // Act
//            var actual = _bll.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(JsonConvert.SerializeObject(new InvoiceErrorViewModel()), JsonConvert.SerializeObject(actual));
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn1Error_InCaseOfNoRateGrid()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = new R_P_Invoice_Correction { ID = 0, R_I_ImageID = 0, R_RG_RateGridID = 0 };
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            SetupInitErrorInvoice(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.First().R_M_InvoiceErrorCodeID);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn1Error_InCaseOfNoCurrencyExchangeRate()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = InitInvoiceCorrection();
//            invoiceCorrection.ID = 1;
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD" });
//            SetupInitErrorInvoice(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.First().R_M_InvoiceErrorCodeID);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn1Error_InCaseOfHasCurrencyExchangeRate()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = InitInvoiceCorrection();
//            invoiceCorrection.ExchangeRate = 1;
//            invoiceCorrection.ListInvoiceError = ListInvoiceErrors();
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(false);
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD" });
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT>());

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn1Error_InCaseOfHasChargeAmount()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = InitInvoiceCorrection();
//            invoiceCorrection.ListInvoiceError = ListInvoiceErrors();
//            invoiceCorrection = AddChargeAmountData(invoiceCorrection);
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(false);
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD" });
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT>());

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturnNoError_InCaseOfChargeAmountIsNull()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = InitInvoiceCorrection();
//            invoiceCorrection.ExchangeRate = (decimal)1.5;
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(false);
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD" });
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT>());

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(0, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup1()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup1_TestPrepareInvoiceInformation()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup1(_mockBLL);
//            invoiceCorrection.ReturnTime = DateTime.Now;
//            invoiceCorrection.PickUpTime = DateTime.Now;
//            invoiceCorrection.ReturnKM = 10;
//            invoiceCorrection.StartingKM = 1;

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup1HasImageID()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup1(_mockBLL);
//            invoiceCorrection.R_I_ImageIdOld = 0;

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup2()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup2WithChangeTypeCurrency_ButNoExchangeRate()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR" });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup2EmptyCurrency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = " " });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup2NullCurrency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR" });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn8Errors_InCaseOf_Setup2WithChangeTypeCurrency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR", ExchangeRate = (decimal)1.5 });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn3PreviousErrors_InCaseOf_Setup3()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup3(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn14Errors_InCaseOf_Setup4()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup4_TestAdCorrectServiceName(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_TestAdCorrectServiceName()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup4_TestAdCorrectServiceName(_mockBLL);
//            invoiceCorrection.M_PickupCountryID = 3;

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn5SNAErrors_InCaseOf_Setup4_DifferentLocation()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup4_TestAdCorrectServiceName(_mockBLL);
//            invoiceCorrection.PickUpLocation = "Saigon";

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrorViewModel_MustReturn3SNAErrors_InCaseOf_Setup5()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup5(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }

//        #endregion
//        #region Setups

//        private R_P_Invoice_Correction GetInvoiceErrorViewModel_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(false);
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD" });
//            _mockBLL.Setup(x => x.GetServiceKeywordsListByCarRentalProviderId(It.IsAny<long>()))
//                .Returns(new List<R_M_Service_Keyword>
//                {
//                    new R_M_Service_Keyword { M_CarRentalProviderID = 1, R_M_SurchargeID = 1, M_LanguageID = 3, ServiceName = "Standortzuschlag"},
//                    new R_M_Service_Keyword { M_CarRentalProviderID = 1, R_M_SurchargeID = 12, M_LanguageID = 1, ServiceName = "Gasoline"}
//                });
//            SetupInitErrorInvoice(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail { R_RG_RateGridID = 1, R_M_SippCodeID = 1 }
//                });

//            var invoiceCorrection = InitInvoiceCorrection();
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "6969" },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC"},
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 15}
//            };
//            invoiceCorrection.ExchangeRate = (decimal)1.5;
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT>());

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction GetInvoiceErrorViewModel_Setup2(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup1(_mockBLL);
//            invoiceCorrection.R_I_ImageIdOld = 1;

//            _mockBLL.Setup(x => x.GetImageByID(It.IsAny<long>()))
//                .Returns(new R_I_Image { ID = 1, R_B_AccessID = 1, R_RG_RateGridID = 1, HasRateGrid = true, ImageStatus = "Processing" });
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "USD" });
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 1, NetAmount = 10 }
//                });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>());

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction GetInvoiceErrorViewModel_Setup3(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);

//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction GetInvoiceErrorViewModel_Setup4_TestAdCorrectServiceName(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup3(_mockBLL);
//            invoiceCorrection.ListService.Add(new R_P_Invoice_Correction_Service { R_M_SurchargeID = 11, IsManualError = false, Status = 0 });
//            invoiceCorrection.ListService.Add(new R_P_Invoice_Correction_Service { R_M_SurchargeID = 67, IsManualError = false, Status = 0 });
//            invoiceCorrection.M_PickupCountryID = invoiceCorrection.M_ReturnCountryID = 1;
//            invoiceCorrection.PickUpLocation = invoiceCorrection.ReturnLocation = "VN";

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction GetInvoiceErrorViewModel_Setup5(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup1(_mockBLL);
//            invoiceCorrection.ListService.Add(new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, CorrectServiceID = 1 });

//            return invoiceCorrection;
//        }

//        #endregion
//        #endregion

//        #region CheckRateGrid via GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_CheckRateGrid()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfDifferentSippCode()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup1(_mockBLL);
//            invoiceCorrection.CarGroup = "Lamboghini";
//            invoiceCorrection.M_PickupCountryID = 1;
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = null, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "USD" });
//            _mockBLL.Setup(x => x.GetImageByID(It.IsAny<long>()))
//                .Returns(new R_I_Image { ID = 1, R_B_AccessID = null, R_RG_RateGridID = 1, HasRateGrid = true, ImageStatus = "Processing" });
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD", M_CarRentalProviderID = 2 });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfHasCarGroupSippCode()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetCarGroupSippCode(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<long>())).Returns(new R_P_CarGroupSippCode { SippCode = "Lamborghini", CarGroup = "Lamborghini" });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfHasDifferentCarGroupSippCode()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetCarGroupSippCode(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<long>())).Returns(new R_P_CarGroupSippCode { SippCode = "Lamboghini", CarGroup = "Lamboghini" });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfLackInvoiceHeader()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup2(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfLackInvoiceHeaderNotHour()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup2(_mockBLL);
//            invoiceCorrection.ReturnKM = 200;
//            invoiceCorrection.StartingKM = 10;
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail { R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Day", Group = "Lambor",
//                        MinDay = 0, MaxDay = 10, MaxKm = 10, AdditionalFee = 1, Rate = (decimal)1.5 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfLackInvoiceHeaderNotHour_MaxDay9999()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup2(_mockBLL);
//            invoiceCorrection.ReturnKM = 200;
//            invoiceCorrection.StartingKM = 10;
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail { R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Day", Group = "Lambor",
//                        MinDay = 9999, MaxDay = 9999, MaxKm = 10, AdditionalFee = 1, Rate = (decimal)1.5 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfLackInvoiceHeaderAvis()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD", M_CarRentalProviderID = 2 });
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail { R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Hour", Group = "Lambor", MinDay = 0, MaxDay = 1, Rate = (decimal)1.5 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_InCaseOfLackInvoiceHeaderSixtEnterpriseNational()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup2(_mockBLL);
//            invoiceCorrection.ReturnKM = 200;
//            invoiceCorrection.StartingKM = 10;
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD", M_CarRentalProviderID = 1 });
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail
//                    {
//                        R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Hour", Group = "Lambor", MinDay = 0, MaxDay = 1, Rate = (decimal)1.5,
//                        MaxKm = 10, AdditionalFee = 1
//                    }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_5Errors_Setup3()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup3(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_5Errors_Setup3_CaseOfAdditionKmsService()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup3(_mockBLL);
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(9999);
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail
//                    {
//                        R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Month", TimeUnit = "Month", Group = "Lambor", MinDay = 9999, MaxDay = 9999, Rate = 0,
//                        MaxKm = 10, AdditionalFee = 1
//                    }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_5Errors_Setup3_CaseOfAdditionKmsServiceMaxDayLessThan9999()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup3(_mockBLL);
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(15);
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail
//                    {
//                        R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Month", TimeUnit = "Month", Group = "Lambor", MinDay = 9, MaxDay = 10, Rate = 0,
//                        MaxKm = 10, AdditionalFee = 1
//                    },
//                    new R_RG_RateGridDetail
//                    {
//                        R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Month", TimeUnit = "Month", Group = "Lambor", MinDay = 10, MaxDay = 11, Rate = 0,
//                        MaxKm = 10, AdditionalFee = 1
//                    },
//                    new R_RG_RateGridDetail
//                    {
//                        R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Month", TimeUnit = "Month", Group = "Lambor", MinDay = 5, MaxDay = 6, Rate = 0,
//                        MaxKm = 10, AdditionalFee = 1
//                    }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 9).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_6Errors_Setup3_CaseOfHasPreviousInvoice()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup3(_mockBLL);
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 15, ServiceCode = "AKMC", NetAmount = (decimal)0.001 }
//                });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", NetAmount = (decimal)0.001 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 15, ServiceCode = "AKMC", NetAmount = (decimal)0.001 }
//            };
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(6, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_4Errors_Setup4()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup4(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckRateGrid_6Errors_Setup4_GreaterThanSIGMA()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckRateGrid_Setup4(_mockBLL);
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", NetAmount = (decimal)0.5 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 15, ServiceCode = "AKMC", NetAmount = (decimal)0.5 }
//            };
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(6, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }

//        #endregion
//        #region Setups

//        private R_P_Invoice_Correction CheckRateGrid_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup3(_mockBLL);
//            invoiceCorrection.IsCheckCarGroup = true;

//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1 }
//                });
//            _mockBLL.Setup(x => x.GetCarGroupSippCode(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<long>())).Returns((R_P_CarGroupSippCode)null);
//            _mockBLL.Setup(x => x.GetBookingByAccessId(It.IsAny<long>())).Returns(new R_B_Booking { CarCategory = "Lamborghini" });

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction CheckRateGrid_Setup2(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckRateGrid_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetCarGroupSippCode(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<long>()))
//                .Returns(new R_P_CarGroupSippCode { SippCode = "Lamborghini", CarGroup = "Lamboghini" });
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail { R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Hour", Group = "Lambor" }
//                });
//            invoiceCorrection.CarGroup = "Lambor";
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", NetAmount = 12 }
//            };

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction CheckRateGrid_Setup3(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckRateGrid_Setup2(_mockBLL);
//            invoiceCorrection.ReturnKM = 200;
//            invoiceCorrection.StartingKM = 10;
//            _mockBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD", M_CarRentalProviderID = 1 });
//            _mockBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>()))
//                .Returns(new List<R_RG_RateGridDetail>
//                {
//                    new R_RG_RateGridDetail
//                    {
//                        R_RG_RateGridID = 1, R_M_SippCodeID = 1, SIPP = "Lambor", Unit = "Month", TimeUnit = "Month", Group = "Lambor", MinDay = 0, MaxDay = 2, Rate = (decimal)1.5,
//                        MaxKm = 10, AdditionalFee = 1
//                    }
//                });
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1 } };
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", NetAmount = 12 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 15, ServiceCode = "AKMC", NetAmount = 12 }
//            };

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction CheckRateGrid_Setup4(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckRateGrid_Setup3(_mockBLL);
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 68 },
//                    new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 15, ServiceCode = "AKMC", NetAmount = (decimal)0.001 }
//                });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", NetAmount = (decimal)0.001 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 15, ServiceCode = "AKMC", NetAmount = (decimal)0.001 }
//            };

//            return invoiceCorrection;
//        }

//        #endregion
//        #endregion

//        #region CheckSNAList via GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_CheckSNAList()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSNAList_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.PrevInvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.PrevInvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 1).ToList().Count);
//            Assert.AreEqual(2, actual.PrevInvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSNAList_Credit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSNAList_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 1 } };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.PrevInvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.PrevInvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 1).ToList().Count);
//            Assert.AreEqual(2, actual.PrevInvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSNAList_priceTempLargerThanSIGMA()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSNAList_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 1 } };
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, ServiceName = "Name", GrossAmount =  (decimal)1.5 }
//                });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, NetAmount = -1, ServiceName = "Name", GrossAmount = (decimal)1.5 }
//            };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.PrevInvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.PrevInvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 1).ToList().Count);
//            Assert.AreEqual(2, actual.PrevInvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }
//        #endregion
//        #region Setups
//        private R_P_Invoice_Correction CheckSNAList_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, ServiceName = "Name", GrossAmount =  (decimal)0.001 }
//                });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, NetAmount = -1, ServiceName = "Name", GrossAmount = (decimal)0.001 }
//            };
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1 } };
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>())).Returns(ListInvoiceErrors());
//            return invoiceCorrection;
//        }
//        #endregion
//        #endregion

//        #region CheckSurcharge via GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_CheckSurcharge()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.CustomerNumber = "9711685";

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }


//        [TestMethod]
//        public void Test_CheckSurcharge_1()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup3(_mockBLL);
//            //invoiceCorrection.CustomerNumber = "9711685";

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_GetStdSurchargeConditionsList_NotSameSurchargeID()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 4, Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 4, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_GetStdSurchargeConditionsList()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra>());

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_PercentIncludedPercent()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentIncludedPercent", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//            .Returns(new List<R_I_Error>
//            {
//                new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//            });
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 1 } };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_NetAmountLessThanSIGMA()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentIncludedPercent", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//            .Returns(new List<R_I_Error>
//            {
//                new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 44, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = -10M }
//            };
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 1 } };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_NoMinMax()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentIncludedPercent", Unit = "package", MinUnit = "day", MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//            .Returns(new List<R_I_Error>
//            {
//                new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 44, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = -10M }
//            };
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 1 } };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_PercentIncludedPercent_Prev()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentIncludedPercent", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_PercentRateOnly()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentRateOnly", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_PercentRateOnly_HasPickUpTime()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentRateOnly", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//            });
//            invoiceCorrection.PickUpTime = DateTime.Now;

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_PercentExceptRefueling()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentExceptRefueling", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_Percent()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "Percent", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_BabySeat()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_Debits()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 5 } };
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, MaxPriceUnit = "PercentIncludedPercent", Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_ContractFee()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.CarProviderID = 1;
//            invoiceCorrection.M_PickupCountryID = invoiceCorrection.M_ReturnCountryID = 15;
//            invoiceCorrection.GrossAmount = 5;

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(5, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_ContractFee_NetAmountLessThan0()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup2(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_ContractFee_NetAmountLessThan0NoGross()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup2(_mockBLL);
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = -1 }
//            };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_TempPrevSurchargesList()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>())).Returns(new List<R_I_Service> {
//                new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 41, NetAmount = (decimal)-14.998 }
//            });
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "Hello", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_TempPrevSurchargesList_netAmountInInvoice_Negative()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>())).Returns(new List<R_I_Service> {
//                new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 41, NetAmount = (decimal)-20 }
//            });
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "Hello", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = GetStdExactSurchargeCondition_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_HasPickupDate()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_HasKm()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            invoiceCorrection.StartingKM = 1;
//            invoiceCorrection.ReturnKM = 5;
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "KM", Max = 7, MaxUnit = "KM", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_CurrencyPackage()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 40, MinUnit = "Currency", Max = 50, MaxUnit = "Currency", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_DifferentUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            invoiceCorrection.StartingKM = 1;
//            invoiceCorrection.ReturnKM = 5;
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 40, MinUnit = "Day", Max = 50, MaxUnit = "KM", Price = 200, PriceType = "package", Status = 0 },
//            });
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMaxUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "Day", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_AmbigousMinUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "HelloWorld", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMaxUnitKM()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            invoiceCorrection.StartingKM = 1;
//            invoiceCorrection.ReturnKM = 5;
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "KM", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMaxUnitCurrency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "Currency", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMinUnitKM()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            invoiceCorrection.StartingKM = 1;
//            invoiceCorrection.ReturnKM = 5;
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Max = 10, MaxUnit = "KM", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMinUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Max = 10, MaxUnit = "Day", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_AmbigousMaxUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Max = 10, MaxUnit = "HelloWorld", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMinUnitCurrency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "Day", Max = 50, MaxUnit = "Currency", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMinUnitCurrencySpecial_RG_Surcharge()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Day", Max = 50, MaxUnit = "Currency", Price = 200, PriceType = "package", Status = 0 },
//            });
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 12198, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 12198, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMinUnitCurrencySpecial_RG_SurchargeWeek()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(8);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Week", Max = 50, MaxUnit = "Currency", Price = 200, PriceType = "package", Status = 0 },
//            });
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 12198, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 12198, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_GetStdExactSurchargeCondition_NoMinMax()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Price = 200, PriceType = "package", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        #endregion
//        #region Setups
//        private R_P_Invoice_Correction CheckSurcharge_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//            });
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 44, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 15 }
//            };
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR", ExchangeRate = (decimal)1.5, M_PickupCountryID = 81, M_ReturnCountryID = 81 });
//            invoiceCorrection.M_PickupCountryID = invoiceCorrection.M_ReturnCountryID = 39;
//            _mockBLL.Setup(x => x.GetListCountriesByCountryCode(It.IsAny<string>())).Returns(
//                new List<M_Country> { new M_Country { ID = 81, CountryCode = "DE", CountryName = "Germany", Status = 0, M_LanguageID = 3 } }
//            );

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction CheckSurcharge_Setup2(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.CarProviderID = 1;
//            invoiceCorrection.M_PickupCountryID = invoiceCorrection.M_ReturnCountryID = 15;
//            invoiceCorrection.GrossAmount = 5;
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = -1, GrossAmount = 1 }
//            };

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction CheckSurcharge_Setup3(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//            });
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "Percent", Max = 50, MaxUnit = "Percent", Price = 5, PriceType = "Percent", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "Percent", Min = 1, MinUnit = "Percent", Max = 7, MaxUnit = "Percent", Price = 200, PriceType = "Percent", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "Percent", Max = 200, MaxUnit = "Percent", Price = 0, PriceType = "Percent", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "Percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "Percent", MaxUnit = "Percent", Price = 0, PriceType = "Percent", Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 44, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 15 }
//            };
//            _mockBLL.Setup(x => x.GetInvoiceData(It.IsAny<long>()))
//                .Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR", ExchangeRate = (decimal)1.5, M_PickupCountryID = 81, M_ReturnCountryID = 81 });
//            invoiceCorrection.M_PickupCountryID = invoiceCorrection.M_ReturnCountryID = 39;
//            _mockBLL.Setup(x => x.GetListCountriesByCountryCode(It.IsAny<string>())).Returns(
//                new List<M_Country> { new M_Country { ID = 81, CountryCode = "DE", CountryName = "Germany", Status = 0, M_LanguageID = 3 } }
//            );

//            return invoiceCorrection;
//        }
//        private R_P_Invoice_Correction GetStdExactSurchargeCondition_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//            });
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(5);
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> { new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 15, Unit = "Percent" } };

//            return invoiceCorrection;
//        }
//        #endregion
//        #endregion

//        #region IsCombineSurchargeCorrectly via GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly_unlimitSurcharge_NotNull()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MaxPriceValue = 15, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", MaxPriceValue = 10, Min = 0, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine_stdUnitKM()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "KM", Max = 7, MaxUnit = "day", Price = 5, PriceType = "Unit", Status = 0, MinPriceValue = 25, MinPriceUnit = "Currency" },
//            });
//            invoiceCorrection.StartingKM = 96;
//            invoiceCorrection.ReturnKM = 100;
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine_stdUnitQuantity()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "Quantity", Max = 7, MaxUnit = "day", Price = 5, PriceType = "Unit", Status = 0, MinPriceValue = 25, MinPriceUnit = "Currency" },
//            });
//            invoiceCorrection.StartingKM = 96;
//            invoiceCorrection.ReturnKM = 100;
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine_stdUnitQuantityEqual0()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "Quantity", Max = 7, MaxUnit = "day", Price = 5, PriceType = "Unit", Status = 0, MinPriceValue = 25, MinPriceUnit = "Currency" },
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 0, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 44, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 0, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 15, Quantity = 1 }
//            };
//            invoiceCorrection.StartingKM = 96;
//            invoiceCorrection.ReturnKM = 100;
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly_Currency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly_Currency_UnitNotPercent()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> { new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 15, Unit = "PercentDif" } };
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>())).Returns(new List<R_I_Error> {
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 3, Comment = "Setup3 No Service", IsSkip = false, Status = 0, CorrectServiceID = 1 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly_CurrencyHasPrice()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly_Currency_PriceTypeUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup2_PriceTypeUnit(_mockBLL);
           
//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_IsCombineSurchargeCorrectly_Currency_PriceTypeUnit_HasPriceGreaterThan1()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup2_PriceTypeUnit(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = (decimal)1.5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = (decimal)1.5, PriceType = "unit", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>())).Returns(new List<R_I_Error>());
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>())).Returns(new List<R_I_Service>());

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }
//        #endregion
//        #region Setups
//        private R_P_Invoice_Correction IsCombineSurchargeCorrectly_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "combine", ChangeToExtraCharge = true, Status = 0 },
//            });

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction IsCombineSurchargeCorrectly_Setup2_PriceTypeUnit(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "unit", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 15, NetAmount = 10 }
//                });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 3, Comment = "Setup3 No Service", IsSkip = false, Status = 0, CorrectServiceID = 1 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0, CorrectServiceID = 1 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0, CorrectServiceID = 1 }
//                });

//            return invoiceCorrection;
//        }
//        #endregion
//        #endregion

//        #region IsCombine2SurchargeCorrectly via GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine2()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine2_unitLower_Day()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "day", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 15, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(2);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine2_unitLower_Month()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "month", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "month", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "month", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "month", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 25, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(2);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine2_unitLower_Month2()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "month", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "month", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 15, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "month", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "month", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 25, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(2);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckSurcharge_FormularType_Combine2_unitLower_Day_LesserPrice()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "day", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(2);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }


//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 1, MinUnit = "day", Max = 7, MaxUnit = "day", Price = 200, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_Currency()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_Currency_UnitNotPercent()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> { new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 15, Unit = "PercentDif" } };
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>())).Returns(new List<R_I_Error> {
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 3, Comment = "Setup3 No Service", IsSkip = false, Status = 0, CorrectServiceID = 1 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_Currency_isSetAcrErrorIsFalse()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "Hello", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> { new R_P_Invoice_Correction_Service { ID = 1, IsManualError = true, Status = 0, R_M_SurchargeID = 41, NetAmount = 15, Unit = "PercentDif" } };
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>())).Returns(new List<R_I_Error> {
//                new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 3, Comment = "Setup3 No Service", IsSkip = false, Status = 0, CorrectServiceID = 1 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(0, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_CurrencyHasPrice()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_Currency_PriceTypeUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup2_PriceTypeUnit(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_Currency_PriceTypeUnit_LargerMaxPriceValue()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup2_PriceTypeUnit(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 30, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 30, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "unit", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.PrevInvoiceErrorsList.Count);
//        }

//        [TestMethod]
//        public void Test_IsCombine2SurchargeCorrectly_Currency_PriceTypeUnit_HasPriceGreaterThan1()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsCombine2SurchargeCorrectly_Setup2_PriceTypeUnit(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = (decimal)1.5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = (decimal)1.5, PriceType = "unit", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>())).Returns(new List<R_I_Error>());
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>())).Returns(new List<R_I_Service>());

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
            
//            // Arrange
//            invoiceCorrection.CarProviderID = 4;
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 232, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5, Unit = "Percent" },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 232, NetAmount = 15, Unit = "Percent" },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 232, NetAmount = 15, Unit = "Percent" }
//            };
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 232, Applicable = false, FormularType = "combine", ChangeToExtraCharge = true, Status = 0 },
//            });

//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(12, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }
//        #endregion
//        #region Setups
//        private R_P_Invoice_Correction IsCombine2SurchargeCorrectly_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 3, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "combine2", ChangeToExtraCharge = true, Status = 0 },
//            });

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction IsCombine2SurchargeCorrectly_Setup2_PriceTypeUnit(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = IsCombineSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "percent", Min = 1, MinUnit = "currency", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "unit", Status = 0 }
//            });
//            _mockBLL.Setup(x => x.GetServicesList(It.IsAny<long>()))
//                .Returns(new List<R_I_Service>
//                {
//                    new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 15, NetAmount = 10 }
//                });
//            _mockBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>
//                {
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 3, Comment = "Setup3 No Service", IsSkip = false, Status = 0, CorrectServiceID = 1 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0, CorrectServiceID = 1 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0, CorrectServiceID = 1 }
//                });

//            return invoiceCorrection;
//        }
//        #endregion
//        #endregion

//        #region CheckVAT via GetInvoiceErrorViewModel
//        #region Tests
//        [TestMethod]
//        public void Test_CheckVAT()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckVAT_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT> { 
//                new R_RG_RateGridVAT { ID = 1, VAT = 10, Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_CheckVAT_TaxAmount()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckVAT_Setup2(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_CheckVAT_TaxAmount_HasVatTaxRate()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckVAT_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT> { 
//                new R_RG_RateGridVAT { ID = 1, VAT = 1, Status = 0, Min = 5 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_CheckVAT_TaxAmount_NoVatTaxRate()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckVAT_Setup2(_mockBLL);
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT> { 
//                new R_RG_RateGridVAT { ID = 1, VAT = 0, Status = 0, Min = 300 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_CheckVAT_NoTaxAmount()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckVAT_Setup2(_mockBLL);
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "6969", TaxRate = 5, NetAmount = 0, GrossAmount = 10 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", TaxRate = 5, NetAmount = 10, GrossAmount = 50 },
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, TaxRate = 5, NetAmount = 10, GrossAmount = 20 }
//            };

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }
//        #endregion
//        #region Setups
//        private R_P_Invoice_Correction CheckVAT_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = GetInvoiceErrorViewModel_Setup2(_mockBLL);
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "6969", TaxRate = 5, NetAmount = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", TaxRate = 5, NetAmount = 10 },
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, TaxRate = 5, NetAmount = 10 }
//            };

//            return invoiceCorrection;
//        }

//        private R_P_Invoice_Correction CheckVAT_Setup2(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckVAT_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT> { 
//                new R_RG_RateGridVAT { ID = 1, VAT = 10, Status = 0, Max = 15, Min = 5 }
//            });
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service>
//            {
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "6969", TaxRate = 5, NetAmount = 0, TaxAmount = 10 },
//                new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC", TaxRate = 5, NetAmount = 10, TaxAmount = 10 },
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, TaxRate = 5, NetAmount = 10, TaxAmount = 10 }
//            };

//            return invoiceCorrection;
//        }
//        #endregion
//        #endregion

//        #region IsExactSurchargeCorrectly
//        #region Tests
//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly1()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Day", Max = 50, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Range", Status = 0 },
//            });
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(1);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly2()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Day", Max = 15, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Range", Status = 0 },
//            });
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(1);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly3()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", Max = 15, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Range", Status = 0 },
//            });
//            var date = DateTime.Now;
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(1);

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Act2 AllowCheaper
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Act3 WhiteSpace Unit
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = " ", Max = 15, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Range", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Act3 priceInInvoice == stdSurcharge.Min.Value
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Day", Max = 0, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Range", Status = 0 },
//            });
//            date = DateTime.Now;
//            invoiceCorrection.ListService = new List<R_P_Invoice_Correction_Service> {
//                new R_P_Invoice_Correction_Service { ID = 1, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 2, IsManualError = false, Status = 0, R_M_SurchargeID = 44, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 3, IsManualError = false, Status = 0, R_M_SurchargeID = 45, NetAmount = 15 },
//                new R_P_Invoice_Correction_Service { ID = 4, IsManualError = false, Status = 0, R_M_SurchargeID = 15, NetAmount = 15, Quantity = 1, UnitPrice = 10, GrossAmount = 10, TaxAmount = 5 },
//                new R_P_Invoice_Correction_Service { ID = 5, IsManualError = false, Status = 0, R_M_SurchargeID = 41, NetAmount = 10 }
//            };
//            invoiceCorrection.PickUpTime = date;
//            invoiceCorrection.ReturnTime = date.AddDays(15);
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly_Unit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", Max = 15, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Unit", Status = 0 },
//            });
            
//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Act2 stdSurcharge.Max.Value == netAmountInInvoice
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", Max = 22.5M, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            // Act3 Price = 0
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", Max = 22.5M, MaxUnit = "Currency", Price = 0, Min = 1, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            // Act3 Price = 0 and stdSurcharge.Max.Value < netAmountInInvoice
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", Max = 20, MaxUnit = "Currency", Price = 0, Min = 1, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Act4 stdSurcharge.Max.Value / stdSurcharge.Price < currentService.Quantity.Value FALSE
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", Max = 200, MaxUnit = "Currency", Price = 200, Min = 1, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly_Unit_NoMax()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 2, Min = 5, MinUnit = "Currency", PriceType = "Unit", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 2, Min = 22.5M, MinUnit = "Currency", PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 0, Min = 22.5M, MinUnit = "Currency", PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 0, Min = 200, MinUnit = "Currency", PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 2, Min = 1, MinUnit = "Currency", PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }
//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly_Unit_NoMinUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 2, Min = 5, PriceType = "Unit", Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxPriceUnit = "Currency", Price = 2, MaxPriceValue = 22.5M, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxPriceUnit = "Currency", Price = 50, MaxPriceValue = 22.5M, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MinPriceValue = 22.5M, MinPriceUnit = "Currency", Price = 0, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MinPriceValue = 22.5M, MinPriceUnit = "Currency", Price = 50, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MinPriceValue = 20, MinPriceUnit = "Currency", Price = 50, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "NotDay", MinPriceValue = 25, MinPriceUnit = "Currency", Price = 50, PriceType = "Unit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsExactSurchargeCorrectly_NotUnit()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = IsExactSurchargeCorrectly_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 0, Min = 5, PriceType = "NotUnit", MinPriceValue = 30, Status = 0 },
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Percent", MinUnit = "Percent", MaxPriceUnit = "Currency", Price = 0, PriceType = "Formular", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 0, Min = 30, PriceType = "NotUnit", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(9, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 12198, Unit = "NotDay", MaxUnit = "Currency", Price = 0, Max = 20, PriceType = "Rate", Status = 0 },
//            });
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 5, R_RG_SurchargeID = 12198, Unit = "KM", MinPriceValue = 22.5M, MinPriceUnit = "Currency", Price = 50, PriceType = "Unit", Status = 0 },
//            });
//            invoiceCorrection.StartingKM = 1;
//            invoiceCorrection.ReturnKM = 1.45M;
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            Assert.AreEqual(8, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//        }
//        #endregion
//        #region Setups
//        private R_P_Invoice_Correction IsExactSurchargeCorrectly_Setup1(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            invoiceCorrection.ListMapService = new List<P_MapService> { new P_MapService { DebitID = 1, CreditID = 0 } };
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 12198, Unit = "Day", Max = 50, MaxUnit = "Currency", Price = 200, PriceType = "Range", Status = 0 },
//            });
//            _mockBLL.Setup(x => x.GetSurchargesListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_Surcharge> {
//                new R_RG_Surcharge { ID = 0, R_RG_RateGridID = 1, M_SurchargeID = 1, Applicable = true, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 1, R_RG_RateGridID = 1, M_SurchargeID = 2, Applicable = false, FormularType = "", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 2, R_RG_RateGridID = 1, M_SurchargeID = 5, Applicable = true, FormularType = "", ChangeToExtraCharge = true, Status = 0, ValidFrom = "09.09", ValidTo = "09.09" },
//                new R_RG_Surcharge { ID = 12198, R_RG_RateGridID = 1, M_SurchargeID = 15, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//                new R_RG_Surcharge { ID = 12198, R_RG_RateGridID = 1, M_SurchargeID = 41, Applicable = false, FormularType = "exact", ChangeToExtraCharge = true, Status = 0 },
//            });

//            return invoiceCorrection;
//        }
//        #endregion
//        #endregion

//        #region IsPercentageSurchargeCorrectly via CheckSurcharge
//        #region Tests
//        [TestMethod]
//        public void Test_IsPercentageSurchargeCorrectly()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 50, MinUnit = "day", Max = 57, MaxUnit = "Currency", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 45, MinUnit = "day", Max = 45, MaxUnit = "Currency", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 50, MinUnit = "day", Max = 7, MaxUnit = "Currency", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            /*
//             * MaxUnit=='Percent'
//             */
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 50, MinUnit = "day", Max = 57, MaxUnit = "Percent", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 0, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(false);
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsPercentageSurchargeCorrectly1()
//        {
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 50, MinUnit = "day", Max = 37, MaxUnit = "Percent", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 50, MinUnit = "Currency", MaxUnit = "Percent", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Min = 50, MinUnit = "Percent", MaxUnit = "Percent", Price = -200M, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(false);
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(3, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//        }

//        [TestMethod]
//        public void Test_IsPercentageSurchargeCorrectly2()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", MinUnit = "day", MaxUnit = "Percent", Price = 50M, Min = 50, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", MinUnit = "Percent", MaxUnit = "Percent", Price = 50M, Min = 50, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", MinUnit = "Currency", MaxUnit = "Percent", Price = 50M, Min = 50, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }


//        [TestMethod]
//        public void Test_IsPercentageSurchargeCorrectly3()
//        {
//            // Arrange
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            var invoiceCorrection = CheckSurcharge_Setup1(_mockBLL);

//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", Max = 200, MinUnit = "day", MaxUnit = "Percent", Price = 50M, Min = 50, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });

//            // Act
//            var actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);

//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", MinUnit = "Percent", MaxUnit = "Percent", Price = 50M, Min = 50, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });

//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);

//            // Assert
//            Assert.AreEqual(10, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.GetStdSurchargeConditionsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_SurchargeConditionExtra> {
//                new R_RG_SurchargeConditionExtra { ID = 1, R_RG_SurchargeID = 12198, Unit = "day", Max = 50, MaxUnit = "currency", Price = 5, PriceType = "unit", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 2, R_RG_SurchargeID = 3, Unit = "package", MinUnit = "Currency", MaxUnit = "Percent", Price = 50M, Min = 50, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 3, R_RG_SurchargeID = 12198, Unit = "package", Max = 200, MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 },
//                new R_RG_SurchargeConditionExtra { ID = 4, R_RG_SurchargeID = 3, Unit = "percent", Max = 200, MaxPriceValue = 10, MaxPriceUnit = "currency", MaxUnit = "currency", Price = 10, PriceType = "package", Status = 0 }
//            });
            
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
            
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);

//            // Arrange
//            _mockBLL.Setup(x => x.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
            
//            // Act
//            actual = _mockBLL.Object.GetInvoiceErrorViewModel(invoiceCorrection);
            
//            // Assert
//            Assert.AreEqual(11, actual.InvoiceErrorsList.Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 2).ToList().Count);
//            Assert.AreEqual(4, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 5).ToList().Count);
//            Assert.AreEqual(1, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 6).ToList().Count);
//            Assert.AreEqual(2, actual.InvoiceErrorsList.Where(x => x.R_M_InvoiceErrorCodeID == 7).ToList().Count);
//        }
//        #endregion
//        #region Setups
//        #endregion
//        #endregion

//        #region GetInvoiceErrors

//        #region Setups

//        #endregion

//        #region Tests

//        /// <summary>
//        /// Scenario: image.R_RG_RateGridID is null
//        /// </summary>
//        [TestMethod]
//        public void Test_GetInvoiceErrors_0()
//        {
//            // Arrange
//            var mockVerifyInvoiceBLL = new Mock<VerifyInvoiceBLL>();
//            var image = new R_I_Image();
//            var invoiceData = new R_I_Data();
//            var errorsList = new List<R_I_Error>();
//            var prevErrorsList = new List<R_I_Error>();
//            var servicesInInvoiceList = new List<R_I_Service>();
//            R_I_Image preImage = null;

//            mockVerifyInvoiceBLL.Setup(m => m.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            mockVerifyInvoiceBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.RNF, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.RNF));

//            // Act
//            mockVerifyInvoiceBLL.Object.GetInvoiceErrors(image, ref preImage, invoiceData, servicesInInvoiceList, ref errorsList, ref prevErrorsList);

//            // Assert
//            // It's must return one RNF invoice error in the errorsList
//            Assert.AreEqual(1, errorsList.Count);
//            Assert.AreEqual(1, errorsList.Count(e => e.R_M_InvoiceErrorCodeID == 1));
//        }
        
//        /// <summary>
//        /// Scenario: Invoice currency <> Rate Grid currency
//        /// </summary>
//        [TestMethod]
//        public void Test_GetInvoiceErrors_1()
//        {
//            // Arrange
//            var mockVerifyInvoiceBLL = new Mock<VerifyInvoiceBLL>();
//            var image = new R_I_Image { ID = 100, R_B_AccessID = 1, R_RG_RateGridID = 1, HasRateGrid = true, ImageStatus = "Processing" };
//            var invoiceData = new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR" };
//            var errorsList = new List<R_I_Error>();
//            var prevErrorsList = new List<R_I_Error>();
//            var servicesInInvoiceList = new List<R_I_Service>();
//            R_I_Image preImage = null;

//            //SetupInitErrorInvoice(mockVerifyInvoiceBLL);
//            mockVerifyInvoiceBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), It.IsAny<ErrorsType>(), It.IsAny<decimal>())).CallBase();
//            mockVerifyInvoiceBLL.Setup(m => m.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            mockVerifyInvoiceBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD", M_CarRentalProviderID = 2 });
//            mockVerifyInvoiceBLL.Setup(x => x.GetServiceKeywordsListByCarRentalProviderId(It.IsAny<long>())).Returns(new List<R_M_Service_Keyword>());
            
//            // Act
//            mockVerifyInvoiceBLL.Object.GetInvoiceErrors(image, ref preImage, invoiceData, servicesInInvoiceList, ref errorsList, ref prevErrorsList);

//            // Assert
//            // It's must return one WRC invoice error in the errorsList
//            Assert.AreEqual(1, errorsList.Count);
//            Assert.AreEqual(1, errorsList.Count(e => e.R_M_InvoiceErrorCodeID == 26));
            
//            // Arrange
//            errorsList = new List<R_I_Error>();
//            invoiceData.ExchangeRate = 5;
//            mockVerifyInvoiceBLL.Setup(m => m.GetRelateImage(100)).Returns(new R_I_Image { ID = 200, R_B_AccessID = 1, R_RG_RateGridID = 1, HasRateGrid = true, ImageStatus = "Processing" });
//            mockVerifyInvoiceBLL.Setup(x => x.GetInvoiceData(200)).Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR", ExchangeRate = 7 });
//            mockVerifyInvoiceBLL.Setup(x => x.GetServicesList(It.IsAny<long>())).Returns(new List<R_I_Service>{new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 1, NetAmount = 10 }});
//            mockVerifyInvoiceBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT> { new R_RG_RateGridVAT { ID = 1, VAT = 10, Status = 0 }});

//            servicesInInvoiceList = new List<R_I_Service>()
//            {
//                new R_I_Service{NetAmount = 200, ID = 1, R_M_SurchargeID = 1},
//                new R_I_Service{NetAmount = 200, ID = 3}
//            };

//            // Act
//            mockVerifyInvoiceBLL.Object.GetInvoiceErrors(image, ref preImage, invoiceData, servicesInInvoiceList, ref errorsList, ref prevErrorsList);

//            // Assert
//            // It's must return only one WRC invoice error in the errorsList
//            Assert.AreEqual(2, errorsList.Count);
//            Assert.AreEqual(2, errorsList.Count(e => e.R_M_InvoiceErrorCodeID == 4));
//        }

//        [TestMethod]
//        public void Test_GetInvoiceErrors_2()
//        {
//            // Arrange
//            var mockVerifyInvoiceBLL = new Mock<VerifyInvoiceBLL>();
//            var image = new R_I_Image { ID = 100, R_B_AccessID = 1, R_RG_RateGridID = 1, HasRateGrid = true, ImageStatus = "Processing" };
//            var invoiceData = new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR", ExchangeRate = 5 };
//            var errorsList = new List<R_I_Error>();
//            var prevErrorsList = new List<R_I_Error>();
//            var servicesInInvoiceList = new List<R_I_Service>();
//            R_I_Image preImage = null;

//            mockVerifyInvoiceBLL.Setup(m => m.CheckAlowCheaper(It.IsAny<long>())).Returns(true);
//            mockVerifyInvoiceBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.RNF, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.RNF));
//            mockVerifyInvoiceBLL.Setup(m => m.GetRelateImage(100)).Returns(new R_I_Image { ID = 200, R_B_AccessID = 1, R_RG_RateGridID = 1, HasRateGrid = true, ImageStatus = "Processing" });
//            mockVerifyInvoiceBLL.Setup(x => x.GetInvoiceData(200)).Returns(new R_I_Data { ID = 1, R_I_ImageID = 1, R_M_SippCodeID = 1, CarGroup = "CBMR", Currency = "EUR" });
//            mockVerifyInvoiceBLL.Setup(x => x.GetStdRateGrid(It.IsAny<long>())).Returns(new R_RG_RateGrid { Currency = "USD", M_CarRentalProviderID = 2 });
//            mockVerifyInvoiceBLL.Setup(x => x.GetServiceKeywordsListByCarRentalProviderId(It.IsAny<long>()))
//                .Returns(new List<R_M_Service_Keyword>
//                {
//                    new R_M_Service_Keyword { M_CarRentalProviderID = 1, R_M_SurchargeID = 1, M_LanguageID = 3, ServiceName = "Standortzuschlag"},
//                    new R_M_Service_Keyword { M_CarRentalProviderID = 1, R_M_SurchargeID = 12, M_LanguageID = 1, ServiceName = "Gasoline"}
//                });

//            mockVerifyInvoiceBLL.Setup(x => x.GetServicesList(It.IsAny<long>())).Returns(new List<R_I_Service>{new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 1, NetAmount = 10 }});
//            mockVerifyInvoiceBLL.Setup(x => x.GetErrorsListByRIDataID(It.IsAny<long>()))
//                .Returns(new List<R_I_Error>{
//                    new R_I_Error { R_I_DataID = 1, Comment = "Setup3 No Service", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 0, Comment = "Setup3 Service_ID 0", IsSkip = false, Status = 0 },
//                    new R_I_Error { R_I_DataID = 1, R_I_ServiceID = 1, Comment = "Setup3 Has Service", IsSkip = false, Status = 0 }
//                });

//            mockVerifyInvoiceBLL.Setup(x => x.GetStdRateGridDetailsListByRateGridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridDetail>{new R_RG_RateGridDetail { R_RG_RateGridID = 1, R_M_SippCodeID = 1 }});
//            mockVerifyInvoiceBLL.Setup(x => x.GetVATsByRategridId(It.IsAny<long>())).Returns(new List<R_RG_RateGridVAT> { new R_RG_RateGridVAT { ID = 1, VAT = 10, Status = 0 }});

//            // Act
//            mockVerifyInvoiceBLL.Object.GetInvoiceErrors(image, ref preImage, invoiceData, servicesInInvoiceList, ref errorsList, ref prevErrorsList);

//            // Assert
//            Assert.AreEqual(1, preImage.R_RG_RateGridID);
//        }

//        #endregion

//        #endregion

//        #region GetLocationFee
//        #region Tests
//        [TestMethod]
//        public void Test_GetLocationFee()
//        {
//            var _mockBLL = new Mock<VerifyInvoiceBLL>();
//            _mockBLL.Setup(x => x.GetRateGridByID(It.IsAny<long>())).Returns((R_RG_RateGrid)null);
//            var actual = _mockBLL.Object.GetLocationFee(0, 0);
//            Assert.AreEqual(0, actual);

//            _mockBLL.Setup(x => x.GetRateGridByID(It.IsAny<long>())).Returns(new R_RG_RateGrid { UseLocation = true });
//            _mockBLL.Setup(x => x.GetListR_RG_LocationByCondition(It.IsAny<long>(), It.IsAny<int>(), It.IsAny<string>())).Returns((List<R_RG_Location>)null);
//            actual = _mockBLL.Object.GetLocationFee(0, 0);
//            Assert.AreEqual(0, actual);

//            _mockBLL.Setup(x => x.GetListR_RG_LocationByCondition(It.IsAny<long>(), It.IsAny<int>(), It.IsAny<string>())).Returns(new List<R_RG_Location>
//                {
//                    new R_RG_Location { ID = 1, Status = 0, MinDay = 0, MaxDay = 9999 },
//                    new R_RG_Location { ID = 2, Status = 0, MinDay = 0, MaxDay = 15, Unit = "Day" }
//                });
//            actual = _mockBLL.Object.GetLocationFee(0, 0);
//            Assert.AreEqual(0, actual);

//            _mockBLL.Setup(x => x.GetListR_RG_LocationByCondition(It.IsAny<long>(), It.IsAny<int>(), It.IsAny<string>())).Returns(new List<R_RG_Location>
//                {
//                    new R_RG_Location { ID = 1, Status = 0, MinDay = 0, MaxDay = 9999 },
//                    new R_RG_Location { ID = 2, Status = 0, MinDay = 0, MaxDay = 15, Unit = "Day", Rate = 0 }
//                });
//            actual = _mockBLL.Object.GetLocationFee(0, 0);
//            Assert.AreEqual(0, actual);

//            _mockBLL.Setup(x => x.GetListR_RG_LocationByCondition(It.IsAny<long>(), It.IsAny<int>(), It.IsAny<string>())).Returns(new List<R_RG_Location>
//                {
//                    new R_RG_Location { ID = 1, Status = 0, MinDay = 0, MaxDay = 9999 },
//                    new R_RG_Location { ID = 2, Status = 0, MinDay = 0, MaxDay = 15, Unit = "Day", Rate = 15 }
//                });
//            actual = _mockBLL.Object.GetLocationFee(0, 0);
//            Assert.AreEqual(0, actual);

//            _mockBLL.Setup(x => x.GetListR_RG_LocationByCondition(It.IsAny<long>(), It.IsAny<int>(), It.IsAny<string>())).Returns(new List<R_RG_Location>
//                {
//                    new R_RG_Location { ID = 1, Status = 0, MinDay = 16, MaxDay = 9999 },
//                    new R_RG_Location { ID = 2, Status = 0, MinDay = 15, MaxDay = 15, Unit = "Week", Rate = 15 }
//                });
//            actual = _mockBLL.Object.GetLocationFee(0, 0);
//            Assert.AreEqual(0, actual);
//        }
//        #endregion
//        #region Setups
//        #endregion
//        #endregion
        
//        private void SetupInitErrorInvoice(Mock<VerifyInvoiceBLL> _mockBLL)
//        {
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.RNF, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.RNF));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.SNA, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.SNA));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.WRC, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.WRC));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.WCG, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.WCG));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.VAT, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.VAT));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.ICC, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.ICC));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.ACR, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.ACR));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.TAE, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.TAE));
//            _mockBLL.Setup(x => x.InitErrorInvoice(It.IsAny<long?>(), It.IsAny<long?>(), ErrorsType.WRR, It.IsAny<decimal>())).Returns(R_I_Error(ErrorsType.WRR));
//        }

//        private R_P_Invoice_Correction InitInvoiceCorrection()
//        {
//            var invoiceCorrection = new R_P_Invoice_Correction
//            {
//                R_I_ImageID = 1,
//                R_RG_RateGridID = 1,
//                ListService = new List<R_P_Invoice_Correction_Service>
//                {
//                    new R_P_Invoice_Correction_Service { IsManualError = true, Status = 0 },
//                    new R_P_Invoice_Correction_Service { IsManualError = true, Status = 0 },
//                    new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0 },
//                    new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "6969" },
//                    new R_P_Invoice_Correction_Service { IsManualError = false, Status = 0, R_M_SurchargeID = 68, ServiceCode = "AKMC"},
//                    new R_P_Invoice_Correction_Service { IsManualError = true, Status = 0, ID = 69 }
//                },
//                Currency = "EUR"
//            };
//            return invoiceCorrection;
//        }

//        private List<R_I_Error> ListInvoiceErrors()
//        {
//            return new List<R_I_Error>
//            {
//                new R_I_Error
//                {
//                    R_I_DataID = 1,
//                    R_I_ServiceID = 1,
//                    R_M_InvoiceErrorCodeID = 1,
//                    IsSkip = true,
//                    CreatedDate = DateTime.Now,
//                    UpdatedDate = DateTime.Now,
//                    Status = 0
//                },
//                new R_I_Error
//                {
//                    R_I_DataID = 1,
//                    IsSkip = false,
//                    R_M_InvoiceErrorCodeID = 2,
//                    CreatedDate = DateTime.Now,
//                    UpdatedDate = DateTime.Now,
//                    Status = 1
//                },
//                new R_I_Error
//                {
//                    R_I_DataID = 1,
//                    R_I_ServiceID = 69,
//                    R_M_InvoiceErrorCodeID = 1,
//                    IsSkip = false,
//                    CreatedDate = DateTime.Now,
//                    UpdatedDate = DateTime.Now,
//                    Status = 0
//                },
//                new R_I_Error
//                {
//                    R_I_DataID = 1,
//                    R_I_ServiceID = 69,
//                    IsSkip = true,
//                    R_M_InvoiceErrorCodeID = 2,
//                    CreatedDate = DateTime.Now,
//                    UpdatedDate = DateTime.Now,
//                    Status = 1
//                }
//            };
//        }

//        private R_P_Invoice_Correction AddChargeAmountData(R_P_Invoice_Correction invoiceCorrection)
//        {
//            invoiceCorrection.BillingAmount = 1;
//            invoiceCorrection.GrossAmount = 3;
//            invoiceCorrection.NetAmount = 1;
//            invoiceCorrection.TaxAmount = 2;
//            invoiceCorrection.ExchangeRate = (decimal)1.5;
//            invoiceCorrection.ListService.ForEach(x =>
//            {
//                x.GrossAmount = 3;
//                x.NetAmount = 2;
//                x.TaxAmount = 1;
//            });
//            return invoiceCorrection;
//        }

//        private R_I_Error R_I_Error(ErrorsType errorType)
//        {
//            var result = new R_I_Error
//            {
//                R_I_DataID = 1,
//                R_I_ServiceID = 1,
//                Comment = "NewString",
//                IsSkip = false,
//                Status = 0
//            };

//            switch (errorType)
//            {
//                case ErrorsType.RNF:
//                    result.R_M_InvoiceErrorCodeID = 1;
//                    break;
//                case ErrorsType.SNA:
//                    result.R_M_InvoiceErrorCodeID = 2;
//                    break;
//                case ErrorsType.WRC:
//                    result.R_M_InvoiceErrorCodeID = 3;
//                    break;
//                case ErrorsType.WCG:
//                    result.R_M_InvoiceErrorCodeID = 4;
//                    break;
//                case ErrorsType.VAT:
//                    result.R_M_InvoiceErrorCodeID = 5;
//                    break;
//                case ErrorsType.ICC:
//                    result.R_M_InvoiceErrorCodeID = 6;
//                    break;
//                case ErrorsType.ACR:
//                    result.R_M_InvoiceErrorCodeID = 7;
//                    break;
//                case ErrorsType.TAE:
//                    result.R_M_InvoiceErrorCodeID = 8;
//                    break;
//                case ErrorsType.WRR:
//                    result.R_M_InvoiceErrorCodeID = 9;
//                    break;
//            }

//            return result;
//        }
//    }
//}
