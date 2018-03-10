using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using T2P._2015.Cross;

namespace T2P._2015.Cross.Utility.OCR
{
    public class RDHelpers
    {
        public static bool IsDateFormat(string context)
        {
            var newContext = context.Trim();
            var firstRegex = new Regex(@"(\d+)[-.\/](\d+)[-.\/](\d+)");
            var secondRegex = new Regex(@"(\d+)[-.\/ ]\b[A-Z]{3}[-.\/ ](\d+)");
            var thirdRegex = new Regex(@"\b[A-Z]{3}[-.\/ ](\d+)[-.\/ ](\d+)");
            if (firstRegex.IsMatch(newContext) || secondRegex.IsMatch(newContext) || thirdRegex.IsMatch(newContext))
            {
                return true;
            }
            return false;
        }

        public static DateTime? PasteDate(string value)
        {

            DateTime dt;
            //yyyy
            value = value.Replace(".", "-").Replace("/", "-").Replace("-", "-").Replace(" ", "-");
            if (DateTime.TryParseExact(value, "dd-MM-yyyy", null, DateTimeStyles.None, out dt))
            {
                return dt;
            }
            if (DateTime.TryParseExact(value, "MM-dd-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-MM-dd", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-dd-MM", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "d-MM-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "MM-d-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-MM-d", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-d-MM", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "dd-M-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "M-dd-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-M-dd", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-dd-M", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "d-M-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "M-d-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-M-d", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yyyy-d-M", null, DateTimeStyles.None, out dt))
            { return dt; }
            //MMM
            if (DateTime.TryParseExact(value, "dd-MMM-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "MMM-dd-yyyy", null, DateTimeStyles.None, out dt))
            { return dt; }


            //yy
            if (DateTime.TryParseExact(value, "dd-MM-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "MM-dd-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-MM-dd", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-dd-MM", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "d-MM-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "MM-d-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-MM-d", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-d-MM", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "dd-M-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "M-dd-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-M-dd", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-dd-M", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "d-M-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "M-d-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-M-d", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "yy-d-M", null, DateTimeStyles.None, out dt))
            { return dt; }
            //MMM
            if (DateTime.TryParseExact(value, "dd-MMM-yy", null, DateTimeStyles.None, out dt))
            { return dt; }
            if (DateTime.TryParseExact(value, "MMM-dd-yy", null, DateTimeStyles.None, out dt))
            { return dt; }

            return null;
        }

        public static Dictionary<int, List<string>> SplitByLengths(string content, List<int> lengths)
        {
            Dictionary<int, List<string>> zzzList = new Dictionary<int, List<string>>();
            foreach (int lengthItem in lengths)
            {
                var zzzItem = RDHelpers.SplitByLength(content.ToLower(), lengthItem);
                zzzList.Add(lengthItem, zzzItem);
            }
            return zzzList;
        }

        public static List<string> SplitByLength(string content, int length)
        {
            List<string> result = new List<string>();
            content = content.Replace("\r\n", " ").Trim();
            var wordsList = content.Split(' ').ToList();
            int maxLength = wordsList.Count - length;
            for (int i = 0; i <= maxLength; i++)
            {
                var tempWordsList = wordsList.Skip(i).Take(length);
                var tempWord = string.Join(" ", tempWordsList);
                result.Add(tempWord);
            }
            result.ForEach(x => x.Trim());
            return result;
        }
        
        public static int CountNumberOfWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;
            var arrWords = text.Split(' ');
            return arrWords.Length;
        }

        public static string Swap2Words(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            var arrWords = text.Split(' ');
            return arrWords[1] + " " + arrWords[0];
        }

        public static string[] SplitBySpecialSymbool(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;
            var result = text.Split('|');
            return result;
        }

        public static bool IsExistSpecialSymbol(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return text.Contains("|");
            }
            return false;
        }

        public class ReferenceKey
        {
            public int Id;
            public string Value;
            public string Type;
        }

        public static List<ReferenceKey> GetReferenceKey()
        {
            List<ReferenceKey> result = new List<ReferenceKey>();
            result.Add(new ReferenceKey() { Value = "check in", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "check-in", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "anreise", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "ankunft", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "von", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "dal", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "arrival date", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "arrival", Type = "CheckIn" });
            result.Add(new ReferenceKey() { Value = "anreise/arrival", Type = "CheckIn" });

            result.Add(new ReferenceKey() { Value = "check out", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "check-out", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "abreise", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "bis", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "al", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "departure date", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "departure", Type = "CheckOut" });
            result.Add(new ReferenceKey() { Value = "abreise/departure", Type = "CheckOut" });

            result.Add(new ReferenceKey() { Value = "ludwigsburg", Type = "InvoiceDate" });
            result.Add(new ReferenceKey() { Value = "rechnungsdatum", Type = "InvoiceDate" });
            result.Add(new ReferenceKey() { Value = "del", Type = "InvoiceDate" });

            result.Add(new ReferenceKey() { Value = "rechnungsnumber", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "rechnungs nr.", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "rechnungs-nr", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "rechnungsnr", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "rechnung.", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "rech.-nr.", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "invoice no.", Type = "InvoiceNumber" });
            result.Add(new ReferenceKey() { Value = "rechnungsnr./folio", Type = "InvoiceNumber" });
            
            result.Add(new ReferenceKey() { Value = "name", Type = "Traveler" });
            result.Add(new ReferenceKey() { Value = "gast name", Type = "Traveler" });
            result.Add(new ReferenceKey() { Value = "gastname", Type = "Traveler" });
            result.Add(new ReferenceKey() { Value = "gast", Type = "Traveler" });
            result.Add(new ReferenceKey() { Value = "cliente", Type = "Traveler" });
            result.Add(new ReferenceKey() { Value = "gast/guest", Type = "Traveler" });


            return result;
        }
    }
}
