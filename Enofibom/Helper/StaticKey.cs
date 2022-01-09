using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom.Helper
{
    public class StaticKey
    {
        public static string IsAdmin = "IsAdmin";
        public static string UserLoggedIn = "UserLoggedIn";
        public static string requestPositionUrl = "https://10.3.64.246/mbfn/sb/lbs/sdk";
        public static string requestIMEIUrl = "https://10.3.64.246/mbfn/sb/adc/sendMessage?msisdn=";
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
