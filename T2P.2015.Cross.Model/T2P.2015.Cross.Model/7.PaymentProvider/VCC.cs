//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using T2P._2015.Cross.Enum;

//namespace VCC
//{
//    public class VirtualCreditCard
//    {
//        private string pAN;

//        public string PAN { get { return pAN; } }

//        private string aVV;

//        public string AVV { get { return aVV; } }

//        private string expiry;

//        public string Expiry { get { return expiry; } }

//        private string cardholderName;

//        public string CardholderName { get { return cardholderName; } }

//        private CardProvider cardProvider;

//        public CardProvider CardProvider { get { return cardProvider; } }

//        private string cA_FrontCard;

//        public string CA_FrontCard { get { return cA_FrontCard; } }

//        private string cA_BackCard;

//        public string CA_BackCard { get { return cA_BackCard; } }

//        public VirtualCreditCard(AmexResponse response, int responseCPN_AVV, string responseCPN_Expiry, string frontCard, string backCard, string cardHolder = "Test Name")
//        {
//            this.pAN = response.TokenIssuanceData.TokenDetails.TokenNumber;
//            this.aVV = responseCPN_AVV.ToString();

//            this.expiry = string.Empty;
//            // Template
//            string year = responseCPN_Expiry.Substring(2, 2);
//            string month = responseCPN_Expiry.Substring(4, 2);
//            this.expiry = month + year;

//            this.cardholderName = cardHolder;
//            this.cardProvider = CardProvider.AMEX;

//            this.cA_FrontCard =  frontCard;
//            this.cA_BackCard = backCard;
//        }

//        public VirtualCreditCard(maintainPreAuthorizationResponseType response, int responseCPN_AVV, string responseCPN_Expiry, string frontCard, string backCard, string cardHolder = "Test Name")
//        {
//            this.pAN = response.Response.maintainPreAuthorizationResp.accountNumber;
//            this.aVV = responseCPN_AVV.ToString();

//            this.expiry = string.Empty;
//            // Template
//            string year = responseCPN_Expiry.Substring(2, 2);
//            string month = responseCPN_Expiry.Substring(4, 2);
//            this.expiry = month + year;

//            this.cardholderName = cardHolder;
//            this.cardProvider = CardProvider.AMEX;

//            this.cA_FrontCard = frontCard;
//            this.cA_BackCard = backCard;
//        }

//        public VirtualCreditCard(OrbiscomResponse response, int responseCPN_AVV, string responseCPN_Expiry, string frontCard, string backCard)
//        {
//            this.pAN = response.CPN.PAN;
//            this.aVV = responseCPN_AVV.ToString();

//            this.expiry = string.Empty;
//            string year = responseCPN_Expiry.Substring(0, 2);
//            string month = responseCPN_Expiry.Substring(2, 2);
//            this.expiry = month + year;

//            this.cardholderName = response.AVSData.CardholderName;
//            this.cardProvider = CardProvider.AirPlus;
//            this.cA_FrontCard = frontCard;
//            this.cA_BackCard = backCard;
//        }
//    }
//}
