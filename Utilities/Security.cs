using System;
using System.Security.Cryptography;
using System.Text;


namespace Utilities
{
    public class Seguridad
    {
        public static string EncriptarPassword(string Password)
        {
            string stKey = "ABCabc123*-";

            try
            {
                TripleDESCryptoServiceProvider des;
                MD5CryptoServiceProvider hashmd5;

                byte[] keyhash, buff;
                string stringEncripted;

                hashmd5 = new MD5CryptoServiceProvider();
                keyhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(stKey));

                hashmd5 = null;
                des = new TripleDESCryptoServiceProvider();

                des.Key = keyhash;
                des.Mode = CipherMode.ECB;

                buff = ASCIIEncoding.ASCII.GetBytes(Password);
                stringEncripted = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buff, 0, buff.Length));

                return stringEncripted;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public static string DesencriptarPassword(string Password)
        {
            string stKey = "ABCabc123*-";

            try
            {
                TripleDESCryptoServiceProvider des;
                MD5CryptoServiceProvider hashmd5;

                byte[] keyhash, buff;
                string stringDecripted;

                hashmd5 = new MD5CryptoServiceProvider();
                keyhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(stKey));

                hashmd5 = null;
                des = new TripleDESCryptoServiceProvider();

                des.Key = keyhash;
                des.Mode = CipherMode.ECB;

                buff = Convert.FromBase64String(Password);
                stringDecripted = ASCIIEncoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length));

                return stringDecripted;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}