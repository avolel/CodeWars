﻿using System;

namespace IsANumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            Console.WriteLine($"Is {num} a Prime Number? {IsPrime(num)}");
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
