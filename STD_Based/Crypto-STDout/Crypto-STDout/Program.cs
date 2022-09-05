using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoHash
{
    public class CryptoHashClass
    {

        static void Main(string[] args)
        {

            Console.WriteLine(ComputeStringToSha256Hash(args[0]).Result);

        }


        public static async Task<string> ComputeStringToSha256Hash(string plainText)
        {

            return await Task.Run(() =>
            {

                // Create a SHA256 hash from string   
                using (SHA256 sha256Hash = SHA256.Create())
                {


                    // Computing Hash - returns here byte array
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes((string)plainText));

                    // now convert byte array to a string   
                    StringBuilder stringbuilder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        stringbuilder.Append(bytes[i].ToString("x2"));
                    }
                    return stringbuilder.ToString();
                }




            });




        }
    }
}