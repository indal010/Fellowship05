using System;

namespace PINRegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PINPattern pattern = new PINPattern();
            bool result = pattern.validatePinCode("abc@.com");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
