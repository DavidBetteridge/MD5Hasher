using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5Hasher
{
    public class Hasher
    {
        public string HashedPassword(string password)
        {
            var hash = "";
            using (var md5 = MD5.Create())
            {
                var hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            return hash;
        }

    }
}
