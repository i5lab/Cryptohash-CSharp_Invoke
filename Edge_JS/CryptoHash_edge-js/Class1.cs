using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoHash
{
    public class CryptoHashClass
    {
        public async Task<object> ComputeStringToSha256Hash(string plainText)
        {
            return Task.Run(() =>
            {
                // Create a SHA256 hash from string   
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // Computing Hash - returns here byte array
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                    string[] strArr = bytes.Select(q => q.ToString("x2")).ToArray();
                    return string.Join("", strArr);
                }
            });
        }
    }
}