using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T2P._2015.Cross.Utility.StringExtension
{
    public static class StringExtensions
    {
        private static readonly string space = " ";
        private static Regex stripRegex = new Regex(@"[^a-zA-Z0-9 -]*");

        public static bool FuzzyEquals(this string strA, string strB, double requiredProbabilityScore = 0.75)
        {
            return strA.FuzzyMatch(strB) > requiredProbabilityScore;
        }

        public static double FuzzyMatch(this string strA, string strB)
        {
            string localA = Strip(strA.Trim().ToLower());
            string localB = Strip(strB.Trim().ToLower());
            if (localA.Contains(space) && localB.Contains(space))
            {
                var partsA = localA.Split(' ');
                var partsB = localB.Split(' ');
                var weightedHighCoefficients = new double[partsA.Length];
                var distanceRatios = new double[partsA.Length];
                for (int i = 0; i < partsA.Length; i++)
                {
                    double high = 0.0;
                    int indexDistance = 0;
                    for (int x = 0; x < partsB.Length; x++)
                    {
                        var coef = CompositeCoefficient(partsA[i], partsB[x]);
                        if (coef > high)
                        {
                            high = coef;
                            indexDistance = Math.Abs(i - x);
                        }
                    }
                    double distanceWeight = indexDistance == 0 ? 1.0 : 1.0 - (indexDistance / (partsA.Length * 1.0));
                    weightedHighCoefficients[i] = high * distanceWeight;
                }
                double avgWeightedHighCoefficient = weightedHighCoefficients.Sum() / (partsA.Length * 1.0);
                return avgWeightedHighCoefficient < 0.999999 ? avgWeightedHighCoefficient : 0.999999; //fudge factor
            }
            else
            {
                var singleComposite = CompositeCoefficient(localA, localB);
                return singleComposite < 0.999999 ? singleComposite : 0.999999; //fudge factor
            }
        }

        public static string ConcatDirectoryPath(string path, string addedPath)
        {
            if (path == string.Empty || addedPath == string.Empty)
            {
                return path;
            }
            return path.TrimEnd('\\') + "\\" + addedPath.TrimStart('\\');
        }

        public static string ConcatUriPath(string path, string addedPath) {
            if (path == string.Empty || addedPath == string.Empty)
            {
                return path;
            }
            return path.TrimEnd('/') + "/" + addedPath.TrimStart('/');
        }

        private static string Strip(string str)
        {
            return stripRegex.Replace(str, string.Empty);
        }

        private static double CompositeCoefficient(string strA, string strB)
        {
            if (strA.Equals(strB)) return 1.0;

            double total = 4.0;
            double dice = strA.DiceCoefficient(strB);
            var lcs = strA.LongestCommonSubsequence(strB);
            int leven = strA.LevenshteinDistance(strB);
            //double levenCoefficient = 1.0 / (1.0 * (leven + 0.2));
            double levenCoefficient = 1;
            if (leven != 0)
            {
                levenCoefficient = 1.0 / (1.0 * (leven + 0.2));
            }//may want to tweak offset
            string strAMp = strA.ToDoubleMetaphone();
            string strBMp = strB.ToDoubleMetaphone();
            int matchCount = 0;

            if (strAMp.Length > 0 && strBMp.Length > 0 && strAMp.Length == strBMp.Length)
            {
                for (int i = 0; i < strAMp.Length; i++)
                {
                    if (strAMp[i] == strBMp[i]) matchCount++;
                }
            }
            if (string.IsNullOrWhiteSpace(strAMp) && string.IsNullOrWhiteSpace(strBMp)) total = 3.0;
            double mpCoefficient = matchCount == 0 || strAMp.Length == 0 ? 0.0 : matchCount / strAMp.Length;
            double avgCoefficent = (dice + lcs.Item2 + levenCoefficient + mpCoefficient) / total;
            return avgCoefficent;
        }
        public static string ToJulianDateString(this DateTime date, string format)
        {
            string ordinalDate = string.Empty;
            if (format.Contains("yyyy"))
                ordinalDate = date.ToString("yyyy") + date.DayOfYear.ToString("000");
            else
                ordinalDate = date.ToString("yy") + date.DayOfYear.ToString("000");
            return ordinalDate;
        }
        public static string ToStringWithFixedLength(this object obj, int totalLength)
        {
            var fixedText = Convert.ToString(obj);
            if (fixedText.Length > totalLength)
                fixedText = fixedText.Substring(0, totalLength);
            else
                fixedText = fixedText.PadRight(totalLength);
            return fixedText;
        }
        public static string ToStringWithFixedLength(this object obj, int totalLength, int decimalLength, bool isDot = false)
        {
            var fixedText = Convert.ToString(obj);
            //var isAddMinus = false;
            //if (fixedText.Contains("-"))
            //{
            //    isAddMinus = true;
            //    fixedText = fixedText.Replace("-", string.Empty);
            //}
            var decimalTail = 0;
            var characterReplace = "";
            var decimalPlaces = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator; 
            if (isDot)
                characterReplace = ".";
            if (fixedText.Contains(decimalPlaces))
            {
                var index = fixedText.IndexOf(decimalPlaces);
                decimalTail = fixedText.Length - index - 1;
                fixedText = fixedText.Replace(decimalPlaces, characterReplace);
            }
            else if (isDot)
                fixedText = string.Concat(fixedText, characterReplace);
            if (decimalTail < decimalLength)
            {
                var tailOfDecimal = new string('0', decimalLength - decimalTail);
                fixedText = string.Concat(fixedText, tailOfDecimal);
            }
            else
            {
                fixedText = fixedText.Substring(0, fixedText.Length - (decimalTail - decimalLength));
            }
            if (fixedText.Length <= totalLength)
                fixedText = fixedText.PadLeft(totalLength, '0');
            else fixedText = fixedText.Substring(0, totalLength);
            //if (isAddMinus == true)
            //{
            //    fixedText = string.Concat("-", fixedText.Remove(0, 1));
            //}
            return fixedText;
        }

        public static string FormatDateTime(DateTime? date, string format)
        {
            return date.HasValue ? date.Value.ToString(format) : string.Empty;
        }

        public static string ToUpper(string input)
        {
            return input != null ? input.ToUpper() : string.Empty;
        }
    }
}
