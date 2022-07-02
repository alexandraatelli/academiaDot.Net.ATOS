using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;


namespace WFCriptografia
{
    internal class Simetrica
    { 
            public static void Main()
            {
                try
                {

                    string original = "Here is some data to encrypt!";

                    // Create a new instance of the Rijndael
                    // class.  This generates a new key and initialization
                    // vector (IV).
                    using (Rijndael myRijndael = Rijndael.Create())
                    {
                        // Encrypt the string to an array of bytes.
                        byte[] encrypted = EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

                        // Decrypt the bytes to a string.
                        string roundtrip = DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);

                        //Display the original data and the decrypted data.
                        Console.WriteLine("Original:   {0}", original);
                        Console.WriteLine("Round Trip: {0}", roundtrip);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
            static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
            {
                // Check arguments.
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException("plainText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");
                byte[] encrypted;
                // Create an Rijndael object
                // with the specified key and IV.
                using (Rijndael rijAlg = Rijndael.Create())
                {
                    rijAlg.Key = Key;
                    rijAlg.IV = IV;

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                    // Create the streams used for encryption.
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {

                                //Write all data to the stream.
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }

                // Return the encrypted bytes from the memory stream.
                return encrypted;
            }

            static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
            {
                // Check arguments.
                if (cipherText == null || cipherText.Length <= 0)
                    throw new ArgumentNullException("cipherText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                // Declare the string used to hold
                // the decrypted text.
                string plaintext = null;

                // Create an Rijndael object
                // with the specified key and IV.
                using (Rijndael rijAlg = Rijndael.Create())
                {
                    rijAlg.Key = Key;
                    rijAlg.IV = IV;

                    // Create a decryptor to perform the stream transform.
                    ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {

                                // Read the decrypted bytes from the decrypting stream
                                // and place them in a string.
                                plaintext = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }

                return plaintext;
            }
        }
    }

/*
namespace Criptografia
{
    public class Simetrica
    {
        public void EncryptAesManaged(string raw)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
                    // Print encrypted string    
                    Console.WriteLine($"Dado criptografado: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                    // Decrypt the bytes to a string.    
                    string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
                    // Print decrypted string. It should be same as raw data    
                    Console.WriteLine($"Dado descriptografado: {decrypted}");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        private byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }

                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return encrypted;
        }
        private string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        public string EncryptData(string textData, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            //iniciar o modo de operação
            objrij.Mode = CipherMode.CBC;
            //setar o padding de operação da string
            objrij.Padding = PaddingMode.PKCS7;
            //setar o tamanho (em bits) da operação 
            objrij.KeySize = 0x80;
            //setar o tamanho do bloco    
            objrij.BlockSize = 0x80;
            //setar a chave de criptografia
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            //setar o vetor de bytes de inicialização para criptografia
            byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);

            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;

            //Cria uma chave simétrica
            ICryptoTransform objtransform = objrij.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(textData);
            //Converte para string e retorna
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
        }

        public string DecryptData(string EncryptedText, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.CBC;
            objrij.Padding = PaddingMode.PKCS7;

            objrij.KeySize = 0x80;
            objrij.BlockSize = 0x80;
            byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            byte[] EncryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(TextByte);  //irá retornar a string original descriptografada
        }
    }
}*/




