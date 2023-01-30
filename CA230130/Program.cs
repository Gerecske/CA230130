using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace CA230130
{
    internal class Program
    {
        static string GetHashValueString(byte[] hv)
        {
            string hvs = string.Empty;
            for (int i = 0; i < hv.Length; i++)
            {
                hvs += $"{hv[i]:X2}";
                if ((i + 1) % 4 == 0) hvs += " ";
            }
            return hvs;
        }
        static void Main(string[] args)
        {
            Byte[] pass = System.Text.Encoding.UTF8.GetBytes("Pass");

            SHA256 sha256 = SHA256.Create();

            byte[] data = sha256.ComputeHash(pass);

            string HashString = GetHashValueString(data);

            Console.WriteLine(HashString);
        }
    }
}