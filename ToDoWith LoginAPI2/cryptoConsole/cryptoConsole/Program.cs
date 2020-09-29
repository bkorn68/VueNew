using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptoConsole
{
    class Program
    {
        private const string  password = "pjoh7nPf1geA3KUo8BSL";
        private const string salt = "bgIxzFoiIA6HzAZ4XTB2";
        static void Main(string[] args)
        {
            string toencrypt = "Hallo Bernhard";
            Console.WriteLine($"toencrypt: '{toencrypt}'");
            string encrypted = CryptographyHelpers.Encrypt( password, salt, toencrypt);
            string decrypted = CryptographyHelpers.Decrypt(password, salt, encrypted);
            Console.WriteLine($"decrypted: '{decrypted}'");


            Console.WriteLine("Press any key to exit this program");
            Console.ReadKey();
        }
    }
}
