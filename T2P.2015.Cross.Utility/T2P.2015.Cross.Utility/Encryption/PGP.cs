using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using T2P._2015.Cross.Utility.FileType;

namespace T2P._2015.Cross.Utility.Encryption
{
    public static class PGP
    {
        public static void EncryptStream(byte[] data, string publicKeyFile, string encryptFilename)
        {
            Stream keyIn;
            FileStream fos;
            keyIn = File.OpenRead(publicKeyFile);
            //string[] fileSplit = filePath.Split('\\');
            //string fileName = fileSplit[fileSplit.Length - 1];

            if (!Directory.Exists(Path.GetDirectoryName(encryptFilename)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(encryptFilename));
            }

            fos = File.Create(encryptFilename);
            Encrypt(data, ReadPublicKey(keyIn), encryptFilename, fos, true, false);
            keyIn.Close();
            fos.Close();
        }

        public static void EncryptUsingFile(StringBuilder sourceFile, string publicKeyFile, string encryptFilename)
        {
            Stream keyIn;
            FileStream fos;
            keyIn = File.OpenRead(publicKeyFile);
            //string[] fileSplit = filePath.Split('\\');
            //string fileName = fileSplit[fileSplit.Length - 1];
            fos = File.Create(encryptFilename);
            byte[] clearData = Encoding.Default.GetBytes(sourceFile.ToString());
            Encrypt(clearData, ReadPublicKey(keyIn), encryptFilename, fos, true, false);
            keyIn.Close();
            fos.Close();
            fos.Dispose();
        }
        public static void EncryptUsingFileByEnCoding(StringBuilder sourceFile, string publicKeyFile, string encryptFilename, Encoding end)
        {
            Stream keyIn;
            FileStream fos;
            keyIn = File.OpenRead(publicKeyFile);
            fos = File.Create(encryptFilename);
            byte[] clearData = end.GetBytes(sourceFile.ToString());

            Encrypt(clearData, ReadPublicKey(keyIn), encryptFilename, fos, true, false);
            keyIn.Close();
            fos.Close();
            fos.Dispose();
        }
        public static void Encrypt(byte[] clearData, PgpPublicKey encKey, string fileName, FileStream fos, bool withIntegrityCheck, bool armor)
        {
            if (fileName == null)
            {
                fileName = PgpLiteralData.Console;
            }

            MemoryStream encOut = new MemoryStream();

            Stream outPut = encOut;
            if (armor)
            {
                outPut = new Org.BouncyCastle.Bcpg.ArmoredOutputStream(outPut);
            }

            MemoryStream bOut = new MemoryStream();

            PgpCompressedDataGenerator comData = new PgpCompressedDataGenerator(CompressionAlgorithmTag.Zip);
            Stream cos = comData.Open(bOut); // open it with the final
            // destination
            PgpLiteralDataGenerator lData = new PgpLiteralDataGenerator();

            // we want to generate compressed data. This might be a user option
            // later,
            // in which case we would pass in bOut.
            Stream pOut = lData.Open(cos, PgpLiteralData.Binary, fileName, clearData.Length, DateTime.Now);

            pOut.Write(clearData, 0, clearData.Length);
            lData.Close();
            comData.Close();

            PgpEncryptedDataGenerator cPk = new PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag.Cast5, withIntegrityCheck, new Org.BouncyCastle.Security.SecureRandom());
            cPk.AddMethod(encKey);

            byte[] bytes = bOut.ToArray();

            Stream cOut = cPk.Open(outPut, bytes.Length);

            cOut.Write(bytes, 0, bytes.Length);
            cOut.Close();

            outPut.Close();

            //FileStream fileStream = new FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            // Writes a block of bytes to this stream using data from
            // a byte array.
            fos.Write(encOut.ToArray(), 0, encOut.ToArray().Length);

            // close file stream
            fos.Close();
        }

        private static PgpPublicKey ReadPublicKey(Stream inputStream)
        {
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            PgpPublicKeyRingBundle pgpPub = new PgpPublicKeyRingBundle(inputStream);
            //
            // we just loop through the collection till we find a key suitable for encryption, in the real
            // world you would probably want to be a bit smarter about this.
            //
            //
            // iterate through the key rings.
            //
            foreach (PgpPublicKeyRing kRing in pgpPub.GetKeyRings())
            {
                foreach (PgpPublicKey k in kRing.GetPublicKeys())
                {
                    if (k.IsEncryptionKey)
                    {
                        return k;
                    }
                }
            }

            throw new ArgumentException("Can't find encryption key in key ring.");
        }

        public static byte[] DecryptUsingFile(string filePath, string privateKeyFile, string passPhrase, Encoding end)
        {
            Stream fin = File.OpenRead(filePath);
            Stream keyIn = File.OpenRead(privateKeyFile);
            byte[] result = DecryptFile(fin, keyIn, passPhrase.ToArray(), end);
            fin.Close();
            keyIn.Close();
            return result;
        }

        // return output File Name
        public static void DecryptUsingFile(string filePath, string privateKeyFile, string passPhrase, string outputFilename, Encoding end)
        {
             List<string> result = new List<string>();
            Stream fin = File.OpenRead(filePath);
            Stream keyIn = File.OpenRead(privateKeyFile);


            result = DecryptFileInAirPlus(fin, keyIn, passPhrase.ToArray(), end); // In AirPlus

            Text writeText = new Text();
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Join(Environment.NewLine, result.ToArray()));
            writeText.WriteText(builder, outputFilename, end);

            fin.Close();
            keyIn.Close();
        }
        private static byte[] DecryptFile(Stream inputStream, Stream keyIn, char[] passwd, Encoding end)
        {
            byte[] result = null;
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            try
            {
                PgpObjectFactory pgpF = new PgpObjectFactory(inputStream);
                PgpEncryptedDataList enc;
                PgpObject o = pgpF.NextPgpObject();
                //
                // the first object might be a PGP marker packet.
                //
                if (o is PgpEncryptedDataList)
                {
                    enc = (PgpEncryptedDataList)o;
                }
                else
                {
                    enc = (PgpEncryptedDataList)pgpF.NextPgpObject();
                }

                //
                // find the secret key
                //
                PgpPrivateKey sKey = null;
                PgpPublicKeyEncryptedData pbe = null;
                PgpSecretKeyRingBundle pgpSec = new PgpSecretKeyRingBundle(
                PgpUtilities.GetDecoderStream(keyIn));
                foreach (PgpPublicKeyEncryptedData pked in enc.GetEncryptedDataObjects())
                {
                    sKey = FindSecretKey(pgpSec, pked.KeyId, passwd);
                    if (sKey != null)
                    {
                        pbe = pked;
                        break;
                    }
                }
                if (sKey == null)
                {
                    throw new ArgumentException("secret key for message not found.");
                }

                Stream clear = pbe.GetDataStream(sKey);
                PgpObjectFactory plainFact = new PgpObjectFactory(clear);
                PgpObject message = plainFact.NextPgpObject();
                if (message is PgpCompressedData)
                {
                    PgpCompressedData cData = (PgpCompressedData)message;
                    PgpObjectFactory pgpFact = new PgpObjectFactory(cData.GetDataStream());
                    message = pgpFact.NextPgpObject();
                }

                if (message is PgpLiteralData)
                {
                    PgpLiteralData ld = (PgpLiteralData)message;
                    Stream unc = ld.GetInputStream();
                    
                    using(MemoryStream ms = new MemoryStream())
                    {
                        unc.CopyTo(ms);
                        result = ms.ToArray();
                    }
                }
                else if (message is PgpOnePassSignatureList)
                {
                    throw new PgpException("encrypted message contains a signed message - not literal data.");
                }
                else
                {
                    throw new PgpException("message is not a simple encrypted file - type unknown.");
                }

                if (pbe.IsIntegrityProtected())
                {
                    if (!pbe.Verify())
                    {
                        Console.Error.WriteLine("message failed integrity check");
                    }
                    else
                    {
                        Console.Error.WriteLine("message integrity check passed");
                    }
                }
                else
                {
                    Console.Error.WriteLine("no message integrity check");
                }

                return result;
            }
            catch (PgpException e)
            {
                Console.Error.WriteLine(e);
                Exception underlyingException = e.InnerException;
                if (underlyingException != null)
                {
                    Console.Error.WriteLine(underlyingException.Message);
                    Console.Error.WriteLine(underlyingException.StackTrace);
                }

                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="keyIn"></param>
        /// <param name="passwd"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static List<string> DecryptFileInAirPlus(Stream inputStream, Stream keyIn, char[] passwd, Encoding end)
        {
            List<string> result = new List<string>();
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            try
            {

                PgpObjectFactory pgpF = new PgpObjectFactory(inputStream);
                PgpEncryptedDataList enc;
                PgpObject o = pgpF.NextPgpObject();
                //
                // the first object might be a PGP marker packet.
                //
                if (o is PgpEncryptedDataList)
                {

                    enc = (PgpEncryptedDataList)o;

                }

                else
                {

                    enc = (PgpEncryptedDataList)pgpF.NextPgpObject();

                }

                //
                // find the secret key
                //
                PgpPrivateKey sKey = null;
                PgpPublicKeyEncryptedData pbe = null;
                PgpSecretKeyRingBundle pgpSec = new PgpSecretKeyRingBundle(
                PgpUtilities.GetDecoderStream(keyIn));
                foreach (PgpPublicKeyEncryptedData pked in enc.GetEncryptedDataObjects())
                {
                    sKey = FindSecretKey(pgpSec, pked.KeyId, passwd);
                    if (sKey != null)
                    {
                        pbe = pked;
                        break;

                    }
                }
                if (sKey == null)
                {
                    throw new ArgumentException("secret key for message not found.");
                }

                Stream clear = pbe.GetDataStream(sKey);
                PgpObjectFactory plainFact = new PgpObjectFactory(clear);
                PgpObject message = plainFact.NextPgpObject();
                if (message is PgpCompressedData)
                {

                    PgpCompressedData cData = (PgpCompressedData)message;
                    PgpObjectFactory pgpFact = new PgpObjectFactory(cData.GetDataStream());
                    message = pgpFact.NextPgpObject();

                }

                if (message is PgpLiteralData)
                {

                    PgpLiteralData ld = (PgpLiteralData)message;
                 
                    Stream unc = ld.GetInputStream();
                  
                    result = ToolReadWriteFile.ReadFile(unc, end);
                }

                else if (message is PgpOnePassSignatureList)
                {

                    throw new PgpException("encrypted message contains a signed message - not literal data.");

                }

                else
                {

                    throw new PgpException("message is not a simple encrypted file - type unknown.");

                }

                if (pbe.IsIntegrityProtected())
                {

                    if (!pbe.Verify())
                    {

                        Console.Error.WriteLine("message failed integrity check");

                    }

                    else
                    {

                        Console.Error.WriteLine("message integrity check passed");

                    }


                }

                else
                {

                    Console.Error.WriteLine("no message integrity check");

                }

                return result;
            }

            catch (PgpException e)
            {

                Console.Error.WriteLine(e);
                Exception underlyingException = e.InnerException;
                if (underlyingException != null)
                {
                    Console.Error.WriteLine(underlyingException.Message);
                    Console.Error.WriteLine(underlyingException.StackTrace);
                }

                return null;
            }
        }
        private static PgpPrivateKey FindSecretKey(PgpSecretKeyRingBundle pgpSec, long keyId, char[] pass)
        {
            PgpSecretKey pgpSecKey = pgpSec.GetSecretKey(keyId);
            if (pgpSecKey == null)
            {
                return null;
            }
            return pgpSecKey.ExtractPrivateKey(pass);
        }
    }
}