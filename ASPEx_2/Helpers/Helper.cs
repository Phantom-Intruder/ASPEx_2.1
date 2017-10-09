using System;
using System.Security.Cryptography;
using System.Text;

namespace ASPEx_2.Models
{
    public static class Helper
    {
        #region Password encoding region
        /// <summary>
        /// Encodes the password using a salt 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string EncodePassword(string pass, string salt) //encrypt password    
        {
            byte[]              bytes             = Encoding.Unicode.GetBytes(pass);
            byte[]              src               = Encoding.Unicode.GetBytes(salt);
            byte[]              dst               = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm       algorithm         = HashAlgorithm.Create("SHA1");
            byte[]              inArray           = algorithm.ComputeHash(dst);

            return EncodePasswordMd5(Convert.ToBase64String(inArray));
        }

        public static string EncodePasswordMd5(string pass) 
        {
            Byte[]      originalBytes       =  ASCIIEncoding.Default.GetBytes(pass);
            MD5         md5                 = new MD5CryptoServiceProvider();
            Byte[]      encodedBytes        =  md5.ComputeHash(originalBytes);
            
            return BitConverter.ToString(encodedBytes);
        }
        #endregion
    }
}