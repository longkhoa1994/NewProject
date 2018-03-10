using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2P._2015.BLL.CarRental._4.Report;
using T2P._2015.Cross.Model;
using Moq;
using T2P._2015.DAL.CarRental._4.Report;
using System.Collections.Generic;
using System.Linq;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Utility.FileType;
using System.Data;

namespace T2P._2015.BLL.RentalCarTest._4.Report
{
    [TestClass]
    public class RC_R_InvoiceReportBLLTest
    {
        private Mock<RC_R_InvoiceReportBLL> _mockBLL;
        private Mock<IRC_R_InvoiceReportDAL> _mockDAL;

        public RC_R_InvoiceReportBLLTest()
        {
            _mockDAL = new Mock<IRC_R_InvoiceReportDAL>();
            _mockDAL.Setup(x => x.GetM_SystemSetting()).Returns(new List<M_SystemSetting>
            {
                new M_SystemSetting { Attribute = "CR_SPEND_TIME_RETURN_DATE_CAR", Value = "60" }
            });

            _mockDAL.Setup(x => x.GetListR_M_TransformData()).Returns(new List<R_M_TransformData>
            { 
                new R_M_TransformData {ServiceTemplate ="Basic Rental",ServiceTranslation ="Grundpreis",ServiceCode ="RATE",ColumnIndex =30,ColumnCode= "AE", ServiceTemplateRemoveSpecial = "BasicRental"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental-Extension",ServiceTranslation ="Zusatztag",ServiceCode ="RATE",ColumnIndex =31,ColumnCode= "AF", ServiceTemplateRemoveSpecial = "BasicRentalExtension"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental-Upgrade",ServiceTranslation ="Upgrade",ServiceCode ="ANULL",ColumnIndex =32,ColumnCode= "AG", ServiceTemplateRemoveSpecial = "BasicRentalUpgrade"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental-Extra Miles/KM",ServiceTranslation ="Berechnete Km *",ServiceCode ="AKMC",ColumnIndex =33,ColumnCode= "AH", ServiceTemplateRemoveSpecial = "BasicRentalExtraMilesKM"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental-Discount",ServiceTranslation ="Rabatt",ServiceCode ="RATE",ColumnIndex =34,ColumnCode= "AI", ServiceTemplateRemoveSpecial = "BasicRentalDiscount"},
                new R_M_TransformData {ServiceTemplate ="Damage Protection",ServiceTranslation ="Haftungsreduzierung",ServiceCode ="EXCE",ColumnIndex =35,ColumnCode= "AJ", ServiceTemplateRemoveSpecial = "DamageProtection"},
                new R_M_TransformData {ServiceTemplate ="Personal Accident Protection",ServiceTranslation ="Insassenunfallversicherung",ServiceCode ="PAI",ColumnIndex =36,ColumnCode= "AK", ServiceTemplateRemoveSpecial = "PersonalAccidentProtection"},
                new R_M_TransformData {ServiceTemplate ="Theft Protection",ServiceTranslation ="Teilkaskoschutz",ServiceCode ="EXCT",ColumnIndex =37,ColumnCode= "AL", ServiceTemplateRemoveSpecial = "TheftProtection"},
                new R_M_TransformData {ServiceTemplate ="Goods in Transit",ServiceTranslation ="Transportversicherung",ServiceCode ="ANULL",ColumnIndex =38,ColumnCode= "AM", ServiceTemplateRemoveSpecial = "GoodsinTransit"},
                new R_M_TransformData {ServiceTemplate ="Other Insurance",ServiceTranslation ="Weitere Schutzpakete",ServiceCode ="ANULL",ColumnIndex =39,ColumnCode= "AN", ServiceTemplateRemoveSpecial = "OtherInsurance"},
                new R_M_TransformData {ServiceTemplate ="Special Equipment Rental",ServiceTranslation ="Zubehoer",ServiceCode ="ANULL",ColumnIndex =40,ColumnCode= "AO", ServiceTemplateRemoveSpecial = "SpecialEquipmentRental"},
                new R_M_TransformData {ServiceTemplate ="Special Equipment Replacement",ServiceTranslation ="Schadensersatz Zubehoer",ServiceCode ="ANULL",ColumnIndex =41,ColumnCode= "AP", ServiceTemplateRemoveSpecial = "SpecialEquipmentReplacement"},
                new R_M_TransformData {ServiceTemplate ="Communication Device Replacement",ServiceTranslation ="Telefon Schadenersatz",ServiceCode ="ANULL",ColumnIndex =42,ColumnCode= "AQ", ServiceTemplateRemoveSpecial = "CommunicationDeviceReplacement"},
                new R_M_TransformData {ServiceTemplate ="One-Way Charge",ServiceTranslation ="Einweggebuehr",ServiceCode ="NOWC",ColumnIndex =43,ColumnCode= "AR", ServiceTemplateRemoveSpecial = "OneWayCharge"},
                new R_M_TransformData {ServiceTemplate ="Delivery",ServiceTranslation ="Zustellung",ServiceCode ="DECC",ColumnIndex =44,ColumnCode= "AS", ServiceTemplateRemoveSpecial = "Delivery"},
                new R_M_TransformData {ServiceTemplate ="Collection",ServiceTranslation ="Abholung",ServiceCode ="DECC",ColumnIndex =45,ColumnCode= "AT", ServiceTemplateRemoveSpecial = "Collection"},
                new R_M_TransformData {ServiceTemplate ="After Hours",ServiceTranslation ="Erweiterte Servicezeiten",ServiceCode ="OHSV",ColumnIndex =46,ColumnCode= "AU", ServiceTemplateRemoveSpecial = "AfterHours"},
                new R_M_TransformData {ServiceTemplate ="Allowance",ServiceTranslation ="Abzueglich",ServiceCode ="ANULL",ColumnIndex =47,ColumnCode= "AV", ServiceTemplateRemoveSpecial = "Allowance"},
                new R_M_TransformData {ServiceTemplate ="Fuel Charge",ServiceTranslation ="Kraftstoff & Service",ServiceCode ="FUEL",ColumnIndex =48,ColumnCode= "AW", ServiceTemplateRemoveSpecial = "FuelCharge"},
                new R_M_TransformData {ServiceTemplate ="Fuel charge litre",ServiceTranslation ="",ServiceCode ="ANULL",ColumnIndex =49,ColumnCode= "AX", ServiceTemplateRemoveSpecial = "Fuelchargelitre"},
                new R_M_TransformData {ServiceTemplate ="Servicepauschale",ServiceTranslation ="24-h Servicepauschale",ServiceCode ="ANULL",ColumnIndex =50,ColumnCode= "AY", ServiceTemplateRemoveSpecial = "Servicepauschale"},
                new R_M_TransformData {ServiceTemplate ="Airport Surcharge",ServiceTranslation ="Flughafen-/Bahnhof-Servicegebuehr",ServiceCode ="AIRP",ColumnIndex =51,ColumnCode= "AZ", ServiceTemplateRemoveSpecial = "AirportSurcharge"},
                new R_M_TransformData {ServiceTemplate ="Small Balance Write-off",ServiceTranslation ="Ausbuchung geringer Differenzbetrag",ServiceCode ="ANULL",ColumnIndex =52,ColumnCode= "BA", ServiceTemplateRemoveSpecial = "SmallBalanceWriteoff"},
                new R_M_TransformData {ServiceTemplate ="Small Balance Refund Write-off",ServiceTranslation ="Ausbuchung ger. Erstattungsbetrag",ServiceCode ="ANULL",ColumnIndex =53,ColumnCode= "BB", ServiceTemplateRemoveSpecial = "SmallBalanceRefundWriteoff"},
                new R_M_TransformData {ServiceTemplate ="VAT",ServiceTranslation ="Mehrwertsteuer x % auf",ServiceCode ="VTAX",ColumnIndex =54,ColumnCode= "BC", ServiceTemplateRemoveSpecial = "VAT"},
                new R_M_TransformData {ServiceTemplate ="Diesel vehicle",ServiceTranslation ="Zuschlag fuer Dieselfahrzeug",ServiceCode ="DIES",ColumnIndex =55,ColumnCode= "BD", ServiceTemplateRemoveSpecial = "Dieselvehicle"},
                new R_M_TransformData {ServiceTemplate ="Peak Period Schg",ServiceTranslation ="Hoch-Saison Zuschlag",ServiceCode ="HPEC",ColumnIndex =56,ColumnCode= "BE", ServiceTemplateRemoveSpecial = "PeakPeriodSchg"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental-Free Miles",ServiceTranslation ="im Grundpreis enthaltene Km",ServiceCode ="RATE",ColumnIndex =57,ColumnCode= "BF", ServiceTemplateRemoveSpecial = "BasicRentalFreeMiles"},
                new R_M_TransformData {ServiceTemplate ="Cash Deposit",ServiceTranslation ="Barvorauszahlung",ServiceCode ="ANULL",ColumnIndex =58,ColumnCode= "BG", ServiceTemplateRemoveSpecial = "CashDeposit"},
                new R_M_TransformData {ServiceTemplate ="Manual Surcharges",ServiceTranslation ="Zusaetzliche Gebuehren",ServiceCode ="ANULL",ColumnIndex =59,ColumnCode= "BH", ServiceTemplateRemoveSpecial = "ManualSurcharges"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental -Extra Days",ServiceTranslation ="Zusatztage",ServiceCode ="RATE",ColumnIndex =60,ColumnCode= "BI", ServiceTemplateRemoveSpecial = "BasicRentalExtraDays"},
                new R_M_TransformData {ServiceTemplate ="Child Seats",ServiceTranslation ="Kindersitz",ServiceCode ="BABY",ColumnIndex =61,ColumnCode= "BJ", ServiceTemplateRemoveSpecial = "ChildSeats"},
                new R_M_TransformData {ServiceTemplate ="Basic Rental -Extra Free Miles",ServiceTranslation ="im Zusatztag enthaltene Km",ServiceCode ="RATE",ColumnIndex =62,ColumnCode= "BK", ServiceTemplateRemoveSpecial = "BasicRentalExtraFreeMiles"},
                new R_M_TransformData {ServiceTemplate ="Aborted Delivery",ServiceTranslation ="Zustellung nicht moeglich",ServiceCode ="ADCC",ColumnIndex =63,ColumnCode= "BL", ServiceTemplateRemoveSpecial = "AbortedDelivery"},
                new R_M_TransformData {ServiceTemplate ="Aborted Collection",ServiceTranslation ="Abholung nicht moeglich",ServiceCode ="ADCC",ColumnIndex =64,ColumnCode= "BM", ServiceTemplateRemoveSpecial = "AbortedCollection"},
                new R_M_TransformData {ServiceTemplate ="FVV Driver Excess - VCH INV",ServiceTranslation ="Rechnung an Fahrer",ServiceCode ="ANULL",ColumnIndex =65,ColumnCode= "BN", ServiceTemplateRemoveSpecial = "FVVDriverExcessVCHINV"},
                new R_M_TransformData {ServiceTemplate ="Customer's Own Insurance",ServiceTranslation ="Versicherung des Kunden",ServiceCode ="ANULL",ColumnIndex =66,ColumnCode= "BO", ServiceTemplateRemoveSpecial = "CustomersOwnInsurance"},
                new R_M_TransformData {ServiceTemplate ="Stand Liable",ServiceTranslation ="Volle Haftung Mietfahrzeug",ServiceCode ="ANULL",ColumnIndex =67,ColumnCode= "BP", ServiceTemplateRemoveSpecial = "StandLiable"},
                new R_M_TransformData {ServiceTemplate ="Age Restriction",ServiceTranslation ="Altersrestriktion",ServiceCode ="YDRV",ColumnIndex =68,ColumnCode= "BQ", ServiceTemplateRemoveSpecial = "AgeRestriction"},
                new R_M_TransformData {ServiceTemplate ="Super Personal accident Protection",ServiceTranslation ="Erw. Insassenunfallversicherung",ServiceCode ="ANULL",ColumnIndex =69,ColumnCode= "BR", ServiceTemplateRemoveSpecial = "SuperPersonalaccidentProtection"},
                new R_M_TransformData {ServiceTemplate ="Additional Drivers",ServiceTranslation ="Zusatzfahrer",ServiceCode ="ADRV",ColumnIndex =70,ColumnCode= "BS", ServiceTemplateRemoveSpecial = "AdditionalDrivers"},
                new R_M_TransformData {ServiceTemplate ="Basic Protection Package",ServiceTranslation ="Basic-Schutzpaket",ServiceCode ="ANULL",ColumnIndex =71,ColumnCode= "BT", ServiceTemplateRemoveSpecial = "BasicProtectionPackage"},
                new R_M_TransformData {ServiceTemplate ="City Fee",ServiceTranslation ="City Fee",ServiceCode ="CITY",ColumnIndex =72,ColumnCode= "BU", ServiceTemplateRemoveSpecial = "CityFee"},
                new R_M_TransformData {ServiceTemplate ="Risk Reduction cover",ServiceTranslation ="Haftpfl./Vollkasko kein Diebs.+ PAI",ServiceCode ="ANULL",ColumnIndex =73,ColumnCode= "BV", ServiceTemplateRemoveSpecial = "RiskReductioncover"},
                new R_M_TransformData {ServiceTemplate ="Third Party Cover",ServiceTranslation ="Haftpflichtversicherung",ServiceCode ="ANULL",ColumnIndex =74,ColumnCode= "BW", ServiceTemplateRemoveSpecial = "ThirdPartyCover"},
                new R_M_TransformData {ServiceTemplate ="Super damage Protection",ServiceTranslation ="Super Damage Protection",ServiceCode ="ANULL",ColumnIndex =75,ColumnCode= "BX", ServiceTemplateRemoveSpecial = "SuperdamageProtection"},
                new R_M_TransformData {ServiceTemplate ="Full tank option",ServiceTranslation ="Kraftstoffverkauf",ServiceCode ="PGAS",ColumnIndex =76,ColumnCode= "BY", ServiceTemplateRemoveSpecial = "Fulltankoption"},
                new R_M_TransformData {ServiceTemplate ="Licenses & Fees",ServiceTranslation ="Verkehrssteuern / Gebuehren",ServiceCode ="RVLF",ColumnIndex =77,ColumnCode= "BZ", ServiceTemplateRemoveSpecial = "LicensesFees"},
                new R_M_TransformData {ServiceTemplate ="vignette",ServiceTranslation ="Vignette",ServiceCode ="RTAX",ColumnIndex =78,ColumnCode= "CA", ServiceTemplateRemoveSpecial = "vignette"},
                new R_M_TransformData {ServiceTemplate ="winter equipment",ServiceTranslation ="Wintertaugliche Bereifung",ServiceCode ="TIRE",ColumnIndex =79,ColumnCode= "CB", ServiceTemplateRemoveSpecial = "winterequipment"},
                new R_M_TransformData {ServiceTemplate ="Snow Chains",ServiceTranslation ="Zubehör",ServiceCode ="SNBR",ColumnIndex =80,ColumnCode= "CC", ServiceTemplateRemoveSpecial = "SnowChains"},
                new R_M_TransformData {ServiceTemplate ="Eco Surcharge",ServiceTranslation ="Umweltbeitrag",ServiceCode ="ETAX",ColumnIndex =81,ColumnCode= "CD", ServiceTemplateRemoveSpecial = "EcoSurcharge"},
                new R_M_TransformData {ServiceTemplate ="Surcharge Damage",ServiceTranslation ="Schadenersatz Neuschaden",ServiceCode ="ANULL",ColumnIndex =82,ColumnCode= "CE", ServiceTemplateRemoveSpecial = "SurchargeDamage"},
                new R_M_TransformData {ServiceTemplate ="Damage repairs",ServiceTranslation ="Schadenreparaturen",ServiceCode ="ANULL",ColumnIndex =83,ColumnCode= "CF", ServiceTemplateRemoveSpecial = "Damagerepairs"},
                new R_M_TransformData {ServiceTemplate ="FLEXI REFUELLING",ServiceTranslation ="Flexi-Refueling",ServiceCode ="ANULL",ColumnIndex =84,ColumnCode= "CG", ServiceTemplateRemoveSpecial = "FLEXIREFUELLING"},
                new R_M_TransformData {ServiceTemplate ="Payment Card Fee",ServiceTranslation ="Gebuehr fuer Kartenzahlung",ServiceCode ="CCSC",ColumnIndex =85,ColumnCode= "CH", ServiceTemplateRemoveSpecial = "PaymentCardFee"},
                new R_M_TransformData {ServiceTemplate ="Sundry Equipment Sales",ServiceTranslation ="Zubehoer",ServiceCode ="ANULL",ColumnIndex =86,ColumnCode= "CI", ServiceTemplateRemoveSpecial = "SundryEquipmentSales"},
                new R_M_TransformData {ServiceTemplate ="Administration Fee",ServiceTranslation ="Kostenpauschale",ServiceCode ="ADFE",ColumnIndex =87,ColumnCode= "CJ", ServiceTemplateRemoveSpecial = "AdministrationFee"},
                new R_M_TransformData {ServiceTemplate ="Super Loss Damage Protection",ServiceTranslation ="Erweiterter Diebstahl-+Unfallschutz",ServiceCode ="ANULL",ColumnIndex =88,ColumnCode= "CK", ServiceTemplateRemoveSpecial = "SuperLossDamageProtection"},
                new R_M_TransformData {ServiceTemplate ="Promotion",ServiceTranslation ="Sofortrabatt",ServiceCode ="ANULL",ColumnIndex =89,ColumnCode= "CL", ServiceTemplateRemoveSpecial = "Promotion"},
                new R_M_TransformData {ServiceTemplate ="Prem/Railway Schg",ServiceTranslation ="Prem/Railway Schg",ServiceCode ="RAIL",ColumnIndex =90,ColumnCode= "CM", ServiceTemplateRemoveSpecial = "PremRailwaySchg"},
                new R_M_TransformData {ServiceTemplate ="Govt Admin Rt Sup",ServiceTranslation ="Govt Admin Rt Sup",ServiceCode ="ANULL",ColumnIndex =91,ColumnCode= "CN", ServiceTemplateRemoveSpecial = "GovtAdminRtSup"},
                new R_M_TransformData {ServiceTemplate ="Super Theft Protection",ServiceTranslation ="Erweiterter Diebstahlschutz",ServiceCode ="ANULL",ColumnIndex =92,ColumnCode= "CO", ServiceTemplateRemoveSpecial = "SuperTheftProtection"},
                new R_M_TransformData {ServiceTemplate ="Glass & Tyres Protection",ServiceTranslation ="Glas- und Reifenschutz",ServiceCode ="GTIN",ColumnIndex =93,ColumnCode= "CP", ServiceTemplateRemoveSpecial = "GlassTyresProtection"},
                new R_M_TransformData {ServiceTemplate ="Fuel Card Litres",ServiceTranslation ="MAUT Deutschland",ServiceCode ="ANULL",ColumnIndex =94,ColumnCode= "CQ", ServiceTemplateRemoveSpecial = "FuelCardLitres"},
                new R_M_TransformData {ServiceTemplate ="Refuelling Service",ServiceTranslation ="Betankungs-Service",ServiceCode ="FUES",ColumnIndex =95,ColumnCode= "CR", ServiceTemplateRemoveSpecial = "RefuellingService"},
                new R_M_TransformData {ServiceTemplate ="Corsica Surcharge",ServiceTranslation ="Zuschlag Korsika",ServiceCode ="ANULL",ColumnIndex =96,ColumnCode= "CS", ServiceTemplateRemoveSpecial = "CorsicaSurcharge"},
                new R_M_TransformData {ServiceTemplate ="Coverage  Package",ServiceTranslation ="Schutzpaket",ServiceCode ="ANULL",ColumnIndex =97,ColumnCode= "CT", ServiceTemplateRemoveSpecial = "CoveragePackage"},
                new R_M_TransformData {ServiceTemplate ="High Season Surcharge",ServiceTranslation ="Zuschlag High Season",ServiceCode ="HPEC",ColumnIndex =98,ColumnCode= "CU", ServiceTemplateRemoveSpecial = "HighSeasonSurcharge"},
                new R_M_TransformData {ServiceTemplate ="Electronic Payment Tag/Pass",ServiceTranslation ="Vignette AT 10 Tage",ServiceCode ="RTAX",ColumnIndex =99,ColumnCode= "CV", ServiceTemplateRemoveSpecial = "ElectronicPaymentTagPass"},
                new R_M_TransformData {ServiceTemplate ="Fines Appeal Waiver",ServiceTranslation ="Bußgeld / Verzicht auf Rechtsbehelf",ServiceCode ="ANULL",ColumnIndex =100,ColumnCode= "CW", ServiceTemplateRemoveSpecial = "FinesAppealWaiver"},
                new R_M_TransformData {ServiceTemplate ="Navigation System",ServiceTranslation ="Navigationssystem",ServiceCode ="GPSS",ColumnIndex =101,ColumnCode= "CX", ServiceTemplateRemoveSpecial = "NavigationSystem"},
                new R_M_TransformData {ServiceTemplate ="Ecological Fees",ServiceTranslation ="Umweltbeitrag",ServiceCode ="ETAX",ColumnIndex =102,ColumnCode= "CY", ServiceTemplateRemoveSpecial = "EcologicalFees"},
                new R_M_TransformData {ServiceTemplate ="Coverage Package 2",ServiceTranslation ="Coverage Package 2",ServiceCode ="ANULL",ColumnIndex =103,ColumnCode= "CZ", ServiceTemplateRemoveSpecial = "CoveragePackage2"},
                new R_M_TransformData {ServiceTemplate ="Damage Administration Fee",ServiceTranslation ="Schadenbearbeitungspauschale",ServiceCode ="DAMA",ColumnIndex =104,ColumnCode= "DA", ServiceTemplateRemoveSpecial = "DamageAdministrationFee"},
                new R_M_TransformData {ServiceTemplate ="Carbon Offset",ServiceTranslation ="Umweltbeitrag",ServiceCode ="ETAX",ColumnIndex =105,ColumnCode= "DB", ServiceTemplateRemoveSpecial = "CarbonOffset"},
                new R_M_TransformData {ServiceTemplate ="COI - Limited Damage Option",ServiceTranslation ="COI - Ltd Damage Option",ServiceCode ="ANULL",ColumnIndex =106,ColumnCode= "DC", ServiceTemplateRemoveSpecial = "COILimitedDamageOption"},
                new R_M_TransformData {ServiceTemplate ="Mobile WI-FI",ServiceTranslation ="Mobiler LTE-Router",ServiceCode ="ANULL",ColumnIndex =107,ColumnCode= "DD", ServiceTemplateRemoveSpecial = "MobileWIFI"},
                new R_M_TransformData {ServiceTemplate ="Cruise Terminal Surcharge",ServiceTranslation ="Kreuzfahrtterminal-Gebuehr",ServiceCode ="ANULL",ColumnIndex =108,ColumnCode= "DE", ServiceTemplateRemoveSpecial = "CruiseTerminalSurcharge"},
                new R_M_TransformData {ServiceTemplate ="Late Check-In",ServiceTranslation ="Late Check-in",ServiceCode ="LARF",ColumnIndex =109,ColumnCode= "DF", ServiceTemplateRemoveSpecial = "LateCheckIn"},
                new R_M_TransformData {ServiceTemplate ="Tablet Device",ServiceTranslation ="Tablet",ServiceCode ="ANULL",ColumnIndex =110,ColumnCode= "DG", ServiceTemplateRemoveSpecial = "TabletDevice"},
                new R_M_TransformData {ServiceTemplate ="Location Surcharge",ServiceTranslation ="Standortzuschlag",ServiceCode ="ANULL",ColumnIndex =111,ColumnCode= "DH", ServiceTemplateRemoveSpecial = "LocationSurcharge"},
                new R_M_TransformData {ServiceTemplate ="Coupon",ServiceTranslation ="Coupon",ServiceCode ="ANULL",ColumnIndex =112,ColumnCode= "DI", ServiceTemplateRemoveSpecial = "Coupon"},
                new R_M_TransformData {ServiceTemplate ="Roadside Assistance Plus",ServiceTranslation ="Roadside Assistance",ServiceCode ="ANULL",ColumnIndex =113,ColumnCode= "DJ", ServiceTemplateRemoveSpecial = "RoadsideAssistancePlus"},
                new R_M_TransformData {ServiceTemplate ="GoZen Coverage",ServiceTranslation ="GoZen Schutzpaket",ServiceCode ="ANULL",ColumnIndex =114,ColumnCode= "DK", ServiceTemplateRemoveSpecial = "GoZenCoverage"},
                new R_M_TransformData {ServiceTemplate ="GoZen Plus Coverage",ServiceTranslation ="GoZen Plus Schutzpaket",ServiceCode ="ANULL",ColumnIndex =115,ColumnCode= "DL", ServiceTemplateRemoveSpecial = "GoZenPlusCoverage"},
                new R_M_TransformData {ServiceTemplate ="Roof & Chassis Protection",ServiceTranslation ="Dach- und Fahrgestell-Schutzpaket",ServiceCode ="ANULL",ColumnIndex =116,ColumnCode= "DM", ServiceTemplateRemoveSpecial = "RoofChassisProtection"},
                new R_M_TransformData {ServiceTemplate ="Emergency Travel Services",ServiceTranslation ="Notfall-Transportservice",ServiceCode ="ANULL",ColumnIndex =117,ColumnCode= "DN", ServiceTemplateRemoveSpecial = "EmergencyTravelServices"},
                new R_M_TransformData {ServiceTemplate ="Valet Parking",ServiceTranslation ="Parkservice",ServiceCode ="ANULL",ColumnIndex =118,ColumnCode= "DO", ServiceTemplateRemoveSpecial = "ValetParking"},
                new R_M_TransformData {ServiceTemplate ="Car Valeting",ServiceTranslation ="Parkservice",ServiceCode ="ANULL",ColumnIndex =119,ColumnCode= "DP", ServiceTemplateRemoveSpecial = "CarValeting"},
                new R_M_TransformData {ServiceTemplate ="Medium protection package",ServiceTranslation ="Schutzpaket medium",ServiceCode ="ANULL",ColumnIndex =120,ColumnCode= "DQ", ServiceTemplateRemoveSpecial = "Mediumprotectionpackage"},
                new R_M_TransformData {ServiceTemplate ="Premium protection package",ServiceTranslation ="Schutzpaket premium",ServiceCode ="ANULL",ColumnIndex =121,ColumnCode= "DR", ServiceTemplateRemoveSpecial = "Premiumprotectionpackage"},
                new R_M_TransformData {ServiceTemplate ="Full Damage Protection",ServiceTranslation ="Umfassender Schadensschutz",ServiceCode ="ANULL",ColumnIndex =122,ColumnCode= "DS", ServiceTemplateRemoveSpecial = "FullDamageProtection"},
                new R_M_TransformData {ServiceTemplate ="Full Theft Protection",ServiceTranslation ="Umfassender Diebstahlschutz",ServiceCode ="ANULL",ColumnIndex =123,ColumnCode= "DT", ServiceTemplateRemoveSpecial = "FullTheftProtection"},
                new R_M_TransformData {ServiceTemplate ="Full Loss Damage Protection",ServiceTranslation ="Umfassender Diebstahl-+Unfallschutz",ServiceCode ="ANULL",ColumnIndex =124,ColumnCode= "DU", ServiceTemplateRemoveSpecial = "FullLossDamageProtection"},
                new R_M_TransformData {ServiceTemplate ="change of prebooked terms",ServiceTranslation ="Change of Prebooked Terms",ServiceCode ="ANULL",ColumnIndex =125,ColumnCode= "DV", ServiceTemplateRemoveSpecial = "changeofprebookedterms"},
                new R_M_TransformData {ServiceTemplate ="MOBILE PHONE KIT",ServiceTranslation ="Mobile Phone Kit",ServiceCode ="ANULL",ColumnIndex =126,ColumnCode= "DW", ServiceTemplateRemoveSpecial = "MOBILEPHONEKIT"},
                new R_M_TransformData {ServiceTemplate ="SELECTION PROTECTION PACKAGE",ServiceTranslation ="Selection Protection Package",ServiceCode ="ANULL",ColumnIndex =127,ColumnCode= "DX", ServiceTemplateRemoveSpecial = "SELECTIONPROTECTIONPACKAGE"},
                new R_M_TransformData {ServiceTemplate ="WINTER EQP ITALY",ServiceTranslation ="Winter Equipment Italy",ServiceCode ="SNBR",ColumnIndex =128,ColumnCode= "DY", ServiceTemplateRemoveSpecial = "WINTEREQPITALY"},
                new R_M_TransformData {ServiceTemplate ="AFTER HOURS COLLECTION FEE",ServiceTranslation ="After Hours Collection Fee",ServiceCode ="ANULL",ColumnIndex =129,ColumnCode= "DZ", ServiceTemplateRemoveSpecial = "AFTERHOURSCOLLECTIONFEE"},
                new R_M_TransformData {ServiceTemplate ="PREPARATION FEE",ServiceTranslation ="Preparation Fee",ServiceCode ="ANULL",ColumnIndex =130,ColumnCode= "EA", ServiceTemplateRemoveSpecial = "PREPARATIONFEE"},
                new R_M_TransformData {ServiceTemplate ="APT CHARGE AT C I",ServiceTranslation ="APT CHARGE AT C I",ServiceCode ="AIRP",ColumnIndex =131,ColumnCode= "EB", ServiceTemplateRemoveSpecial = "APTCHARGEATCI"},
                new R_M_TransformData {ServiceTemplate ="MANDATORY REFUELLING SURCHARGE",ServiceTranslation ="MANDATORY REFUELLING SURCHARGE",ServiceCode ="ANULL",ColumnIndex =132,ColumnCode= "EC", ServiceTemplateRemoveSpecial = "MANDATORYREFUELLINGSURCHARGE"},
                new R_M_TransformData {ServiceTemplate ="ENHANCED PARTNER PROTECTION",ServiceTranslation ="ENHANCED PARTNER PROTECTION",ServiceCode ="ANULL",ColumnIndex =133,ColumnCode= "ED", ServiceTemplateRemoveSpecial = "ENHANCEDPARTNERPROTECTION"},
                new R_M_TransformData {ServiceTemplate ="TOLL PASSAGE",ServiceTranslation =" Toll passages",ServiceCode ="RTAX",ColumnIndex =134,ColumnCode= "EE", ServiceTemplateRemoveSpecial = "TOLLPASSAGE"},
                new R_M_TransformData {ServiceTemplate ="PREMIUM DISCOUNT",ServiceTranslation ="PREMIUM DISCOUNT",ServiceCode ="ANULL",ColumnIndex =135,ColumnCode= "EF", ServiceTemplateRemoveSpecial = "PREMIUMDISCOUNT"},
                new R_M_TransformData {ServiceTemplate ="AUTOMATIC CARS",ServiceTranslation ="AUTOMATIC CARS",ServiceCode ="AUTO",ColumnIndex =136,ColumnCode= "EG", ServiceTemplateRemoveSpecial = "AUTOMATICCARS"},
                new R_M_TransformData {ServiceTemplate ="PREPARATION COST",ServiceTranslation ="Bereitstellungskosten",ServiceCode ="ANULL",ColumnIndex =137,ColumnCode= "EH", ServiceTemplateRemoveSpecial = "PREPARATIONCOST"},
                new R_M_TransformData {ServiceTemplate ="CROSS BORDER FEE",ServiceTranslation ="CROSS BORDER FEE",ServiceCode ="CRBF",ColumnIndex =138,ColumnCode= "EI", ServiceTemplateRemoveSpecial = "CROSSBORDERFEE"},
                new R_M_TransformData {ServiceTemplate ="EUROPDRIVE COVER",ServiceTranslation ="EUROPDRIVE COVER",ServiceCode ="ANULL",ColumnIndex =139,ColumnCode= "EJ", ServiceTemplateRemoveSpecial = "EUROPDRIVECOVER"},
                new R_M_TransformData {ServiceTemplate ="TOLL ROAD ADMIN FEE",ServiceTranslation ="TOLL ROAD ADMIN FEE",ServiceCode ="ANULL",ColumnIndex =140,ColumnCode= "EK", ServiceTemplateRemoveSpecial = "TOLLROADADMINFEE"},
                new R_M_TransformData {ServiceTemplate ="Contract Tax",ServiceTranslation ="Vertragsgebühr 1%",ServiceCode ="CTRF",ColumnIndex =141,ColumnCode= "EL", ServiceTemplateRemoveSpecial = "ContractTax"},

            });
            _mockBLL = new Mock<RC_R_InvoiceReportBLL>(_mockDAL.Object);
            _mockBLL.Setup(x => x.SendMail(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<RentalEmailCategory>(), It.IsAny<string>(), It.IsAny<R_M_CompanySetting>())).Returns(new R_N_SentBox { ID = 1, IsSuccess = 1 });
            _mockBLL.Setup(x => x.SaveDatabase(It.IsAny<R_N_SentBox>(), It.IsAny<R_I_Report>(), It.IsAny<List<long>>())).Returns(true);
            _mockBLL.Setup(x => x.GetTemplatePath()).Returns(@"D:\GIT\Configuration Items\3. Implementation\2. T2P.2015.Service\T2P.2015.Service.API\T2P.2015.Service.API\Templates\Report\RC_InvoiceReport.en-US.xlsx");
        }

        [TestMethod]
        public void ShouldReturnNoData_WhenNoCompanySetup()
        {
            // Arrange
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns((List<R_M_CompanySetting>)null);
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);


            // Arrange
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns(new List<R_M_CompanySetting>());
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);


            // Arrange
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns(
                new List<R_M_CompanySetting>
                {
                    new R_M_CompanySetting { ID = 1, Type = "NotReport" }
                });
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);
        }

        [TestMethod]
        public void ShouldReturnNoData_WhenNotInSchedule()
        {
            // Arrange
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns(
                new List<R_M_CompanySetting>
                { 
                    new R_M_CompanySetting { ID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                        Frequency = R_M_CompanySettingFrequency.Week.ToString(), Time = DateTime.Now.ToString("HH:mm"),
                        Date = DateTime.Now.AddDays(1).DayOfWeek.ToString() },
                    new R_M_CompanySetting { ID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                        Frequency = R_M_CompanySettingFrequency.Week.ToString(), Time = DateTime.Now.AddHours(1).ToString("HH:mm"),
                        Date = DateTime.Now.DayOfWeek.ToString() }
                }
            );
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);


            // Arrange
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns(
                new List<R_M_CompanySetting>
                { 
                    new R_M_CompanySetting { ID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                        Frequency = R_M_CompanySettingFrequency.Month.ToString(), Time = DateTime.Now.AddHours(1).ToString("HH:mm"),
                        Date = DateTime.Now.Month.ToString("dd") },
                    new R_M_CompanySetting { ID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                        Frequency = R_M_CompanySettingFrequency.Month.ToString(), Time = DateTime.Now.ToString("HH:mm"),
                        Date = DateTime.Now.AddDays(1).Month.ToString("d") },
                    new R_M_CompanySetting { ID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                        Frequency = R_M_CompanySettingFrequency.Month.ToString(), Time = DateTime.Now.ToString("HH:mm"),
                        Date = DateTime.Now.AddDays(-1).Month.ToString("d") },
                    new R_M_CompanySetting { ID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                        Frequency = R_M_CompanySettingFrequency.Month.ToString(), Time = DateTime.Now.ToString("HH:mm"),
                        Date = "31" },
                }
            );
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);
        }

        [TestMethod]
        public void ShouldReturnSuccess_IfHasClaimReport()
        {
            // Arrange
            SetupForClaimReport();
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.Success);
        }

        
        [TestMethod]
        public void ShouldReturnSuccess_IfHasMonthlyReport()
        {
            // Arrange
            SetupForMonthlyReport();
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.Success);
        }

        [TestMethod]
        public void ShouldReturnCorrectInformation_OnPrepareExcelDataFunction()
        {
            // Arrange
            List<R_I_DataReport> listR_I_DataReport = new List<R_I_DataReport>
            {
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789001", RentalNumber = "123456789001",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = string.Empty, CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 1, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                },
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789002", RentalNumber = "123456789002",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = "HENRICH MEIER", CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 2, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                },
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789003", RentalNumber = "123456789003",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = "HENRICH MEIER", CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 3, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                }
            };
            List<long> listR_I_DataID = new List<long>();

            SetupForClaimReport();

            // Act
            var result = _mockBLL.Object.PrepareExcelData(listR_I_DataReport, listR_I_DataID);

            // Assert
            Assert.AreEqual(result.Count, 3);
            //Assert.AreEqual(result.Last().AdditionalDriver, "18.00");
            Assert.AreEqual(result.Last().Delivery, "-5.00");
            Assert.AreEqual(result.Last().Collection, "-1.00");

            Assert.AreEqual(result.First().DriverFirstName, string.Empty);
            Assert.AreEqual(result.First().DriverSurname, string.Empty);
            Assert.AreEqual(result.Last().DriverFirstName, "HENRICH");
            Assert.AreEqual(result.Last().DriverSurname, "MEIER");
        }

        [TestMethod]
        public void ShouldReturnError_IfCannotSaveDatabase()
        {
            // Arrange
            _mockBLL.Setup(x => x.SaveDatabase(It.IsAny<R_N_SentBox>(), It.IsAny<R_I_Report>(), It.IsAny<List<long>>())).Returns(false);
            SetupForClaimReport();
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.ErrorUpdateDB);

            // Arrange
            SetupForMonthlyReport();
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.ErrorUpdateDB);
        }

        [TestMethod]
        public void ShouldReturnError_IfCannotSendEmail()
        {
            // Arrange
            _mockBLL.Setup(x => x.SendMail(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<RentalEmailCategory>(), It.IsAny<string>(), It.IsAny<R_M_CompanySetting>())).Returns(new R_N_SentBox { ID = 0, IsSuccess = 0 });
            SetupForClaimReport();
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.ErrorSendEmail);

            // Arrange
            SetupForMonthlyReport();
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.ErrorSendEmail);
        }

        [TestMethod]
        public void ShouldReturnNoData_IfStoredProcedureDontHaveData()
        {
            // Arrange
            SetupForClaimReport();
            _mockDAL.Setup(x => x.GetForClaimReportByR_M_CompanyID(It.IsAny<long>(), It.IsAny<DateTime>())).Returns(new List<R_I_DataReport>());
            // Act
            ProcessStatus result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);
            // Arrange
            SetupForClaimReport();
            _mockDAL.Setup(x => x.GetForClaimReportByR_M_CompanyID(It.IsAny<long>(), It.IsAny<DateTime>())).Returns((List<R_I_DataReport>)null);
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);

            // Arrange
            SetupForMonthlyReport();
            _mockDAL.Setup(x => x.GetForReportByR_M_CompanyID(It.IsAny<long>(), It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(new List<R_I_DataReport>());
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);
            // Arrange
            SetupForMonthlyReport();
            _mockDAL.Setup(x => x.GetForReportByR_M_CompanyID(It.IsAny<long>(), It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns((List<R_I_DataReport>)null);
            // Act
            result = _mockBLL.Object.Run(1);
            // Assert
            Assert.AreEqual(result.Code, ProcessStatusCode.NoData);
        }

        [TestMethod]
        public void ShouldLogging_IfNoService()
        {
            // Arrange
            List<R_I_DataReport> listR_I_DataReport = new List<R_I_DataReport>
            {
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789001", RentalNumber = "123456789001",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = string.Empty, CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 1, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                }
            };
            List<long> listR_I_DataID = new List<long> { 1, 2, 5 };
            SetupForClaimReport();
            _mockDAL.Setup(x => x.GetListServicesByListR_I_DataID(It.IsAny<List<long>>())).Returns(new List<R_I_Service>());
            // Act
            var result = _mockBLL.Object.PrepareExcelData(listR_I_DataReport, listR_I_DataID);
            // Assert
            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result.First().VAT, string.Empty);
        }

        #region Setups

        private void SetupForClaimReport()
        {
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns(new List<R_M_CompanySetting> { 
                new R_M_CompanySetting { ID = 1, R_M_CompanyID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.ClaimReport.ToString(),
                    Frequency = R_M_CompanySettingFrequency.Week.ToString(), Time = DateTime.Now.AddHours(-1).ToString("HH:mm"), Date = DateTime.Now.DayOfWeek.ToString() }
            });
            _mockDAL.Setup(x => x.GetListR_M_FileLocation()).Returns(new List<R_M_FileLocation> {
                new R_M_FileLocation { M_CarRentalProviderID = 6, IP = @"\\192.168.10.5\BCD" }
            });
            _mockDAL.Setup(x => x.GetForClaimReportByR_M_CompanyID(It.IsAny<long>(), It.IsAny<DateTime>())).Returns(new List<R_I_DataReport> {
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789001", RentalNumber = "123456789001",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = string.Empty, CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 1, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received", RateGrid = "Online Rate"
                },
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789002", RentalNumber = "123456789002",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = "HENRICH MEIER", CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 2, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received", RateGrid = "Online Rate"
                },
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789003", RentalNumber = "123456789003",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = "HENRICH MEIER", CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 3, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received", RateGrid = "Online Rate"
                }
            });
            _mockDAL.Setup(x => x.GetListServicesByListR_I_DataID(It.IsAny<List<long>>())).Returns(new List<R_I_Service> {
                new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 68, ServiceName = "Basic rental", NetAmount = 75.72m, TaxRate = 19, TaxAmount = 14.39m, GrossAmount = 90.11m },
                new R_I_Service { ID = 2, R_I_DataID = 1, R_M_SurchargeID = 9, ServiceName = "Collection", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 3, R_I_DataID = 1, R_M_SurchargeID = 9, ServiceName = "Delivery", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 4, R_I_DataID = 2, R_M_SurchargeID = 68, ServiceName = "Basic rental", NetAmount = 75.72m, TaxRate = 19, TaxAmount = 14.39m, GrossAmount = 90.11m },
                new R_I_Service { ID = 5, R_I_DataID = 2, R_M_SurchargeID = 9, ServiceName = "Collection", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 6, R_I_DataID = 2, R_M_SurchargeID = 9, ServiceName = "Delivery", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 7, R_I_DataID = 3, R_M_SurchargeID = 68, ServiceName = "Basic rental", NetAmount = -75.72m, TaxRate = 19, TaxAmount = -14.39m, GrossAmount = -90.11m },
                new R_I_Service { ID = 8, R_I_DataID = 3, R_M_SurchargeID = 9, ServiceName = "Collection", NetAmount = -1m, TaxRate = 19, TaxAmount = -0.95m, GrossAmount = -5.95m },
                new R_I_Service { ID = 9, R_I_DataID = 3, R_M_SurchargeID = 9, ServiceName = "Delivery", NetAmount = -5m, TaxRate = 19, TaxAmount = -0.95m, GrossAmount = -5.95m },
                new R_I_Service { ID = 10, R_I_DataID = 3, R_M_SurchargeID = 1, ServiceName = "Airport-Railway Surcharge/Oneri Aeroportuali", NetAmount = -4.02m, TaxRate = 22, TaxAmount = -0.88m, GrossAmount = -4.9m },
                new R_I_Service { ID = 11, R_I_DataID = 3, R_M_SurchargeID = 5, ServiceName = "Manual Correction transaction", NetAmount = -8.95m, TaxRate = 0, TaxAmount = 0, GrossAmount = -8.95m },
                new R_I_Service { ID = 12, R_I_DataID = 3, R_M_SurchargeID = 6, ServiceName = "Additional driver", NetAmount = 18, TaxRate = 27, TaxAmount = 4.86m, GrossAmount = 22.86m },
                new R_I_Service { ID = 13, R_I_DataID = 3, R_M_SurchargeID = 8, ServiceName = "GPS guaranteed", NetAmount = 35, TaxRate = 21, TaxAmount = 7.35m, GrossAmount = 42.35m },
                new R_I_Service { ID = 14, R_I_DataID = 3, R_M_SurchargeID = 12, ServiceName = "Fuelling", NetAmount = 17.46m, TaxRate = 21, TaxAmount = 3.67m, GrossAmount = 21.13m },
                new R_I_Service { ID = 15, R_I_DataID = 3, R_M_SurchargeID = 25, ServiceName = "PAI", NetAmount = -16.29m, TaxRate = 0, TaxAmount = 0, GrossAmount = 16.29m },
                new R_I_Service { ID = 16, R_I_DataID = 3, R_M_SurchargeID = 27, ServiceName = "(*) Accessories/Accessori", NetAmount = 20, TaxRate = 22, TaxAmount = 4.4m, GrossAmount = 24.4m },
                new R_I_Service { ID = 17, R_I_DataID = 3, R_M_SurchargeID = 49, ServiceName = "Out of hours", NetAmount = 50, TaxRate = 20, TaxAmount = 10, GrossAmount = 60 },
                new R_I_Service { ID = 18, R_I_DataID = 3, R_M_SurchargeID = 67, ServiceName = "Einweggebuehren", NetAmount = 800, TaxRate = 21, TaxAmount = 168, GrossAmount = 968 },
                new R_I_Service { ID = 19, R_I_DataID = 3, R_M_SurchargeID = 68, ServiceName = "Días de alquiler", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 20, R_I_DataID = 3, R_M_SurchargeID = 72, ServiceName = "Admin fee", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 21, R_I_DataID = 3, R_M_SurchargeID = 223, ServiceName = "Diesel", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 22, R_I_DataID = 3, R_M_SurchargeID = 242, ServiceName = "Automatikwunsch", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 23, R_I_DataID = 3, R_M_SurchargeID = null, ServiceName = "Basic Protection ", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 24, R_I_DataID = 3, R_M_SurchargeID = null, ServiceName = "Basic Rental Free Miles", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 25, R_I_DataID = 3, R_M_SurchargeID = null, ServiceName = "Basic Rental Upgrade", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 26, R_I_DataID = 3, R_M_SurchargeID = null, ServiceName = "licences & Fees", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 27, R_I_DataID = 3, R_M_SurchargeID = null, ServiceName = "Winter equipment", NetAmount = 260, TaxRate = 21, TaxAmount = 54.59m, GrossAmount = 314.59m },
                new R_I_Service { ID = 28, R_I_DataID = 2, R_M_SurchargeID = 68, ServiceName = "Basic Rental Extra Days", NetAmount = 10, TaxRate = 7, TaxAmount = 0.07m, GrossAmount = 10.07m },
            });
            _mockDAL.Setup(x => x.GetListErrorsByListR_I_DataID(It.IsAny<List<long>>())).Returns(new List<R_I_Error> {
                new R_I_Error { ID = 1, R_I_DataID = 1, R_I_ServiceID = 1, R_M_InvoiceErrorCodeID = 2, ExpectedAmount = 50m },
                new R_I_Error { ID = 2, R_I_DataID = 1, R_I_ServiceID = 2, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 10m },
                new R_I_Error { ID = 3, R_I_DataID = 1, R_I_ServiceID = 3, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 10m },
                new R_I_Error { ID = 5, R_I_DataID = 2, R_I_ServiceID = 4, R_M_InvoiceErrorCodeID = 27, ExpectedAmount = 50m },
                new R_I_Error { ID = 6, R_I_DataID = 2, R_I_ServiceID = 5, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 0 },
                new R_I_Error { ID = 7, R_I_DataID = 2, R_I_ServiceID = 6, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 0 },
                new R_I_Error { ID = 8, R_I_DataID = 3, R_I_ServiceID = 1, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 9, R_I_DataID = 3, R_I_ServiceID = 23, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 230m },
                new R_I_Error { ID = 10, R_I_DataID = 3, R_I_ServiceID = 24, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 5m },
                new R_I_Error { ID = 11, R_I_DataID = 3, R_I_ServiceID = 25, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 230m },
                new R_I_Error { ID = 12, R_I_DataID = 3, R_I_ServiceID = 26, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 200m },
                new R_I_Error { ID = 13, R_I_DataID = 3, R_I_ServiceID = 21, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 14, R_I_DataID = 3, R_I_ServiceID = 20, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 15, R_I_DataID = 3, R_I_ServiceID = 22, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 16, R_I_DataID = 3, R_I_ServiceID = 19, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 17, R_I_DataID = 3, R_I_ServiceID = 18, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 18, R_I_DataID = 3, R_I_ServiceID = 17, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 19, R_I_DataID = 3, R_I_ServiceID = 16, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 20, R_I_DataID = 3, R_I_ServiceID = 15, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 21, R_I_DataID = 3, R_I_ServiceID = 14, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 22, R_I_DataID = 3, R_I_ServiceID = 13, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 23, R_I_DataID = 3, R_I_ServiceID = 12, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 24, R_I_DataID = 3, R_I_ServiceID = 11, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 25, R_I_DataID = 3, R_I_ServiceID = 10, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
                new R_I_Error { ID = 26, R_I_DataID = 2, R_I_ServiceID = 28, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 13 },
            });
        }

        private void SetupForMonthlyReport()
        {
            _mockDAL.Setup(x => x.GetListR_M_CompanySetting()).Returns(new List<R_M_CompanySetting> { 
                new R_M_CompanySetting { ID = 1, R_M_CompanyID = 1, Email = "test@example.com", Type = R_M_CompanySettingType.InvoiceReport.ToString(),
                    Frequency = R_M_CompanySettingFrequency.Month.ToString(), Time = DateTime.Now.AddHours(-1).ToString("HH:mm"), Date = DateTime.Now.Day.ToString() }
            });
            _mockDAL.Setup(x => x.GetListR_M_FileLocation()).Returns(new List<R_M_FileLocation> {
                new R_M_FileLocation { M_CarRentalProviderID = 6, IP = @"\\192.168.10.5\BCD" }
            });
            _mockDAL.Setup(x => x.GetForReportByR_M_CompanyID(It.IsAny<long>(), It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(CreateDataReport());
            _mockDAL.Setup(x => x.GetListServicesByListR_I_DataID(It.IsAny<List<long>>())).Returns(new List<R_I_Service> {
                new R_I_Service { ID = 1, R_I_DataID = 1, R_M_SurchargeID = 68, ServiceName = "Basic rental", NetAmount = 75.72m, TaxRate = 19, TaxAmount = 14.39m, GrossAmount = 90.11m },
                new R_I_Service { ID = 2, R_I_DataID = 1, R_M_SurchargeID = 9, ServiceName = "Collection", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 3, R_I_DataID = 1, R_M_SurchargeID = 9, ServiceName = "Delivery", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 4, R_I_DataID = 2, R_M_SurchargeID = 68, ServiceName = "Basic rental", NetAmount = 75.72m, TaxRate = 19, TaxAmount = 14.39m, GrossAmount = 90.11m },
                new R_I_Service { ID = 5, R_I_DataID = 2, R_M_SurchargeID = 9, ServiceName = "Collection", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 6, R_I_DataID = 2, R_M_SurchargeID = 9, ServiceName = "Delivery", NetAmount = 5m, TaxRate = 19, TaxAmount = 0.95m, GrossAmount = 5.95m },
                new R_I_Service { ID = 7, R_I_DataID = 3, R_M_SurchargeID = 68, ServiceName = "Basic rental", NetAmount = -75.72m, TaxRate = 19, TaxAmount = -14.39m, GrossAmount = -90.11m },
                new R_I_Service { ID = 8, R_I_DataID = 3, R_M_SurchargeID = 9, ServiceName = "Collection", NetAmount = -1m, TaxRate = 19, TaxAmount = -0.95m, GrossAmount = -5.95m },
                new R_I_Service { ID = 9, R_I_DataID = 3, R_M_SurchargeID = 9, ServiceName = "Delivery", NetAmount = -5m, TaxRate = 19, TaxAmount = -0.95m, GrossAmount = -5.95m },
                new R_I_Service { ID = 10, R_I_DataID = 3, R_M_SurchargeID = 1, ServiceName = "Airport-Railway Surcharge/Oneri Aeroportuali", NetAmount = -4.02m, TaxRate = 22, TaxAmount = -0.88m, GrossAmount = -4.9m },
                new R_I_Service { ID = 11, R_I_DataID = 3, R_M_SurchargeID = 5, ServiceName = "Manual Correction transaction", NetAmount = -8.95m, TaxRate = 0, TaxAmount = 0, GrossAmount = -8.95m },
                new R_I_Service { ID = 12, R_I_DataID = 3, R_M_SurchargeID = 6, ServiceName = "Additional driver", NetAmount = 18, TaxRate = 27, TaxAmount = 4.86m, GrossAmount = 22.86m },
                new R_I_Service { ID = 13, R_I_DataID = 3, R_M_SurchargeID = 8, ServiceName = "GPS guaranteed", NetAmount = 35, TaxRate = 21, TaxAmount = 7.35m, GrossAmount = 42.35m },
                new R_I_Service { ID = 14, R_I_DataID = 3, R_M_SurchargeID = 12, ServiceName = "Fuelling", NetAmount = 17.46m, TaxRate = 21, TaxAmount = 3.67m, GrossAmount = 21.13m },
                new R_I_Service { ID = 15, R_I_DataID = 3, R_M_SurchargeID = 25, ServiceName = "PAI", NetAmount = -16.29m, TaxRate = 0, TaxAmount = 0, GrossAmount = 16.29m }
            });
            _mockDAL.Setup(x => x.GetListErrorsByListR_I_DataID(It.IsAny<List<long>>())).Returns(new List<R_I_Error> {
                new R_I_Error { ID = 1, R_I_DataID = 1, R_I_ServiceID = 1, R_M_InvoiceErrorCodeID = 2, ExpectedAmount = 50m },
                new R_I_Error { ID = 2, R_I_DataID = 1, R_I_ServiceID = 2, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 10m },
                new R_I_Error { ID = 3, R_I_DataID = 1, R_I_ServiceID = 3, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 10m },
                new R_I_Error { ID = 5, R_I_DataID = 2, R_I_ServiceID = 4, R_M_InvoiceErrorCodeID = 27, ExpectedAmount = 50m },
                new R_I_Error { ID = 6, R_I_DataID = 2, R_I_ServiceID = 5, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 0 },
                new R_I_Error { ID = 7, R_I_DataID = 2, R_I_ServiceID = 6, R_M_InvoiceErrorCodeID = 4, ExpectedAmount = 0 },
            });
        }

        private List<R_I_DataReport> CreateDataReport()
        {
            return new List<R_I_DataReport> {
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789001", RentalNumber = "123456789001",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = string.Empty, CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 1, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                },
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789002", RentalNumber = "123456789002",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = "HENRICH MEIER", CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 2, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                },
                new R_I_DataReport { CreatedDate = DateTime.Now, InvoiceNumber = "123456789003", RentalNumber = "123456789003",
                    CustomerNumber = "987654321", CustomerName = "BAYER TEST", TravelerName = "HENRICH MEIER", CarGroup = "CCAR",
                    MOPCode = "Others", PickUpTime = DateTime.Now, ReturnTime = DateTime.Now, PickupStationCode = "CGNE01",
                    PickUpLocation = "Affalterbach", ReturnStationCode = "CGNC24", ReturnLocation = "COLOGNE RES VIA CGNE01", StartingKM = 18357,
                    ReturnKM = 19461, Distance = 1104, NetAmount = 85.72m, GrossAmount = 102.01m, TaxAmount = 16.29m, ID = 3, BookingNo = "1066838310",
                    R_B_AccessID = 848, Email = "admin@t2p.com", PickupCountry = "DE", ReturnCountry = "DE", M_CompanyID = 1, ParentID = 2, ReportStatus = "ESCALATED\n",
                    ReportDescription = "Cancellation/New invoice has not been received"
                }
            };
        }

        #endregion

        [TestMethod]
        public void Test_Create_FileExcel()
        {
            SetupForMonthlyReport();
            string filePath = @"C:\Users\khoa.ngo\Desktop\CraeteFile\" + DateTime.Now.ToString("yyyyMMddZHHmmss") + "_Report_Weekly_ClaimedInvoice.xlsx";
            dynamic input = new Dynamic();
            List<R_I_DataReport> listR_I_DataReport = CreateDataReport();// BaseBLL.Instance.CommandStoredProcedureName<R_I_DataReport>("p_R_I_DataReport_GetForClaimsReport_Test", input);
            List<long> listR_I_DataID;
            _mockBLL.Object.CreateExcelFile(filePath, listR_I_DataReport, out listR_I_DataID);
        }

        [TestMethod]
        public void Test_Create_FileExcel_ReportClaim()
        {
            SetupForMonthlyReport();
            string filePath = @"C:\Users\khoa.ngo\Desktop\CraeteFile\" + DateTime.Now.ToString("yyyyMMddZHHmmss") + "ClaimedReportInvoice.xlsx";
            dynamic input = new Dynamic();
            List<P_R_ClaimReport> listR_I_DataReport = CreateDataReportClaim();// BaseBLL.Instance.CommandStoredProcedureName<R_I_DataReport>("p_R_I_DataReport_GetForClaimsReport_Test", input);
            List<long> listR_I_DataID;
            //_mockBLL.Object.CreateExcelFile(filePath, listR_I_DataReport, out listR_I_DataID);
        }

        private List<P_R_ClaimReport> CreateDataReportClaim()
        {
            return new List<P_R_ClaimReport>() { };
        }
    }
}
