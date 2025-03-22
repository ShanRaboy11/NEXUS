using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NEXUS.Classes
{
    public class Cryptography
    {
        public static string ToSHA256(string s)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = ToSHA256(enteredPassword); 
            return enteredHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase); 
        }
    }
}
