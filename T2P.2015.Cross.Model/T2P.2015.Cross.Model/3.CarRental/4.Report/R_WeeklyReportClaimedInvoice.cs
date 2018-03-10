using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.BLL.CarRental._4.Report
{
    public class P_R_WeeklyReportClaimedInvoice
    {
        public string InvoiceCreated { get; set; }
        public string InvoiceNumber { get; set; }
        public string RentalAgreementNumber { get; set; }
        public string ReservationNumber { get; set; }
        public string ContractID { get; set; }
        public string ContractName { get; set; }
        public string DriverSurname { get; set; }
        public string DriverFirstName { get; set; }
        public string TravelerEmail { get; set; }
        public string SippCode { get; set; }
        public string MopCode { get; set; }
        public string CheckoutDate { get; set; }
        public string CheckoutTime { get; set; }
        public string CheckinDate { get; set; }
        public string CheckinTime { get; set; }
        public string CheckoutStationCode { get; set; }
        public string CheckoutStationName { get; set; }
        public string CheckoutStationCountry { get; set; }
        public string CheckoutStationLocation { get; set; }
        public string CheckinStationCode { get; set; }
        public string CheckinStationName { get; set; }
        public string CheckinStationCountry { get; set; }
        public string ChargedDays { get; set; }
        public string CheckoutKM { get; set; }
        public string CheckinKM { get; set; }
        public string DrivenKM { get; set; }
        public string NetRevenueEUR { get; set; }
        public string TotalRevenue { get; set; }
        public string Currency { get; set; }

        /*All Service In Template*/
        public string BasicRental { get; set; }
        public string BasicRentalExtension { get; set; }
        public string BasicRentalUpgrade { get; set; }
        public string BasicRentalExtraMilesKM { get; set; }
        public string BasicRentalDiscount { get; set; }
        public string DamageProtection { get; set; }
        public string PersonalAccidentProtection { get; set; }
        public string TheftProtection { get; set; }
        public string GoodsinTransit { get; set; }
        public string OtherInsurance { get; set; }
        public string SpecialEquipmentRental { get; set; }
        public string SpecialEquipmentReplacement { get; set; }
        public string CommunicationDeviceReplacement { get; set; }
        public string OneWayCharge { get; set; }
        public string Delivery { get; set; }
        public string Collection { get; set; }
        public string AfterHours { get; set; }
        public string Allowance { get; set; }
        public string FuelCharge { get; set; }
        public string Fuelchargelitre { get; set; }
        public string Servicepauschale { get; set; }
        public string AirportSurcharge { get; set; }
        public string SmallBalanceWriteoff { get; set; }
        public string SmallBalanceRefundWriteoff { get; set; }
        public string VAT { get; set; }
        public string Dieselvehicle { get; set; }
        public string PeakPeriodSchg { get; set; }
        public string BasicRentalFreeMiles { get; set; }
        public string CashDeposit { get; set; }
        public string ManualSurcharges { get; set; }
        public string BasicRentalExtraDays { get; set; }
        public string ChildSeats { get; set; }
        public string BasicRentalExtraFreeMiles { get; set; }
        public string AbortedDelivery { get; set; }
        public string AbortedCollection { get; set; }
        public string FVVDriverExcessVCHINV { get; set; }
        public string CustomersOwnInsurance { get; set; }
        public string StandLiable { get; set; }
        public string AgeRestriction { get; set; }
        public string SuperPersonalaccidentProtection { get; set; }
        public string AdditionalDrivers { get; set; }
        public string BasicProtectionPackage { get; set; }
        public string CityFee { get; set; }
        public string RiskReductioncover { get; set; }
        public string ThirdPartyCover { get; set; }
        public string SuperdamageProtection { get; set; }
        public string Fulltankoption { get; set; }
        public string LicensesFees { get; set; }
        public string vignette { get; set; }
        public string winterequipment { get; set; }
        public string SnowChains { get; set; }
        public string EcoSurcharge { get; set; }
        public string SurchargeDamage { get; set; }
        public string Damagerepairs { get; set; }
        public string FLEXIREFUELLING { get; set; }
        public string PaymentCardFee { get; set; }
        public string SundryEquipmentSales { get; set; }
        public string AdministrationFee { get; set; }
        public string SuperLossDamageProtection { get; set; }
        public string Promotion { get; set; }
        public string PremRailwaySchg { get; set; }
        public string GovtAdminRtSup { get; set; }
        public string SuperTheftProtection { get; set; }
        public string GlassTyresProtection { get; set; }
        public string FuelCardLitres { get; set; }
        public string RefuellingService { get; set; }
        public string CorsicaSurcharge { get; set; }
        public string CoveragePackage { get; set; }
        public string HighSeasonSurcharge { get; set; }
        public string ElectronicPaymentTagPass { get; set; }
        public string FinesAppealWaiver { get; set; }
        public string NavigationSystem { get; set; }
        public string EcologicalFees { get; set; }
        public string CoveragePackage2 { get; set; }
        public string DamageAdministrationFee { get; set; }
        public string CarbonOffset { get; set; }
        public string COILimitedDamageOption { get; set; }
        public string MobileWIFI { get; set; }
        public string CruiseTerminalSurcharge { get; set; }
        public string LateCheckIn { get; set; }
        public string TabletDevice { get; set; }
        public string LocationSurcharge { get; set; }
        public string Coupon { get; set; }
        public string RoadsideAssistancePlus { get; set; }
        public string GoZenCoverage { get; set; }
        public string GoZenPlusCoverage { get; set; }
        public string RoofChassisProtection { get; set; }
        public string EmergencyTravelServices { get; set; }
        public string ValetParking { get; set; }
        public string CarValeting { get; set; }
        public string Mediumprotectionpackage { get; set; }
        public string Premiumprotectionpackage { get; set; }
        public string FullDamageProtection { get; set; }
        public string FullTheftProtection { get; set; }
        public string FullLossDamageProtection { get; set; }
        public string changeofprebookedterms { get; set; }
        public string MOBILEPHONEKIT { get; set; }
        public string SELECTIONPROTECTIONPACKAGE { get; set; }
        public string WINTEREQPITALY { get; set; }
        public string AFTERHOURSCOLLECTIONFEE { get; set; }
        public string PREPARATIONFEE { get; set; }
        public string APTCHARGEATCI { get; set; }
        public string MANDATORYREFUELLINGSURCHARGE { get; set; }
        public string ENHANCEDPARTNERPROTECTION { get; set; }
        public string TOLLPASSAGE { get; set; }
        public string PREMIUMDISCOUNT { get; set; }
        public string AUTOMATICCARS { get; set; }
        public string PREPARATIONCOST { get; set; }
        public string CROSSBORDERFEE { get; set; }
        public string EUROPDRIVECOVER { get; set; }
        public string TOLLROADADMINFEE { get; set; }
        public string ContractTax { get; set; }
        //Expected
        public string ExpectedBasicRental { get; set; }
        public string ExpectedBasicRentalExtension { get; set; }
        public string ExpectedBasicRentalUpgrade { get; set; }
        public string ExpectedBasicRentalExtraMilesKM { get; set; }
        public string ExpectedBasicRentalDiscount { get; set; }
        public string ExpectedDamageProtection { get; set; }
        public string ExpectedPersonalAccidentProtection { get; set; }
        public string ExpectedTheftProtection { get; set; }
        public string ExpectedGoodsinTransit { get; set; }
        public string ExpectedOtherInsurance { get; set; }
        public string ExpectedSpecialEquipmentRental { get; set; }
        public string ExpectedSpecialEquipmentReplacement { get; set; }
        public string ExpectedCommunicationDeviceReplacement { get; set; }
        public string ExpectedOneWayCharge { get; set; }
        public string ExpectedDelivery { get; set; }
        public string ExpectedCollection { get; set; }
        public string ExpectedAfterHours { get; set; }
        public string ExpectedAllowance { get; set; }
        public string ExpectedFuelCharge { get; set; }
        public string ExpectedFuelchargelitre { get; set; }
        public string ExpectedServicepauschale { get; set; }
        public string ExpectedAirportSurcharge { get; set; }
        public string ExpectedSmallBalanceWriteoff { get; set; }
        public string ExpectedSmallBalanceRefundWriteoff { get; set; }
        public string ExpectedVAT { get; set; }
        public string ExpectedDieselvehicle { get; set; }
        public string ExpectedPeakPeriodSchg { get; set; }
        public string ExpectedBasicRentalFreeMiles { get; set; }
        public string ExpectedCashDeposit { get; set; }
        public string ExpectedManualSurcharges { get; set; }
        public string ExpectedBasicRentalExtraDays { get; set; }
        public string ExpectedChildSeats { get; set; }
        public string ExpectedBasicRentalExtraFreeMiles { get; set; }
        public string ExpectedAbortedDelivery { get; set; }
        public string ExpectedAbortedCollection { get; set; }
        public string ExpectedFVVDriverExcessVCHINV { get; set; }
        public string ExpectedCustomersOwnInsurance { get; set; }
        public string ExpectedStandLiable { get; set; }
        public string ExpectedAgeRestriction { get; set; }
        public string ExpectedSuperPersonalaccidentProtection { get; set; }
        public string ExpectedAdditionalDrivers { get; set; }
        public string ExpectedBasicProtectionPackage { get; set; }
        public string ExpectedCityFee { get; set; }
        public string ExpectedRiskReductioncover { get; set; }
        public string ExpectedThirdPartyCover { get; set; }
        public string ExpectedSuperdamageProtection { get; set; }
        public string ExpectedFulltankoption { get; set; }
        public string ExpectedLicensesFees { get; set; }
        public string Expectedvignette { get; set; }
        public string Expectedwinterequipment { get; set; }
        public string ExpectedSnowChains { get; set; }
        public string ExpectedEcoSurcharge { get; set; }
        public string ExpectedSurchargeDamage { get; set; }
        public string ExpectedDamagerepairs { get; set; }
        public string ExpectedFLEXIREFUELLING { get; set; }
        public string ExpectedPaymentCardFee { get; set; }
        public string ExpectedSundryEquipmentSales { get; set; }
        public string ExpectedAdministrationFee { get; set; }
        public string ExpectedSuperLossDamageProtection { get; set; }
        public string ExpectedPromotion { get; set; }
        public string ExpectedPremRailwaySchg { get; set; }
        public string ExpectedGovtAdminRtSup { get; set; }
        public string ExpectedSuperTheftProtection { get; set; }
        public string ExpectedGlassTyresProtection { get; set; }
        public string ExpectedFuelCardLitres { get; set; }
        public string ExpectedRefuellingService { get; set; }
        public string ExpectedCorsicaSurcharge { get; set; }
        public string ExpectedCoveragePackage { get; set; }
        public string ExpectedHighSeasonSurcharge { get; set; }
        public string ExpectedElectronicPaymentTagPass { get; set; }
        public string ExpectedFinesAppealWaiver { get; set; }
        public string ExpectedNavigationSystem { get; set; }
        public string ExpectedEcologicalFees { get; set; }
        public string ExpectedCoveragePackage2 { get; set; }
        public string ExpectedDamageAdministrationFee { get; set; }
        public string ExpectedCarbonOffset { get; set; }
        public string ExpectedCOILimitedDamageOption { get; set; }
        public string ExpectedMobileWIFI { get; set; }
        public string ExpectedCruiseTerminalSurcharge { get; set; }
        public string ExpectedLateCheckIn { get; set; }
        public string ExpectedTabletDevice { get; set; }
        public string ExpectedLocationSurcharge { get; set; }
        public string ExpectedCoupon { get; set; }
        public string ExpectedRoadsideAssistancePlus { get; set; }
        public string ExpectedGoZenCoverage { get; set; }
        public string ExpectedGoZenPlusCoverage { get; set; }
        public string ExpectedRoofChassisProtection { get; set; }
        public string ExpectedEmergencyTravelServices { get; set; }
        public string ExpectedValetParking { get; set; }
        public string ExpectedCarValeting { get; set; }
        public string ExpectedMediumprotectionpackage { get; set; }
        public string ExpectedPremiumprotectionpackage { get; set; }
        public string ExpectedFullDamageProtection { get; set; }
        public string ExpectedFullTheftProtection { get; set; }
        public string ExpectedFullLossDamageProtection { get; set; }
        public string Expectedchangeofprebookedterms { get; set; }
        public string ExpectedMOBILEPHONEKIT { get; set; }
        public string ExpectedSELECTIONPROTECTIONPACKAGE { get; set; }
        public string ExpectedWINTEREQPITALY { get; set; }
        public string ExpectedAFTERHOURSCOLLECTIONFEE { get; set; }
        public string ExpectedPREPARATIONFEE { get; set; }
        public string ExpectedAPTCHARGEATCI { get; set; }
        public string ExpectedMANDATORYREFUELLINGSURCHARGE { get; set; }
        public string ExpectedENHANCEDPARTNERPROTECTION { get; set; }
        public string ExpectedTOLLPASSAGE { get; set; }
        public string ExpectedPREMIUMDISCOUNT { get; set; }
        public string ExpectedAUTOMATICCARS { get; set; }
        public string ExpectedPREPARATIONCOST { get; set; }
        public string ExpectedCROSSBORDERFEE { get; set; }
        public string ExpectedEUROPDRIVECOVER { get; set; }
        public string ExpectedTOLLROADADMINFEE { get; set; }
        public string ExpectedContractTax { get; set; }

        /*
        public string ExpectedAdditionalDriver { get; set; }
        public string AdditionalDriver { get; set; }
        public string ExpectedAdminFee { get; set; }
        public string AdminFee { get; set; }
        public string ExpectedAfterHour { get; set; }
        public string AfterHour { get; set; }
        public string ExpectedAirportSurcharge { get; set; }
        public string AirportSurcharge { get; set; }
        public string ExpectedBasicProtection { get; set; }
        public string BasicProtection { get; set; }
        public string ExpectedBasicRental { get; set; }
        public string BasicRental { get; set; }
        public string ExpectedBasicRentalFeeMiles { get; set; }
        public string BasicRentalFeeMiles { get; set; }
        public string ExpectedBasicRentalUpgrade { get; set; }
        public string BasicRentalUpgrade { get; set; }
        public string ExpectedChargeForAutomatic { get; set; }
        public string ChargeForAutomatic { get; set; }
        public string ExpectedCollection { get; set; }
        public string Collection { get; set; }
        public string ExpectedDelivery { get; set; }
        public string Delivery { get; set; }
        public string ExpectedDiesel { get; set; }
        public string Diesel { get; set; }
        public string ExpectedFuelCharge { get; set; }
        public string FuelCharge { get; set; }
        public string FuelChargeLitre { get; set; }
        public string ExpectedLicensesFees { get; set; }
        public string LicensesFees { get; set; }
        public string ExpectedNavigation { get; set; }
        public string Navigation { get; set; }
        public string ExpectedOneWayCharge { get; set; }
        public string OneWayCharge { get; set; }
        public string ExpectedPAI { get; set; }
        public string PAI { get; set; }
        public string ExpectedVAT { get; set; }
        public string VAT { get; set; }
        public string ExpectedWinterEquipment { get; set; }
        public string WinterEquipment { get; set; }
        public string ExpectedSnowChains { get; set; }
         * public string SnowChains { get; set; }
        public string BasicRentalExtraDays { get; set; }
        public string ExpectedBasicRentalExtraDays { get; set; }
        
        */
        public string Status { get; set; }
        public string Description { get; set; }
        public string RateGrid { get; set; }


        /*End All Service In Template*/

        public long M_CarRentalProviderID { get; set; }
        public P_R_WeeklyReportClaimedInvoice()
        {
            BasicRental = string.Empty; ExpectedBasicRental = string.Empty;
            BasicRentalExtension = string.Empty; ExpectedBasicRentalExtension = string.Empty;
            BasicRentalUpgrade = string.Empty; ExpectedBasicRentalUpgrade = string.Empty;
            BasicRentalExtraMilesKM = string.Empty; ExpectedBasicRentalExtraMilesKM = string.Empty;
            BasicRentalDiscount = string.Empty; ExpectedBasicRentalDiscount = string.Empty;
            DamageProtection = string.Empty; ExpectedDamageProtection = string.Empty;
            PersonalAccidentProtection = string.Empty; ExpectedPersonalAccidentProtection = string.Empty;
            TheftProtection = string.Empty; ExpectedTheftProtection = string.Empty;
            GoodsinTransit = string.Empty; ExpectedGoodsinTransit = string.Empty;
            OtherInsurance = string.Empty; ExpectedOtherInsurance = string.Empty;
            SpecialEquipmentRental = string.Empty; ExpectedSpecialEquipmentRental = string.Empty;
            SpecialEquipmentReplacement = string.Empty; ExpectedSpecialEquipmentReplacement = string.Empty;
            CommunicationDeviceReplacement = string.Empty; ExpectedCommunicationDeviceReplacement = string.Empty;
            OneWayCharge = string.Empty; ExpectedOneWayCharge = string.Empty;
            Delivery = string.Empty; ExpectedDelivery = string.Empty;
            Collection = string.Empty; ExpectedCollection = string.Empty;
            AfterHours = string.Empty; ExpectedAfterHours = string.Empty;
            Allowance = string.Empty; ExpectedAllowance = string.Empty;
            FuelCharge = string.Empty; ExpectedFuelCharge = string.Empty;
            Fuelchargelitre = string.Empty; ExpectedFuelchargelitre = string.Empty;
            Servicepauschale = string.Empty; ExpectedServicepauschale = string.Empty;
            AirportSurcharge = string.Empty; ExpectedAirportSurcharge = string.Empty;
            SmallBalanceWriteoff = string.Empty; ExpectedSmallBalanceWriteoff = string.Empty;
            SmallBalanceRefundWriteoff = string.Empty; ExpectedSmallBalanceRefundWriteoff = string.Empty;
            VAT = string.Empty; ExpectedVAT = string.Empty;
            Dieselvehicle = string.Empty; ExpectedDieselvehicle = string.Empty;
            PeakPeriodSchg = string.Empty; ExpectedPeakPeriodSchg = string.Empty;
            BasicRentalFreeMiles = string.Empty; ExpectedBasicRentalFreeMiles = string.Empty;
            CashDeposit = string.Empty; ExpectedCashDeposit = string.Empty;
            ManualSurcharges = string.Empty; ExpectedManualSurcharges = string.Empty;
            BasicRentalExtraDays = string.Empty; ExpectedBasicRentalExtraDays = string.Empty;
            ChildSeats = string.Empty; ExpectedChildSeats = string.Empty;
            BasicRentalExtraFreeMiles = string.Empty; ExpectedBasicRentalExtraFreeMiles = string.Empty;
            AbortedDelivery = string.Empty; ExpectedAbortedDelivery = string.Empty;
            AbortedCollection = string.Empty; ExpectedAbortedCollection = string.Empty;
            FVVDriverExcessVCHINV = string.Empty; ExpectedFVVDriverExcessVCHINV = string.Empty;
            CustomersOwnInsurance = string.Empty; ExpectedCustomersOwnInsurance = string.Empty;
            StandLiable = string.Empty; ExpectedStandLiable = string.Empty;
            AgeRestriction = string.Empty; ExpectedAgeRestriction = string.Empty;
            SuperPersonalaccidentProtection = string.Empty; ExpectedSuperPersonalaccidentProtection = string.Empty;
            AdditionalDrivers = string.Empty; ExpectedAdditionalDrivers = string.Empty;
            BasicProtectionPackage = string.Empty; ExpectedBasicProtectionPackage = string.Empty;
            CityFee = string.Empty; ExpectedCityFee = string.Empty;
            RiskReductioncover = string.Empty; ExpectedRiskReductioncover = string.Empty;
            ThirdPartyCover = string.Empty; ExpectedThirdPartyCover = string.Empty;
            SuperdamageProtection = string.Empty; ExpectedSuperdamageProtection = string.Empty;
            Fulltankoption = string.Empty; ExpectedFulltankoption = string.Empty;
            LicensesFees = string.Empty; ExpectedLicensesFees = string.Empty;
            vignette = string.Empty; Expectedvignette = string.Empty;
            winterequipment = string.Empty; Expectedwinterequipment = string.Empty;
            SnowChains = string.Empty; ExpectedSnowChains = string.Empty;
            EcoSurcharge = string.Empty; ExpectedEcoSurcharge = string.Empty;
            SurchargeDamage = string.Empty; ExpectedSurchargeDamage = string.Empty;
            Damagerepairs = string.Empty; ExpectedDamagerepairs = string.Empty;
            FLEXIREFUELLING = string.Empty; ExpectedFLEXIREFUELLING = string.Empty;
            PaymentCardFee = string.Empty; ExpectedPaymentCardFee = string.Empty;
            SundryEquipmentSales = string.Empty; ExpectedSundryEquipmentSales = string.Empty;
            AdministrationFee = string.Empty; ExpectedAdministrationFee = string.Empty;
            SuperLossDamageProtection = string.Empty; ExpectedSuperLossDamageProtection = string.Empty;
            Promotion = string.Empty; ExpectedPromotion = string.Empty;
            PremRailwaySchg = string.Empty; ExpectedPremRailwaySchg = string.Empty;
            GovtAdminRtSup = string.Empty; ExpectedGovtAdminRtSup = string.Empty;
            SuperTheftProtection = string.Empty; ExpectedSuperTheftProtection = string.Empty;
            GlassTyresProtection = string.Empty; ExpectedGlassTyresProtection = string.Empty;
            FuelCardLitres = string.Empty; ExpectedFuelCardLitres = string.Empty;
            RefuellingService = string.Empty; ExpectedRefuellingService = string.Empty;
            CorsicaSurcharge = string.Empty; ExpectedCorsicaSurcharge = string.Empty;
            CoveragePackage = string.Empty; ExpectedCoveragePackage = string.Empty;
            HighSeasonSurcharge = string.Empty; ExpectedHighSeasonSurcharge = string.Empty;
            ElectronicPaymentTagPass = string.Empty; ExpectedElectronicPaymentTagPass = string.Empty;
            FinesAppealWaiver = string.Empty; ExpectedFinesAppealWaiver = string.Empty;
            NavigationSystem = string.Empty; ExpectedNavigationSystem = string.Empty;
            EcologicalFees = string.Empty; ExpectedEcologicalFees = string.Empty;
            CoveragePackage2 = string.Empty; ExpectedCoveragePackage2 = string.Empty;
            DamageAdministrationFee = string.Empty; ExpectedDamageAdministrationFee = string.Empty;
            CarbonOffset = string.Empty; ExpectedCarbonOffset = string.Empty;
            COILimitedDamageOption = string.Empty; ExpectedCOILimitedDamageOption = string.Empty;
            MobileWIFI = string.Empty; ExpectedMobileWIFI = string.Empty;
            CruiseTerminalSurcharge = string.Empty; ExpectedCruiseTerminalSurcharge = string.Empty;
            LateCheckIn = string.Empty; ExpectedLateCheckIn = string.Empty;
            TabletDevice = string.Empty; ExpectedTabletDevice = string.Empty;
            LocationSurcharge = string.Empty; ExpectedLocationSurcharge = string.Empty;
            Coupon = string.Empty; ExpectedCoupon = string.Empty;
            RoadsideAssistancePlus = string.Empty; ExpectedRoadsideAssistancePlus = string.Empty;
            GoZenCoverage = string.Empty; ExpectedGoZenCoverage = string.Empty;
            GoZenPlusCoverage = string.Empty; ExpectedGoZenPlusCoverage = string.Empty;
            RoofChassisProtection = string.Empty; ExpectedRoofChassisProtection = string.Empty;
            EmergencyTravelServices = string.Empty; ExpectedEmergencyTravelServices = string.Empty;
            ValetParking = string.Empty; ExpectedValetParking = string.Empty;
            CarValeting = string.Empty; ExpectedCarValeting = string.Empty;
            Mediumprotectionpackage = string.Empty; ExpectedMediumprotectionpackage = string.Empty;
            Premiumprotectionpackage = string.Empty; ExpectedPremiumprotectionpackage = string.Empty;
            FullDamageProtection = string.Empty; ExpectedFullDamageProtection = string.Empty;
            FullTheftProtection = string.Empty; ExpectedFullTheftProtection = string.Empty;
            FullLossDamageProtection = string.Empty; ExpectedFullLossDamageProtection = string.Empty;
            changeofprebookedterms = string.Empty; Expectedchangeofprebookedterms = string.Empty;
            MOBILEPHONEKIT = string.Empty; ExpectedMOBILEPHONEKIT = string.Empty;
            SELECTIONPROTECTIONPACKAGE = string.Empty; ExpectedSELECTIONPROTECTIONPACKAGE = string.Empty;
            WINTEREQPITALY = string.Empty; ExpectedWINTEREQPITALY = string.Empty;
            AFTERHOURSCOLLECTIONFEE = string.Empty; ExpectedAFTERHOURSCOLLECTIONFEE = string.Empty;
            PREPARATIONFEE = string.Empty; ExpectedPREPARATIONFEE = string.Empty;
            APTCHARGEATCI = string.Empty; ExpectedAPTCHARGEATCI = string.Empty;
            MANDATORYREFUELLINGSURCHARGE = string.Empty; ExpectedMANDATORYREFUELLINGSURCHARGE = string.Empty;
            ENHANCEDPARTNERPROTECTION = string.Empty; ExpectedENHANCEDPARTNERPROTECTION = string.Empty;
            TOLLPASSAGE = string.Empty; ExpectedTOLLPASSAGE = string.Empty;
            PREMIUMDISCOUNT = string.Empty; ExpectedPREMIUMDISCOUNT = string.Empty;
            AUTOMATICCARS = string.Empty; ExpectedAUTOMATICCARS = string.Empty;
            PREPARATIONCOST = string.Empty; ExpectedPREPARATIONCOST = string.Empty;
            CROSSBORDERFEE = string.Empty; ExpectedCROSSBORDERFEE = string.Empty;
            EUROPDRIVECOVER = string.Empty; ExpectedEUROPDRIVECOVER = string.Empty;
            TOLLROADADMINFEE = string.Empty; ExpectedTOLLROADADMINFEE = string.Empty;
            ContractTax = string.Empty; ExpectedContractTax = string.Empty;

            //RateGrid = InvoiceCreated = InvoiceNumber = RentalAgreementNumber = ReservationNumber = ContractID = ContractName = DriverSurname = DriverFirstName = TravelerEmail = SippCode = MopCode = CheckoutDate = CheckoutTime = CheckinDate = CheckinTime = CheckoutStationCode = CheckoutStationName = CheckoutStationCountry = CheckoutStationLocation = CheckinStationCode = CheckinStationName = CheckinStationCountry = ChargedDays = CheckinKM = CheckoutKM = DrivenKM = NetRevenueEUR = TotalRevenue = AdditionalDriver = AdminFee = AfterHour = AirportSurcharge = BasicProtection = BasicRental = BasicRentalFeeMiles = ChargeForAutomatic = Collection = Delivery = Diesel = FuelCharge = FuelChargeLitre = LicensesFees = Navigation = OneWayCharge = PAI = VAT = WinterEquipment = Status = string.Empty;
            //ExpectedAdditionalDriver = ExpectedAdminFee = ExpectedAfterHour = ExpectedAirportSurcharge = ExpectedBasicProtection = ExpectedBasicRental = ExpectedBasicRentalFeeMiles = ExpectedBasicRentalUpgrade = ExpectedChargeForAutomatic = ExpectedCollection = ExpectedDelivery = ExpectedDiesel = ExpectedFuelCharge = ExpectedLicensesFees = ExpectedNavigation = ExpectedOneWayCharge = ExpectedPAI = ExpectedSnowChains = ExpectedVAT = ExpectedWinterEquipment = string.Empty;

            BasicRentalExtraDays = ExpectedBasicRentalExtraDays = string.Empty;
        }
    }

    public class P_R_ClaimReport
    {
        public string ReservationNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string ClaimDate { get; set; }
        public string Provider { get; set; }
        public string CityOfCheckIn { get; set; }
        public string Country { get; set; }
        public string InitialTotalGrossAmount { get; set; }
        public string ExpectedTotalGrossAmount { get; set; }
        public string ExpectedCreditGrossAmount { get; set; }
        public string CurrencyInvoice { get; set; }
        public string ErrorCode { get; set; }
        public string ServiceDescription { get; set; }
        public string CompanyName { get; set; }
        public string Traveler { get; set; }
        public P_R_ClaimReport()
        { 
        
        }
    }

    public class P_R_WeeklyReportClaimedInvoiceHasCompany : P_R_WeeklyReportClaimedInvoice
    {
        public long M_CompanyID { get; set; }
    }

    public class R_WeeklyReportResponse
    {
        public long ID { get; set; }
        public int RowNum { get; set; }
        public string Provider { get; set; }
        public string FileName { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfInvoice { get; set; }
        public DateTime SentDate { get; set; }
        public long TotalRecords { get; set; }
        public string FilePath { get; set; }
    }

    public enum P_R_WeeklyReportClaimedInvoiceProcedure
    {
        R_WeeklyReportResponse_GetList,
        R_WeeklyReportResponse_GetTotal
    }
}
