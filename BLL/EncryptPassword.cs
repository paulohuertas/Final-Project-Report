using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BLL
{
    public class EncryptPassword
    {
        public string EncryptPass(string data)
        {
            SHA1 sha = SHA1.Create();

            byte[] hash = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder transformedPass = new StringBuilder();
            for(int i = 0; i < transformedPass.Length; i++)
            {
                transformedPass.Append(hash[i].ToString());

            }
            return transformedPass.ToString();
        }
    }
}
