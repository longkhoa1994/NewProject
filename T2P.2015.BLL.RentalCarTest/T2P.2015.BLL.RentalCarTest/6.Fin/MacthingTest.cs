using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.BLL.RentalCarTest._1.Booking;

namespace T2P._2015.BLL.RentalCarTest._6.Fin
{
    [TestClass]
    public class MacthingTest
    {
        [TestMethod]
        public void TestMatching()
        {
            //Input
            InitDataRentalCar initData = new InitDataRentalCar();
            DateTime date = DateTime.Now;
            initData.CreateData(date, 0, 0);
            //Action


            //Output
        }
    }
}
