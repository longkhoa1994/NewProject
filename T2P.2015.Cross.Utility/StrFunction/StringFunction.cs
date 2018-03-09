using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.StrFunction
{
    public class StringFunction
    {
        /// <summary>
        /// Remove các khoảng trắng dư thừa trong chuỗi
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string RemoveMultipleSpacesInString(string inputString)
        {
            inputString = inputString.Trim();
            return Regex.Replace(inputString, " {2,}", " ");
        }

        /// <summary>
        /// Remove 1 string con trong 1 string cha
        /// </summary>
        /// <param name="parentString"></param>
        /// <param name="subString"></param>
        /// <returns></returns>
        public static string RemoveSubStringInString(string parentString, string subString)
        {
            if (parentString == null || subString == null) return parentString;

            return parentString.Replace(subString, string.Empty);
        }

        /// <summary>
        /// Thay thế 1 string con trong 1 string cha
        /// </summary>
        /// <param name="parentString"></param>
        /// <param name="currentSubString"></param>
        /// <param name="newSubString"></param>
        /// <returns></returns>
        public static string ReplaceSubStringInString(string parentString, string currentSubString, string newSubString)
        {
            if (parentString == null || currentSubString == null || newSubString == null) return parentString;

            return parentString.Replace(currentSubString, newSubString);
        }

        /// <summary>
        /// Remove kỹ tự đặc biệt
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString)) return inputString;

            var result = new string(inputString.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
            return result;
        }

        /// <summary>
        /// Thay thế ký tự đặc biệt bằng khoảng cách
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReplaceSpecialCharactersBySpaces(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            var newText = new string(text.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());

            var builder = new StringBuilder();

            foreach (var c in text)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    builder.Append(c);
                }
                else
                {
                    builder.Append(" ");
                }
            }
            return builder.ToString();
        }

        /// <summary>
        /// Remove danh sách các chuỗi trong 1 chuỗi cha
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="subStrings"></param>
        /// <returns></returns>
        public static string RemoveSubStringsInString(string inputString, List<string> subStrings)
        {
            if (inputString == null || subStrings == null || !subStrings.Any()) return inputString;

            foreach (string sub in subStrings)
            {
                while (inputString.Contains(sub))
                {
                    inputString = RemoveSubStringInString(inputString, sub);
                }
            }
            inputString = RemoveMultipleSpacesInString(inputString);
            return inputString;
        }

        /// <summary>
        /// Hàm replace value nếu chuỗi chứa key
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="dictionarys"></param>
        /// <returns></returns>
        public static string ReplaceAbbreviationInString(string inputString, Dictionary<string, string> dictionarys)
        {
            if (inputString == null || dictionarys == null || !dictionarys.Any()) return inputString;

            var words = inputString.Split(' ');
            foreach (var word in words)
            {
                var newWord = string.Empty;
                var bExisted = dictionarys.TryGetValue(word, out newWord);
                if (bExisted)
                {
                    inputString = inputString.Replace(word, newWord);
                }
            }
            return inputString;
        }
    }
}
