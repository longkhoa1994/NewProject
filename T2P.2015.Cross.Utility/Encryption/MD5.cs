using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace T2P._2015.Cross.Utility.Encryption
{
    public static class MD5
    {
        public static string GetMd5Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        public static bool VerifyMd5Hash(string input, string hash)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                // Hash the input.
                string hashOfInput = GetMd5Hash(input);

                // Create a StringComparer an compare the hashes.
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                return 0 == comparer.Compare(hashOfInput, hash);
            }
        }

        public static string GeneratePassword()
        {
            string a = GetMd5Hash(Guid.NewGuid().ToString()).Substring(0, 6);
            return GetMd5Hash(Guid.NewGuid().ToString()).Substring(0, 6);
        }

        public static string GeneratePassword(int length)
        {
            string number = "0123456789";
            string specialCharacter = "!@#$%^&*";
            string charactersLower = "abcdefghijklmnopqrstuvwxyz";
            string charactersUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Random rad = new Random();

            StringBuilder result = new StringBuilder(8);
            
            result.Append(charactersLower[rad.Next(charactersLower.Length)]);
            result.Append(charactersUpper[rad.Next(charactersUpper.Length)]);
            result.Append(specialCharacter[rad.Next(specialCharacter.Length)]);
            result.Append(number[rad.Next(number.Length)]);

            for (int i = 0; i < length - 4; i++)
            {
                result.Append(number[rad.Next(number.Length)]);
            }

            return result.ToString();
        }

        public static string GetMd5HashFromFile(string filePath)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(filePath))
                {
                    byte[] data = md5Hash.ComputeHash(stream);

                    StringBuilder sBuilder = new StringBuilder();

                    for (int i = 0; i < data.Length; i++)
                    {
                        sBuilder.Append(data[i].ToString("x2"));
                    }

                    return sBuilder.ToString();
                }
            }
        }
    }
}