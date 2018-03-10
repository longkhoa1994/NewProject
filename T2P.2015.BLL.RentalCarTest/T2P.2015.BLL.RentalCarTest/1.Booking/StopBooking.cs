using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.BLL.CarRental;
using System.Transactions;
using T2P._2015.Cross.Model;

namespace T2P._2015.BLL.RentalCarTest._1.Booking
{
    /// <summary>
    /// Summary description for StopBooking
    /// </summary>
    [TestClass]
    public class StopBooking
    {

        [TestMethod]
        public void Booking_Has_Fin_After_7Days()
        {
            using (var cop = new TransactionScope())
            {
                InitDataRentalCar InitData = new InitDataRentalCar();
                InitDataRentalCar.InnitData hgjfgj = InitData.CreateData(DateTime.Now.AddDays(-10), 1, 0);
                StopBLL output = new StopBLL();
                output.Process();
                R_B_Access oupts = BaseBLL.Instance.GetByID<R_B_Access>(hgjfgj.R_B_Acces.ID);
                if (oupts != null)
                {
                    Assert.IsTrue("Processing" == oupts.BookingStatus);
                }
            }
        }
        [TestMethod]
        public void Booking_Has_Inv_After_7Days()
        {

                InitDataRentalCar InitData = new InitDataRentalCar();
                InitDataRentalCar.InnitData hgjfgj = InitData.CreateData(DateTime.Now.AddDays(-10), 1, 0);
                StopBLL output = new StopBLL();
                output.Process();
                R_B_Access oupts = BaseBLL.Instance.GetByID<R_B_Access>(hgjfgj.R_B_Acces.ID);
                if (oupts != null)
                {
                    Assert.IsTrue("Processing" == oupts.BookingStatus);
                }
            
        }

        [TestMethod]
        public void Booking_No_Inv_And_No_Fin_After_7Days()
        {
            using (var cop = new TransactionScope())
            {
                InitDataRentalCar InitData = new InitDataRentalCar();
                InitDataRentalCar.InnitData hgjfgj = InitData.CreateData(DateTime.Now.AddDays(-10), 0, 0);
                StopBLL output = new StopBLL();
                output.Process();
                R_B_Access oupts = BaseBLL.Instance.GetByID<R_B_Access>(hgjfgj.R_B_Acces.ID);
                if (oupts != null)
                {
                    Assert.IsTrue("StopProcess" == oupts.BookingStatus);
                }
            }
        }

        [TestMethod]
        public void Booking_Has_Fin_Before_7Days()
        {
            using (var cop = new TransactionScope())
            {
                InitDataRentalCar InitData = new InitDataRentalCar();
                InitDataRentalCar.InnitData hgjfgj = InitData.CreateData(DateTime.Now, 1, 0);
                StopBLL output = new StopBLL();
                output.Process();
                R_B_Access oupts = BaseBLL.Instance.GetByID<R_B_Access>(hgjfgj.R_B_Acces.ID);
                if (oupts != null)
                {
                    Assert.IsTrue("Processing" == oupts.BookingStatus);
                }
            }
        }
        [TestMethod]
        public void Booking_Has_Inv_Before_7Days()
        {
            using (var cop = new TransactionScope())
            {
                InitDataRentalCar InitData = new InitDataRentalCar();
                InitDataRentalCar.InnitData hgjfgj = InitData.CreateData(DateTime.Now, 0, 1);
                StopBLL output = new StopBLL();
                output.Process();
                R_B_Access oupts = BaseBLL.Instance.GetByID<R_B_Access>(hgjfgj.R_B_Acces.ID);
                if (oupts != null)
                {
                    Assert.IsTrue("Processing" == oupts.BookingStatus);
                }
            }
        }

        [TestMethod]
        public void Booking_No_Inv_And_No_Fin_Before_7Days()
        {
            using (var cop = new TransactionScope())
            {
                InitDataRentalCar InitData = new InitDataRentalCar();
                InitDataRentalCar.InnitData hgjfgj = InitData.CreateData(DateTime.Now, 0, 0);
                StopBLL output = new StopBLL();
                output.Process();
                R_B_Access oupts = BaseBLL.Instance.GetByID<R_B_Access>(hgjfgj.R_B_Acces.ID);
                if (oupts != null)
                {
                    Assert.IsTrue("Processing" == oupts.BookingStatus);
                }
            }
        }
    }
}
