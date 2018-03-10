using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using T2P._2015.Cross.Utility.Log;
using T2P._2015.Cross.Enum;
using System.Data.SqlClient;

namespace T2P._2015.Cross.Utility.Conversion
{
    public static class Conversion
    {
        const int MAX_RUN_COUNT = 10;

        #region Int and Bool Convert

        public static bool IntToBool(int? temp)
        {
            if (temp == null)
                return false;
            else
            {
                if (temp.Value == 1)
                    return true;
                else
                    return false;
            }
        }

        public static int BoolToInt(bool data)
        {
            return data == true ? 1 : 0;
        }

        #endregion Int and Bool Convert

        #region String Convert

        public static string ArrayToString(object[] obj)
        {
            try
            {
                return ArrayToString(obj, ",");
            }
            catch
            {
                throw;
            }
        }

        public static string ArrayToString(object[] obj, string separator)
        {
            try
            {
                if (obj == null || obj.Count() == 0)
                    return string.Empty;
                else
                {
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";

                    string result = String.Empty;
                    for (int i = 0; i < obj.Length; i++)
                    {
                        if (i < obj.Length - 1)
                            result = result + obj[i].ToString() + separator;
                        else
                            result = result + obj[i].ToString();
                    }
                    return result;
                }
            }
            catch
            {
                throw;
            }
        }

        public static object[] StringToArray(string obj)
        {
            try
            {
                return StringToArray(obj, ',');
            }
            catch
            {
                throw;
            }
        }

        public static object[] StringToArray(string obj, char separator)
        {
            try
            {
                if (string.IsNullOrEmpty(obj))
                    return null;
                else
                {
                    if (separator <= 0)
                        separator = ',';
                    string[] temp = obj.Split(separator);
                    return Array.ConvertAll<string, object>(temp, StringToObject);
                }
            }
            catch
            {
                throw;
            }
        }

        public static string ListToString(List<object> obj)
        {
            try
            {
                return ListToString(obj, ",");
            }
            catch
            {
                throw;
            }
        }

        public static string ListToString(List<object> obj, string separator)
        {
            try
            {
                if (obj == null || obj.Count == 0)
                    return string.Empty;
                else
                {
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";

                    string result = String.Empty;
                    foreach (int i in obj)
                    {
                        result = result + i.ToString() + separator;
                    }
                    result = result.Remove(result.Length - 1);
                    return result;
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<object> StringToList(string obj)
        {
            try
            {
                return StringToList(obj, ',');
            }
            catch
            {
                throw;
            }
        }

        public static List<object> StringToList(string obj, char separator)
        {
            try
            {
                if (string.IsNullOrEmpty(obj))
                    return null;
                else
                {
                    if (separator <= 0)
                        separator = ',';
                    string[] temp = obj.Split(separator);
                    return Array.ConvertAll<string, object>(temp, StringToObject).ToList();
                }
            }
            catch
            {
                throw;
            }
        }

        public static object StringToObject(string o)
        {
            object obj = o;
            return obj;
        }

        public static string DecimalToString(decimal? obj, int roundNumber)
        {
            if (obj.HasValue)
            {
                return Math.Round(obj.Value, roundNumber).ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        public static string DecimalToStringRemovePoint(decimal? obj, int roundNumber)
        {
            if (obj.HasValue)
            {
                return Math.Round(obj.Value, roundNumber).ToString("n" + roundNumber).Replace(".", string.Empty).Replace(",", string.Empty);
            }
            else
            {
                return string.Empty;
            }
        }

        public static string[] StringToBinary(this string data)
        {
            char[] charArray = data.ToCharArray();
            string[] stringResult = new string[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                string result = Convert.ToString(charArray[i], 2).PadLeft(8, '0');
                stringResult[i] = result;
            }

            return stringResult;
        }

        public static string[] StringToHexaDecimal(this string data)
        {
            char[] charArray = data.ToCharArray();
            string[] stringResult = new string[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                string result = Convert.ToInt32(charArray[i]).ToString("x");
                stringResult[i] = result;
            }

            return stringResult;
        }
        public static string HexaDecimalToString(this string[] data, Encoding enCodingParam = null)
        {
            Encoding enCoding = enCodingParam ?? Encoding.Default;

            string stringJoin = string.Join("", data);

            var bytes = new byte[stringJoin.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(stringJoin.Substring(i * 2, 2), 16);
            }

            string result = enCoding.GetString(bytes);

            return result;
        }


        public static string BinaryToString(this string[] data, Encoding enCodingParam = null)
        {
            Encoding enCoding = enCodingParam ?? Encoding.Default;

            string stringJoin = string.Join("", data);

            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < stringJoin.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(stringJoin.Substring(i, 8), 2));
            }

            string result = enCoding.GetString(byteList.ToArray());

            return result;
        }

        #endregion String Convert

        #region String Format

        public static string StringToLowerCase(object o)
        {
            if (o == null)
                return string.Empty;
            return o.ToString().Trim().ToLower();
        }

        public static string StringToUpperCase(object o)
        {
            if (o == null)
                return string.Empty;
            return o.ToString().Trim().ToUpper();
        }

        #endregion String Format

        #region Date Convert

        public static string DateFormat(DateTime? date, string format)
        {
            if (date != null)
            {
                return String.Format("{0:" + format + "}", date);
            }
            return "";
        }

        public static string DateFormat(DateTime date, string format)
        {
            if (date != null && date.Year != 1)
            {
                return String.Format("{0:" + format + "}", date);
            }
            return "";
        }

        public static DateTime FirstDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime LastDayOfMonth(this DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            try
            {
                //--------Calculation Description
                //dt = Today = WesnesDay, 2011/01/19
                //StartOfWeek = DayOfWeek.Sunday
                //diff = WesnesDay - Sunday = 4
                //-> StartOfWeek = WesnesDay.AddDays(-diff) = Sunday, 2011/01/16

                int diff = dt.DayOfWeek - startOfWeek;
                if (diff < 0)
                {
                    diff += 7;
                }

                return dt.AddDays(-diff);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
        }

        public static DateTime EndOfWeek(this DateTime dt, DayOfWeek endOfWeek)
        {
            try
            {
                //--------Calculation Description
                //dt = Today = WesnesDay, 2011/01/19
                //EndOfWeek = DayOfWeek.Saturday
                //diff = Saturday - WesnesDay = 3
                //-> EndOfWeek = WesnesDay.AddDays(diff) = Saturday, 2011/01/22

                int diff = endOfWeek - dt.DayOfWeek;
                if (diff < 0)
                {
                    diff += 7;
                }

                return dt.AddDays(diff);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Log here
                throw ex;
            }
        }

        public static DateTime VerifyDate(int year, int month, int day)
        {
            try
            {
                int days = DateTime.DaysInMonth(year, month);
                if (day > days)
                    return new DateTime(year, month, days);

                return new DateTime(year, month, day);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
        }

        public static DateTime? ConvertNDate(string date)
        {
            try
            {
                DateTime? result = ConvertDate(date);
                if (result == DateTime.MinValue)
                {
                    result = null;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DateTime ConvertDate(string date)
        {
            try
            {
                DateTime result = new DateTime();
                if (string.IsNullOrWhiteSpace(date))
                {
                    result = new DateTime();
                }
                DateTime temp = new DateTime();
                if (DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "ddd, dd MMM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "dd MMM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "ddd, d MMM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "d MMM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "MMyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "DDMMMYY", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                if (DateTime.TryParseExact(date, "yyMM", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out temp))
                    result = temp;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static decimal GetTimezone(string remark)
        {
            try
            {
                decimal result = 0;

                if (!string.IsNullOrWhiteSpace(remark))
                {
                    var rex = new Regex(@"(\+|\-)(.*?)(\))");
                    string timezone = remark.Count(x => x == ')') > 0 ? rex.Match(remark).Value.Replace(")", string.Empty).Trim() : remark;
                    string[] temp = timezone.Split(':');

                    if (temp.Length == 1)
                    {
                        result = ObjectToDecimal(remark);
                    }
                    if (temp.Length > 1)
                    {
                        var hours = ObjectToInt(temp[0]);
                        var minutes = ObjectToInt(temp[1]);
                        result = hours > 0 ? ObjectToDecimal(ObjectToDecimal(hours) + ((ObjectToDecimal(minutes)) / 60)) : ObjectToDecimal(ObjectToDecimal(hours) - ((ObjectToDecimal(minutes)) / 60));
                    }
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime CaculateWorkingDay(DateTime fromDate, DateTime toDate)
        {
            int noOfDays = 0;
            fromDate = fromDate.AddDays(1);
            while (fromDate.Date <= toDate.Date)
            {
                if (fromDate.DayOfWeek == DayOfWeek.Sunday || fromDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    noOfDays += 1;
                }
                fromDate = fromDate.AddDays(1);
            }

            //DateTime dt = toDate.AddDays(noOfDays);

            int addDay = 0;
            for (int i = 0; i < noOfDays; i++)
            {
                toDate = toDate.AddDays(1);
                if (toDate.DayOfWeek == DayOfWeek.Saturday || (toDate.DayOfWeek == DayOfWeek.Sunday))
                    addDay++;
            }
            DateTime dt = toDate.AddDays(addDay);

            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                dt = dt.AddDays(1);
            }

            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                dt = dt.AddDays(2);
            }
            return dt;
        }

        #endregion Date Convert

        #region Money Format
        public static string MoneyFormat(decimal number, string languageCode)
        {
            CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo(languageCode);
            return number.ToString("N2", info);
            //return String.Format(info, "{0:c}", number); 
        }
        public static string MoneyFormatN(decimal? number, string languageCode)
        {
            if (!number.HasValue) return string.Empty;

            CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo(languageCode);
            return number.Value.ToString("N2", info);
            //return String.Format(info, "{0:c}", number); 
        }
        #endregion

        #region Object Convert

        public static int? ObjectToNInt(object o)
        {
            if (o == null)
                return null;
            int temp = 0;
            if (int.TryParse(o.ToString(), out temp))
                return temp;

            return null;
        }

        public static int ObjectToInt(object o)
        {
            if (o == null)
                return 0;
            int temp = 0;
            if (int.TryParse(o.ToString(), out temp))
                return temp;

            return 0;
        }

        public static int NObjectToInt(object o)
        {
            if (o == null)
                return 0;
            int temp = 0;
            if (int.TryParse(o.ToString(), out temp))
                return temp;
            else
                return -1;
        }

        public static bool ObjectToBool(object o)
        {
            if (o == null)
                return false;
            try
            {
                return Convert.ToBoolean(o);
            }
            catch
            {
                return false;
            }
        }

        public static bool ObjectNumberToBool(object o)
        {
            if (o == null)
                return false;
            try
            {
                return Convert.ToBoolean(Convert.ToInt32(o));
            }
            catch
            {
                return false;
            }
        }

        public static bool? ObjectToNBool(object o)
        {
            if (o == null)
                return null;
            try
            {
                return Convert.ToBoolean(o);
            }
            catch
            {
                return false;
            }
        }

        public static decimal ObjectToDecimal(object o)
        {
            try
            {
                if (o == null)
                    return 0;
                decimal de = Convert.ToDecimal(o, CultureInfo.InvariantCulture);
                //if (decimal.TryParse(convert, out de))
                return de;
            }
            catch
            {
                return 0;
            }
        }

        public static decimal? ObjectToDecimalN(object o)
        {
            if (o == null)
                return null;
            decimal de = 0;
            if (decimal.TryParse(o.ToString(), out de))
                return de;

            return null;
        }

        public static float? ObjectToFloatN(object o)
        {
            if (o == null)
                return null;
            float de = 0;
            if (float.TryParse(o.ToString(), out de))
                return de;
            return null;
        }

        public static bool CheckObjectToDecimal(object o)
        {
            if (o == null)
                return false;
            decimal temp = 0;
            if (decimal.TryParse(o.ToString(), out temp))
                return true;

            return false;
        }

        public static double ObjectToDouble(object o)
        {
            if (o == null)
                return 0;
            double de = 0;
            if (double.TryParse(o.ToString(), out de))
                return de;

            return 0;
        }

        public static DateTime ObjectToDateTime(object o)
        {
            if (o == null)
                return new DateTime();
            DateTime dt = new DateTime();
            if (DateTime.TryParse(o.ToString(), out dt))
                return dt;
            return new DateTime();
        }

        public static DateTime? ObjectToNDateTime(object o)
        {
            if (o == null)
                return null;
            DateTime dt = new DateTime();
            if (DateTime.TryParse(o.ToString(), out dt))
                return dt;
            return null;
        }

        public static string ObjectToString(object o)
        {
            if (o == null)
                return String.Empty;
            return o.ToString().Trim();
        }

        public static long? ObjectToNLong(object o)
        {
            if (o == null)
                return null;
            long temp = 0;
            if (long.TryParse(o.ToString(), out temp))
                return temp;

            return null;
        }

        public static long ObjectToLong(object o)
        {
            if (o == null)
                return 0;
            long temp = 0;
            if (long.TryParse(o.ToString(), out temp))
                return temp;

            return 0;
        }

        public static float ObjectToFloat(object o)
        {
            if (o == null)
                return 0;
            float temp = 0;
            if (float.TryParse(o.ToString(), out temp))
                return temp;

            return 0;
        }

        public static object ObjectDataRowToDB(DataRow row, string o)
        {
            if (row.Table.Columns.Contains(o))
                return row[o];
            return null;
        }

        public static T Json2Class<T>(object o)
        {
            return JsonConvert.DeserializeObject<T>(o.ToString());
        }

        public static string Object2Json(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        #endregion Object Convert

        #region Convert Type Code

        public static Type GetUnderlyingType(Type source)
        {
            if (source.IsGenericType
                && (source.GetGenericTypeDefinition() == typeof(Nullable<>)))
            {
                // source is a Nullable type so return its underlying type
                return Nullable.GetUnderlyingType(source);
            }

            // source isn't a Nullable type so just return the original type
            return source;
        }

        public static T Parse<T>(object value)
        {
            Type type = typeof(T);

            T result = default(T);
            if (value != null)

                return Parse<T>(type, value);
            else
                return result;
        }

        public static T Parse<T>(Type type, object value)
        {
            T entity = default(T);
            try
            {
                if (!type.Name.ToLower().Contains(TypeCode.String.ToString().ToLower()))
                {
                    entity = (T)Activator.CreateInstance(type);
                }
                TypeConverter tc = TypeDescriptor.GetConverter(type);
                entity = (T)tc.ConvertFromString(null, CultureInfo.CurrentCulture, value.ToString());

                return entity;
            }
            catch (Exception)
            {
                try
                {
                    TypeConverter tc = TypeDescriptor.GetConverter(type);
                    return entity = (T)tc.ConvertFromString(null, CultureInfo.InvariantCulture, value.ToString());
                }
                catch (Exception ex2)
                {
                    throw ex2;
                }

            }
        }

        public static object Parse(Type type, object value)
        {
            object entity = null;
            try
            {
                if (value != null)
                {
                    if (!type.Name.ToLower().Contains(TypeCode.String.ToString().ToLower()))
                    {
                        entity = Activator.CreateInstance(type);
                    }
                    if (type.Name == TypeCode.Boolean.ToString())
                    {
                        return ObjectToBool(value);
                    }
                    TypeConverter tc = TypeDescriptor.GetConverter(type);
                    return entity = (object)tc.ConvertFromString(null, CultureInfo.CurrentCulture, value.ToString());
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {

                try
                {
                    TypeConverter tc = TypeDescriptor.GetConverter(type);
                    return entity = (object)tc.ConvertFromString(null, CultureInfo.InvariantCulture, value.ToString());
                }
                catch (Exception ex2)
                {
                    throw ex2;
                }

            }
        }

        public static object ConvertTypeCode(TypeCode typeCode, object obj2)
        {
            try
            {
                object result = new object();
                switch (typeCode)
                {
                    case TypeCode.Int32: result = ObjectToNInt(obj2); break;
                    case TypeCode.Int64: result = ObjectToNLong(obj2); break;
                    case TypeCode.Boolean: result = ObjectToBool(obj2); break;
                    case TypeCode.Decimal: result = ObjectToDecimal(obj2); break;
                    case TypeCode.Double: result = ObjectToDouble(obj2); break;
                    case TypeCode.DateTime: result = ObjectToNDateTime(obj2); break;
                    case TypeCode.String: result = ObjectToString(obj2); break;
                    case TypeCode.Object: result = obj2; break;
                    default: break;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Convert Type Code

        #region Convert Umlaut to Latin and reverse
        public static string UmlautToLatin(string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                    return string.Empty;
                string result = string.Empty;
                result = input;
                result = result.Replace("ß", "ss");
                result = result.Replace("ä", "ae");
                result = result.Replace("ö", "oe");
                result = result.Replace("ü", "ue");
                result = result.Replace("Ä", "Ae");
                result = result.Replace("Ö", "Oe");
                result = result.Replace("Ü", "Ue");
                result = result.Replace("é", "e");
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static string LatinToUmlaut(string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                    return string.Empty;
                string result = string.Empty;
                result = input;
                result = result.Replace("ss", "ß");
                result = result.Replace("ae", "ä");
                result = result.Replace("oe", "ö");
                result = result.Replace("ue", "ü");
                result = result.Replace("Ae", "Ä");
                result = result.Replace("Oe", "Ö");
                result = result.Replace("Ue", "Ü");

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool CompareLatinAndUmlaut(string input, string compare, bool isContain = true)
        {
            input = RemoveSigns(input);
            compare = RemoveSigns(compare);

            if (isContain)
            {
                if (UmlautToLatin(input).Contains(compare))
                {
                    return true;
                }
                return LatinToUmlaut(input).Contains(compare);
            }
            else
            {
                if (UmlautToLatin(input) == compare)
                {
                    return true;
                }
                return LatinToUmlaut(input) == compare;
            }
        }

        public static string ConvertGermanAddress(string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                    return string.Empty;
                string result = string.Empty;
                result = UmlautToLatin(input.Trim());
                result = result.Replace("strasse", "");
                result = result.Replace("street", "");
                result = result.Replace("str.", "");
                result = result.Replace("str", "");
                result = result.Replace("und", "&");
                result = result.Replace("and", "&");

                result = result
                    .Replace("–", " ")
                    .Replace("-", " ")
                    .Replace("_", " ")
                    .Replace("!", " ")
                    .Replace("#", " ")
                    .Replace("$", " ")
                    .Replace("@", " ")
                    .Replace("%", " ")
                    .Replace("^", " ")
                    .Replace("*", " ")
                    .Replace("+", " ")
                    .Replace("=", " ");

                result = result.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "");
                result = result.Replace("<>", " ").Replace("><", "").Replace("<>", " ");

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static readonly string[] Signs = new string[]
{

"aAeEoOuUiIdDyY",

"áàạảãâấầậẩẫăắằặẳẵ",

"ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

"éèẹẻẽêếềệểễ",

"ÉÈẸẺẼÊẾỀỆỂỄ",

"óòọỏõôốồộổỗơớờợởỡ",

"ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

"úùụủũưứừựửữ",

"ÚÙỤỦŨƯỨỪỰỬỮ",

"íìịỉĩ",

"ÍÌỊỈĨ",

"đ",

"Đ",

"ýỳỵỷỹ",

"ÝỲỴỶỸ"

};

        public static string RemoveSigns(string str)
        {

            for (int i = 1; i < Signs.Length; i++)
            {

                for (int j = 0; j < Signs[i].Length; j++)

                    str = str.Replace(Signs[i][j], Signs[0][i - 1]);

            }

            return str;

        }



        #endregion

        #region Clone
        public static T Clone<T>(T obj)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ms, obj);
                    ms.Position = 0;

                    return (T)formatter.Deserialize(ms);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T DeepCopy<T>(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Object cannot be null");
            return (T)Process(obj);
        }

        static object Process(object obj)
        {
            if (obj == null)
                return null;
            Type type = obj.GetType();
            if (type.IsValueType || type == typeof(string))
            {
                return obj;
            }
            else if (type.IsArray)
            {
                Type elementType = Type.GetType(
                     type.FullName.Replace("[]", string.Empty));
                var array = obj as Array;
                Array copied = Array.CreateInstance(elementType, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    copied.SetValue(Process(array.GetValue(i)), i);
                }
                return Convert.ChangeType(copied, obj.GetType());
            }
            else if (type.IsClass)
            {
                object toret = Activator.CreateInstance(obj.GetType());
                FieldInfo[] fields = type.GetFields(BindingFlags.Public |
                            BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo field in fields)
                {
                    object fieldValue = field.GetValue(obj);
                    if (fieldValue == null)
                        continue;
                    field.SetValue(toret, Process(fieldValue));
                }
                return toret;
            }
            else
                throw new ArgumentException("Unknown type");
        }

        #endregion

        #region Convertion between Date and WeekNumber
        public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(daysOffset);
            int firstWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);
            DateTime fromDate = result.AddDays(-3);

            //If weeknumber is 53 and fromdate > 28-10-2015. No week 53 in this year
            if (DateTime.Compare(fromDate, new DateTime(year, 12, 28)) > 0 && weekOfYear >= 53)
            {
                fromDate = new DateTime();
            }

            return fromDate;
        }


        public static void GetIso8601WeekOfYear(DateTime time, ref int weekNumber, ref int year)
        {
            if (time != null && time != DateTime.MinValue)
            {
                // Week 1 is the 1st week of the year with a Thursday in it.
                // If its Monday, Tuesday or Wednesday, then it'll 
                // be the same week# as whatever Thursday, Friday, Saturday or Sunday are,
                // and we always get those right
                DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
                int currentYear = time.Year;
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                {
                    time = time.AddDays(4);
                }

                // Return the week of our adjusted day
                weekNumber = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                if (time.Month == 1 && (weekNumber == 52 || weekNumber == 53))
                {
                    currentYear -= 1;
                }
                else if (time.Month == 12 && weekNumber == 1)
                {
                    currentYear += 1;
                }
                year = currentYear;
            }
        }
        #endregion

        #region Calculate Distance between 2 string
        public static int LevenshteinDistance(string source, string target)
        {
            if ((source == null) || (target == null)) return 0;
            if ((source.Length == 0) || (target.Length == 0)) return 0;
            if (source == target) return source.Length;

            int sourceWordCount = source.Length;
            int targetWordCount = target.Length;

            // Step 1
            if (sourceWordCount == 0)
                return targetWordCount;

            if (targetWordCount == 0)
                return sourceWordCount;

            int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

            // Step 2
            for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
            for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

            for (int i = 1; i <= sourceWordCount; i++)
            {
                for (int j = 1; j <= targetWordCount; j++)
                {
                    // Step 3
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                    // Step 4
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            return distance[sourceWordCount, targetWordCount];
        }

        public static decimal CalculateSimilarity(string source, string target)
        {
            if ((source == null) || (target == null)) return 0;
            if ((source.Length == 0) || (target.Length == 0)) return 0;
            if (source == target) return 1;

            int stepsToSame = LevenshteinDistance(source, target);
            return (1 - ((decimal)stepsToSame / (decimal)Math.Max(source.Length, target.Length)));
        }
        #endregion

        #region Calculate Timer for NextInvoiceStep
        public static DateTime SetTime(dynamic stepInfo, DateTime timeNow)
        {
            DateTime nextTime = new DateTime();
            //DateTime timeNow = BaseBLL.Instance.ParseDateTimeNowSVTimeZone();
            Frequency frequency;
            if (System.Enum.TryParse(stepInfo.Detail.Frequency, out frequency))
            {
                InvoiceStepCode iStepCode;
                //DateTime dateDiliverImage = stepInfo.Detail.DateDiliverImage == null ? timeNow : stepInfo.Detail.DateDiliverImage;
                DateTime dateDiliverImage = GetDateDiliverImage(stepInfo, timeNow);
                DateTime dateExportCSV = stepInfo.Detail.DateExportCSV == null ? timeNow : stepInfo.Detail.DateExportCSV;
                DateTime timer = Convert.ToDateTime(stepInfo.Detail.ExecutionTime);
                double hour = Conversion.ObjectToDouble(-stepInfo.Detail.CompanyTimeZone + stepInfo.Detail.ServerTimeZone);
                int period = Conversion.ObjectToInt(stepInfo.Detail.Period) > 0 ? Conversion.ObjectToInt(stepInfo.Detail.Period) : 1;

                List<int> executionDateList = new List<int>();
                if (!string.IsNullOrWhiteSpace(stepInfo.Detail.ExecutionDate))
                {
                    string[] executionDateArr = stepInfo.Detail.ExecutionDate.Split(',');
                    executionDateArr.ToList().ForEach(x =>
                    {
                        if (!string.IsNullOrWhiteSpace(x))
                        {
                            int executionDate = Conversion.ObjectToInt(x) > 0 ? Conversion.ObjectToInt(x) : 1;
                            executionDateList.Add(executionDate);
                        }
                    });
                }
                TimeSpan a = new TimeSpan(timeNow.Hour, timeNow.Minute, 0);
                TimeSpan b = new TimeSpan(timer.AddHours(hour).Hour, timer.Minute, 0);
                TimeSpan c = b - a;
                switch (frequency)
                {
                    case Frequency.Days:

                        if (c.Ticks > 0)
                        //if (timer.AddHours(hour) > timeNow)
                        {
                            nextTime = DateTime.Now.Date.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                        }
                        else
                        {
                            nextTime = DateTime.Now.Date.AddDays(period).AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                        }
                        break;

                    case Frequency.Weeks:
                        if (System.Enum.TryParse(stepInfo.StepCode, out iStepCode))
                        {
                            if (iStepCode == InvoiceStepCode.ICSV)
                            {
                                //nextTime = GetNextWeekday(dateExportCSV, executionDateList.FirstOrDefault(), period).AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                int daysToAdd = (int)executionDateList.FirstOrDefault() - 1 - (int)dateDiliverImage.DayOfWeek + 7;
                                daysToAdd = daysToAdd % 7;
                                int dayDiff = (int)executionDateList.FirstOrDefault() - 1 - (int)dateDiliverImage.DayOfWeek;
                                // if (today and expected day are the same) and (The expected date has not yet arrived)
                                if (daysToAdd == 0 && (timer.AddHours(hour) > timeNow))
                                {
                                    nextTime = dateExportCSV.Date.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                }
                                else if (daysToAdd > 0 && dayDiff > 0)
                                {
                                    nextTime = dateExportCSV.Date.AddDays(daysToAdd).AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                }
                                else
                                {
                                    nextTime = GetNextWeekday(dateExportCSV, executionDateList.FirstOrDefault(), period);
                                    nextTime = nextTime.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                }
                            }
                            else
                            {
                                int daysToAdd = (int)executionDateList.FirstOrDefault() - 1 - (int)dateDiliverImage.DayOfWeek + 7;
                                int dayDiff = (int)executionDateList.FirstOrDefault() - 1 - (int)dateDiliverImage.DayOfWeek;
                                daysToAdd = daysToAdd % 7;
                                // if (today and expected day are the same) and (The expected date has not yet arrived)
                                if (daysToAdd == 0 && (timer.AddHours(hour) > timeNow))
                                {
                                    nextTime = dateDiliverImage.Date.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                }
                                else if (daysToAdd > 0 && dayDiff > 0)
                                {
                                    nextTime = dateDiliverImage.Date.AddDays(daysToAdd).AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                }
                                else
                                {
                                    nextTime = GetNextWeekday(dateDiliverImage, executionDateList.FirstOrDefault(), period);
                                    nextTime = nextTime.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                                }

                            }
                        }

                        //while (nextTime.Date < timeNow.Date || (nextTime.Date == timeNow.Date && c.Ticks < 0))

                        int runCountWeekLoop = 0;
                        while (nextTime.Date < timeNow.Date)
                        {
                            nextTime = nextTime.AddDays(period * 7);
                            runCountWeekLoop++;
                            if (runCountWeekLoop > MAX_RUN_COUNT)
                            {
                                break;
                            }
                        }
                        break;

                    case Frequency.Months:
                        if (System.Enum.TryParse(stepInfo.StepCode, out iStepCode))
                        {
                            if (iStepCode == InvoiceStepCode.ICSV)
                            {
                                nextTime = GetNextMonthday(dateExportCSV, period, executionDateList.ToArray());
                            }
                            else
                            {
                                nextTime = GetNextMonthday(dateDiliverImage, period, executionDateList.ToArray());
                            }
                        }

                        int runCountMonthLoop = 0;
                        while (nextTime.Date < timeNow.Date || (nextTime.Date == timeNow.Date && c.Ticks < 0))
                        {
                            nextTime = GetNextMonthday(nextTime, period, executionDateList.ToArray());
                            runCountMonthLoop++;
                            if(runCountMonthLoop > MAX_RUN_COUNT)
                            {
                                break;
                            }

                        }
                        //if (daysToAdd == 0 && (timer.AddHours(hour) > timeNow))
                        if (nextTime.Month == DateTime.Today.Month && nextTime.Year == DateTime.Today.Year && nextTime.Date == DateTime.Today.Date && timer.AddHours(hour) < timeNow)
                        {
                            nextTime = nextTime.AddMonths(period);
                            nextTime = nextTime.Date.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                        }
                        else if (DateTime.Today.Date <= nextTime.Date && DateTime.Today.Month == nextTime.Month)
                        {
                            nextTime = nextTime.Date.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                        }
                        else
                        {
                            //nextTime = nextTime.AddMonths(period);
                            nextTime = nextTime.Date.AddHours(hour).AddHours(timer.Hour).AddMinutes(timer.Minute);
                        }

                        break;

                    default: break;
                }
            }
            else
            {
            }
            return nextTime;
        }



        public static DateTime GetNextWeekday(DateTime start, int day, int period)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - 1 - (int)start.DayOfWeek + 7);
            daysToAdd = daysToAdd % 7;
            if (daysToAdd > 0)
            {
                period = period - 1;
            }
            for (int i = 0; i < period; i++)
            {
                daysToAdd = daysToAdd + 7;
            }

            return start.Date.AddDays(daysToAdd);
        }

        private static DateTime GetNextMonthday(DateTime start, int period, params int[] day)
        {
            DateTime date = new DateTime();
            DateTime nextDate = new DateTime();
            if (start.Month == DateTime.Today.Month && start.Year == DateTime.Today.Year && start.Day <= day.Max())
            {
                nextDate = DateTime.Today;
            }
            else
            {
                nextDate = start.AddMonths(period);
            }
            int maxDay = DateTime.DaysInMonth(nextDate.Year, nextDate.Month);
            List<DateTime> sendDates = new List<DateTime>();
            for (int i = 0; i < day.Length; i++)
            {
                if (day[i] == 0)
                {
                    day[i] = 1;
                }
                if (day[i] <= maxDay)
                {
                    sendDates.Add(new DateTime(nextDate.Year, nextDate.Month, day[i]));
                }
                else
                {
                    sendDates.Add(new DateTime(nextDate.Year, nextDate.Month, maxDay));
                }
            }

            //sendDates.RemoveAll(m => m.Date == start.Date);

            if (sendDates.Count() > 0)
            {
                date = sendDates.Any(m => m >= DateTime.Today) ? sendDates.Where(m => m >= DateTime.Today).Min() : sendDates.FirstOrDefault().AddMonths(period); //DateTime.Today.AddDays(1);
            }
            else
            {
                date = DateTime.Today.AddMonths(period);
            }

            return date;
        }
        #endregion

        #region File process

        public static bool DeleteFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void DeleteFile(List<string> filesList)
        {
            try
            {
                foreach (string fileItem in filesList)
                {
                    if (File.Exists(fileItem))
                    {
                        System.IO.File.Delete(fileItem);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region DateTime
        public static DateTime ToDateTime(this object obj)
        {

            try
            {
                var formats = new string[] { "yyyyMMdd" };
                var content = obj.ToString();
                var datetime = DateTime.MinValue;
                foreach (var format in formats)
                {
                    DateTime.TryParseExact(content, format, null, DateTimeStyles.None, out datetime);
                    if (!datetime.Equals(DateTime.MinValue))
                        return datetime;
                }
                return datetime;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
        #endregion

        public static DataTable CreateDataTableSchemae<T>()
        {
            DataTable dataTable = new DataTable();

            Type type = typeof(T);
            var properties = type.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                if (info.CanWrite)
                    dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            return dataTable;
        }

        public static void AddDataRow<T>(this DataTable dt, T entity)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            var values = new List<object>();
            foreach (PropertyInfo info in properties)
            {
                if (info.CanWrite)
                    values.Add(info.GetValue(entity));
            }

            dt.Rows.Add(values.ToArray());
        }

        public static void MappingColumn(this SqlBulkCopy bulkCopy, Type type)
        {
            var properties = type.GetProperties();

            foreach (PropertyInfo info in properties)
            {
                bulkCopy.ColumnMappings.Add(info.Name, info.Name);
            }
        }

        private static DateTime GetDateDiliverImage(dynamic stepInfo, DateTime timeNow)
        {
            DateTime result;
            int period = Conversion.ObjectToInt(stepInfo.Detail.Period) > 0 ? Conversion.ObjectToInt(stepInfo.Detail.Period) : 1;

            if (stepInfo.Detail.DateDiliverImage == null)
            {
                result = timeNow;
            }
            else
            {
                Frequency frequency;
                if (System.Enum.TryParse(stepInfo.Detail.Frequency, out frequency))
                {
                    switch (frequency)
                    {
                        case Frequency.Days:
                            if (timeNow.AddDays(period * -1) > stepInfo.Detail.DateDiliverImage)
                            {
                                result = timeNow;
                            }
                            else
                            {
                                result = stepInfo.Detail.DateDiliverImage;
                            }
                            break;
                        case Frequency.Weeks:
                            if (timeNow.AddDays(period * -7) > stepInfo.Detail.DateDiliverImage)
                            {
                                result = timeNow;
                            }
                            else
                            {
                                result = stepInfo.Detail.DateDiliverImage;
                            }
                            break;
                        case Frequency.Months:
                            if (timeNow.AddDays(period * -30) > stepInfo.Detail.DateDiliverImage)
                            {
                                result = timeNow;
                            }
                            else
                            {
                                result = stepInfo.Detail.DateDiliverImage;
                            }
                            break;
                        default:
                            result = timeNow;
                            break;
                    }
                }
                else
                {
                    result = timeNow;
                }
            }

            return result;
        }
    }
}