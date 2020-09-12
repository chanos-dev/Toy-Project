using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptChan
{
    public class Encrypt
    {
        private string encKey = "chansos!@#$%^&*()_+";

        private Encrypt() { }        

        private static Encrypt _instance;
        
        public static Encrypt Instance
        {
            get
            {
                if(_instance is null)
                {
                    _instance = new Encrypt();
                }

                return _instance;
            }
        }

        //http://curlybrackets.com/posts/43017/how-to-encrypt-and-decrypt-a-string-in-c-sharp
        public string EncyptPass(string passWord)
        { 
            if (!string.IsNullOrEmpty(passWord))
            { 
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    using (var tdes = new TripleDESCryptoServiceProvider())
                    {
                        tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(encKey));
                        tdes.Mode = CipherMode.ECB;
                        tdes.Padding = PaddingMode.PKCS7;

                        using (var transform = tdes.CreateEncryptor())
                        {
                            byte[] textBytes = UTF8Encoding.UTF8.GetBytes(passWord);
                            byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                            return Convert.ToBase64String(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
            else
            {
                return null;
            } 
        }

        public string DecryptPass(string passWord)
        {
            if (!string.IsNullOrEmpty(passWord))
            {
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    using (var tdes = new TripleDESCryptoServiceProvider())
                    {
                        tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(encKey));
                        tdes.Mode = CipherMode.ECB;
                        tdes.Padding = PaddingMode.PKCS7;

                        using (var transform = tdes.CreateDecryptor())
                        {
                            byte[] cipherBytes = Convert.FromBase64String(passWord);
                            byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                            return UTF8Encoding.UTF8.GetString(bytes);
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

    }
}
