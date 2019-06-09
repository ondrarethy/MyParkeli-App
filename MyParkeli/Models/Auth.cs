using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        public static async Task<string> GetHashFromDB(string user)
        {
            //https://myparkeli.firebaseio.com/users/admin.json

            string html = string.Empty;
            string url = string.Format("https://myparkeli.firebaseio.com/users2/{0}/pass.json",user);

            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }

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
