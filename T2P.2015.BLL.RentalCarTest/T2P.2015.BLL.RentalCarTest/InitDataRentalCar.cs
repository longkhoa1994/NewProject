using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model;
using T2P._2015.DAL;

namespace T2P._2015.BLL.RentalCarTest._1.Booking
{
    public class InitDataRentalCar
    {
        public class InnitData
        {
            R_B_Header r_B_Header;

            public R_B_Header R_B_Header
            {
                get { return r_B_Header; }
                set { r_B_Header = value; }
            }

            R_B_Booking r_B_Booking;

            public R_B_Booking R_B_Booking
            {
                get { return r_B_Booking; }
                set { r_B_Booking = value; }
            }

            R_B_Access r_B_Acces;

            public R_B_Access R_B_Acces
            {
                get { return r_B_Acces; }
                set { r_B_Acces = value; }
            }

            private List<DataInvoice> listDataInvoice;

            public List<DataInvoice> ListDataInvoice
            {
                get { return listDataInvoice; }
                set { listDataInvoice = value; }
            }

            private List<DataFin> listDataFin;

            public List<DataFin> ListDataFin
            {
                get { return listDataFin; }
                set { listDataFin = value; }
            }

           

        }

        public class DataInvoice
        {
            private R_I_Image r_I_Image;
            public R_I_Image R_I_Image
            {
                get { return r_I_Image; }
                set { r_I_Image = value; }
            }
            private R_I_Data r_I_Data;

            public R_I_Data R_I_Data
            {
                get { return r_I_Data; }
                set { r_I_Data = value; }
            }

        }

        public class DataFin
        {
            private R_F_Header r_F_Header;

            public R_F_Header R_F_Header
            {
                get { return r_F_Header; }
                set { r_F_Header = value; }
            }

            private R_F_Transaction r_F_Transaction;

            public R_F_Transaction R_F_Transaction
            {
                get { return r_F_Transaction; }
                set { r_F_Transaction = value; }
            }
        }
        public InnitData CreateData(DateTime returnDate, int inputNumberInv, int inputNumberFin)
        {   
            InnitData initData = new InnitData();
            initData.R_B_Header = InitHeader();
            initData.R_B_Acces = InitB_Access();
            string bookingNo = Guid.NewGuid().ToString();
            initData.R_B_Booking = InitB_Booking(returnDate,bookingNo);

            InitDataInvoice(inputNumberInv, initData, bookingNo);

            InitDataFin(inputNumberFin, initData, bookingNo);

           return initData = SaveDate(initData);
        }

        private void InitDataFin(int inputNumberFin, InnitData initData, string bookingNo)
        {
            initData.ListDataFin = new List<DataFin>();
            for (int i = 0; i < inputNumberFin; i++)
            {
                DataFin dataFin = new DataFin();
                dataFin.R_F_Header = new R_F_Header()
                {
                    FileType = "CSV",
                    FileName = "",
                    TransactionIdentify = "6D99AC4E-45F8-4959-B9A3-F94CA72940ED",
                    CompanyIdentify = "F6E6C4B7-6351-4B5C-ADBB-07FF18FE8974",
                    SequenceID = "54545654",
                    TransactionCount = 1,
                    CreatedBy = 1,
                    UpdatedBy = 1,
                    Status = 0
                };
                dataFin.R_F_Transaction = new R_F_Transaction()
                {
                    FinancialID = 4962,
                    DocumentNo = "454ED54564",
                    ReservationNumber = bookingNo,
                    GrossAmount = 100,
                    Currency = "EUR",
                    CarRentalProvider = "Sixt",
                    TravelerName = "Test traveler",
                    FinancialStatus = "New",
                    CreatedBy = 1,
                    UpdatedBy = 1,
                    Status = 0
                };
                initData.ListDataFin.Add(dataFin);
            }
        
        }

        private InnitData SaveDate(InnitData initData)
        {
            using (SqlConnection cnn = DataProvider.OpenConnection())
            {
                using (SqlTransaction tran = cnn.BeginTransaction())
                {
                    long bHeader = BaseDAL.Instance.InsertOrUpdate<R_B_Header>(initData.R_B_Header, tran);
                    initData.R_B_Header.ID = bHeader;

                    long bAccesID = BaseDAL.Instance.InsertOrUpdate<R_B_Access>(initData.R_B_Acces, tran);
                    initData.R_B_Booking.R_B_HeaderID = bHeader;
                    initData.R_B_Booking.R_B_AccessID = bAccesID;
                    initData.R_B_Acces.ID = bAccesID;

                    long bBookingID = BaseDAL.Instance.InsertOrUpdate<R_B_Booking>(initData.R_B_Booking, tran);
                    initData.R_B_Booking.ID = bBookingID;

                    if (initData.ListDataInvoice.Any())
                    {
                        foreach (var inv in initData.ListDataInvoice)
                        {
                            inv.R_I_Image.R_B_AccessID = bAccesID;
                            long imageID = BaseDAL.Instance.InsertOrUpdate<R_I_Image>(inv.R_I_Image, tran);
                            inv.R_I_Data.R_I_ImageID = imageID;
                            BaseDAL.Instance.InsertOrUpdate<R_I_Data>(inv.R_I_Data, tran);
                        }

                    }
                    if (initData.ListDataFin.Any())
                    {
                        foreach (var fin in initData.ListDataFin)
                        {
                            long finHerderID = BaseDAL.Instance.InsertOrUpdate<R_F_Header>(fin.R_F_Header, tran);
                            fin.R_F_Header.ID = finHerderID;
                            fin.R_F_Transaction.R_F_HeaderID = finHerderID;
                            fin.R_F_Transaction.R_B_AccessID = bAccesID;
                            long finID = BaseDAL.Instance.InsertOrUpdate<R_F_Transaction>(fin.R_F_Transaction, tran);
                            fin.R_F_Transaction.ID = finID;
                        }

                    }
                    tran.Commit();
                }
            }
            return initData;
        }

        

        private void InitDataInvoice(int inputNumberInv, InnitData initData, string bookingNo)
        {
            initData.ListDataInvoice = new List<DataInvoice>();
            for (int i = 0; i < inputNumberInv; i++)
            {
                DataInvoice dataInvoice = new DataInvoice();
                dataInvoice.R_I_Image = new R_I_Image()
                {
                    R_M_FileLocationID = 2,
                    HasRateGrid = false,
                    FilePath = @"R_Invoice_Image\20160808",
                    FileName = @"R_Invoice_Image\20160808",
                    ImageStatus = "Processing",
                    IsParking = false,
                    BookingNo = bookingNo,
                    CreatedBy = 1,
                    UpdatedBy = 1,
                    Status = 0
                };
                dataInvoice.R_I_Data = new R_I_Data() {
                    R_M_SippCodeID = 81,
                    M_PickupCountryID = 81,
                    M_ReturnCountryID = 81,
                    CustomerNumber = "454645545",
                    InvoiceNumber ="4545456",
                    InvoiceDate = DateTime.Now,
                    CarGroup = "CBMR",
                    NetAmount = 110,
                    TaxAmount = 11,
                    GrossAmount = 100,
                    Currency = "EUR",
                    BillingAmount = 0,
                    BillingCurrency = "EUR",
                    PickUpTime = DateTime.Now,
                    ReturnTime =DateTime.Now,
                    PickUpLocation = "Affalterbach",
                    ReturnLocation = "Affalterbach",
                    StartingKM = 100,
                    ReturnKM = 1000,
                    Distance = 900,
                    Comment = "",
                    CreatedBy = 1,
                    UpdatedBy = 1,
                    Status = 0
                };

                initData.ListDataInvoice.Add(dataInvoice);
            }
        }

        private R_B_Booking InitB_Booking(DateTime dateinput,string bookingNo)
        {
            return new R_B_Booking() { 
                BookingNo = bookingNo,
                CustomerNo = DateTime.Today.ToString(),
                CustomerName = "CustomerName Test",
                LastName ="bbb",
                FirstName = "AAA",
                Email = "khoa.ngo@travel2pay.com",
                CarRentalProvider  = "aaa",
                CarCategory = "Audi",
                PickupDate =DateTime.Now.AddDays(-3),
                ReturnDate = dateinput,
                PickupTime = "07:52:00",
                ReturnTime = "19:46:00",
                PickupCity = "Berlin",
                PickupCountry = "de",
                ReturnCity ="Frankfurt",
                ReturnCountry = "da",
                BookedDate = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = 1,
                Status = 0
            };
        }

        private R_B_Access InitB_Access()
        {
            return new R_B_Access() { 
                //M_HotelPlatformID = 3,
                M_CompanyID = 18236,
                M_CarRentalProviderID = 2,
                M_TravelerID = 351788,
                BookingStatus ="Processing",
                CreatedBy = 1,
                UpdatedBy = 1,
                Status = 0
            };
        }

        private R_B_Header InitHeader()
        {
            return new R_B_Header() {
                R_B_ImportID = 1,
                M_FileLocationID =3,
                FilePath = @"ImportBookingCarRental\\"+ DateTime.Now.Date+"\\",
                FileName = "Template for Manual_Reservation.xlsx",
                ReservationStatus = "Commit",
                TimeStamp = DateTime.Now,
                ReservationCount = 5,
                CreatedBy =1,
                UpdatedBy =1,
                Status = 0
            };
        }

    }
}
