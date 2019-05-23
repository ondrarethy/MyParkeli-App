using System;
using System.Security.Cryptography;
using System.Text;

namespace MyParkeli.Models
{
    public class Auth
    {
        public Auth()
        {

        }
        /*public static bool IsAlright(string email, string pass)
        {
            if(email != "admin@rethy.cz" || pass != "secret")
            {
                return true;
            }
            return false;
        }*/
        public static string GetHashFromDB(string email)
        {
            return "2BB80D537B1DA3E38BD30361AA855686BDE0EACD7162FEF6A25FE97BF527A25B";
        }
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
