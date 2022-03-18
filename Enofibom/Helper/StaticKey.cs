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
        

        public static string API_MAIN = "http://localhost:8088/api";
        //public static string API_GETLOGINMEMBER = API_MAIN + "/GetAllMembers";
        //public static string API_GETMEMBER = API_MAIN + "/GetMember";
        //public static string API_ADDMEMBER = API_MAIN + "/AddMember";
        //public static string API_UPDATEMEMBER = API_MAIN + "/UpdateMember";

        public static string API_GETLOCATION = API_MAIN +  "/MBFConnect/GetLocation/";
        public static string API_GETIMEI = API_MAIN + "/MBFConnect/GetIMEI/";
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
