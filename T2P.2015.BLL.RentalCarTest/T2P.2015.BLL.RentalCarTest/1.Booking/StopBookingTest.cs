using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.Cross.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.BLL.Master;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Enum.CarRental.CarProvider;
using T2P._2015.Cross.Enum.CarRental.Invoice;
using T2P._2015.Cross.Model;
using T2P._2015.Cross.Utility.Conversion;
using T2P._2015.Cross.Utility.Network;
using T2P._2015.DAL.CarRental;
using T2P._2015.Cross.Model._3.CarRental._3.Notification;
using T2P._2015.Cross.Utility.FileType;

namespace T2P._2015.BLL.RentalCarTest._1.Booking
{
    [TestClass]
    public class StopBookingTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            List<M_CompanyGeneralSetting> lstCompanyGeneral = new List<M_CompanyGeneralSetting>(){
                                    new M_CompanyGeneralSetting { Attribute = "Invoice"}, 
                                  new M_CompanyGeneralSetting { Attribute = "Fin" }
            };
            M_CompanyGeneralSetting companyGeneralSetting = lstCompanyGeneral.FirstOrDefault(x => x.Attribute == "Fin");
            M_CompanyGeneralSetting companyGeneralSetting1 = lstCompanyGeneral.Where(x => x.Attribute == "Fin").FirstOrDefault();
        }
        [TestMethod]
        public void TestMethod2()
        {
            R_N_Approval appro = new R_N_Approval()
            {
                ID = 3,
                R_I_DataID = 51,
                TokenString = "afgdsgdfsg",
                From ="abc.tesdt",
                To = "dafsgf",
                SendDate = DateTime.Now,
                Subject ="abc",
                Body ="test",
                IsSuccess = 0,
                CreatedBy =1 ,
                UpdatedBy =1,
                Status =0
            };

            BaseBLL.Instance.InsertOrUpdate<R_N_Approval>(appro);
        }

        [TestMethod]
        public void SplitFile()
        {
            ConvertToPDF pdf = new ConvertToPDF();
            pdf.SplitPDF(@"D:\Temp", @"D:\Temp\Enter1243657669_20171005165258883.pdf", "ABCDE");


        }
        
        [TestMethod]
        public void UpdateData()
        {
            R_N_BillingEmail tmpHeader = new R_N_BillingEmail() 
            { 
                ID = 1433,
                M_CarRentalProviderSettingID = 1,
                Type="Information",
                Subject = "2017053115_",
                From = "khoa.ngo@travel2pay.com",
                To = "carrentaldev@travel2pay.com",
                ReceivingDate = DateTime.Now,
                MessageID = "016501d34400$2d5f37a0$881da6e0$@travel2pay.com",
                UpdatedBy = 32,
                CreatedBy = 32,
                Status = 0
            };
            
            BaseBLL baseBLL = new BaseBLL();
            long idTmpHeader = baseBLL.InsertOrUpdate<R_N_BillingEmail>(tmpHeader);
        }

    }
}
