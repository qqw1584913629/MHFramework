using System;
using System.Security.Cryptography;
using System.Text;

namespace Helper
{
    public static class MD5Helper
    {
        public static string StringMD5(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] result = Encoding.Default.GetBytes(password);
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }
    }
}