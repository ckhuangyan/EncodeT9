using System;

namespace EncodeT9
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Crypto.EncodeT9("Bonjour");
            Console.WriteLine($"Bonjour : {res}");
        }
    }
}
