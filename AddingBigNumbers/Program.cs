using System;
using System.Numerics;

namespace AddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"123 + 456 = {Add("123","456")}");
        }

        private static string Add(string number1, string number2)
        {
            number1 = (string.IsNullOrEmpty(number1)) ? "0" : number1;
            number2 = (string.IsNullOrEmpty(number2)) ? "0" : number2;
            return (BigInteger.Parse(number1) + BigInteger.Parse(number2)).ToString();
        }
    }
}
