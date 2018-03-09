using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.Encryption
{
    public class DES_EDE3
    {
        public static string Encrypt(string source, string key)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

            byte[] byteBuff;

            DES.Key = StringToByteArray(key);
            DES.Mode = CipherMode.ECB; //CBC, CFB, ECB
            byteBuff = Encoding.UTF8.GetBytes(source);

            string encoded = Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }

        public static string Decrypt(string encodedText, string key)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

            byte[] byteBuff;

            DES.Key = StringToByteArray(key);
            DES.Mode = CipherMode.ECB; //CBC, CFB, ECB
            byteBuff = StringToByteArray(encodedText);

            string plaintext = Encoding.UTF8.GetString(DES.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return plaintext;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
