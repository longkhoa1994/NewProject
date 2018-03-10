using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.PaymentHub
{
    public class FileRelation
    {
        public string InputClassName { get; set; }
        public string InputClassPath { get; set; }
        public string InputAttributeName { get; set; }
        public string OwnClassName { get; set; }
        public string OwnClassPath { get; set; }
        public string OwnAttributeName { get; set; }
        public string BookingClassPath { get; set; }
        public string BookingAttributeName { get; set; }
        public string FixedValue { get; set; }
        public int ValueType { get; set; }
        public string TransactionTypePath { get; set; }
        public string TransactionTypeCode { get; set; }
        public string Formula { get; set; }
        public string ListAdditionalPath { get; set; }
    }
}
