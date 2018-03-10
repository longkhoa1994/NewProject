using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.Cross.Utility.FileType;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using T2P._2015.BLL.Financial;
using T2P._2015.BLL.Invoice;
using T2P._2015.BLL.Master;
using T2P._2015.BLL.Notification;
using T2P._2015.BLL.Process;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Model;
using T2P._2015.Cross.Model._2.Hotel.Process;
using T2P._2015.Cross.Model.Process;
using T2P._2015.Cross.Utility.Configuration;
using T2P._2015.Cross.Utility.Conversion;
using T2P._2015.Cross.Utility.Encryption;
using T2P._2015.Cross.Utility.Log;
using T2P._2015.Cross.Utility.Network;
using T2P._2015.Model;
using T2P._2015.BLL.CarRental._2.Invoice;

namespace T2P._2015.BLL.RentalCarTest._4.Report
{
    /// <summary>
    /// Summary description for ExcelTest
    /// </summary>
    [TestClass]
    public class ExcelTest
    {
        public ExcelTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CreateImportDataReport()
        {
            var inputFile = @"C:\Users\hieu.nguyen\Desktop\Bayer_itelya_Reservation.xls";
            var outputTemplate = @"C:\Users\hieu.nguyen\Desktop\template.xlsx";
            var outputFile = @"\Users\hieu.nguyen\Desktop\Bayer_itelya_Reservation_Report.xls";
            var excel = new Excel();
            var listAddtions = new List<List<string>>();
            listAddtions.Add(new List<string> { "ERROR" });
            listAddtions.Add(new List<string> { "Missing Some thing " });
            excel.CreateImportDataReport(inputFile, 0, outputFile, 2, outputTemplate, listAddtions, "ReservationReport");
        }

        [TestMethod]
        public void TestReadFile()
        {
            InvoiceDataBLL invoicedata = new InvoiceDataBLL();
            invoicedata.ReadFile(@"C:\Users\khoa.ngo\Desktop\TemplateInvoiceData27022018_02 - Copy.xls");
        }

    }
}
