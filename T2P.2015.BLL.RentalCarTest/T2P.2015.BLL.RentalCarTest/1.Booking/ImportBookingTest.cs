using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.Cross.Model;
using T2P._2015.BLL.CarRental;
using Moq;
using T2P._2015.BLL.Interface;
using T2P._2015.BLL.Master;
using T2P._2015.DAL.CarRental;
using T2P._2015.Cross.Enum.CarRental.CarProvider;

namespace T2P._2015.BLL.RentalCarTest._1.Booking
{
    [TestClass]
    public class ImportBookingTest
    {

        [TestMethod]
        public void Test_ValidateImportBooking_Missing_Reservation_Status()
        {
            try
            {
                // arrange  
                List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
                P_RImportBooking item = new P_RImportBooking();
                item.R_B_Header = new R_B_Header();
                item.R_B_Booking = new R_B_Booking();
                listp_RImportBooking.Add(item);
                bool result = false;
                // act
                R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

                // assert
                if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "ReservationStatus is missing." && x.R_B_Booking.Status == 3))
                {
                    result = true;
                }
                Assert.IsTrue(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Wrong_Reservation_Status()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item =new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Test Status Wrong"
            };
            item.R_B_Booking = new R_B_Booking() 
            { 
            };
            listp_RImportBooking.Add(item);
            bool result = false;
            // act
            R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking,Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "ReservationStatus is wrong." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Invalid_TimeStamp_Information()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.MinValue.Date
            };
            item.R_B_Booking = new R_B_Booking()
            {
            };
            listp_RImportBooking.Add(item);
            bool result = false;
            // act
            R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Invalid TimeStamp information." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Reservation_Number_Is_Missing()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now    
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo ="",
            };
            listp_RImportBooking.Add(item);
            bool result = false;
            // act
            R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Reservation number is missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_For_R_B_Header()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            
            item = new P_RImportBooking();
            item.R_B_Booking = new R_B_Booking();
            item.R_B_Header = new R_B_Header() { ReservationStatus = ""};
            //Reservation is missing
            listp_RImportBooking.Add(item);


            item = new P_RImportBooking();
            item.R_B_Booking = new R_B_Booking();
            item.R_B_Header = new R_B_Header() { ReservationStatus = "Test is wrong" };
            //ReservationStatus is wrong
            listp_RImportBooking.Add(item);

            item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header() 
            { 
                ReservationStatus = "Cancel" ,
                TimeStamp = DateTime.MinValue.Date
            };
            item.R_B_Booking = new R_B_Booking();
            //Invalid TimeStamp information.
            listp_RImportBooking.Add(item);

            item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking();
            //Reservation number is missing
            listp_RImportBooking.Add(item);
            

            bool result = false;
            // act
            R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking[0].R_B_Booking.AdditionInformation == "ReservationStatus is missing."
                && listp_RImportBooking[1].R_B_Booking.AdditionInformation == "ReservationStatus is wrong."
                && listp_RImportBooking[2].R_B_Booking.AdditionInformation == "Invalid TimeStamp information."
                && listp_RImportBooking[3].R_B_Booking.AdditionInformation == "Reservation number is missing.")
            {
                if (listp_RImportBooking.Any(x => x.R_B_Booking.Status != 3))
                {
                    result = false;
                }
                else
                    result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_CustomerNameORCustomerCode_Is_Missing()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
            };
            listp_RImportBooking.Add(item);
            bool result = false;
            // act
            R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Customer name or Customer code is missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Duplicate_BookingNumber()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Customer Name Test",
                CustomerNo = "Customer No",
            };
            listp_RImportBooking.Add(item);

            item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Customer Name Test",
                CustomerNo = "Customer No",
            };
            listp_RImportBooking.Add(item);

            bool result = false;
            // act
            R_B_BookingBLL.BLL.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Reservation number " + x.R_B_Booking.BookingNo + " is duplicated in file." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Customer_Name_Customer_Code_Is_Wrong()
        {
            // arrange  
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();

            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Customer Name Test",
                CustomerNo = "Customer No",
            };
            listp_RImportBooking.Add(item);
            bool result = false;


            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();
            List<R_B_Booking> list = null;
            _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(list);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(1);
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Customer name or Customer code is wrong" && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Traveler_Name_Is_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();
            
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName,item.R_B_Booking.CustomerNo,"1","2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Traveler Name is missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Traveler_Email_Is_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test"
            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Traveler email is missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_CarRental_Provider_Is_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();
            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test"
            };

            listp_RImportBooking.Add(item);
           
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);

            List<R_B_Booking> lstR_B_Booking = new List<R_B_Booking>();
            _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(lstR_B_Booking);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Car Rental Provider is missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_CarRental_Category_Is_Missing()
        {
            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();

            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "Sixt",
            };

            List<R_B_Booking> lstR_B_Booking = new List<R_B_Booking>();

            listp_RImportBooking.Add(item);

            _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(lstR_B_Booking);

            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Car Category is missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_PickUP_Date_Is_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "Sixt",
                CarCategory = "MBMR",
            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            
            List<R_B_Booking> lstR_B_Booking = new List<R_B_Booking>();
            _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(lstR_B_Booking);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Pick up or return date is missing" && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Test_ValidateImportBooking_PickUP_Time_Is_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "Sixt",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,

            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            List<R_B_Booking> lstR_B_Booking = new List<R_B_Booking>();
            _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(lstR_B_Booking);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Pick up or return time is missing" && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_PickUP_Localtion_Wrong_Or_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "Sixt",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString()
            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Pickup or return location is wrong or missing." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_CarRental_Provider_Wrong_Or_Missing()
        {

            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SixtWrong",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            List<R_B_Booking> lstR_B_Booking = new List<R_B_Booking>();

            _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(lstR_B_Booking);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Car Rental Provider is wrong." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Test_ValidateImportBooking_Reservation_Cancelled()
        {
            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SX",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };

            listp_RImportBooking.Add(item);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Reservation has been cancelled." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Reservation_Did_Not_Exist_For_Cancellation()
        {
            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Cancel",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SX",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };

            listp_RImportBooking.Add(item);
            R_B_Booking r_B_Booking = null;

            _mockI_R_B_BookingDAL.Setup(x => x.GetByBookingNo("", "")).Returns(r_B_Booking);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "This reservation number did not exist for Cancellation." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Reservation_Is_Not_Allowed_Updating()
        {
            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();


            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Commit",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SX",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };
            listp_RImportBooking.Add(item);
            R_B_Booking r_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SX",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };
            _mockI_R_B_BookingDAL.Setup(x => x.GetByBookingNo(It.IsAny<string>(), It.IsAny<string>())).Returns(r_B_Booking);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());


            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "This reservation is not allowed for updating." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateImportBooking_Reservation_Has_Cancelled()
        {
            // arrange  
            Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
            Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

            List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
            P_RImportBooking item = new P_RImportBooking();
            item.R_B_Header = new R_B_Header()
            {
                ReservationStatus = "Commit",
                TimeStamp = DateTime.Now
            };
            item.R_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SX",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };

            listp_RImportBooking.Add(item);
            R_B_Booking r_B_Booking = new R_B_Booking()
            {
                BookingNo = "123456",
                CustomerName = "Test17172",
                CustomerNo = "17172",
                FirstName = "FirstName Test",
                LastName = "LastName Test",
                Email = "Email Test",
                CarRentalProvider = "SX",
                CarCategory = "MBMR",
                PickupDate = DateTime.Now,
                ReturnDate = DateTime.Now,
                PickupTime = DateTime.Now.Date.ToString(),
                ReturnTime = DateTime.Now.Date.ToString(),
                PickupCountry = "DE",
                ReturnCountry = "DE",
            };

            _mockI_R_B_BookingDAL.Setup(x => x.GetByBookingNo(It.IsAny<string>(),"Cancel")).Returns(r_B_Booking);
            _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            bool result = false;
            // act
            R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
            input.ValidateImportBooking(listp_RImportBooking, Platform.BCD.ToString());

            // assert
            if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Reservation has been cancelled." && x.R_B_Booking.Status == 3))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        //[TestMethod]
        //public void Test_ValidateImportBooking_Reservation_Has_Duplicated_In_Systems()
        //{
        //    // arrange  
        //    Mock<I_M_CompanyBLL> _mockM_CompanyBLL = new Mock<I_M_CompanyBLL>();
        //    Mock<I_R_B_BookingDAL> _mockI_R_B_BookingDAL = new Mock<I_R_B_BookingDAL>();

        //    List<P_RImportBooking> listp_RImportBooking = new List<P_RImportBooking>();
        //    P_RImportBooking item = new P_RImportBooking();
        //    item.R_B_Header = new R_B_Header()
        //    {
        //        ReservationStatus = "Commit",
        //        TimeStamp = DateTime.Now
        //    };
        //    item.R_B_Booking = new R_B_Booking()
        //    {
        //        BookingNo = "123456",
        //        CustomerName = "Test17172",
        //        CustomerNo = "17172",
        //        FirstName = "FirstName Test",
        //        LastName = "LastName Test",
        //        Email = "Email Test",
        //        CarRentalProvider = "SX",
        //        CarCategory = "MBMR",
        //        PickupDate = DateTime.Now,
        //        ReturnDate = DateTime.Now,
        //        PickupTime = DateTime.Now.Date.ToString(),
        //        ReturnTime = DateTime.Now.Date.ToString(),
        //        PickupCountry = "DE",
        //        ReturnCountry = "DE",
        //    };

        //    listp_RImportBooking.Add(item);
        //    R_B_Booking r_B_Booking = null;
        //    List<R_B_Booking> lstTemp = new List<R_B_Booking>() { new R_B_Booking() { BookingNo = "123456" } };
        //    _mockI_R_B_BookingDAL.Setup(x => x.GetList()).Returns(lstTemp);
        //    _mockI_R_B_BookingDAL.Setup(x => x.GetByBookingNo(It.IsAny<string>(), "Cancel")).Returns(r_B_Booking);
        //    _mockM_CompanyBLL.Setup(x => x.CheckCompanyInfoHDE(item.R_B_Booking.CustomerName, item.R_B_Booking.CustomerNo, "1", "2")).Returns(0);
            
        //    bool result = false;
        //    // act
        //    R_B_BookingBLL input = new R_B_BookingBLL(_mockM_CompanyBLL.Object, _mockI_R_B_BookingDAL.Object);
        //    input.ValidateImportBooking(listp_RImportBooking);

        //    // assert
        //    if (listp_RImportBooking.Any(x => x.R_B_Booking.AdditionInformation == "Reservation number " + item.R_B_Booking.BookingNo + " has existed in System." && x.R_B_Booking.Status == 3))
        //    {
        //        result = true;
        //    }
        //    Assert.IsTrue(result);
        //}
    }
}
